using System;
using System.Collections;
using Newtonsoft.Json.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using static System.IO.File;
using static System.Reflection.Assembly;
using static System.Uri;
using static KeepCoding.Logger;
using static KeepCoding.ModuleScript;
using static UnityEditor.EditorApplication;
using static UnityEngine.GUILayout;
using static UnityEngine.Networking.UnityWebRequest;

namespace KeepCoding.Internal
{
    /// <summary>
    /// Custom inspector for <see cref="ModuleScript"/>. 
    /// </summary>
    [CanEditMultipleObjects, CLSCompliant(false), CustomEditor(typeof(ModuleScript), true)]
    public sealed class ModuleScriptEditor : Editor
    {
        private static string SelfPath => UnescapeDataString(new UriBuilder(GetExecutingAssembly().CodeBase).Path);

        /// <summary>
        /// Creates the colorblind button.
        /// </summary>
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var module = (ModuleScript)target;

            if (isPlaying && module.IsColorblindSupported)
                module.IsColorblind = Toggle(module.IsColorblind, "Enable colorblind");

            if (IsOutdated && Button("Download latest KeepCoding version"))
                module.StartCoroutine(GetLatest());
        }

        private static bool AssertNetwork(UnityWebRequest web, string message)
        {
            bool b = web.isNetworkError || web.isHttpError;

            if (b)
                Self($"{message}: {web.error}", LogType.Warning);

            return b;
        }

        private static IEnumerator GetLatest()
        {
            using UnityWebRequest latest = PathManager.LatestGitHub;

            yield return latest.SendWebRequest();

            if (AssertNetwork(latest, "The library was unable to get the version number"))
                yield break;

            string tagName = JObject.Parse(latest.downloadHandler.text).GetValue("tag_name").ToObject<string>();

            Self($"The latest version ({tagName}) was successfully fetched, downloading files...");

            yield return InstallLatest(tagName, "xml");
            yield return InstallLatest(tagName, "dll");

            Self($"Process complete. Your Unity should now start reloading...");

        }

        private static IEnumerator InstallLatest(string tagName, string extension)
        {
            using UnityWebRequest web = Get($"https://github.com/Emik03/KeepCoding/releases/download/{tagName}/KeepCoding.{extension}");

            Self($"Downloading the latest {extension} file...");

            yield return web.SendWebRequest();

            if (AssertNetwork(web, $"The library was unable to get the {extension} file from latest"))
                yield break;

            Self($"Installing the latest {extension} file...");

            WriteAllBytes(SelfPath, web.downloadHandler.data);

        }
    }
}
