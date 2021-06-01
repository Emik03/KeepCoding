using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Reflection;
using System;
using UnityEngine;

namespace KeepCoding
{
    /// <summary>
    /// A class to allow logging with a specific format. Written by Emik.
    /// </summary>
    public sealed class Logger : IDump, ILog
    {
        /// <summary>
        /// The string constructor. The string determines the name.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <param name="name">The name of the value.</param>
        /// <param name="showId">Determines whether to show the unique identifier when logging.</param>
        public Logger(string name, bool showId = false)
        {
            Name = name.NullCheck("The name cannot be null!");

            if (Name == SelfName)
                throw new FormatException($"The name {SelfName} is reserved for the library.");

            Id = ids.SetOrReplace(Name, i => ++i);

            _showId = showId;
        }

        /// <summary>
        /// The type constructor. The type's name determines the name.
        /// </summary>
        /// <param name="type">The name of the value, using <see cref="MemberInfo.Name"/>.</param>
        /// <param name="showId">Determines whether to show the unique identifier when logging.</param>
        public Logger(Type type, bool showId = false) : this(type?.Name, showId) { }

        /// <value>
        /// The unique identifier of the current name.
        /// </value>
        public int Id { get; private set; }

        /// <value>
        /// The name of the logger.
        /// </value>
        public string Name { get; private set; }

        internal static readonly Dictionary<string, int> ids = new Dictionary<string, int>();

        private readonly bool _showId;

        private const string Format = "[{0}] {1}";

        private static readonly string SelfName = PathManager.AssemblyName.Name;

        /// <summary>
        /// Dumps all information that it can find of the type using reflection. This should only be used to debug.
        /// </summary>
        /// <param name="obj">The object to reflect on.</param>
        /// <param name="getVariables">Whether it should search recursively for the elements within the elements.</param>
        public static void Dump(object obj, bool getVariables = false)
        {
            int index = 0;

            string Format<T>(string name, T value) => Helper.VariableTemplate.Form(index++, name, value?.GetType().ToString() ?? Helper.Null, string.Join(", ", value.Unwrap(getVariables).Select(o => o.ToString()).ToArray()));

            var values = new List<object>();

            obj.GetType().GetFields(Helper.Flags).ForEach(f => values.Add(Format(f.Name, f.GetValue(obj))));
            obj.GetType().GetProperties(Helper.Flags).ForEach(p => values.Add(Format(p.Name, p.GetValue(obj, null))));

            Debug.LogWarning(Helper.DumpTemplate.Form(string.Join("", values.Select(o => string.Join("", o.Unwrap(getVariables).Select(o => o.ToString()).ToArray())).ToArray())));
        }

        /// <summary>
        /// Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.
        /// </summary>
        /// <param name="getVariables">Whether it should search recursively for the elements within the elements.</param>
        /// <param name="logs">All of the variables to throughly log.</param>
        public void Dump(bool getVariables, params Expression<Func<object>>[] logs) => Debug.LogWarning(Helper.DumpTemplate.Form(Name, Id, string.Join("", logs.Select((l, n) => Helper.VariableTemplate.Form(n, Helper.NameOfVariable(l), l.Compile()()?.GetType().ToString() ?? Helper.Null, string.Join(", ", l.Compile()().Unwrap(getVariables).Select(o => o.ToString()).ToArray()))).ToArray())));

        /// <summary>
        /// Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.
        /// </summary>
        /// <param name="logs">All of the variables to throughly log.</param>
        public void Dump(params Expression<Func<object>>[] logs) => Dump(false, logs);

        /// <summary>
        /// Determines if both objects are equal.
        /// </summary>
        /// <param name="obj">The comparison.</param>
        /// <returns>Whether both objects are equal.</returns>
        public override bool Equals(object obj) => obj is Logger loggable &&
                   Id == loggable.Id &&
                   Name == loggable.Name;

        /// <summary>
        /// Gets the hash code of the object.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            int hashCode = -1919740922;
            hashCode = (hashCode * -1521134295) + Id.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        /// <summary>
        /// Logs message, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="logType">The type of logging. Different logging types have different icons within the editor.</param>
        public void Log<T>(T message, LogType logType = LogType.Log) => logType.Method()(Format.Form($"{Name}{(_showId ? $" #{Id}" : "")}", message.UnwrapToString()));

        /// <summary>
        /// Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="args">All of the arguments to embed into <paramref name="message"/>.</param>
        public void Log<T>(T message, params object[] args) => Log(message.UnwrapToString().Form(args.ConvertAll(a => a.UnwrapToString())));

        /// <summary>
        /// Logs multiple entries to the console.
        /// </summary>
        /// <param name="logs">The array of logs to individual output into the console.</param>
        public void LogMultiple(params string[] logs) => logs?.ForEach(s => Log(s));

        internal static void Self(string message, LogType logType = LogType.Log) => logType.Method()(Format.Form(SelfName, message));
    }
}
