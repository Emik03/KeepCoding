using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.Video;
using static KeepCoding.Game.ModManager;
using static KeepCoding.Game.ModSourceEnum;
using static KeepCoding.ModInfo;
using static System.IntPtr;
using static System.Linq.Enumerable;
using static System.Reflection.Assembly;
using static UnityEngine.Application;
using static UnityEngine.AssetBundle;
using static UnityEngine.Debug;
using static UnityEngine.Object;
using static UnityEngine.RuntimePlatform;
using Object = UnityEngine.Object;

namespace KeepCoding
{
    extern alias core;

    /// <summary>
    /// Allows loading external information stored on the module. Written by Emik.
    /// </summary>
    public static class PathManager
    {
        /// <value>
        /// Gets this library's <see cref="AssemblyName"/>.
        /// </value>
        public static AssemblyName AssemblyName => GetExecutingAssembly().GetName();

        /// <value>
        /// Gets this library's version number. Currently used by <see cref="ModuleScript"/> to log the version number of this library.
        /// </value>
        /// <remarks>
        /// If you want the version number of your modules, refer to <see cref="ModuleScript.Version"/> instead, or <see cref="GetModInfo{T}(T)"/>.
        /// </remarks>
        public static Version Version => AssemblyName.Version;

        private const string
            FileExtensionBundle = "bundle",
            FileExtensionLinux = "so",
            FileExtensionMacOS = "dylib",
            FileExtensionWindows = "dll",
            FileFormat = "{0}.{1}";

        private static readonly Dictionary<string, string> _paths = new Dictionary<string, string>();

        private static readonly Dictionary<string, ModInfo> _modInfos = new Dictionary<string, ModInfo>();

        private static readonly PlatformNotSupportedException _intPtrException = new PlatformNotSupportedException("IntPtr size is not 4 or 8, what kind of system is this?");

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
            LogWarning($"{indent}{obj.GetComponents<Component>().UnwrapToString()}");

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
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <param name="bundleFileName">The name of the bundle assembly.</param>
        /// <returns>A <see cref="ModInfo"/> of the mod info json file located in the mod.</returns>
        public static ModInfo GetModInfo(string bundleFileName)
        {
            Logger.Self($"Retrieving the {nameof(ModInfo)} data from \"{bundleFileName}\"...");

            if (isEditor)
            {
                Logger.Self($"This method is being run on the Editor, therefore a new instance of {nameof(ModInfo)} will be returned.");
                return new ModInfo();
            }

            if (_modInfos.TryGetValue(bundleFileName, out var info))
            {
                Logger.Self($"{bundleFileName}'s {nameof(ModInfo)} has already been cached. Returning cached result.");
                return info;
            }

            bundleFileName.NullOrEmptyCheck("You cannot retrieve a mod's modInfo.json if the bundle file name is null or empty.");

            string search = GetPath(FileFormat.Form(bundleFileName, FileExtensionWindows)),
                file = $"{search}{GetSlashType(in search)}modInfo.json";

            if (!File.Exists(file))
                throw new FileNotFoundException($"The mod bundle was found in {search}, but no mod info was found! (Expected to find \"{file}\")");

            Logger.Self($"File found! Returning {file}.");

            info = Deserialize(file);

            _modInfos.Add(bundleFileName, info);

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
        /// Finds the path of a given file within each mod.
        /// </summary>
        /// <remarks>
        /// You need to specify the extensions of the file too, otherwise the file cannot be found.
        /// </remarks>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="search">The file to search for. Make sure to include extensions!</param>
        /// <returns>The path to <paramref name="search"/>.</returns>
        public static string GetPath(string search)
        {
            Logger.Self($"Searching for file \"{search}\" anywhere in the mods folder...");

            if (isEditor)
            {
                Logger.Self("This method is being run on the Editor, therefore an empty string will be returned.");
                return "";
            }

            if (_paths.TryGetValue(search, out string path))
            {
                Logger.Self($"{path}'s path has already been cached. Returning cached result.");
                return path;
            }

            search.NullOrEmptyCheck("You cannot retrieve a path if the file name is null or empty.");

            path = (GetAllModPathsFromSource(Local).Call(f => Logger.Self("Searching for enabled local mods...")).Find(search) ??
                GetAllModPathsFromSource(SteamWorkshop).Call(f => Logger.Self("Searching for enabled steam workshop mods...")).Find(search))
                .Replace($"/{search}", "").Replace(@$"\{search}", "");

            _paths.Add(search, path);

            return path;
        }

        /// <summary>
        /// Finds the path of the mod.
        /// </summary>
        /// <param name="type">Any data from the assembly, which is used to get the name.</param>
        /// <returns>The path to the mod.</returns>
        public static string GetPath(Type type) => GetPath(FileFormat.Form(NameOfAssembly(type), FileExtensionWindows));

        /// <summary>
        /// Finds the path of the mod.
        /// </summary>
        /// <typeparam name="T">The type to get the assembly from, which is used to get the name.</typeparam>
        /// <param name="_">Any data from the assembly, which is used to get the name.</param>
        /// <returns>The path to the mod.</returns>
        public static string GetPath<T>(T _ = default) => GetPath(FileFormat.Form(NameOfAssembly<T>(), FileExtensionWindows));

        /// <summary>
        /// Loads a library by searching for the bundle. Do not run this on the Editor.
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
            Logger.Self($"Preparing to copy library \"{libraryFileName}\" which exists in \"{bundleFileName}\".");

            if (isEditor)
            {
                Logger.Self($"This method is being run on the Editor, therefore nothing will be done.");
                return;
            }

            libraryFileName.NullOrEmptyCheck("You cannot load a library which has a null or empty name.");

            string path = GetPath(FileFormat.Form(bundleFileName, FileExtensionWindows));

            CopyLibrary(in libraryFileName, in path);

            Logger.Self($"The library has been copied over. They are now ready to be referenced.");
        }

