using System;
using System.IO;
using KeepCoding.Internal;
using Newtonsoft.Json.Converters;
using UnityEngine;
using static System.IO.Path;
using static KeepCoding.PathManager;
using static Newtonsoft.Json.Formatting;
using static Newtonsoft.Json.JsonConvert;
using static UnityEngine.Application;

namespace KeepCoding
{
    /// <summary>
    /// Meant for information that needs to be deserialized within the mod settings folder by samfundev.
    /// </summary>
    /// <remarks>
    /// <see href="https://github.com/Qkrisi/ktanemodkit/blob/master/Assets/Scripts/ModConfig.cs"/>
    /// </remarks>
    /// <typeparam name="TDeserialize">The type to deserialize the file.</typeparam>
    public class ModConfig<TDeserialize> : ILog where TDeserialize : new()
    {
        private readonly string _settingsPath;

        private static readonly object s_settingsFileLock = new object();

        private static readonly Logger s_logger = new Logger(typeof(ModConfig<>));

        /// <summary>
        /// Creates a new <see cref="ModConfig{T}"/> with the target file name and an optional event of when the file is read.
        /// </summary>
        /// <param name="fileName">The file name to get.</param>
        public ModConfig(string fileName)
        {
            string settingsFolder = Combine(persistentDataPath, "Modsettings");

            if (isEditor && !Directory.Exists(settingsFolder))
                Directory.CreateDirectory(settingsFolder);

            if (!fileName.Contains("."))
                fileName += ".json";

            _settingsPath = Combine(settingsFolder, fileName);
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
        public static string SerializeSettings(TDeserialize settings) => SerializeObject(settings, Indented, new StringEnumConverter());

        /// <summary>
        /// Reads the settings from the settings file.
        /// If the settings couldn't be read, the default settings will be returned.
        /// </summary>
        public TDeserialize Read() => SuppressIO(() =>
        {
            HasReadSucceeded = false;

            lock (s_settingsFileLock)
            {
                if (!File.Exists(_settingsPath))
                    File.WriteAllText(_settingsPath, SerializeSettings(new TDeserialize()));

                TDeserialize deserialized = DeserializeObject<TDeserialize>(File.ReadAllText(_settingsPath));

                if (deserialized is null)
                    deserialized = new TDeserialize();

                HasReadSucceeded = true;

                return deserialized;
            }
        }, new TDeserialize());

        /// <summary>
        /// Writes the settings to the settings file.
        /// To protect the user settings, this does nothing if the last read wasn't successful.
        /// </summary>
        public void Write(TDeserialize value)
        {
            if (!HasReadSucceeded)
                return;

            SuppressIO(() =>
            {
                lock (s_settingsFileLock)
                    File.WriteAllText(_settingsPath, SerializeSettings(value));
            });
        }

        /// <summary>
        /// Deserializes, then reserializes the file according to <see cref="SerializeSettings(TDeserialize)"/>.
        /// </summary>
        /// <returns>A string representation of the value from <see cref="Read"/>.</returns>
        public override string ToString() => SerializeSettings(Read());
    }
}
