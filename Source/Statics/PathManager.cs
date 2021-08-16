using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using KeepCoding.Internal;
using UnityEngine;
using UnityEngine.Networking;
using static System.IntPtr;
using static System.Linq.Enumerable;
using static System.Reflection.Assembly;
using static System.Reflection.BindingFlags;
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
    extern alias core;

    /// <summary>
    /// Allows loading external information stored on the module. 
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

        private static readonly Dictionary<string, ModInfo> s_modInfos = new Dictionary<string, ModInfo>();

        private static readonly PlatformNotSupportedException s_intPtrException = new PlatformNotSupportedException("IntPtr size is not 4 or 8, what kind of system is this?");

        /// <summary>
        /// Gets this library's <see cref="AssemblyName"/>.
        /// </summary>
        public static AssemblyName AssemblyName => GetExecutingAssembly().GetName();

        /// <summary>
        /// Gets this library's version number. Currently used by <see cref="ModuleScript"/> to log the version number of this library.
        /// </summary>
        /// <remarks>
        /// If you want the version number of your modules, refer to <see cref="ModuleScript.Version"/> instead, or <see cref="GetModInfo()"/>.
        /// </remarks>
        public static Version Version => AssemblyName.Version;

        internal static string Caller => new StackFrame(2).GetMethod().ReflectedType.Assembly.GetName().Name;

        internal static UnityWebRequest LatestGitHub => Get("https://api.github.com/repos/Emik03/KeepCoding/releases/latest");

        /// <summary>
        /// Loads a library from the directory of the mod caller.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="name">The library's name, excluding the extension.</param>
        public static void LoadLibrary(string name) => LoadLibrary(name, Caller);

        /// <summary>
        /// Loads a library from the directory of the specified mod's assembly name.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="name">The library's name, excluding the extension.</param>
        /// <param name="assembly">The mod's assembly name.</param>
        public static void LoadLibrary(string name, string assembly)
        {
            Self($"Preparing to copy library \"{name}\" which exists in \"{assembly}\".");

            if (isEditor)
            {
                Self($"This method is being run on the Editor, therefore nothing will be done.");
                return;
            }

            name.NullOrEmptyCheck("You cannot load a library which has a null or empty name.");

            CopyLibrary(name, GetDirectory(assembly));

            Self($"The library has been copied over. They are now ready to be referenced.");
        }

        /// <summary>
        /// Prints a hierarchy of all game objects.
        /// </summary>
        /// <param name="indent">The amount of spaces used for indenting children of game objects.</param>
        public static void PrintHierarchy(ushort indent = 4) => FindObjectsOfType<GameObject>().Where(g => !g.transform.parent).ToArray().ForEach(g => PrintHierarchy(g, indent));

        /// <summary>
        /// Prints the hierarchy from the game object specified.
        /// </summary>
        /// <param name="obj">The game object to search the hierarchy.</param>
        /// <param name="indent">The amount of spaces used for indenting children of game objects.</param>
        /// <param name="depth">The level of depth which determines level of indentation. Leave this variable as 0.</param>
        public static void PrintHierarchy(GameObject obj, ushort indent = 4, ushort depth = 0)
        {
            string space = new string(Repeat(' ', indent * depth).ToArray());

            Log($"{space}{obj.name}");
            LogWarning($"{space}{obj.GetComponents<Component>().Stringify()}");

            foreach (Transform child in obj.transform)
                PrintHierarchy(child.gameObject, (ushort)(depth + 1), indent);
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
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <returns>The directory to the mod caller.</returns>
        public static string GetDirectory() => GetDirectory(Caller);

        /// <summary>
        /// Finds the directory of the specified mod's assembly name.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="assembly">The mod assembly's name.</param>
        /// <returns>The directory to <paramref name="assembly"/>.</returns>
        public static string GetDirectory(string assembly)
        {
            if (s_modDirectories.TryGetValue(assembly, out string path))
                return path;

            Self($"Searching for \"{assembly}\" within the mod dictionary...");

            if (isEditor)
            {
                s_modDirectories.Add(assembly, path = "");

                Self("This method is being run on the Editor, therefore an empty string will be returned.");

                return path;
            }

            assembly.NullOrEmptyCheck("You cannot retrieve a path if the mod assembly is null or empty.");

            if (!s_modDirectories.ContainsKey(assembly))
                CacheModDirectories(assembly);

            path = s_modDirectories[assembly];

            Self($"The directory {assembly} has been found. Location: {path}!");

            s_filePaths.Add(assembly, path);

            return path;
        }

        /// <summary>
        /// Finds the path of a given file within the mod caller.
        /// </summary>
        /// <remarks>
        /// You need to specify the extensions of the file too, otherwise the file cannot be found.
        /// </remarks>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="file">The file to search for. Make sure to include extensions!</param>
        /// <returns>The path to <paramref name="file"/> within the mod caller directory.</returns>
        public static string GetPath(string file) => GetPath(file, Caller);

        /// <summary>
        /// Finds the path of a given file within a specified mod's assembly name.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="file">The file to search for. Make sure to include extensions!</param>
        /// <param name="assembly">The mod assembly's name.</param>
        /// <returns>The path to <paramref name="file"/> within <paramref name="assembly"/>.</returns>
        public static string GetPath(string file, string assembly)
        {
            string key = $"{assembly}_{file}";

            if (s_filePaths.TryGetValue(key, out string path))
                return path;

            if (isEditor)
            {
                s_filePaths.Add(key, path = "");

                Self("This method is being run on the Editor, therefore an empty string will be returned.");

                return path;
            }

            file.NullOrEmptyCheck("You cannot retrieve a path if the file name is null or empty.");

            path = Find(file, GetDirectory(assembly));

            Self($"The file {file} from {assembly} has been found. Location: {path}");

            s_filePaths.Add(key, path);

            return path;
        }

        /// <summary>
        /// Deserializes the modInfo.json of the mod caller.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <returns>A <see cref="ModInfo"/> from the mod caller's modInfo.json file.</returns>
        public static ModInfo GetModInfo() => GetModInfo(Caller);

        /// <summary>
        /// Deserializes the modInfo.json of a specified mod's assembly name.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="assembly">The mod assembly's name.</param>
        /// <returns>A <see cref="ModInfo"/> from <paramref name="assembly"/>.</returns>
        public static ModInfo GetModInfo(string assembly)
        {
            if (s_modInfos.TryGetValue(assembly, out ModInfo info))
                return info;

            Self($"Retrieving the {nameof(ModInfo)} data from \"{assembly}\"...");

            if (isEditor)
            {
                s_modInfos.Add(assembly, info = new ModInfo());

                Self($"This method is being run on the Editor, therefore a new instance of {nameof(ModInfo)} will be returned.");

                return info;
            }

            assembly.NullOrEmptyCheck($"You cannot retrieve a mod's {nameof(ModInfo)} if the bundle file name is null or empty.");

            string file = GetPath("modInfo.json", assembly);

            if (!File.Exists(file))
                throw new FileNotFoundException($"The mod bundle was found in \"{assembly}\", but no mod info was found! (Expected to find \"{file}\")");

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
        public static Work<T[]> GetAssetsAsync<T>(string file) where T : Object => new Work<T[]>(() => GetAssets<T>(file));

        /// <summary>
        /// Retrieves assets of a specific type from a different bundle file.
        /// </summary>
        /// <typeparam name="T">The type of asset to retrieve.</typeparam>
        /// <param name="file">The name of the bundle file to grab the assets from.</param>
        /// <param name="assembly">The mod assembly's name.</param>
        /// <returns>A <see cref="Work{T}"/> instance that can retrieve the assets from <paramref name="assembly"/>.</returns>
        public static Work<T[]> GetAssetsAsync<T>(string file, string assembly) where T : Object => new Work<T[]>(() => GetAssets<T>(file, assembly));

        /// <summary>
        /// Retrieves assets of a specific type from a bundle file within the mod caller.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <typeparam name="T">The type of asset to retrieve.</typeparam>
        /// <param name="file">The name of the bundle file to grab the assets from.</param>
        /// <returns>The assets retrieved from the mod caller.</returns>
        public static T[] GetAssets<T>(string file) where T : Object => GetAssets<T>(file, Caller);

        /// <summary>
        /// Retrieves assets of a specific type from a bundle file within a specified mod's assembly name.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <typeparam name="T">The type of asset to retrieve.</typeparam>
        /// <param name="file">The name of the bundle file to grab the assets from.</param>
        /// <param name="assembly">The mod assembly's name.</param>
        /// <returns>The assets retrieved from <paramref name="assembly"/>.</returns>
        public static T[] GetAssets<T>(string file, string assembly) where T : Object => (T[])LoadAssets<T>(file, assembly).AsEnumerable().OfType<object>().Last();

        private static void CacheModDirectories(in string modAssembly)
        {
            foreach (KeyValuePair<string, Mod> mod in (Dictionary<string, Mod>)typeof(ModManager).GetField("loadedMods", DeclaredOnly | Instance | NonPublic).GetValue(ModManager.Instance))
                if (!s_modDirectories.ContainsKey(mod.Value.ModID))
                    s_modDirectories.Add(mod.Value.ModID, mod.Key);

            if (!s_modDirectories.ContainsKey(modAssembly))
                throw new KeyNotFoundException($"The mod assembly \"{modAssembly}\" could not be found in the dictionary! Contents: {s_modDirectories.Stringify()}");
        }

        private static void CopyLibrary(in string libraryFileName, in string path)
        {
            const string Target = "dlls";

            switch (platform)
            {
                case WindowsPlayer:
                    File.Copy(path + Size switch
                    {
                        4 => @$"\{Target}\x86\",
                        8 => @$"\{Target}\x86_64\",
                        _ => throw s_intPtrException
                    } + FileFormat(libraryFileName, FileExtensionWindows), dataPath + @"\Mono\" + FileFormat(libraryFileName, FileExtensionWindows), true);
                    break;

                case OSXPlayer:
                    string dest = CombineMultiple(dataPath, "Frameworks", "MonoEmbedRuntime", "osx");

                    if (!Directory.Exists(dest))
                        Directory.CreateDirectory(dest);

                    File.Copy(CombineMultiple(path, Target, FileFormat(libraryFileName, FileExtensionMacOS)), Path.Combine(dest, FileFormat(libraryFileName, FileExtensionMacOS)), true);
                    break;

                case LinuxPlayer:
                    File.Copy(CombineMultiple(path, Target, FileFormat(libraryFileName, FileExtensionLinux)), CombineMultiple(dataPath, "Mono", Size switch
                    {
                        4 => "x86",
                        8 => "x86_64",
                        _ => throw s_intPtrException
                    }, FileFormat(libraryFileName, FileExtensionLinux)), true);
                    break;

                default: throw new PlatformNotSupportedException($"The platform \"{platform}\" is unsupported. The operating systems supported are Windows, Mac, and Linux.");
            }
        }

        private static string FileFormat(in string fileName, in string fileExtension) => "{0}.{1}".Form(fileName, fileExtension);

        private static string Find(in string find, in string directory)
        {
            try
            {
                return Directory.GetFiles(directory, find).FirstOrDefault();
            }
            catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException || ex is DirectoryNotFoundException || ex is UnauthorizedAccessException)
            {
                Self($"The file \"{find}\" could not be accessed: {ex}");
                return null;
            }
        }

        private static IEnumerator LoadAssets<TAsset>(string file, string assembly) where TAsset : Object
        {
            file.NullOrEmptyCheck("You cannot load a video from a nonexistent file.");

            if (!file.Contains('.'))
                file += ".bundle";

            Self($"Loading type \"{typeof(TAsset).Name}\" from \"{file}\" which exists in \"{assembly}\".");

            AssetBundleCreateRequest request = LoadFromFileAsync(GetPath(file, assembly));

            yield return request;

            AssetBundle mainBundle = request.assetBundle.NullCheck("The bundle was null.");

            IEnumerable<TAsset> assets = mainBundle.LoadAllAssets<TAsset>().OrderBy(o => o.name).ToArray().NullOrEmptyCheck($"There are no assets of type \"{typeof(TAsset).Name}\".");

            Self($"{assets.Count()} assets of type \"{typeof(TAsset).Name}\" have been loaded into memory!");

            yield return assets;
        }
    }
}
