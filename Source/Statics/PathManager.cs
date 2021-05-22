using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;
using Debug = UnityEngine.Debug;
using Object = UnityEngine.Object;
using ModSourceEnum = KeepCoding.Game.ModSourceEnum;

namespace KeepCoding
{
    extern alias core;

    /// <summary>
    /// Allows loading external information stored on the module. Do not use this code on the Editor. Written by Emik.
    /// </summary>
    public static class PathManager
    {
        private const string
            FileExtensionBundle = "bundle",
            FileExtensionLinux = "so",
            FileExtensionMacOS = "dylib",
            FileExtensionWindows = "dll",
            FileFormat = "{0}.{1}";

        private static readonly Dictionary<Tuple<string, string>, object> _cachedResults = new();

        /// <summary>
        /// Prints a hierarchy of all game objects.
        /// </summary>
        /// <param name="indentation">The amount of spaces used for indenting children of game objects.</param>
        public static void PrintFullHierarchy(ushort indentation = 4) => Object.FindObjectsOfType<GameObject>().Where(g => !g.transform.parent).ToArray().ForEach(g => PrintHierarchy(g, indentation));

        /// <summary>
        /// Prints the hierarchy from the game object specified.
        /// </summary>
        /// <param name="obj">The game object to search the hierarchy.</param>
        /// <param name="indentation">The amount of spaces used for indenting children of game objects.</param>
        /// <param name="depth">The level of depth which determines level of indentation. Leave this variable as 0.</param>
        public static void PrintHierarchy(GameObject obj, ushort indentation = 4, ushort depth = 0)
        {
            string indent = new(Enumerable.Repeat(' ', indentation * depth).ToArray());

            Debug.Log($"{indent}{obj.name}");
            Debug.LogWarning($"{indent}{obj.GetComponents<Component>().UnwrapToString()}");

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
        /// Gets the path and deserializes the modInfo.json located at every mod's root folder.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <param name="bundleFileName">The name of the bundle assembly.</param>
        /// <returns>The version number of the mod.</returns>
        public static ModInfo GetModInfo(string bundleFileName)
        {
            bundleFileName.NullOrEmptyCheck("You cannot retrieve a mod's modInfo.json if the bundle file name is null or empty.");

            Current(in bundleFileName, out var current);

            if (IsCached(in current))
                return GetCache<ModInfo>(in current);

            string path = GetPath(FileFormat.Form(bundleFileName, FileExtensionWindows));

            return SetCache(current, ModInfo.Deserialize($"{path}{GetSlashType(in path)}modInfo.json"));
        }

        /// <summary>
        /// Finds a path of a given file within each mod.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="fileName">The file name to search for.</param>
        /// <returns>The path to <paramref name="fileName"/>.</returns>
        public static string GetPath(string fileName)
        {
            fileName.NullOrEmptyCheck("You cannot retrieve a path if the file name is null or empty.");

            Current(in fileName, out var current);

            if (IsCached(in current))
                return GetCache<string>(in current);

            string path = Game.ModManager.GetEnabledModPaths(ModSourceEnum.Local)
                              .FirstOrDefault(x => Directory.GetFiles(x, fileName).Any()) ??
                          Game.ModManager.GetEnabledModPaths(ModSourceEnum.SteamWorkshop)
                              .FirstOrDefault(x => Directory.GetFiles(x, fileName).Any()) ??
                          GetDisabledPath(fileName) ?? throw new FileNotFoundException($"The file name {fileName} could not be found within your mods folder!");

            return SetCache(current, path
                .Replace($"/{fileName}", "")
                .Replace(@$"\{fileName}", ""));
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
        /// <param name="bundleFileName">The name of the bundle file.</param>
        /// <param name="libraryFileName">The library's name, excluding the extension.</param>
        public static void LoadLibrary(string bundleFileName, string libraryFileName)
        {
            libraryFileName.NullOrEmptyCheck("You cannot load a library which has a null or empty name.");

            Current(bundleFileName + libraryFileName, out var current);

            if (IsCached(in current))
                return;

            SetCache<string>(current, null);

            string path = GetPath(FileFormat.Form(bundleFileName, FileExtensionWindows));

            Log($"The path to load {libraryFileName} as called from {bundleFileName} is: {path}.");

            CopyLibrary(in libraryFileName, in path);
        }

        /// <summary>
        /// Gets the video clips, the last yield return contains all of the videos.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="bundleFileName">The name of the bundle file.</param>
        /// <param name="bundleVideoFileName">The name of the bundle that contains videos.</param>
        /// <returns>The <see cref="AssetBundleCreateRequest"/> needed to load the files, followed by the <see cref="VideoClip"/> <see cref="Array"/>.</returns>
        public static IEnumerator LoadVideoClips(string bundleFileName, string bundleVideoFileName)
        {
            bundleVideoFileName.NullOrEmptyCheck("You cannot load a video from a nonexistent file.");

            Current(bundleFileName + bundleVideoFileName, out var current);

            if (IsCached(in current))
            {
                yield return GetCache<VideoClip[]>(in current);
                yield break;
            }

            string path = GetPath(FileFormat.Form(bundleFileName, FileExtensionWindows));

            var request = AssetBundle.LoadFromFileAsync($"{path}{GetSlashType(in path)}{FileFormat.Form(bundleVideoFileName, FileExtensionBundle)}");

            yield return request;

            var mainBundle = request.assetBundle.NullCheck("The bundle was null.");

            var videos = mainBundle.LoadAllAssets<VideoClip>().OrderBy(clip => clip.name).ToArray().NullOrEmptyCheck("There are no videos.");

            SetCache(current, videos);
            
            yield return videos;
        }

        internal static void Log(in string message) => Debug.Log($"[Keep Coding] {message}");

        internal static FileVersionInfo GetVersionLibrary() => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

        private static void CopyLibrary(in string libraryFileName, in string path)
        {
            var unhandledIntPtr = new PlatformNotSupportedException("IntPtr size is not 4 or 8, what kind of system is this?");

            switch (Application.platform)
            {
                case RuntimePlatform.WindowsPlayer:
                    File.Copy(path + (IntPtr.Size == 4 ? "\\dlls\\x86\\" : IntPtr.Size == 8 ? "\\dlls\\x86_64\\" : throw unhandledIntPtr) + FileFormat.Form(libraryFileName, FileExtensionWindows), Application.dataPath + "\\Mono\\" + FileFormat.Form(libraryFileName, FileExtensionWindows), true);
                    break;

                case RuntimePlatform.OSXPlayer:
                    string dest = CombineMultiple(Application.dataPath, "Frameworks", "MonoEmbedRuntime", "osx");

                    if (!Directory.Exists(dest))
                        Directory.CreateDirectory(dest);

                    File.Copy(CombineMultiple(path, "dlls", FileFormat.Form(libraryFileName, FileExtensionMacOS)), Path.Combine(dest, FileFormat.Form(libraryFileName, FileExtensionMacOS)), true);
                    break;

                case RuntimePlatform.LinuxPlayer:
                    File.Copy(CombineMultiple(path, "dlls", FileFormat.Form(libraryFileName, FileExtensionLinux)), CombineMultiple(Application.dataPath, "Mono", IntPtr.Size == 4 ? "x86" : IntPtr.Size == 8 ? "x86_64" : throw unhandledIntPtr, FileFormat.Form(libraryFileName, FileExtensionLinux)), true);
                    break;

                default: throw new PlatformNotSupportedException("The OS is not windows, linux, or mac, what kind of system is this?");
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void Current(in string bundleFileName, out Tuple<string, string> current) => current = new StackTrace().GetFrame(1).GetMethod().Name.ToTuple(bundleFileName);

        private static bool IsCached(in Tuple<string, string> current) => _cachedResults.ContainsKey(current);

        private static char GetSlashType(in string path) => path.Count(c => c == '/') >= path.Count(c => c == '\\') ? '/' : '\\';

        private static string GetDisabledPath(string fileName) 
            => Game.ModManager.GetDisabledModPaths().FirstValue(path =>
            {
                try
                {
                    string[] files = Directory.GetFiles(path, fileName);

                    if (files.LengthOrDefault() > 0 && !files[0].Trim().IsNullOrEmpty())
                        return files[0];
                }
                catch (Exception ex) when (ex is ArgumentException or ArgumentNullException or DirectoryNotFoundException or UnauthorizedAccessException) { }

                return null;
            });

        private static T GetCache<T>(in Tuple<string, string> current) => (T)_cachedResults[current];

        private static T SetCache<T>(Tuple<string, string> current, T value) => value.Call(v => _cachedResults.Add(current, v));
    }
}
