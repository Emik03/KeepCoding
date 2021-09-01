using System;
using System.IO;
using KeepCoding.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using UnityEngine;
using static System.IO.Path;
using static KeepCoding.PathManager;
using static Newtonsoft.Json.Formatting;
using static Newtonsoft.Json.JsonConvert;
using static Newtonsoft.Json.Linq.JObject;
using static UnityEngine.Application;

namespace KeepCoding
{
    /// <summary>
    /// Meant for information that needs to be deserialized within the mod settings folder, by samfundev.
    /// </summary>
    /// <remarks>
    /// <see href="https://github.com/Qkrisi/ktanemodkit/blob/master/Assets/Scripts/ModConfig.cs"/>
    /// </remarks>
    /// <typeparam name="TSerialize">The type to serialize and deserialize the file.</typeparam>
    public class ModConfig<TSerialize> : ILog where TSerialize : new()
    {
        private readonly string _settingsPath;

        private static readonly string s_settingsFolder;

        private static readonly object s_settingsFileLock = new object();

        private static readonly Logger s_logger = new Logger(typeof(ModConfig<>));

        /// <summary>
        /// Creates a new <see cref="ModConfig{T}"/> with the target file name and an optional event of when the file is read.
        /// </summary>
        /// <param name="fileName">The file name to get.</param>
        /// <param name="mergeSettings">The way that the default value and the file merge.</param>
        public ModConfig(string fileName, JsonMergeSettings mergeSettings = null)
        {
            if (!fileName.Contains("."))
                fileName += ".json";

            _settingsPath = Combine(s_settingsFolder, fileName);

            Merge(default, mergeSettings ?? new JsonMergeSettings());
        }

        static ModConfig()
        {
            s_settingsFolder = Combine(persistentDataPath, "Modsettings");

            if (!isEditor && !Directory.Exists(s_settingsFolder))
                Directory.CreateDirectory(s_settingsFolder);
        }

        /// <summary>
        /// Whether or not there has been a successful read of the settings file.
        /// </summary>
        public bool HasReadSucceeded { get; private set; }

        /// <summary>
        /// Logs message, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="logType">The type of logging. Different logging types have different icons within the editor.</param>
        [CLSCompliant(false)]
        public void Log<T>(T message, LogType logType = LogType.Log) => s_logger.Log(message, logType);

        /// <summary>
        /// Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="args">All of the arguments to embed into <paramref name="message"/>.</param>
        public void Log<T>(T message, params object[] args) => s_logger.Log(message, args);

        /// <summary>
        /// Logs multiple entries to the console.
        /// </summary>
        /// <param name="logs">The array of logs to individual output into the console.</param>
        public void LogMultiple(params string[] logs) => s_logger.LogMultiple(logs);

        /// <summary>
        /// Serializes settings the same way it's written to the file. Supports settings that use enums.
        /// </summary>
        public static string SerializeSettings(TSerialize settings) => SerializeObject(settings, Indented, new StringEnumConverter());

        /// <summary>
        /// Reads, merges, and writes the settings to the settings file. To protect the user settings, this does nothing if the read isn't successful.
        /// </summary>
        /// <param name="value">The value to merge the file with.</param>
        /// <param name="mergeSettings">The way that <paramref name="value"/> and the file merge.</param>
        public void Merge(TSerialize value, JsonMergeSettings mergeSettings)
        {
            JObject original = Parse(ToString());

            original.Merge(Parse(SerializeSettings(value)));

            Write(original.ToString());
        }

        /// <summary>
        /// Reads the settings from the settings file. If the settings couldn't be read, the default settings will be returned.
        /// </summary>
        /// <param name="settings">The settings for serializing the json file.</param>
        public TSerialize Read(JsonSerializerSettings settings = null) => SuppressIO(() =>
        {
            HasReadSucceeded = false;

            lock (s_settingsFileLock)
            {
                if (!File.Exists(_settingsPath))
                    File.WriteAllText(_settingsPath, SerializeSettings(new TSerialize()));

                TSerialize deserialized = DeserializeObject<TSerialize>(File.ReadAllText(_settingsPath), settings);

                if (deserialized is null)
                    deserialized = new TSerialize();

                HasReadSucceeded = true;

                return deserialized;
            }
        }, new TSerialize());

        /// <summary>
        /// Writes the settings to the settings file. To protect the user settings, this does nothing if the last read wasn't successful.
        /// </summary>
        /// <param name="value">The value to overwrite the settings file with.</param>
        public void Write(TSerialize value) => Write(SerializeSettings(value));

        /// <summary>
        /// Writes the string to the settings file. To protect the user settings, this does nothing if the last read wasn't successful.
        /// </summary>
        /// <param name="value"></param>
        public void Write(string value)
        {
            if (!HasReadSucceeded)
                return;

            SuppressIO(() =>
            {
                lock (s_settingsFileLock)
                    File.WriteAllText(_settingsPath, value);
            });
        }

        /// <summary>
        /// Deserializes, then reserializes the file according to <see cref="SerializeSettings(TSerialize)"/>.
        /// </summary>
        /// <returns>A string representation of the value from <see cref="Read"/>.</returns>
        public override string ToString() => SerializeSettings(Read());
    }
}
