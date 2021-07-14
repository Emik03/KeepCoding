using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using static Newtonsoft.Json.JsonConvert;
using static System.IO.File;

namespace KeepCoding
{
    /// <summary>
    /// Contains information about the colorblind mod's info, this class can be used to deserialize every mod's "modInfo.json".
    /// </summary>
    public sealed class ColorblindInfo
    {
        /// <value>
        /// Determines whether colorblind mode is on.
        /// </value>
        [JsonProperty("Enabled")]
        public bool IsEnabled { get; private set; }

        /// <value>
        /// Contains module ids and their colorblind states.
        /// </value>
        [JsonProperty("EnabledModules")]
        public Dictionary<string, bool?> Modules { get; private set; }

        /// <summary>
        /// Determines if both objects are equal.
        /// </summary>
        /// <param name="obj">The comparison.</param>
        /// <returns>True if both of them are <see cref="ColorblindInfo"/> and contain the same <see cref="IsEnabled"/> and <see cref="Modules"/>.</returns>
        public override bool Equals(object obj) => obj is ColorblindInfo c && IsEnabled == c.IsEnabled && Modules == c.Modules;

        /// <summary>
        /// Gets the hash code.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            int hashCode = 1258913641;
            hashCode = hashCode * -1521134295 + IsEnabled.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Dictionary<string, bool?>>.Default.GetHashCode(Modules);
            return hashCode;
        }

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns><see cref="Modules"/> unwrapped with <see cref="Helper.UnwrapToString{T}(T, bool, string)"/>.</returns>
        public override string ToString() => Modules.UnwrapToString();

        /// <summary>
        /// Deserializes a modInfo.json file.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="SecurityException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <param name="path">The path of the file to deserialize.</param>
        /// <returns><paramref name="path"/> deserialized as <see cref="ColorblindInfo"/>.</returns>
        public static ColorblindInfo Deserialize(string path) => DeserializeObject<ColorblindInfo>(ReadAllText(path.NullCheck("A \"null\" path cannot be searched.")));
    }
}
