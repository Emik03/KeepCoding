using System;
using System.Collections;
using UnityEngine;

namespace KeepCoding.v151
{
    /// <summary>
    /// Advanced coroutine handler. Written by Emik.
    /// </summary>
    public sealed class Routine : RoutineBase
    {
        /// <summary>
        /// Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.
        /// </summary>
        /// <param name="enumerator">The enumerator to call when initiated.</param>
        /// <param name="monoBehaviour">The MonoBehaviour to reference when calling the method.</param>
        public Routine(Func<IEnumerator> enumerator, MonoBehaviour monoBehaviour) : base(monoBehaviour) => _enumerator = enumerator;

        /// <summary>
        /// Starts the coroutine. Unless specified by <paramref name="allowSimultaneousRuns"/>, it will not be called if this class is in the middle of running the coroutine.
        /// </summary>
        /// <param name="allowSimultaneousRuns">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        public void Start(bool allowSimultaneousRuns = true)
        {
            if (!IsRunning || allowSimultaneousRuns)
                Coroutines.Add(MonoBehaviour.StartCoroutine(Coroutine()));
        }

        /// <summary>
        /// Stops and restarts the first coroutine that was run.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        public void Restart()
        {
            if (Coroutines.Count == 0)
                throw new EmptyIteratorException("Coroutines is empty.");

            MonoBehaviour.StopCoroutine(Coroutines[0]);

            Coroutines[0] = MonoBehaviour.StartCoroutine(Coroutine());
        }

        /// <summary>
        /// Restarts all coroutines currently running.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        public void RestartAll()
        {
            if (Coroutines.Count == 0)
                throw new EmptyIteratorException("Coroutines is empty.");

            for (int i = 0; i < Coroutines.Count; i++)
            {
                MonoBehaviour.StopCoroutine(Coroutines[i]);
                Coroutines[i] = MonoBehaviour.StartCoroutine(Coroutine());
            }
        }

        private IEnumerator Coroutine()
        {
            IsRunning = true;
            yield return _enumerator();
            IsRunning = false;
        }

        private readonly Func<IEnumerator> _enumerator;
    }

    /// <summary>
    /// Advanced coroutine handler. Written by Emik.
    /// </summary>
    public sealed class Routine<T> : RoutineBase
    {
        /// <summary>
        /// Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.
        /// </summary>
        /// <param name="enumerator">The enumerator to call when initiated.</param>
        /// <param name="monoBehaviour">The MonoBehaviour to reference when calling the method.</param>
        public Routine(Func<T, IEnumerator> enumerator, MonoBehaviour monoBehaviour) : base(monoBehaviour) => _enumerator = enumerator;

        /// <summary>
        /// Starts the coroutine. Unless specified by <paramref name="allowSimultaneousRuns"/>, it will not be called if this class is in the middle of running the coroutine.
        /// </summary>
        /// <param name="t">The first argument to pass into the coroutine.</param>
        /// <param name="allowSimultaneousRuns">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        public void Start(T t, bool allowSimultaneousRuns = true)
        {
            if (!IsRunning || allowSimultaneousRuns)
                Coroutines.Add(MonoBehaviour.StartCoroutine(Coroutine(t)));
        }

        /// <summary>
        /// Stops and restarts the first coroutine that was run.
        /// </summary>
        /// <param name="t">The first argument to pass into the coroutine.</param>
        /// <exception cref="EmptyIteratorException"></exception>
        public void Restart(T t)
        {
            if (Coroutines.Count == 0)
                throw new EmptyIteratorException("Coroutines is empty.");

            MonoBehaviour.StopCoroutine(Coroutines[0]);

            Coroutines[0] = MonoBehaviour.StartCoroutine(Coroutine(t));
        }

