using UnityEditor;
using static System.Reflection.BindingFlags;
using static UnityEditor.EditorApplication;
using static UnityEngine.GUILayout;

namespace KeepCoding.Internal
{
    /// <summary>
    /// Custom inspector for <see cref="ModuleScript"/>. 
    /// </summary>
    [CanEditMultipleObjects]
    [CustomEditor(typeof(ModuleScript), true)]
    public sealed class ModuleScriptEditor : Editor
    {
        /// <summary>
        /// Creates the colorblind button.
        /// </summary>
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var module = (ModuleScript)target;

            if (isPlaying && module.GetType().GetMethod("OnColorblindChanged", DeclaredOnly | Instance | Public) is { })
                module.IsColorblind = Toggle(module.IsColorblind, "Enable colorblind");
        }
    }
}
