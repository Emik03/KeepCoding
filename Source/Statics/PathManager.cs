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
using UnityEngine.Video;
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
        /// If you want the version number of your modules, refer to <see cref="ModuleScript.Version"/> instead, or <see cref="GetModInfo{T}(T)"/>.
        /// </remarks>
        public static Version Version => AssemblyName.Version;

        internal static UnityWebRequest LatestGitHub => Get("https://api.github.com/repos/Emik03/KeepCoding/releases/latest");

        private static string GetCaller => new StackFrame(2).GetMethod().ReflectedType.Name;

        /// <summary>
        /// Loads a library by searching for the bundle.
        /// </summary>
        /// <remarks>
        /// If the library has already been loaded, then this method will prematurely halt.
        /// </remarks>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="bundleFileName">The name of the bundle file.</param>
        /// <param name="libraryFileName">The library's name, excluding the extension.</param>
        public static void LoadLibrary(string bundleFileName, string libraryFileName)
        {
            Self($"Preparing to copy library \"{libraryFileName}\" which exists in \"{bundleFileName}\".");

            if (isEditor)
            {
                Self($"This method is being run on the Editor, therefore nothing will be done.");
                return;
            }

            libraryFileName.NullOrEmptyCheck("You cannot load a library which has a null or empty name.");

            CopyLibrary(libraryFileName, GetDirectory(bundleFileName));

            Self($"The library has been copied over. They are now ready to be referenced.");
        }

        /// <summary>
        /// Loads a library by searching for the bundle.
        /// </summary>
        /// <remarks>
        /// If the library has already been loaded, then this method will prematurely halt.
        /// </remarks>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="type">Any data from the assembly, which is used to get the name.</param>
        /// <param name="libraryFileName">The library's name, excluding the extension.</param>
        public static void LoadLibrary(Type type, string libraryFileName) => LoadLibrary(NameOfAssembly(type), libraryFileName);

        /// <summary>
        /// Loads a library by searching for the bundle.
        /// </summary>
        /// <remarks>
        /// If the library has already been loaded, then this method will prematurely halt.
        /// </remarks>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <typeparam name="T">The type to get the assembly from, which is used to get the name.</typeparam>
        /// <param name="_">Any data from the assembly, which is used to get the name.</param>
        /// <param name="libraryFileName">The library's name, excluding the extension.</param>
        public static void LoadLibrary<T>(T _, string libraryFileName) => LoadLibrary(NameOfAssembly<T>(), libraryFileName);

        /// <summary>
        /// Prints a hierarchy of all game objects.
        /// </summary>
        /// <param name="indentation">The amount of spaces used for indenting children of game objects.</param>
        public static void PrintHierarchy(ushort indentation = 4) => FindObjectsOfType<GameObject>().Where(g => !g.transform.parent).ToArray().ForEach(g => PrintHierarchy(g, indentation));

        /// <summary>
        /// Prints the hierarchy from the game object specified.
        /// </summary>
        /// <param name="obj">The game object to search the hierarchy.</param>
        /// <param name="indentation">The amount of spaces used for indenting children of game objects.</param>
        /// <param name="depth">The level of depth which determines level of indentation. Leave this variable as 0.</param>
        public static void PrintHierarchy(GameObject obj, ushort indentation = 4, ushort depth = 0)
        {
            string indent = new string(Repeat(' ', indentation * depth).ToArray());

            Log($"{indent}{obj.name}");
            LogWarning($"{indent}{obj.GetComponents<Component>().Stringify()}");

            foreach (Transform child in obj.transform)
                PrintHierarchy(child.gameObject, (ushort)(depth + 1), indentation);
        }

        /// <summary>
        /// Combines multiple paths together.
        /// </summary>
        /// <param name="paths">The paths to combine with.</param>
        /// <returns>A single path consisting of the combined path of the array.</returns>
        public static string CombineMultiple(params string[] paths) => paths.Aggregate(Path.Combine);

        /// <summary>
        /// Finds the path of a mod.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="modAssembly">The mod assembly's name. This is used to get the mod in question.</param>
        /// <returns>The path to <paramref name="modAssembly"/>.</returns>
        public static string GetDirectory(string modAssembly)
        {
            if (s_modDirectories.TryGetValue(modAssembly, out string path))
                return path;

            Self($"Searching for \"{modAssembly}\" within the mod dictionary...");

            if (isEditor)
            {
                s_modDirectories.Add(modAssembly, path = "");

                Self("This method is being run on the Editor, therefore an empty string will be returned.");

                return path;
            }

            modAssembly.NullOrEmptyCheck("You cannot retrieve a path if the mod assembly is null or empty.");

            if (!s_modDirectories.ContainsKey(modAssembly))
                CacheModDirectories(modAssembly);

            path = s_modDirectories[modAssembly];

            Self($"Found {modAssembly} in {path}!");

            s_filePaths.Add(modAssembly, path);

            return path;
        }

        /// <summary>
        /// Finds the path of the mod.
        /// </summary>
        /// <param name="type">Any data from the assembly, which is used to get the name.</param>
        /// <returns>The path to the mod.</returns>
        public static string GetDirectory(Type type) => GetDirectory(NameOfAssembly(type));

        /// <summary>
        /// Finds the path of the mod.
        /// </summary>
        /// <typeparam name="T">The type to get the assembly from, which is used to get the name.</typeparam>
        /// <param name="_">Any data from the assembly, which is used to get the name.</param>
        /// <returns>The path to the mod.</returns>
        public static string GetDirectory<T>(T _ = default) => GetDirectory(NameOfAssembly<T>());

        /// <summary>
        /// Finds the path of a given file within each mod.
        /// </summary>
        /// <remarks>
        /// You need to specify the extensions of the file too, otherwise the file cannot be found.
        /// </remarks>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="modAssembly">The mod assembly's name. This is used to get the mod in question.</param>
        /// <param name="search">The file to search for. Make sure to include extensions!</param>
        /// <returns>The path to <paramref name="search"/>.</returns>
        public static string GetPath(string modAssembly, string search)
        {
            string key = $"{modAssembly}_{search}";

            if (s_filePaths.TryGetValue(key, out string path))
                return path;

            if (isEditor)
            {
                s_filePaths.Add(key, path = "");

                Self("This method is being run on the Editor, therefore an empty string will be returned.");

                return path;
            }

            search.NullOrEmptyCheck("You cannot retrieve a path if the file name is null or empty.");

            path = Find(search, GetDirectory(modAssembly));

            Self($"Found {modAssembly}'s {search} in {path}!");

            s_filePaths.Add(key, path);

            return path;
        }

        /// <summary>
        /// Finds the path of a given file within each mod.
        /// </summary>
        /// <param name="type">Any data from the assembly, which is used to get the name.</param>
        /// <param name="search">The file to search for. Make sure to include extensions!</param>
        /// <returns>The path to the mod.</returns>
        public static string GetPath(Type type, string search) => GetPath(NameOfAssembly(type), FileFormat(NameOfAssembly(type), FileExtensionWindows));

        /// <summary>
        /// Finds the path of a given file within each mod.
        /// </summary>
        /// <typeparam name="T">The type to get the assembly from, which is used to get the name.</typeparam>
        /// <param name="_">Any data from the assembly, which is used to get the name.</param>
        /// <param name="search">The file to search for. Make sure to include extensions!</param>
        /// <returns>The path to the mod.</returns>
        public static string GetPath<T>(T _, string search) => GetPath(NameOfAssembly<T>(), FileFormat(NameOfAssembly<T>(), FileExtensionWindows));

        /// <summary>
        /// Gets the assembly's directory where the type <paramref name="type"/> exists.
        /// </summary>
        /// <param name="type">The type to get the assembly directory of.</param>
        /// <returns>The path to the directory of the assembly where the type <paramref name="type"/> comes from.</returns>
        public static string NameOfAssembly(Type type) => type.Assembly.GetName().Name;

        /// <summary>
        /// Gets the assembly's directory where the type <typeparamref name="T"/> exists.
        /// </summary>
        /// <typeparam name="T">The type to get the assembly directory of.</typeparam>
        /// <returns>The path to the directory of the assembly where the type <typeparamref name="T"/> comes from.</returns>
        public static string NameOfAssembly<T>() => NameOfAssembly(typeof(T));

        /// <summary>
        /// Gets the path and deserializes the modInfo.json located at every mod's root folder.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="modAssembly">The mod assembly's name. This is used to get the mod in question.</param>
        /// <returns>A <see cref="ModInfo"/> of the mod info json file located in the mod.</returns>
        public static ModInfo GetModInfo(string modAssembly)
        {
            if (s_modInfos.TryGetValue(modAssembly, out ModInfo info))
                return info;

            Self($"Retrieving the {nameof(ModInfo)} data from \"{modAssembly}\"...");

            if (isEditor)
            {
                s_modInfos.Add(modAssembly, info = new ModInfo());

                Self($"This method is being run on the Editor, therefore a new instance of {nameof(ModInfo)} will be returned.");

                return info;
            }

            modAssembly.NullOrEmptyCheck("You cannot retrieve a mod's modInfo.json if the bundle file name is null or empty.");

            string file = GetPath(modAssembly, "modInfo.json");

            if (!File.Exists(file))
                throw new FileNotFoundException($"The mod bundle was found in {modAssembly}, but no mod info was found! (Expected to find \"{file}\")");

            Self($"File found! Returning {file}.");

            info = Deserialize(file);

            s_modInfos.Add(modAssembly, info);

            return info;
        }

        /// <summary>
        /// Gets the path and deserializes the modInfo.json located at every mod's root folder.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <param name="type">Any data from the assembly, which is used to get the name.</param>
        /// <returns>A <see cref="ModInfo"/> of the mod info json file located in the mod.</returns>
        public static ModInfo GetModInfo(Type type) => GetModInfo(NameOfAssembly(type));

        /// <summary>
        /// Gets the path and deserializes the modInfo.json located at every mod's root folder.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <typeparam name="T">The type to get the assembly from, which is used to get the name.</typeparam>
        /// <param name="_">Any data from the assembly, which is used to get the name.</param>
        /// <returns>A <see cref="ModInfo"/> of the mod info json file located in the mod.</returns>
        public static ModInfo GetModInfo<T>(T _) => GetModInfo(NameOfAssembly<T>());

        /// <summary>
        /// Retrieves assets of a specific type from a different bundle file.
        /// </summary>
        /// <typeparam name="TAsset">The type of asset to retrieve.</typeparam>
        /// <param name="bundleFileName">The name of the bundle file.</param>
        /// <param name="bundleAssetFileName">The name of the bundle file to grab the assets from.</param>
        /// <returns>The assets retrieved from the file.</returns>
        public static TAsset[] GetAssets<TAsset>(string bundleFileName, string bundleAssetFileName) where TAsset : Object => (TAsset[])LoadAssets<TAsset>(bundleFileName, bundleAssetFileName).AsEnumerable().OfType<object>().Last();

        /// <summary>
        /// Retrieves assets of a specific type from a different bundle file.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="type">Any data from the assembly, which is used to get the name.</param>
        /// <param name="bundleVideoFileName">The name of the bundle that contains videos.</param>
        /// <returns>The <see cref="AssetBundleCreateRequest"/> needed to load the files, followed by the <see cref="VideoClip"/> <see cref="Array"/>.</returns>
        public static TAsset[] GetAssets<TAsset>(Type type, string bundleVideoFileName) where TAsset : Object => GetAssets<TAsset>(NameOfAssembly(type), bundleVideoFileName);

        /// <summary>
        /// Retrieves assets of a specific type from a different bundle file.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <typeparam name="T">The type to get the assembly from, which is used to get the name.</typeparam>
        /// <typeparam name="TAsset">The type of asset to return.</typeparam>
        /// <param name="_">Any data from the assembly, which is used to get the name.</param>
        /// <param name="bundleVideoFileName">The name of the bundle that contains videos.</param>
        /// <returns>The <see cref="AssetBundleCreateRequest"/> needed to load the files, followed by the <see cref="VideoClip"/> <see cref="Array"/>.</returns>
        public static TAsset[] GetAssets<T, TAsset>(T _, string bundleVideoFileName) where TAsset : Object => GetAssets<TAsset>(NameOfAssembly<T>(), bundleVideoFileName);

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
            switch (platform)
            {
                case WindowsPlayer:
                    File.Copy(path + (Size == 4 ? @"\dlls\x86\" : Size == 8 ? @"\dlls\x86_64\" : throw s_intPtrException) + FileFormat(libraryFileName, FileExtensionWindows), dataPath + @"\Mono\" + FileFormat(libraryFileName, FileExtensionWindows), true);
                    break;

                case OSXPlayer:
                    string dest = CombineMultiple(dataPath, "Frameworks", "MonoEmbedRuntime", "osx");

                    if (!Directory.Exists(dest))
                        Directory.CreateDirectory(dest);

                    File.Copy(CombineMultiple(path, "dlls", FileFormat(libraryFileName, FileExtensionMacOS)), Path.Combine(dest, FileFormat(libraryFileName, FileExtensionMacOS)), true);
                    break;

                case LinuxPlayer:
                    File.Copy(CombineMultiple(path, "dlls", FileFormat(libraryFileName, FileExtensionLinux)), CombineMultiple(dataPath, "Mono", Size == 4 ? "x86" : Size == 8 ? "x86_64" : throw s_intPtrException, FileFormat(libraryFileName, FileExtensionLinux)), true);
                    break;

                default: throw new PlatformNotSupportedException("The OS is not windows, linux, or mac, what kind of system is this?");
            }
        }

        private static string FileFormat(in string fileName, in string fileExtension) => "{0}.{1}".Form(fileName, fileExtension);

        private static string Find(in string search, in string directory)
        {
            try
            {
                return Directory.GetFiles(directory, search).FirstOrDefault();
            }
            catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException || ex is DirectoryNotFoundException || ex is UnauthorizedAccessException)
            {
                Self($"Caught {ex.GetType()}!");
            }

            Self($"The file \"{search}\" could not be found.");
            return null;
        }

        private static IEnumerator LoadAssets<TAsset>(string bundleFileName, string bundleAssetFileName) where TAsset : Object
        {
            Self($"Loading type {typeof(TAsset).Name} from \"{bundleAssetFileName}\" which exists in \"{bundleFileName}\".");

            bundleAssetFileName.NullOrEmptyCheck("You cannot load a video from a nonexistent file.");

            if (!bundleAssetFileName.Contains('.'))
                bundleAssetFileName += ".bundle";

            AssetBundleCreateRequest request = LoadFromFileAsync(GetPath(bundleFileName, bundleAssetFileName));

            yield return request;

            AssetBundle mainBundle = request.assetBundle.NullCheck("The bundle was null.");

            IEnumerable<TAsset> assets = mainBundle.LoadAllAssets<TAsset>().OrderBy(o => o.name).ToArray().NullOrEmptyCheck($"There are no assets of type {typeof(TAsset).Name}.");

            Self($"{assets.Count()} assets of type {typeof(TAsset).Name} have been loaded into memory!");

            yield return assets;
        }
    }
}
