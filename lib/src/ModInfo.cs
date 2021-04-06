using Newtonsoft.Json;
using System;
using System.IO;
using System.Security;

namespace KeepCodingAndNobodyExplodes
{
    /// <summary>
    /// Contains information about the mod's info, this class can be used to deserialize every mod's "modInfo.json".
    /// </summary>
    public class ModInfo
    {
        /// <value>
        /// Contains the ID of the mod, not to be mistaken with <see cref="ModuleScript.ModuleId"/>.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <value>
        /// Contains the title of the mod.
        /// </value>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <value>
        /// Contains the author of the mod.
        /// </value>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <value>
        /// Contains the description of the mod.
        /// </value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <value>
        /// Contains the current version of the mod.
        /// </value>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Contains the current unity version of the mod.
        /// </summary>
        [JsonProperty("unityVersion")]
        public string UnityVersion { get; set; }

        /// <summary>
        /// Deserializes a modInfo.json file.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="SecurityException"></exception>
        /// <param name="path">The path of the file to deserialize.</param>
        /// <returns><paramref name="path"/> deserialized as <see cref="ModInfo"/>.</returns>
        public static ModInfo Deserialize(string path) => JsonConvert.DeserializeObject<ModInfo>(File.ReadAllText(path));
    }
}
