using System;
using System.Collections;
using System.Threading;
using UnityEngine;

namespace KeepCoding.Internal
{
    /// <summary>
    /// Abstract class for the <see cref="Work"/> datatype, since the different overloads are similar to each other.
    /// </summary>
    public abstract class WorkBase
    {
        private readonly int _maximumThreadsActive;

        private protected WorkBase() : this(true, 1) { }

        private protected WorkBase(in bool allowSimultaneousActive, in int maximumThreadsActive)
        {
            AllowSimultaneousActive = allowSimultaneousActive;
            _maximumThreadsActive = maximumThreadsActive;

            Thread ??= new Thread(() => { });
        }

        /// <summary>
        /// Determines whether any thread in this class is running.
        /// </summary>
        public bool IsRunning { get; private protected set; }

        /// <summary>
        /// Determines whether it should skip on starting a thread if it doesn't allow multiple.
        /// </summary>
        public bool AllowSimultaneousActive { get; }

        /// <summary>
        /// Counts the number of threads currently active within this class, and all of its overloads.
        /// </summary>
        public static int ThreadsActive { get; private protected set; }

        /// <summary>
        /// The thread of the class.
        /// </summary>
        public Thread Thread { get; private protected set; }

        /// <summary>
        /// Interrupts the thread.
        /// </summary>
        public void Stop()
        {
            if (!IsRunning)
                return;

            Thread.Interrupt();

            ThreadsActive--;

            IsRunning = false;
        }

        /// <summary>
        /// Waits until it is allowed to run a thread.
        /// </summary>
        /// <returns><see cref="WaitWhile"/> until <see cref="ThreadsActive"/> is strictly less than <see cref="_maximumThreadsActive"/>.</returns>
        private protected IEnumerator WaitForOtherThreads() => new WaitWhile(() => _maximumThreadsActive <= ThreadsActive);

        /// <summary>
        /// Waits until its own thread is no longer running..
        /// </summary>
        /// <returns><see cref="WaitWhile"/> until <see cref="IsRunning"/> is no longer true.</returns>
        private protected IEnumerator WaitForOwnThread() => new WaitWhile(() => IsRunning);
    }
}