        /// <summary>
        /// Restarts all coroutines currently running.
        /// </summary>
        /// <param name="t">The first argument to pass into the coroutine.</param>
        /// <exception cref="EmptyIteratorException"></exception>
        public void RestartAll(T t)
        {
            if (Coroutines.Count == 0)
                throw new EmptyIteratorException("Coroutines is empty.");

            for (int i = 0; i < Coroutines.Count; i++)
            {
                MonoBehaviour.StopCoroutine(Coroutines[i]);
                Coroutines[i] = MonoBehaviour.StartCoroutine(Coroutine(t));
            }
        }

        private IEnumerator Coroutine(T t)
        {
            IsRunning = true;
            yield return _enumerator(t);
            IsRunning = false;
        }

        private readonly Func<T, IEnumerator> _enumerator;
    }

    /// <summary>
    /// Advanced coroutine handler. Written by Emik.
    /// </summary>
    public sealed class Routine<T1, T2> : RoutineBase
    {
        /// <summary>
        /// Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.
        /// </summary>
        /// <param name="enumerator">The enumerator to call when initiated.</param>
        /// <param name="monoBehaviour">The MonoBehaviour to reference when calling the method.</param>
        public Routine(Func<T1, T2, IEnumerator> enumerator, MonoBehaviour monoBehaviour) : base(monoBehaviour) => _enumerator = enumerator;

        /// <summary>
        /// Starts the coroutine. Unless specified by <paramref name="allowSimultaneousRuns"/>, it will not be called if this class is in the middle of running the coroutine.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="allowSimultaneousRuns">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        public void Start(T1 t1, T2 t2, bool allowSimultaneousRuns = true)
        {
            if (!IsRunning || allowSimultaneousRuns)
                Coroutines.Add(MonoBehaviour.StartCoroutine(Coroutine(t1, t2)));
        }

        /// <summary>
        /// Stops and restarts the first coroutine that was run.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        public void Restart(T1 t1, T2 t2)
        {
            if (Coroutines.Count == 0)
                throw new EmptyIteratorException("Coroutines is empty.");

            MonoBehaviour.StopCoroutine(Coroutines[0]);

            Coroutines[0] = MonoBehaviour.StartCoroutine(Coroutine(t1, t2));
        }

        /// <summary>
        /// Restarts all coroutines currently running.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        public void RestartAll(T1 t1, T2 t2)
        {
            if (Coroutines.Count == 0)
                throw new EmptyIteratorException("Coroutines is empty.");

            for (int i = 0; i < Coroutines.Count; i++)
            {
                MonoBehaviour.StopCoroutine(Coroutines[i]);
                Coroutines[i] = MonoBehaviour.StartCoroutine(Coroutine(t1, t2));
            }
        }

        private IEnumerator Coroutine(T1 t1, T2 t2)
        {
            IsRunning = true;
            yield return _enumerator(t1, t2);
            IsRunning = false;
        }

        private readonly Func<T1, T2, IEnumerator> _enumerator;
    }

    /// <summary>
    /// Advanced coroutine handler. Written by Emik.
    /// </summary>
    public sealed class Routine<T1, T2, T3> : RoutineBase
    {
        /// <summary>
        /// Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.
        /// </summary>
        /// <param name="enumerator">The enumerator to call when initiated.</param>
        /// <param name="monoBehaviour">The MonoBehaviour to reference when calling the method.</param>
        public Routine(Func<T1, T2, T3, IEnumerator> enumerator, MonoBehaviour monoBehaviour) : base(monoBehaviour) => _enumerator = enumerator;

        /// <summary>
        /// Starts the coroutine. Unless specified by <paramref name="allowSimultaneousRuns"/>, it will not be called if this class is in the middle of running the coroutine.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <param name="allowSimultaneousRuns">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        public void Start(T1 t1, T2 t2, T3 t3, bool allowSimultaneousRuns = true)
        {
            if (!IsRunning || allowSimultaneousRuns)
                Coroutines.Add(MonoBehaviour.StartCoroutine(Coroutine(t1, t2, t3)));
        }

