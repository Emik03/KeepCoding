using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security;

namespace KeepCoding.v13
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
        public string Id { get; private set; }

        /// <value>
        /// Contains the title of the mod.
        /// </value>
        [JsonProperty("title")]
        public string Title { get; private set; }

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
        /// Contains the current version of the mod.
        /// </value>
        [JsonProperty("version")]
        public string Version { get; private set; }

        /// <summary>
        /// Contains the current unity version of the mod.
        /// </summary>
        [JsonProperty("unityVersion")]
        public string UnityVersion { get; private set; }

        /// <value>
        /// Returns the current values of this <see cref="ModInfo"/> as a dictionary, where the key is the variable name and the value is the variable value.
        /// </value>
        public Dictionary<string, string> Values => new Dictionary<string, string>() 
        { 
            { nameof(Id), Id },
            { nameof(Title), Title }, 
            { nameof(Author), Author }, 
            { nameof(Description), Description }, 
            { nameof(Version), Version }, 
            { nameof(UnityVersion), UnityVersion } 
        };

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
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="SecurityException"></exception>
        /// <param name="path">The path of the file to deserialize.</param>
        /// <returns><paramref name="path"/> deserialized as <see cref="ModInfo"/>.</returns>
        public static ModInfo Deserialize(string path) => JsonConvert.DeserializeObject<ModInfo>(File.ReadAllText(path.NullCheck("A \"null\" path cannot be searched.")));
    }
}
