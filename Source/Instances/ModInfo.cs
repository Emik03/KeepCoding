using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using KeepCoding.Internal;
using Newtonsoft.Json;
using static System.IO.File;
using static KeepCoding.PathManager;
using static Newtonsoft.Json.JsonConvert;

namespace KeepCoding
{
    /// <summary>
    /// Contains information about the mod's info, this class can be used to deserialize every mod's "modInfo.json".
    /// </summary>
    public sealed class ModInfo
    {
        /// <summary>
        /// Contains the author of the mod.
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; private set; }

        /// <summary>
        /// Contains the description of the mod.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// Contains the ID of the mod, not to be mistaken with <see cref="ModuleScript.Id"/>.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Contains the title of the mod.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; private set; }

        /// <summary>
        /// Contains the current unity version of the mod.
        /// </summary>
        [JsonProperty("unityVersion")]
        public string UnityVersion { get; private set; }

        /// <summary>
        /// Contains the current version of the mod.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; private set; }

        /// <summary>
        /// Returns the current values of this <see cref="ModInfo"/> as a dictionary, where the key is the variable name and the value is the variable value.
        /// </summary>
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
        /// <returns><see cref="Values"/> unwrapped with <see cref="Helper.Stringify{T}(T, StringifyFormat)"/>.</returns>
        public override string ToString() => Values.Stringify();

        /// <summary>
        /// Deserializes a modInfo.json file. An <see cref="IOException"/> will make it return a new <see cref="ColorblindInfo"/> instance with no arguments.
        /// </summary>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="path">The path of the file to deserialize.</param>
        /// <param name="settings">The settings for the serialization.</param>
        /// <returns><paramref name="path"/> deserialized as <see cref="ModInfo"/>.</returns>
        public static ModInfo Deserialize(string path, JsonSerializerSettings settings = null) => SuppressIO(() => DeserializeObject<ModInfo>(ReadAllText(path.NullCheck("A \"null\" path cannot be searched.")), settings), new ModInfo());
    }
}
