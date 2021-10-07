using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UnityEngine;
using static KeepCoding.Logger;
using static UnityEngine.Application;

namespace KeepCoding
{
    /// <summary>
    /// Provides methods to retrieve information from other external mods.
    /// </summary>
    public static class External
    {
        private static readonly Dictionary<KMBomb, ReadOnlyCollection<ModuleContainer>> s_allModules = new Dictionary<KMBomb, ReadOnlyCollection<ModuleContainer>>();

        /// <summary>
        /// Gets the rule seed number, or a default value.
        /// </summary>
        /// <param name="module">The module to retrieve the id from.</param>
        /// <param name="editorValue">The value to <see langword="return"/> if played on the Unity Editor.</param>
        /// <returns>If successful, the rule seed's number that is used as the seed in <see cref="MonoRandom"/>. The default value is 1, or <paramref name="editorValue"/> if played in the Unity Editor.</returns>
        public static int GetRuleSeedId(ModuleContainer module, int editorValue)
        {
            int standard = isEditor ? editorValue : 1;

            var ruleSeedObject = GameObject.Find("RuleSeedModifierProperties");

            if (ruleSeedObject is null)
                return standard;

            IDictionary<string, object> ruleSeedDictionary = ruleSeedObject.GetComponent<IDictionary<string, object>>();

            if (!ruleSeedDictionary.ContainsKey("RuleSeed"))
                return standard;

            if (ruleSeedDictionary.ContainsKey("AddSupportedModule"))
                ruleSeedDictionary["AddSupportedModule"] = module.Id;

            return (ruleSeedDictionary["RuleSeed"] as int?) ?? standard;
        }

        /// <summary>
        /// Retrieves the ignore list from the Boss Module Manager mod used primarily by boss modules.
        /// </summary>
        /// <param name="module">The module to retrieve the name from.</param>
        /// <returns>If successful, the boss module's ignore list, otherwise a new empty string array.</returns>
        public static string[] GetIgnoredModules(ModuleContainer module)
        {
            if (isEditor)
                return new string[0];

            var managerObject = GameObject.Find("BossModuleManager");

            var logger = new Logger("KMBossModule");

            if (managerObject is null)
            {
                logger.Log("Boss Module Manager is not installed.");
                return new string[0];
            }

            IDictionary<string, object> dictionary = managerObject.GetComponent<IDictionary<string, object>>();

            const string Key = "GetIgnoredModules";

            if (dictionary is null || !dictionary.ContainsKey(Key))
            {
                logger.Log($"Boss Module Manager does not have a list on record for “{module.Name}”.");
                return new string[0];
            }

            string[] list = ((Func<string, string[]>)dictionary[Key])(module.Name);

            logger.Log($"Boss Module Manager returned list for “{module}”: {(list is null ? Helper.Null : list.Combine())}");
            return list ?? new string[0];
        }

        /// <summary>
        /// Allows you to get the collection of <see cref="ModuleContainer"/> from a <see cref="KMBomb"/>.
        /// </summary>
        /// <remarks>
        /// This collection also includes vanilla modules, including <see cref="ComponentPool.ComponentTypeEnum.Empty"/> components and <see cref="ComponentPool.ComponentTypeEnum.Timer"/>. You can filter the collection with <see cref="ModuleContainer.IsVanilla"/>, <see cref="ModuleContainer.IsModded"/>, <see cref="ModuleContainer.IsSolvable"/>, or <see cref="ModuleContainer.IsNeedy"/>, <see cref="ModuleContainer.IsEmptyOrTimer"/>, or <see cref="ModuleContainer.IsModule"/>.
        /// </remarks>
        /// <param name="bomb">The instance of <see cref="KMBomb"/> that has modules.</param>
        /// <returns>All modules within <paramref name="bomb"/>.</returns>
        [CLSCompliant(false)]
        public static ReadOnlyCollection<ModuleContainer> ModulesOfBomb(KMBomb bomb)
        {
            if (bomb is null)
            {
                if (isEditor)
                    Self($"{nameof(ModulesOfBomb)} was called with a null {nameof(KMBomb)}, returning null.");

                return null;
            }

            if (s_allModules.ContainsKey(bomb))
                return s_allModules[bomb];

            ReadOnlyCollection<ModuleContainer> modules = bomb.ToModules().ToReadOnly();

            s_allModules
                .Keys
                .Where(bomb => !bomb)
                .ForEach(bomb => s_allModules.Remove(bomb));

            s_allModules.Add(bomb, modules);

            return modules;
        }
    }
}
