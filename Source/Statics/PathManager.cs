using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using KeepCoding.Internal;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;
using static System.IntPtr;
using static System.Linq.Enumerable;
using static System.Reflection.Assembly;
using static System.Reflection.BindingFlags;
using static KeepCoding.Game;
using static KeepCoding.Logger;
using static KeepCoding.ModInfo;
using static UnityEngine.Application;
using static UnityEngine.AssetBundle;
using static UnityEngine.Debug;
using static UnityEngine.Networking.UnityWebRequest;
using static UnityEngine.Object;
using static UnityEngine.RuntimePlatform;
using Object = UnityEngine.Object;

namespace KeepCoding
{
    /// <summary>
    /// Allows loading external information stored on the module. Default values are returned either when run on the editor or when an <see cref="IOException"/> and similar occur. The default values are specified in the remarks of each method.
    /// </summary>
    public static class PathManager
    {
        private const string
            FileExtensionBundle = "bundle",
            FileExtensionLinux = "so",
            FileExtensionMacOS = "dylib",
            FileExtensionWindows = "dll";

        private static readonly Dictionary<string, string> s_filePaths = new Dictionary<string, string>(),
            s_modDirectories = new Dictionary<string, string>();

        private static readonly Dictionary<string, Object[]> s_objects = new Dictionary<string, Object[]>();

        private static readonly Dictionary<string, ModInfo> s_modInfos = new Dictionary<string, ModInfo>();

        /// <summary>
        /// Gets this library's version number. Currently used by <see cref="ModuleScript"/> to log the version number of this library.
        /// </summary>
        /// <remarks>
        /// If you want the version number of your modules, refer to <see cref="ModuleScript.Version"/> instead, or <see cref="GetModInfo()"/>.
        /// </remarks>
        public static Version Version => AssemblyName.Version;

        internal static string Caller => new StackFrame(2).GetMethod().ReflectedType.Assembly.GetName().Name;

        internal static AssemblyName AssemblyName { get; } = GetExecutingAssembly().GetName();

        internal static UnityWebRequest LatestGitHub => Get("https://api.github.com/repos/Emik03/KeepCoding/releases/latest");

        /// <summary>
        /// Loads a library from the directory of the mod caller.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="name">The library's name, excluding the extension.</param>
        public static void LoadLibrary(string name) => LoadLibrary(name, Caller);

        /// <summary>
        /// Loads a library from the directory of the specified mod's assembly name.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="name">The library's name, excluding the extension.</param>
        /// <param name="assembly">The mod's assembly name.</param>
        public static void LoadLibrary(string name, string assembly)
        {
            Self($"Preparing to copy library \"{name.NullOrEmptyCheck("You cannot load a library which has a null or empty name.")}\" which exists in \"{assembly.NullOrEmptyCheck("You cannot load a library which has a null or empty mod assembly.")}\".");

            if (isEditor)
            {
                Self($"This method is being run on the Editor, therefore nothing will be done.");
                return;
            }

            SuppressIO(() => CopyLibrary(name, GetDirectory(assembly)));

            Self($"The library has been copied over. They are now ready to be referenced.");
        }

        /// <summary>
        /// Prints a hierarchy of all game objects.
        /// </summary>
        /// <param name="indent">The amount of spaces used for indenting children of game objects.</param>
        public static void PrintHierarchy(int indent = 4) => FindObjectsOfType<GameObject>().Where(g => !g.transform.parent).ToArray().ForEach(g => PrintHierarchy(g, indent));

        /// <summary>
        /// Prints the hierarchy from the game object specified.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <param name="obj">The game object to search the hierarchy.</param>
        /// <param name="indent">The amount of spaces used for indenting children of game objects.</param>
        /// <param name="depth">The level of depth which determines level of indentation. Leave this variable as 0.</param>
        [CLSCompliant(false)]
        public static void PrintHierarchy(GameObject obj, int indent = 4, ushort depth = 0)
        {
            string space = new string(Repeat(' ', indent * depth).ToArray());

            Log($"{space}{obj.Assert("The game object cannot be null.")!.name}");
            LogWarning($"{space}{obj!.GetComponents<Component>().Stringify()}");

            foreach (Transform child in obj.transform)
                PrintHierarchy(child.gameObject, indent, (ushort)(depth + 1));
        }