        /// <summary>
        /// Stops and restarts the first coroutine that was run.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <exception cref="EmptyIteratorException"></exception>
        public void Restart(T1 t1, T2 t2, T3 t3)
        {
            if (Coroutines.Count == 0)
                throw new EmptyIteratorException("Coroutines is empty.");

            MonoBehaviour.StopCoroutine(Coroutines[0]);

            Coroutines[0] = MonoBehaviour.StartCoroutine(Coroutine(t1, t2, t3));
        }

        /// <summary>
        /// Restarts all coroutines currently running.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <exception cref="EmptyIteratorException"></exception>
        public void RestartAll(T1 t1, T2 t2, T3 t3)
        {
            if (Coroutines.Count == 0)
                throw new EmptyIteratorException("Coroutines is empty.");

            for (int i = 0; i < Coroutines.Count; i++)
            {
                MonoBehaviour.StopCoroutine(Coroutines[i]);
                Coroutines[i] = MonoBehaviour.StartCoroutine(Coroutine(t1, t2, t3));
            }
        }

        private IEnumerator Coroutine(T1 t1, T2 t2, T3 t3)
        {
            IsRunning = true;
            yield return _enumerator(t1, t2, t3);
            IsRunning = false;
        }

        private readonly Func<T1, T2, T3, IEnumerator> _enumerator;
    }

    /// <summary>
    /// Advanced coroutine handler. Written by Emik.
    /// </summary>
    public sealed class Routine<T1, T2, T3, T4> : RoutineBase
    {
        /// <summary>
        /// Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.
        /// </summary>
        /// <param name="enumerator">The enumerator to call when initiated.</param>
        /// <param name="monoBehaviour">The MonoBehaviour to reference when calling the method.</param>
        public Routine(Func<T1, T2, T3, T4, IEnumerator> enumerator, MonoBehaviour monoBehaviour) : base(monoBehaviour) => _enumerator = enumerator;

        /// <summary>
        /// Starts the coroutine. Unless specified by <paramref name="allowSimultaneousRuns"/>, it will not be called if this class is in the middle of running the coroutine.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <param name="t4">The fourth argument to pass into the coroutine.</param>
        /// <param name="allowSimultaneousRuns">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        public void Start(T1 t1, T2 t2, T3 t3, T4 t4, bool allowSimultaneousRuns = true)
        {
            if (!IsRunning || allowSimultaneousRuns)
                Coroutines.Add(MonoBehaviour.StartCoroutine(Coroutine(t1, t2, t3, t4)));
        }

        /// <summary>
        /// Stops and restarts the first coroutine that was run.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <param name="t4">The fourth argument to pass into the coroutine.</param>
        /// <exception cref="EmptyIteratorException"></exception>
        public void Restart(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            if (Coroutines.Count == 0)
                throw new EmptyIteratorException("Coroutines is empty.");

            MonoBehaviour.StopCoroutine(Coroutines[0]);

            Coroutines[0] = MonoBehaviour.StartCoroutine(Coroutine(t1, t2, t3, t4));
        }

        /// <summary>
        /// Restarts all coroutines currently running.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <param name="t4">The fourth argument to pass into the coroutine.</param>
        /// <exception cref="EmptyIteratorException"></exception>
        public void RestartAll(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            if (Coroutines.Count == 0)
                throw new EmptyIteratorException("Coroutines is empty.");

            for (int i = 0; i < Coroutines.Count; i++)
            {
                MonoBehaviour.StopCoroutine(Coroutines[i]);
                Coroutines[i] = MonoBehaviour.StartCoroutine(Coroutine(t1, t2, t3, t4));
            }
        }

        private IEnumerator Coroutine(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            IsRunning = true;
            yield return _enumerator(t1, t2, t3, t4);
            IsRunning = false;
        }

        private readonly Func<T1, T2, T3, T4, IEnumerator> _enumerator;
    }
}