        /// <summary>
        /// Loads a library by searching for the bundle. Do not run this on the Editor.
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
        /// Loads a library by searching for the bundle. Do not run this on the Editor.
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

        private static void CopyLibrary(in string libraryFileName, in string path)
        {
            switch (platform)
            {
                case WindowsPlayer:
                    File.Copy(path + (Size == 4 ? @"\dlls\x86\" : Size == 8 ? @"\dlls\x86_64\" : throw _intPtrException) + FileFormat.Form(libraryFileName, FileExtensionWindows), dataPath + @"\Mono\" + FileFormat.Form(libraryFileName, FileExtensionWindows), true);
                    break;

                case OSXPlayer:
                    string dest = CombineMultiple(dataPath, "Frameworks", "MonoEmbedRuntime", "osx");

                    if (!Directory.Exists(dest))
                        Directory.CreateDirectory(dest);

                    File.Copy(CombineMultiple(path, "dlls", FileFormat.Form(libraryFileName, FileExtensionMacOS)), Path.Combine(dest, FileFormat.Form(libraryFileName, FileExtensionMacOS)), true);
                    break;

                case LinuxPlayer:
                    File.Copy(CombineMultiple(path, "dlls", FileFormat.Form(libraryFileName, FileExtensionLinux)), CombineMultiple(dataPath, "Mono", Size == 4 ? "x86" : Size == 8 ? "x86_64" : throw _intPtrException, FileFormat.Form(libraryFileName, FileExtensionLinux)), true);
                    break;

                default: throw new PlatformNotSupportedException("The OS is not windows, linux, or mac, what kind of system is this?");
            }
        }

        private static char GetSlashType(in string path) => path.Count(c => c == '/') >= path.Count(c => c == '\\') ? '/' : '\\';

        private static string Find(List<string> directories, string search) 
            => directories.FirstValue(path =>
            {
                try
                {
                    string[] files = Directory.GetFiles(path, search);

                    if (files.LengthOrDefault() > 0 && !files[0].Trim().IsNullOrEmpty())
                        return files[0].Call(s => Logger.Self($"Found \"{search}\" in {files[0]}!"));
                }
                catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException || ex is DirectoryNotFoundException || ex is UnauthorizedAccessException) 
                {
                    Logger.Self($"Caught {ex.GetType()}!");
                }

                Logger.Self($"The file \"{search}\" could not be found.");
                return null;
            });

        private static IEnumerator LoadAssets<TAsset>(string bundleFileName, string bundleAssetFileName) where TAsset : Object
        {
            Logger.Self($"Loading type {typeof(TAsset).Name} from \"{bundleAssetFileName}\" which exists in \"{bundleFileName}\".");

            bundleAssetFileName.NullOrEmptyCheck("You cannot load a video from a nonexistent file.");

            string path = GetPath(FileFormat.Form(bundleFileName, FileExtensionWindows));

            var request = LoadFromFileAsync($"{path}{GetSlashType(in path)}{FileFormat.Form(bundleAssetFileName, FileExtensionBundle)}");

            yield return request;

            var mainBundle = request.assetBundle.NullCheck("The bundle was null.");

            var assets = mainBundle.LoadAllAssets<TAsset>().OrderBy(o => o.name).ToArray().NullOrEmptyCheck($"There are no assets of type {typeof(TAsset).Name}.");

            Logger.Self($"{assets.Count()} assets of type {typeof(TAsset).Name} have been loaded into memory!");

            yield return assets;
        }
    }
}
