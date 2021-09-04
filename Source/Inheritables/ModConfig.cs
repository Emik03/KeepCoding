using System;
using System.Collections.Generic;
using System.IO;
using KeepCoding.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using UnityEngine;
using static System.IO.Path;
using static System.Text.RegularExpressions.Regex;
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

        private static readonly string s_settingsFolder = Combine(persistentDataPath, "Modsettings");

        private static readonly object s_settingsFileLock = new object();

        private readonly Logger _logger = new Logger($"ModConfig ({typeof(TSerialize).Assembly.GetName().Name}.{typeof(TSerialize).Name})");

        /// <summary>
        /// Creates a new <see cref="ModConfig{T}"/> with the target file name and an optional event of when the file is read.
        /// </summary>
        /// <exception cref="ConstructorArgumentException"></exception>
        public ModConfig() : this($"{Caller}-settings") { }

        /// <summary>
        /// Creates a new <see cref="ModConfig{T}"/> with the target file name and an optional event of when the file is read.
        /// </summary>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <param name="fileName">The file name to get.</param>
        public ModConfig(string fileName)
        {
            if (fileName is null)
                return;

            if (!fileName.Contains("."))
                fileName += File.Exists($"{Combine(s_settingsFolder, fileName)}.txt") ? ".txt" : ".json";

            _settingsPath = Combine(s_settingsFolder, fileName);

            Merge(new TSerialize());
        }

        static ModConfig()
        {
            if (!isEditor && !Directory.Exists(s_settingsFolder))
                SuppressIO(() => Directory.CreateDirectory(s_settingsFolder));
        }

        /// <summary>
        /// Whether or not there has been a successful read of the settings file.
        /// </summary>
        [JsonIgnore]
        public bool HasReadSucceeded { get; private set; }

        /// <summary>
        /// Logs message, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="logType">The type of logging. Different logging types have different icons within the editor.</param>
        [CLSCompliant(false)]
        public void Log<T>(T message, LogType logType = LogType.Log) => _logger.Log(message, logType);

        /// <summary>
        /// Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="args">All of the arguments to embed into <paramref name="message"/>.</param>
        public void Log<T>(T message, params object[] args) => _logger.Log(message, args);

        /// <summary>
        /// Logs multiple entries to the console.
        /// </summary>
        /// <param name="logs">The array of logs to individual output into the console.</param>
        public void LogMultiple(params string[] logs) => _logger.LogMultiple(logs);

        /// <summary>
        /// Reads, merges, and writes the settings to the settings file. To protect the user settings, this does nothing if the read isn't successful.
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="value">The value to merge the file with.</param>
        /// <param name="isDiscarding">Determines whether it should remove values from the original file that isn't contained within the type, or has the incorrect type.</param>
        public void Merge(TSerialize value, bool isDiscarding = false)
        {
            JObject original = Parse(ToString()),
                values = Parse(SuppressIO<string>(() => File.ReadAllText(_settingsPath), ""));

            original.Merge(values, new JsonMergeSettings());

            IDictionary<string, JToken> keyValuePairs = values;

            if (isDiscarding)
                ((IDictionary<string, JToken>)original).ForEach((string k, JToken v) =>
                {
                    if (!IsMatch(k, @"$HowToUse\d+^") && (!keyValuePairs.ContainsKey(k) || original[k].Type != values[k].Type))
                        original.Remove(k);
                });

            Write(original.ToString());
        }

        /// <summary>
        /// Writes the settings to the settings file. To protect the user settings, this does nothing if the last read wasn't successful.
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="value">The value to overwrite the settings file with.</param>
        public void Write(TSerialize value) => Write(SerializeSettings(value.NullCheck("The value cannot be null.")));

        /// <summary>
        /// Writes the string to the settings file. To protect the user settings, this does nothing if the last read wasn't successful.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="value">The contents to write.</param>
        public void Write(string value)
        {
            if (!HasReadSucceeded)
                return;

            Log($"Writing to file \"{_settingsPath}\" the following contents: {value.NullCheck("The value cannot be null.")}");

            SuppressIO(() =>
            {
                lock (s_settingsFileLock)
                    File.WriteAllText(_settingsPath, value);
            });
        }

        /// <summary>
        /// Serializes settings the same way it's written to the file. Supports settings that use enums.
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        public static string SerializeSettings(TSerialize value) => SerializeObject(value.NullCheck("The value cannot be null."), Indented, new StringEnumConverter());

        /// <summary>
        /// Deserializes, then reserializes the file according to <see cref="SerializeSettings(TSerialize)"/>.
        /// </summary>
        /// <returns>A string representation of the value from <see cref="Read"/>.</returns>
        public override string ToString() => SerializeSettings(Read());

        /// <summary>
        /// Reads the settings from the settings file. If the settings couldn't be read, the default settings will be returned.
        /// </summary>
        public TSerialize Read() => SuppressIO(() =>
        {
            HasReadSucceeded = false;

            lock (s_settingsFileLock)
            {
                if (!File.Exists(_settingsPath))
                    File.WriteAllText(_settingsPath, SerializeSettings(new TSerialize()));

                TSerialize deserialized = DeserializeObject<TSerialize>(File.ReadAllText(_settingsPath), new JsonSerializerSettings());

                if (deserialized is null)
                {
                    Log("Reading and deserializing the file ended up as null, creating default value...");
                    deserialized = new TSerialize();
                }

                HasReadSucceeded = true;

                Log($"Read was successful: {deserialized}");

                return deserialized;
            }
        }, new TSerialize());
    }
}