        /// <summary>
        /// Combines multiple paths together.
        /// </summary>
        /// <param name="paths">The paths to combine with.</param>
        /// <returns>A single path consisting of the combined path of the array.</returns>
        public static string CombineMultiple(params string[] paths) => paths.Aggregate(Path.Combine);

        /// <summary>
        /// Finds the directory of the mod caller.
        /// </summary>
        /// <remarks>
        /// Default: An empty <see cref="string"/>.
        /// </remarks>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <returns>The directory to the mod caller.</returns>
        public static string GetDirectory() => GetDirectory(Caller);

        /// <summary>
        /// Finds the directory of the specified mod's assembly name.
        /// </summary>
        /// <remarks>
        /// Default: An empty <see cref="string"/>.
        /// </remarks>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="assembly">The mod assembly's name.</param>
        /// <returns>The directory to <paramref name="assembly"/>.</returns>
        public static string GetDirectory(string assembly)
        {
            if (s_modDirectories.TryGetValue(assembly.NullOrEmptyCheck("You cannot retrieve a path if the mod assembly is null or empty."), out string path))
                return path;

            Self($"Searching for \"{assembly}\" within the mod dictionary...");

            if (!IsKtane)
            {
                s_modDirectories.Add(assembly, path = "");

                Self("This method is being run outside of the Keep Talking and Nobody Explodes executable, therefore an empty string will be returned.");

                return path;
            }

            if (!s_modDirectories.ContainsKey(assembly))
            {
                CacheModDirectories();

                if (!s_modDirectories.ContainsKey(assembly))
                {
                    Self($"Unable to index \"{assembly}\" into {nameof(s_modDirectories)}, contents: {s_modDirectories.Stringify()}");
                    return "";
                }
            }

            path = s_modDirectories[assembly];

            Self($"The directory {assembly} has been found. Location: {path}");

            s_filePaths.Add(assembly, path);

            return path;
        }

        /// <summary>
        /// Finds the path of a given file within the mod caller. You need to specify the extensions of the file too, otherwise the file cannot be found.
        /// </summary>
        /// <remarks>
        /// Default: An empty <see cref="string"/>.
        /// </remarks>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="file">The file to search for. Make sure to include extensions!</param>
        /// <returns>The path to <paramref name="file"/> within the mod caller directory.</returns>
        public static string GetPath(string file) => GetPath(file, Caller);

        /// <summary>
        /// Finds the path of a given file within a specified mod's assembly name. You need to specify the extensions of the file too, otherwise the file cannot be found.
        /// </summary>
        /// <remarks>
        /// Default: An empty <see cref="string"/>.
        /// </remarks>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="file">The file to search for. Make sure to include extensions!</param>
        /// <param name="assembly">The mod assembly's name.</param>
        /// <returns>The path to <paramref name="file"/> within <paramref name="assembly"/>.</returns>
        public static string GetPath(string file, string assembly)
        {
            string key = $"{assembly.NullOrEmptyCheck("You cannot retrieve a path if the mod assembly is null or empty.")}_{file.NullOrEmptyCheck("You cannot retrieve a path if the file name is null or empty.")}";

            if (s_filePaths.TryGetValue(key, out string path))
                return path;

            if (isEditor)
            {
                s_filePaths.Add(key, path = "");

                Self("This method is being run on the Editor, therefore an empty string will be returned.");

                return path;
            }

            path = SuppressIO(() => Directory.GetFiles(GetDirectory(assembly), file).FirstOrDefault(), "");

            Self($"The file {file} from {assembly} has been found. Location: {path}");

            s_filePaths.Add(key, path);

            return path;
        }

