using System.Collections;
using System.Linq;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GUILayout;

namespace KeepCoding
{
    /// <summary>
    /// Custom inspector for <see cref="TPScript{TModule}"/>. Written by Emik.
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

            if (Button("Force Solve"))
                StartVerification((MonoBehaviour)target);

            if (Button("Force Solve All"))
                FindObjectsOfType<MonoBehaviour>().Where(m => m is ITP).Distinct().ToArray().ForEach(StartVerification);
        }

        private static void StartVerification(MonoBehaviour obj) => obj.StartCoroutine(VerifySolve(obj));

        private static IEnumerator VerifySolve(MonoBehaviour obj)
        {
            var tp = (ITP)obj;
            var module = obj.GetComponent<ModuleScript>();

            yield return tp.ForceSolve();

            if (!module.IsSolved)
                module.Log($"The module's solve coroutine finished before the module solved! This is a mistake because Twitch Plays will force-solve a module as soon as the {nameof(IEnumerator)} finishes running. You can fix it by adding a while loop for {nameof(ModuleScript.IsSolved)} that yield returns true.", LogType.Error);
        }
    }
}
