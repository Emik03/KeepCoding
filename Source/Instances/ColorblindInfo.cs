using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using static UnityEngine.Application;

namespace KeepCoding
{
    /// <summary>
    /// Contains information about the colorblind mod's info, this class can be used to deserialize "ColorblindMode.json".
    /// </summary>
    public sealed class ColorblindInfo : ModConfig<ColorblindInfo>
    {
        /// <summary>
        /// Creates a <see cref="ColorblindInfo"/> without read/writing the file.
        /// </summary>
        public ColorblindInfo() : base(null) { }

        /// <summary>
        /// Creates a <see cref="ColorblindInfo"/> while read/writing the file.
        /// </summary>
        /// <param name="moduleId">The module's id to grab information from.</param>
        public ColorblindInfo(string moduleId) : base("ColorblindMode")
        {
            if (isEditor)
                return;

            ColorblindInfo info = Read();

            IsEnabled = info.IsEnabled;
            Modules = info.Modules;

            if (!Modules.TryGetValue(moduleId.NullCheck("The module id cannot be null."), out bool? isEnabled))
                Modules[moduleId] = null;

            Write(this);

            IsModuleEnabled = isEnabled ?? IsEnabled;
        }

        [JsonConstructor]
#pragma warning disable IDE0051 // Remove unused private members
        private ColorblindInfo(bool isEnabled, Dictionary<string, bool?> modules) : this()
#pragma warning restore IDE0051 // Remove unused private members
        {
            IsEnabled = isEnabled;
            Modules = modules;
        }

        /// <summary>
        /// Determines whether colorblind mode is on.
        /// </summary>
        [JsonProperty("Enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Determines whether colorblind mode for the module is on.
        /// </summary>
        [JsonIgnore]
        public bool IsModuleEnabled { get; set; }

        /// <summary>
        /// Contains module ids and their colorblind states.
        /// </summary>
        [JsonProperty("EnabledModules")]
        public Dictionary<string, bool?> Modules { get; private set; } = new Dictionary<string, bool?>();

        /// <summary>
        /// Determines if both objects are equal.
        /// </summary>
        /// <param name="obj">The comparison.</param>
        /// <returns>True if both of them are <see cref="ColorblindInfo"/> and contain the same <see cref="IsEnabled"/> and <see cref="Modules"/>.</returns>
        public override bool Equals(object obj) => obj is ColorblindInfo c && IsEnabled == c.IsEnabled && Modules.SequenceEqual(c.Modules);

        /// <summary>
        /// Gets the hash code.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode() => HashCode.Combine(IsEnabled, Modules);

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns><see cref="Modules"/> unwrapped with <see cref="Helper.Stringify{T}(T, StringifyFormat)"/>.</returns>
        public override string ToString() => Modules.Stringify();
    }
}