        /// <summary>
        /// Deserializes the modInfo.json of the mod caller.
        /// </summary>
        /// <remarks>
        /// Default: A new instance of <see cref="ModInfo"/> with <see keyword="default"/> values.
        /// </remarks>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <returns>A <see cref="ModInfo"/> from the mod caller's modInfo.json file.</returns>
        public static ModInfo GetModInfo() => GetModInfo(Caller);

        /// <summary>
        /// Deserializes the modInfo.json of a specified mod's assembly name.
        /// </summary>
        /// <remarks>
        /// Default: A new instance of <see cref="ModInfo"/> with <see keyword="default"/> values.
        /// </remarks>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="assembly">The mod assembly's name.</param>
        /// <returns>A <see cref="ModInfo"/> from <paramref name="assembly"/>.</returns>
        public static ModInfo GetModInfo(string assembly)
        {
            if (s_modInfos.TryGetValue(assembly.NullOrEmptyCheck($"You cannot retrieve a mod's {nameof(ModInfo)} if the bundle file name is null or empty."), out ModInfo info))
                return info;

            Self($"Retrieving the {nameof(ModInfo)} data from \"{assembly}\"...");

            if (isEditor)
            {
                s_modInfos.Add(assembly, info = new ModInfo());

                Self($"This method is being run on the Editor, therefore a new instance of {nameof(ModInfo)} will be returned.");

                return info;
            }

            string file = GetPath("modInfo.json", assembly);

            if (!File.Exists(file))
            {
                Self($"The path finder located a file that does not exist, therefore a new instance of {nameof(ModInfo)} will be returned.");

                return new ModInfo();
            }

            Self($"Deserializing \"{file}\"...");

            info = Deserialize(file);

            s_modInfos.Add(assembly, info);

            return info;
        }

        /// <summary>
        /// Retrieves assets of a specific type from a different bundle file.
        /// </summary>
        /// <typeparam name="T">The type of asset to retrieve.</typeparam>
        /// <param name="file">The name of the bundle file to grab the assets from.</param>
        /// <returns>A <see cref="Work{T}"/> instance that can retrieve the assets from the mod caller.</returns>
        [CLSCompliant(false)]
        public static Work<T[]> GetAssetsAsync<T>(string file) where T : Object => new Work<T[]>(() => GetAssets<T>(file));

        /// <summary>
        /// Retrieves assets of a specific type from a different bundle file.
        /// </summary>
        /// <typeparam name="T">The type of asset to retrieve.</typeparam>
        /// <param name="file">The name of the bundle file to grab the assets from.</param>
        /// <param name="assembly">The mod assembly's name.</param>
        /// <returns>A <see cref="Work{T}"/> instance that can retrieve the assets from <paramref name="assembly"/>.</returns>
        [CLSCompliant(false)]
        public static Work<T[]> GetAssetsAsync<T>(string file, string assembly) where T : Object => new Work<T[]>(() => GetAssets<T>(file, assembly));

        /// <summary>
        /// Retrieves assets of a specific type from a bundle file within the mod caller.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of asset to retrieve.</typeparam>
        /// <param name="file">The name of the bundle file to grab the assets from.</param>
        /// <returns>The assets retrieved from the mod caller.</returns>
        [CLSCompliant(false)]
        public static T[] GetAssets<T>(string file) where T : Object => GetAssets<T>(file, Caller);

        /// <summary>
        /// Retrieves assets of a specific type from a bundle file within a specified mod's assembly name.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of asset to retrieve.</typeparam>
        /// <param name="file">The name of the bundle file to grab the assets from.</param>
        /// <param name="assembly">The mod assembly's name.</param>
        /// <returns>The assets retrieved from <paramref name="assembly"/>.</returns>
        [CLSCompliant(false)]
        public static T[] GetAssets<T>(string file, string assembly) where T : Object => LoadAssets<T>(file, assembly).OfType<T[]>().First();

