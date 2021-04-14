using System;
using System.Collections;
using System.Threading;
using UnityEngine;

namespace KeepCoding.v13
{
    /// <summary>
    /// Advanced multi-threading handler. Written by Emik.
    /// </summary>
    public sealed class Work : WorkBase
    {
        /// <summary>
        /// Stores the method so that it can later be called when a new thread starts.
        /// </summary>
        /// <param name="work">The method to call when thread starts.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        public Work(Action work, bool allowSimultaneousActive, uint maximumThreadsActive)
            : base(allowSimultaneousActive, maximumThreadsActive)
            => Thread = new Thread(() =>
            {
                work.NullCheck($"The variable {nameof(work)} cannot be null.")();
                IsRunning = false;
            });

        /// <summary>
        /// Starts a new thread, and waits until it is finished before halting.
        /// </summary>
        /// <returns><see cref="WaitWhile"/> in various places until the thread has been finished.</returns>
        public IEnumerator Start()
        {
            if (!AllowSimultaneousActive && IsRunning)
                yield break;

            yield return WaitForOtherThreads();

            IsRunning = true;

            ThreadsActive++;

            Thread.Start();

            yield return WaitForOwnThread();

            ThreadsActive--;
        }
    }

    /// <summary>
    /// Advanced multi-threading handler. Written by Emik.
    /// </summary>
    public sealed class Work<TResult> : WorkBase
    {
        /// <summary>
        /// Stores the method so that it can later be called when a new thread starts.
        /// </summary>
        /// <param name="work">The method to call when thread starts.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        public Work(Func<TResult> work, bool allowSimultaneousActive, uint maximumThreadsActive)
            : base(allowSimultaneousActive, maximumThreadsActive)
            => Thread = new Thread(() =>
            {
                Result = work.NullCheck($"The variable {nameof(work)} cannot be null.")();
                IsRunning = false;
            });

        /// <summary>
        /// Starts a new thread, and waits until it is finished before halting.
        /// </summary>
        /// <returns><see cref="WaitWhile"/> in various places until the thread has been finished.</returns>
        public IEnumerator Start()
        {
            if (!AllowSimultaneousActive && IsRunning)
                yield break;

            yield return WaitForOtherThreads();

            IsRunning = true;

            ThreadsActive++;

            Thread.Start();

            yield return WaitForOwnThread();

            ThreadsActive--;
        }

        /// <value>
        /// The returned value of the thread.
        /// </value>
        public TResult Result { get; private set; }
    }

    /// <summary>
    /// Advanced multi-threading handler. Written by Emik.
    /// </summary>
    public sealed class Work<T1, TResult> : WorkBase
    {
        /// <summary>
        /// Stores the method so that it can later be called when a new thread starts.
        /// </summary>
        /// <param name="work">The method to call when thread starts.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        public Work(Func<T1, TResult> work, bool allowSimultaneousActive, uint maximumThreadsActive)
            : base(allowSimultaneousActive, maximumThreadsActive) => _work = work;

        /// <summary>
        /// Starts a new thread, and waits until it is finished before halting.
        /// </summary>
        /// <returns><see cref="WaitWhile"/> in various places until the thread has been finished.</returns>
        public IEnumerator Start(T1 arg)
        {
            if (!AllowSimultaneousActive && IsRunning)
                yield break;

            yield return WaitForOtherThreads();

            IsRunning = true;

            ThreadsActive++;

            Thread = new Thread(() =>
            {
                Result = _work.NullCheck($"The variable {nameof(_work)} cannot be null.")(arg);
                IsRunning = false;
            });

            Thread.Start();

            yield return WaitForOwnThread();

            ThreadsActive--;
        }

        /// <value>
        /// The returned value of the thread.
        /// </value>
        public TResult Result { get; private set; }

        private readonly Func<T1, TResult> _work;
    }

