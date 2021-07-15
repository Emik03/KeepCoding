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
    /// Contains information about the mod's info, this class can be used to deserialize every mod's "modInfo.json".
    /// </summary>
    public sealed class ModInfo
    {
        /// <value>
        /// Contains the author of the mod.
        /// </value>
        [JsonProperty("author")]
        public string Author { get; private set; }

        /// <value>
        /// Contains the description of the mod.
        /// </value>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <value>
        /// Contains the ID of the mod, not to be mistaken with <see cref="ModuleScript.Id"/>.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <value>
        /// Contains the title of the mod.
        /// </value>
        [JsonProperty("title")]
        public string Title { get; private set; }

        /// <summary>
        /// Contains the current unity version of the mod.
        /// </summary>
        [JsonProperty("unityVersion")]
        public string UnityVersion { get; private set; }

        /// <value>
        /// Contains the current version of the mod.
        /// </value>
        [JsonProperty("version")]
        public string Version { get; private set; }

        /// <value>
        /// Returns the current values of this <see cref="ModInfo"/> as a dictionary, where the key is the variable name and the value is the variable value.
        /// </value>
        public Dictionary<string, string> Values => new Dictionary<string, string>()
        {
            { nameof(Author), Author },
            { nameof(Description), Description },
            { nameof(Id), Id },
            { nameof(Title), Title },
            { nameof(UnityVersion), UnityVersion },
            { nameof(Version), Version }
        };

        /// <summary>
        /// Determines if both objects are equal.
        /// </summary>
        /// <param name="obj">The comparison.</param>
        /// <returns>True if both of them are <see cref="ModInfo"/> and contain the same <see cref="Values"/>.</returns>
        public override bool Equals(object obj) => obj is ModInfo modInfo && modInfo.Values == Values;

        /// <summary>
        /// Gets the hash code.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode() => 1291433875 + EqualityComparer<Dictionary<string, string>>.Default.GetHashCode(Values);

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns><see cref="Values"/> unwrapped with <see cref="Helper.UnwrapToString{T}(T, bool, string)"/>.</returns>
        public override string ToString() => Values.UnwrapToString();

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
        /// <param name="settings">The settings for the serialization.</param>
        /// <returns><paramref name="path"/> deserialized as <see cref="ModInfo"/>.</returns>
        public static ModInfo Deserialize(string path, JsonSerializerSettings settings = null) => DeserializeObject<ModInfo>(ReadAllText(path.NullCheck("A \"null\" path cannot be searched.")), settings);
    }
}
