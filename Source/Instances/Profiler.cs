using System;
using System.Diagnostics;
using UnityEngine;
using static System.Diagnostics.Stopwatch;
using static UnityEngine.LogType;

namespace KeepCoding
{
    /// <summary>
    /// Times your code and runs a method after <see cref="Dispose"/> runs.
    /// </summary>
    public sealed class Profiler : IDisposable
    {
        private readonly Action<string, TimeSpan> _action;

        private readonly Stopwatch _stopwatch;

        /// <summary>
        /// Creates a profiler that will run an <see cref="Action{T}"/> when <see cref="Dispose"/> runs.
        /// </summary>
        /// <param name="action">The action to run when disposed.</param>
        public Profiler(Action action) : this() => _action = (_, unused) => action?.Invoke();

        /// <summary>
        /// Creates a profiler that will run an <see cref="Action{T}"/> with a <see cref="string"/> as the resulting parameter when <see cref="Dispose"/> runs.
        /// </summary>
        /// <param name="action">The action to run when disposed.</param>
        public Profiler(Action<string> action) : this() => _action = (s, _) => action?.Invoke(s);

        /// <summary>
        /// Creates a profiler that will run an <see cref="Action{T}"/> with a <see cref="string"/> and <see cref="LogType"/> as the resulting parameter when <see cref="Dispose"/> runs.
        /// </summary>
        /// <param name="action">The action to run when disposed.</param>
        /// <param name="type">The type of logging to perform.</param>
        [CLSCompliant(false)]
        public Profiler(Action<string, LogType> action, LogType type = Log) : this() => _action = (s, _) => action?.Invoke(s, type);

        /// <summary>
        /// Creates a profiler that will run an <see cref="Action{T}"/> with a <see cref="string"/> and <see cref="TimeSpan"/> as the resulting parameter when <see cref="Dispose"/> runs.
        /// </summary>
        /// <param name="action">The action to run when disposed.</param>
        public Profiler(Action<string, TimeSpan> action) : this() => _action = action;

        /// <summary>
        /// Creates a profiler that will run an <see cref="Action{T}"/> with a <see cref="string"/> and <see cref="TimeSpan"/> as the resulting parameter when <see cref="Dispose"/> runs.
        /// </summary>
        /// <param name="action">The action to run when disposed.</param>
        public Profiler(Action<TimeSpan, string> action) : this() => _action = (s, t) => action?.Invoke(t, s);

        /// <summary>
        /// Creates a profiler that will run an <see cref="Action{T}"/> with a <see cref="TimeSpan"/> as the resulting parameter when <see cref="Dispose"/> runs.
        /// </summary>
        /// <param name="action">The action to run when disposed.</param>
        public Profiler(Action<TimeSpan> action) : this() => _action = (_, t) => action?.Invoke(t);

        /// <summary>
        /// Creates a profiler that will not run any actions.
        /// </summary>
        public Profiler() => _stopwatch = StartNew();

        /// <summary>
        /// The current amount of time that has been elapsed since the creation of this <see cref="Profiler"/>.
        /// </summary>
        public TimeSpan Elapsed => _stopwatch.Elapsed;

        /// <summary>
        /// Stops the timer and runs the action.
        /// </summary>
        public void Dispose()
        {
            TimeSpan elapsed = Stop();

            _action?.Invoke($"{new StackTrace().GetFrame(1).GetMethod().Name}: {elapsed}", elapsed);
        }

        /// <summary>
        /// Stops the timer and returns the time elapsed.
        /// </summary>
        /// <returns>A <see cref="TimeSpan"/> representing how long the <see cref="Profiler"/> ran for before this method was called.</returns>
        public TimeSpan Stop()
        {
            _stopwatch.Stop();

            return Elapsed;
        }
    }
}
