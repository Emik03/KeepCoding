using System.Collections.Generic;
using System.Linq;
using static System.String;

namespace KeepCoding
{
    /// <summary>
    /// Everything needed to generate a single bomb.
    /// </summary>
    public sealed class GeneratorSetting
    {
        /// <summary>
        /// Creates a generator setting with the default parameters.
        /// </summary>
        public GeneratorSetting() : this(false, 5, 3, 90, 300, new List<ComponentPool>()) { }

        /// <summary>
        /// Creates a generator setting based on the provided parameters.
        /// </summary>
        /// <param name="frontFaceOnly">Force modules to be placed only on the front face. By default this will limit the module count to 5 (+1 for the timer). Useful in rare circumstances where you wish to generate a bomb with a few modules and guarantee that they will all be visibile simultaneously.</param>
        /// <param name="optionalWidgetCount">Set how many optional widgets (widgets other than serial number) that should be placed on the bomb.</param>
        /// <param name="numStrikes">The number of strikes at which the bomb explodes. Hardcore is 1. More forgiving is 3.</param>
        /// <param name="timeBeforeNeedyActivation">Time, in seconds, which must elapse before any unactivated Needy modules are automatically activated.</param>
        /// <param name="timeLimit">Initial value for the timer when the bomb is activated, in seconds.</param>
        /// <param name="componentPools">The pools of modules that will be used when generating a bomb.</param>
        public GeneratorSetting(bool frontFaceOnly, int optionalWidgetCount, int numStrikes, int timeBeforeNeedyActivation, float timeLimit, List<ComponentPool> componentPools)
        {
            FrontFaceOnly = frontFaceOnly;
            OptionalWidgetCount = optionalWidgetCount;
            NumStrikes = numStrikes;
            TimeBeforeNeedyActivation = timeBeforeNeedyActivation;
            TimeLimit = timeLimit;
            ComponentPools = componentPools;
        }

        /// <summary>
        /// Force modules to be placed only on the front face. By default this will limit the module count to 5 (+1 for the timer). Useful in rare circumstances where you wish to generate a bomb with a few modules and guarantee that they will all be visibile simultaneously.
        /// </summary>
        public bool FrontFaceOnly { get; }

        /// <summary>
        /// Set how many optional widgets (widgets other than serial number) that should be placed on the bomb.
        /// </summary>
        public int OptionalWidgetCount { get; }

        /// <summary>
        /// The number of strikes at which the bomb explodes. Hardcore is 1. More forgiving is 3.
        /// </summary>
        public int NumStrikes { get; }

        /// <summary>
        /// Time, in seconds, which must elapse before any unactivated Needy modules are automatically activated.
        /// </summary>
        public int TimeBeforeNeedyActivation { get; }

        /// <summary>
        /// Initial value for the timer when the bomb is activated, in seconds.
        /// </summary>
        public float TimeLimit { get; }

        /// <summary>
        /// The pools of modules that will be used when generating a bomb.
        /// </summary>
        public List<ComponentPool> ComponentPools { get; }

        /// <summary>
        /// The total count of modules that will be added according to the component pools.
        /// </summary>
        /// <returns>The amount of components.</returns>
        public int GetComponentCount() => ComponentPools.Sum(c => c.Count);

        /// <summary>
        /// Converts itself to a string.
        /// </summary>
        /// <returns>Time, number of strikes, and the pools converted to a string.</returns>
        public override string ToString() => $"Time: {TimeLimit}, NumStrikes: {NumStrikes}\n{ComponentPools.Count} Pools:\n{Join("", ComponentPools.ConvertAll(c => $"{c}\n").ToArray())}";
    }
}
