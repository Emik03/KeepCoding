using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using KeepCoding.Internal;
using UnityEngine;
using static System.Array;
using static System.String;
using static KeepCoding.Helper;

namespace KeepCoding
{
    /// <summary>
    /// A class to allow logging with a specific format.
    /// </summary>
    public sealed class Logger :
#if !SIMPLIFIED
        IDump,
#endif
        ILog
    {
        internal static readonly Dictionary<string, int> s_ids = new Dictionary<string, int>();

        private readonly bool _showId, _showInLfa;

        private readonly string _format;

        private static readonly string s_selfName = PathManager.AssemblyName.Name;

        /// <summary>
        /// The string constructor. The string determines the name.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <param name="name">The name of the value.</param>
        /// <param name="showId">Determines whether to show the unique identifier when logging.</param>
        /// <param name="showInLfa">Determines whether to format such that the Logfile Analyzer would use.</param>
        public Logger(string name, bool showId = false, bool showInLfa = true)
        {
            Name = name.NullCheck("The name cannot be null.");

            if (Name == s_selfName)
                throw new FormatException($"The name {s_selfName} is reserved for the library.");

            Id = s_ids.SetOrReplace(Name, i => ++i);

            _showId = showId;
            _showInLfa = showInLfa;

            _format = _showInLfa ? "[{0}] {1}" : "<{0}> {1}";
        }

        /// <summary>
        /// The type constructor. The type's name determines the name.
        /// </summary>
        /// <param name="type">The name of the value, using <see cref="MemberInfo.Name"/>.</param>
        /// <param name="showId">Determines whether to show the unique identifier when logging.</param>
        /// <param name="showInLfa">Determines whether to format such that the Logfile Analyzer would use.</param>
        public Logger(Type type, bool showId = false, bool showInLfa = true) : this(type?.Name, showId, showInLfa) { }

        /// <summary>
        /// The unique identifier of the current name.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// The name of the logger.
        /// </summary>
        public string Name { get; }

#if !SIMPLIFIED
        private const string VariableTemplate = "\n\n[{0}] {1}\n({2})\n{3}";

        /// <summary>
        /// Dumps all information that it can find of the type using reflection. This should only be used to debug.
        /// </summary>
        /// <typeparam name="T">The type of component to reflect on.</typeparam>
        /// <param name="obj">The object to reflect on.</param>
        /// <param name="getVariables">Whether it should search recursively for the elements within the elements.</param>
        public void Dump<T>(T obj, bool getVariables = false)
        {
            static string Format<TValue>(in string name, ref int index, in TValue value) => VariableTemplate.Form(index++, name, typeof(TValue).ToString() ?? Null, value.Stringify());

            int index = 0;
            var values = new List<string>();

            typeof(T).GetFields(Flags).ForEach(f => values.Add(Format(f.Name, ref index, f.GetValue(obj))));
            typeof(T).GetProperties(Flags).ForEach(p => values.Add(Format(p.Name, ref index, p.GetValue(obj, null))));

            Log(Join("", values.ToArray()), LogType.Warning);
        }

        /// <summary>
        /// Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.
        /// </summary>
        /// <param name="getVariables">Whether it should search recursively for the elements within the elements.</param>
        /// <param name="logs">All of the variables to throughly log.</param>
        public void Dump(bool getVariables, params Expression<Func<object>>[] logs) => Log(Join("", logs.Select((l, n) => VariableTemplate.Form(n, l.NameOf(), l.Compile()()?.GetType().ToString() ?? Null, l.Compile()().Stringify())).ToArray()), LogType.Warning);

        /// <summary>
        /// Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.
        /// </summary>
        /// <param name="logs">All of the variables to throughly log.</param>
        public void Dump(params Expression<Func<object>>[] logs) => Dump(false, logs);
#endif

        /// <summary>
        /// Logs message, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="logType">The type of logging. Different logging types have different icons within the editor.</param>
        [CLSCompliant(false)]
        public void Log<T>(T message, LogType logType = LogType.Log) => logType.Method()(Format(_format, $"{Name}{(_showId ? $" #{Id}" : "")}", message.Combine()));

        /// <summary>
        /// Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="args">All of the arguments to embed into <paramref name="message"/>.</param>
        public void Log<T>(T message, params object[] args) => Log(Format(message.Combine(), ConvertAll(args, a => a.Combine())));

#if !SIMPLIFIED
        /// <summary>
        /// Logs multiple entries to the console.
        /// </summary>
        /// <param name="logs">The array of logs to individual output into the console.</param>
        public void LogMultiple(params string[] logs) => logs?.ForEach(s => Log(s));
#endif

        /// <summary>
        /// Determines if both objects are equal.
        /// </summary>
        /// <param name="obj">The comparison.</param>
        /// <returns>Whether both objects are equal.</returns>
        public override bool Equals(object obj) => Equals(obj as Logger);

        /// <summary>
        /// Determines if both <see cref="Logger"/> instances are equal.
        /// </summary>
        /// <param name="loggable">The comparison.</param>
        /// <returns>Whether both <see cref="Logger"/>s are equal.</returns>
        public bool Equals(Logger loggable) => loggable is { } &&
            Id == loggable.Id &&
            Name == loggable.Name;

        /// <summary>
        /// Gets the hash code of the object.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            int hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        /// <summary>
        /// A string representation of this <see cref="Logger"/> instance.
        /// </summary>
        /// <returns>The format of the logging.</returns>
        public override string ToString() => $"{(_showInLfa ? '[' : '<')}{Name}{(_showId ? $" #{Id}" : "")}{(_showInLfa ? ']' : '>')}]";

        internal static void Self(in string message, in LogType logType = LogType.Log) => logType.Method()($"[{s_selfName}] {message}");
    }
}