        internal static void SuppressIO(Action func, Action<Exception> caught = null) => func.Catch<IOException, NotSupportedException, UnauthorizedAccessException>(e =>
        {
            Self($"Caught error of type {e.GetType()}: {e}");
            caught?.Invoke(e);
        })();

        internal static T SuppressIO<T>(Func<T> func, T caught) => func.Catch<IOException, NotSupportedException, UnauthorizedAccessException, T>(e =>
        {
            Self($"Caught error of type {e.GetType()}, returning new instance of {typeof(T).Name}: {e}");
            return caught;
        })();

        private static void CacheModDirectories()
        {
            foreach (KeyValuePair<string, Mod> mod in (Dictionary<string, Mod>)typeof(ModManager).GetField("loadedMods", DeclaredOnly | Instance | NonPublic).GetValue(ModManager.Instance))
                if (!s_modDirectories.ContainsKey(mod.Value.ModID))
                    s_modDirectories.Add(mod.Value.ModID, mod.Key);
        }

        private static void CopyLibrary(in string file, in string path)
        {
            const string Target = "dlls";

            string architecture = Size switch
            {
                4 => "x86",
                8 => "x86_64",
                _ => throw new PlatformNotSupportedException($"{nameof(IntPtr)}'s {nameof(Size)} is not 4 or 8. Only 32-bit and 64-bit devices are supported.")
            };

            switch (platform)
            {
                case WindowsPlayer:
                    File.Copy(@$"{path}\{Target}\{architecture}\{FileFormat(file, FileExtensionWindows)}", @$"{dataPath}\Mono\{FileFormat(file, FileExtensionWindows)}", true);
                    break;

                case OSXPlayer:
                    string dest = CombineMultiple(dataPath, "Frameworks", "MonoEmbedRuntime", "osx");

                    if (!Directory.Exists(dest))
                        Directory.CreateDirectory(dest);

                    File.Copy(CombineMultiple(path, Target, FileFormat(file, FileExtensionMacOS)), Path.Combine(dest, FileFormat(file, FileExtensionMacOS)), true);
                    break;

                case LinuxPlayer:
                    File.Copy(CombineMultiple(path, Target, FileFormat(file, FileExtensionLinux)), CombineMultiple(dataPath, "Mono", architecture, FileFormat(file, FileExtensionLinux)), true);
                    break;

                default: throw new PlatformNotSupportedException($"The platform \"{platform}\" is unsupported. The operating systems supported are Windows, Mac, and Linux.");
            }
        }

        private static string FileFormat(in string name, in string extension) => $"{name}.{extension}";

        private static IEnumerable LoadAssets<T>(string file, string assembly) where T : Object
        {
            if (!file.NullOrEmptyCheck("You cannot retrieve a path if the file name is null or empty.").Contains("."))
                file += ".bundle";

            string key = $"{assembly.NullOrEmptyCheck("You cannot retrieve a path if the mod assembly is null or empty.")}_{file}";

            if (s_objects.TryGetValue(key, out Object[] objs))
            {
                yield return objs.ConvertAll(o => (T)o);
                yield break;
            }

            if (isEditor)
            {
                s_objects.Add(assembly, objs = new Object[0]);

                Self($"This method is being run on the Editor, therefore an empty array of {nameof(Object)} will be returned.");

                yield return objs.ConvertAll(o => (T)o);
                yield break;
            }

            Self($"Loading type \"{typeof(T).Name}\" from \"{file}\" which exists in \"{assembly}\".");

            AssetBundleCreateRequest request = LoadFromFileAsync(GetPath(file, assembly));

            yield return request;

            T[] assets = request
                .assetBundle
                .NullCheck("The bundle was null.")
                .LoadAllAssets<T>()
                .NullOrEmptyCheck($"There are no assets of type \"{typeof(T).Name}\".")
                .Sort((x, y) => x.name.CompareTo(y.name));

            Self($"{assets.Length} assets of type \"{typeof(T).Name}\" have been loaded into memory!");

            s_objects.Add(assembly, assets);

            yield return assets;
        }
    }
}
