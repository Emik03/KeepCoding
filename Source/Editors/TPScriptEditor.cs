using System.Collections;
using System.Linq;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GUILayout;

namespace KeepCoding
{
    /// <summary>
    /// Custom inspector for <see cref="TPScript{TModule}"/>. 
    /// </summary>
    [CanEditMultipleObjects]
    [CustomEditor(typeof(TPScript<>), true)]
    public class TPScriptEditor : Editor
    {
        /// <summary>
        /// Creates the force solve buttons.
        /// </summary>
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var tp = (ITP)target;

            tp.IsTimeSkippable = Toggle(tp.IsTimeSkippable, "Allow Time-Skipping");

            if (Button("Run autosolver"))
                StartVerification((CacheableBehaviour)target);

            if (Button("Run every autosolver"))
                FindObjectsOfType<CacheableBehaviour>().Where(m => m is ITP).Distinct().ToArray().ForEach(StartVerification);
        }

        private static void StartVerification(CacheableBehaviour obj) => obj.StartCoroutine(VerifySolve(obj));

        private static IEnumerator VerifySolve(CacheableBehaviour obj)
        {
            var tp = (ITP)obj;
            var module = obj.Get<ModuleScript>();

            yield return tp.ForceSolve();

            if (!module.IsSolved)
                module.Log($"The module's solve coroutine finished before the module solved! This is a mistake because Twitch Plays will force-solve a module as soon as the {nameof(IEnumerator)} finishes running. You can fix it by adding a while loop for {nameof(ModuleScript.IsSolved)} that yield returns true.", LogType.Error);
        }
    }
}