    /// <summary>
    /// Advanced multi-threading handler. Written by Emik.
    /// </summary>
    public sealed class Work<T1, T2, TResult> : WorkBase
    {
        /// <summary>
        /// Stores the method so that it can later be called when a new thread starts.
        /// </summary>
        /// <param name="work">The method to call when thread starts.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        public Work(Func<T1, T2, TResult> work, bool allowSimultaneousActive, uint maximumThreadsActive)
            : base(allowSimultaneousActive, maximumThreadsActive) => _work = work;

        /// <summary>
        /// Starts a new thread, and waits until it is finished before halting.
        /// </summary>
        /// <returns><see cref="WaitWhile"/> in various places until the thread has been finished.</returns>
        public IEnumerator Start(T1 arg1, T2 arg2)
        {
            if (!AllowSimultaneousActive && IsRunning)
                yield break;

            yield return WaitForOtherThreads();

            IsRunning = true;

            ThreadsActive++;

            Thread = new Thread(() =>
            {
                Result = _work.NullCheck($"The variable {nameof(_work)} cannot be null.")(arg1, arg2);
                IsRunning = false;
            });

            Thread.Start();

            yield return WaitForOwnThread();

            ThreadsActive--;
        }

        /// <value>
        /// The returned value of the thread.
        /// </value>
        public TResult Result { get; private set; }

        private readonly Func<T1, T2, TResult> _work;
    }

    /// <summary>
    /// Advanced multi-threading handler. Written by Emik.
    /// </summary>
    public sealed class Work<T1, T2, T3, TResult> : WorkBase
    {
        /// <summary>
        /// Stores the method so that it can later be called when a new thread starts.
        /// </summary>
        /// <param name="work">The method to call when thread starts.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        public Work(Func<T1, T2, T3, TResult> work, bool allowSimultaneousActive, uint maximumThreadsActive)
            : base(allowSimultaneousActive, maximumThreadsActive) => _work = work;

        /// <summary>
        /// Starts a new thread, and waits until it is finished before halting.
        /// </summary>
        /// <returns><see cref="WaitWhile"/> in various places until the thread has been finished.</returns>
        public IEnumerator Start(T1 arg1, T2 arg2, T3 arg3)
        {
            if (!AllowSimultaneousActive && IsRunning)
                yield break;

            yield return WaitForOtherThreads();

            IsRunning = true;

            ThreadsActive++;

            Thread = new Thread(() =>
            {
                Result = _work.NullCheck($"The variable {nameof(_work)} cannot be null.")(arg1, arg2, arg3);
                IsRunning = false;
            });

            Thread.Start();

            yield return WaitForOwnThread();

            ThreadsActive--;
        }

        /// <value>
        /// The returned value of the thread.
        /// </value>
        public TResult Result { get; private set; }

        private readonly Func<T1, T2, T3, TResult> _work;
    }

    /// <summary>
    /// Advanced multi-threading handler. Written by Emik.
    /// </summary>
    public sealed class Work<T1, T2, T3, T4, TResult> : WorkBase
    {
        /// <summary>
        /// Stores the method so that it can later be called when a new thread starts.
        /// </summary>
        /// <param name="work">The method to call when thread starts.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        public Work(Func<T1, T2, T3, T4, TResult> work, bool allowSimultaneousActive, uint maximumThreadsActive)
            : base(allowSimultaneousActive, maximumThreadsActive) => _work = work;

        /// <summary>
        /// Starts a new thread, and waits until it is finished before halting.
        /// </summary>
        /// <returns><see cref="WaitWhile"/> in various places until the thread has been finished.</returns>
        public IEnumerator Start(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!AllowSimultaneousActive && IsRunning)
                yield break;

            yield return WaitForOtherThreads();

            IsRunning = true;

            ThreadsActive++;

            Thread = new Thread(() =>
            {
                Result = _work.NullCheck($"The variable {nameof(_work)} cannot be null.")(arg1, arg2, arg3, arg4);
                IsRunning = false;
            });

            Thread.Start();

            yield return WaitForOwnThread();

            ThreadsActive--;
        }

        /// <value>
        /// The returned value of the thread.
        /// </value>
        public TResult Result { get; private set; }

        private readonly Func<T1, T2, T3, T4, TResult> _work;
    }
}
