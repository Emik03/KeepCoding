using Assets.Scripts.Mods;
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Linq;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace KeepCodingAndNobodyExplodes
{
    extern alias core;

    /// <summary>
    /// Allows loading external information stored on the module. Do not use this code on the Editor. Written by Emik.
    /// </summary>
    public static class PathManager
    {
        private const string 
            FileFormat = "{0}.{1}",
            FileExtensionWindows = "dll", 
            FileExtensionMacOS = "dylib", 
            FileExtensionLinux = "so";

        private static readonly Dictionary<Tuple<string, string>, string> _cachedResults = new Dictionary<Tuple<string, string>, string>();

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void Current(string bundleFileName, out Tuple<string, string> current) => current = new StackTrace().GetFrame(1).GetMethod().Name.ToTuple(bundleFileName);

        private static string SetCache(this Tuple<string, string> current, string value) 
        { 
            _cachedResults.Add(current, value); 
            return value;
        }

        private static bool IsCached(this Tuple<string, string> current) => _cachedResults.ContainsKey(current);

        private static string GetCache(this Tuple<string, string> current) => _cachedResults[current];

        /// <summary>
        /// Combines multiple paths together.
        /// </summary>
        /// <param name="paths">The paths to combine with.</param>
        /// <returns>A single path consisting of the combined path of the array.</returns>
        public static string CombineMultiple(params string[] paths) => paths.Aggregate(Path.Combine);

        /// <summary>
        /// Retrieves the file path to the JSON file in the mod folder.
        /// </summary>
        /// <remarks>
        /// It is very cruicial that we do not return ModInfo in any method, including private ones as the editor library does not have it, and therefore won't be able to run this library in the first place.
        /// </remarks>
        /// <exception cref="FileNotFoundException"></exception>
        /// <param name="bundleFileName">The name of the bundle assembly.</param>
        /// <returns>The version number of the mod.</returns>
        public static string GetModInfoPath(string bundleFileName)
        {
            Current(bundleFileName, out var current);

            if (IsCached(current))
                return GetCache(current);

            var methodInfo = typeof(ModManager).GetMethod("GetModInfoFromPath", Helper.Flags);

            return SetCache(current, ((ModInfo)methodInfo.Invoke(ModManager.Instance, new object[] { GetPath(bundleFileName), ModInfo.ModSourceEnum.Local })).FilePath ??
                ((ModInfo)methodInfo.Invoke(ModManager.Instance, new object[] { GetPath(bundleFileName), ModInfo.ModSourceEnum.SteamWorkshop })).FilePath ??
                ((ModInfo)methodInfo.Invoke(ModManager.Instance, new object[] { GetPath(bundleFileName), ModInfo.ModSourceEnum.Invalid })).FilePath ??
                throw new FileNotFoundException(bundleFileName));
        }

        /// <summary>
        /// Retrieves the version number from the JSON file in the mod folder.
        /// </summary>
        /// <remarks>
        /// It is very cruicial that we do not return ModInfo in any method, including private ones as the editor library does not have it, and therefore won't be able to run this library in the first place.
        /// </remarks>
        /// <exception cref="FileNotFoundException"></exception>
        /// <param name="bundleFileName">The name of the bundle assembly.</param>
        /// <returns>The version number of the mod.</returns>
        public static string GetModInfoVersion(string bundleFileName)
        {
            Current(bundleFileName, out var current);

            if (IsCached(current))
                return GetCache(current);

            var methodInfo = typeof(ModManager).GetMethod("GetModInfoFromPath", Helper.Flags);

            return SetCache(current, ((ModInfo)methodInfo.Invoke(ModManager.Instance, new object[] { GetPath(bundleFileName), ModInfo.ModSourceEnum.Local })).Version ??
                ((ModInfo)methodInfo.Invoke(ModManager.Instance, new object[] { GetPath(bundleFileName), ModInfo.ModSourceEnum.SteamWorkshop })).Version ??
                ((ModInfo)methodInfo.Invoke(ModManager.Instance, new object[] { GetPath(bundleFileName), ModInfo.ModSourceEnum.Invalid })).Version ??
                throw new FileNotFoundException(bundleFileName));
        }

        /// <summary>
        /// Finds a path of a given file within each mod.
        /// </summary>
        /// <exception cref="FileNotFoundException"></exception>
        /// <param name="fileName">The file name to search for.</param>
        /// <returns>The path to <paramref name="fileName"/>.</returns>
        public static string GetPath(string fileName)
        {
            Current(fileName, out var current);

            if (IsCached(current))
                return GetCache(current);

            string path = ModManager.Instance.GetEnabledModPaths(ModInfo.ModSourceEnum.Local)
                              .FirstOrDefault(x => Directory.GetFiles(x, fileName).Any()) ??
                          ModManager.Instance.GetEnabledModPaths(ModInfo.ModSourceEnum.SteamWorkshop)
                              .FirstOrDefault(x => Directory.GetFiles(x, fileName).Any()) ??
                          GetDisabledPath(fileName) ?? throw new FileNotFoundException(fileName);

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
        /// <exception cref="FileNotFoundException"></exception>
        /// <param name="bundleFileName">The name of the bundle file.</param>
        /// <param name="libraryFileName">The library's name, excluding the extension.</param>
        public static void LoadLibrary(string bundleFileName, string libraryFileName)
        {
            Current(bundleFileName + libraryFileName, out var current);

            if (IsCached(current))
                return;

            SetCache(current, null);

            string path = GetPath(FileFormat.Form(bundleFileName, FileExtensionWindows));

            Debug.Log($"[Keep Coding So Nobody Explodes] The path to load {libraryFileName} as called from {bundleFileName} is: {path}.");

            CopyLibrary(libraryFileName, path);
        }

        private static void CopyLibrary(string libraryFileName, string path)
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

        private static string GetDisabledPath(string fileName)
        {
            var disabledPaths = ModManager.Instance.GetDisabledModPaths();

            foreach (string disabledPath in disabledPaths)
            {
                try
                {
                    string[] files = Directory.GetFiles(disabledPath, fileName);

                    if (files.LengthOrDefault() > 0 && !files[0].Trim().IsNullOrEmpty())
                        return files[0];
                }
                catch (Exception)
                {
                    continue;
                }
            }

            return null;
        }
    }
}
