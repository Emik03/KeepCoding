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
    /// Contains information about the colorblind mod's info, this class can be used to deserialize "ColorblindMode.json".
    /// </summary>
    public sealed class ColorblindInfo
    {
        /// <summary>
        /// Creates a <see cref="ColorblindInfo"/> while read/writing the file.
        /// </summary>
        /// <param name="moduleId">The module's id to grab information from.</param>
        public ColorblindInfo(string moduleId = null)
        {
            if (isEditor)
                return;

            if (!Exists(File))
            {
                Write(moduleId);
                return;
            }

            try
            {
                ColorblindInfo info = Deserialize(File);

                IsEnabled = info.IsEnabled;
                Modules = info.Modules;
            }
            catch (Exception e) when (e is ArgumentException || e is ArgumentNullException || e is DirectoryNotFoundException || e is FileNotFoundException || e is IOException || e is NotSupportedException || e is NullIteratorException || e is NullReferenceException || e is PathTooLongException || e is SecurityException || e is UnauthorizedAccessException)
            {
                Error(moduleId, e);
            }

            if (!Modules.TryGetValue(moduleId, out bool? isEnabled))
                Modules[moduleId] = null;

            Write(moduleId);

            IsModuleEnabled = isEnabled ?? IsEnabled;
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
        /// Determines whether colorblind mode for the module is on.
        /// </summary>
        public bool IsModuleEnabled { get; set; }

        /// <summary>
        /// The directory of the mod settings file.
        /// </summary>
        public static string File { get; } = CombineMultiple(persistentDataPath, "Modsettings", "ColorblindMode.json");

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

        private static void Error(string moduleId, Exception e) => new Logger("Colorblind Mode", false).Log(@$"Error in ""{moduleId ?? Helper.Null}"": {e.Message} ({e.GetType().FullName}){e.StackTrace}");

        private void Write(string moduleId)
        {
            try
            {
                WriteAllText(File, SerializeObject(this, Indented));
            }
            catch (Exception e) when (e is ArgumentException || e is ArgumentNullException || e is DirectoryNotFoundException || e is IOException || e is NotSupportedException || e is PathTooLongException || e is SecurityException || e is UnauthorizedAccessException)
            {
                Error(moduleId, e);
            }
        }
    }
}
