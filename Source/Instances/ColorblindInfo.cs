using KeepCoding.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using static KeepCoding.PathManager;
using static Newtonsoft.Json.Formatting;
using static Newtonsoft.Json.JsonConvert;
using static System.IO.File;
using static UnityEngine.Application;

namespace KeepCoding
{
    /// <summary>
    /// Contains information about the colorblind mod's info, this class can be used to deserialize every mod's "modInfo.json".
    /// </summary>
    public sealed class ColorblindInfo
    {
        /// <summary>
        /// Default constructor. Deserializes with the default directory.
        /// </summary>
        /// <param name="moduleId">The module id, which is only used for logging in case of failure.</param>
        public ColorblindInfo(string moduleId = null)
        {
            if (isEditor)
                return;

            if (!Exists(Directory))
            {
                Write(moduleId);
                return;
            }

            try
            {
                Deserialize(Directory);
            }
            catch (Exception e) when (e is ArgumentException || e is ArgumentNullException || e is DirectoryNotFoundException || e is FileNotFoundException || e is IOException || e is NotSupportedException || e is NullIteratorException || e is NullReferenceException || e is PathTooLongException || e is SecurityException || e is UnauthorizedAccessException)
            {
                Error(moduleId, e);
            }
        }

        /// <summary>
        /// Creates a <see cref="ColorblindInfo"/> while modifying <see cref="ModuleScript.IsColorblind"/>.
        /// </summary>
        /// <param name="module">The module to modify <see cref="ModuleScript.IsColorblind"/> with.</param>
        public ColorblindInfo(ModuleScript module) : this()
        {
            if (isEditor)
                return;

            if (!Modules.TryGetValue(module.Module.Id, out bool? isEnabled))
                Modules[module.Module.Id] = null;

            Write(module.Module.Id);

            IsEnabled = isEnabled ?? IsEnabled;
        }

        [JsonConstructor]
#pragma warning disable IDE0051 // Remove unused private members
        private ColorblindInfo(bool isEnabled, Dictionary<string, bool?> modules)
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
        /// The directory of the mod settings file.
        /// </summary>
        public static string Directory { get; } = CombineMultiple(persistentDataPath, "Modsettings", "ColorblindMode.json");

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
        /// Deserializes a ColorblindMode.json file.
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
        /// <returns><paramref name="path"/> deserialized as <see cref="ColorblindInfo"/>.</returns>
        public static ColorblindInfo Deserialize(string path, JsonSerializerSettings settings = null) => DeserializeObject<ColorblindInfo>(ReadAllText(path.NullCheck("A \"null\" path cannot be searched.")), settings);

        private static void Error(in string moduleId, in Exception e)
        {
            if (!isEditor)
                new Logger("Colorblind Mode", false).Log(@$"Error in ""{moduleId ?? Helper.Null}"": {e.Message} ({e.GetType().FullName}){e.StackTrace}");
        }

        private void Write(in string moduleId)
        {
            try
            {
                WriteAllText(Directory, SerializeObject(this, Indented));
            }
            catch (Exception e) when (e is ArgumentException || e is ArgumentNullException || e is DirectoryNotFoundException || e is IOException || e is NotSupportedException || e is PathTooLongException || e is SecurityException || e is UnauthorizedAccessException)
            {
                Error(moduleId, e);
            }
        }
    }
}
