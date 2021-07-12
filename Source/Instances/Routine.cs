using System;
using System.Collections;
using UnityEngine;

namespace KeepCoding
{
    /// <summary>
    /// Advanced coroutine handler.
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
        /// Starts the coroutine. Unless specified by <paramref name="allowMultiple"/>, it will not be called if this class is in the middle of running the coroutine.
        /// </summary>
        /// <param name="allowMultiple">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void Start(bool allowMultiple = true, bool oneByOne = false)
        {
            if (!IsRunning || allowMultiple)
                Coroutines.Add(Add(Coroutine(oneByOne)));
        }

        /// <summary>
        /// Starts a coroutine if no coroutines are running, otherwise restarts.
        /// </summary>
        /// <param name="allowMultiple">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void StartOrRestart(bool allowMultiple = true, bool oneByOne = false)
        {
            if (Coroutines.IsNullOrEmpty())
                Start(allowMultiple, oneByOne);
            else
                Restart(oneByOne);
        }

        /// <summary>
        /// Stops and restarts the first coroutine that was run.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void Restart(bool oneByOne = false)
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            Remove(Coroutines[0]);

            Coroutines[0] = Add(Coroutine(oneByOne));
        }

        /// <summary>
        /// Restarts all coroutines currently running.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void RestartAll(bool oneByOne)
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            for (int i = 0; i < Coroutines.Count; i++)
            {
                Remove(Coroutines[i]);
                Coroutines[i] = Add(Coroutine(oneByOne));
            }
        }

        private IEnumerator Coroutine(bool oneByOne)
        {
            yield return Wait(oneByOne);
            IsRunning = true;

            yield return _enumerator();
            IsRunning = false;
        }

        private readonly Func<IEnumerator> _enumerator;
    }

    /// <summary>
    /// Advanced coroutine handler. 
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
        /// Starts the coroutine. Unless specified by <paramref name="allowMultiple"/>, it will not be called if this class is in the middle of running the coroutine.
        /// </summary>
        /// <param name="t">The first argument to pass into the coroutine.</param>
        /// <param name="allowMultiple">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void Start(T t, bool allowMultiple = true, bool oneByOne = false)
        {
            if (!IsRunning || allowMultiple)
                Coroutines.Add(Add(Coroutine(t, oneByOne)));
        }

        /// <summary>
        /// Starts a coroutine if no coroutines are running, otherwise restarts.
        /// </summary>
        /// <param name="t">The first argument to pass into the coroutine.</param>
        /// <param name="allowMultiple">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void StartOrRestart(T t, bool allowMultiple = true, bool oneByOne = false)
        {
            if (Coroutines.IsNullOrEmpty())
                Start(t, allowMultiple, oneByOne);
            else
                Restart(t, oneByOne);
        }

        /// <summary>
        /// Stops and restarts the first coroutine that was run.
        /// </summary>
        /// <param name="t">The first argument to pass into the coroutine.</param>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void Restart(T t, bool oneByOne = false)
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            Remove(Coroutines[0]);

            Coroutines[0] = Add(Coroutine(t, oneByOne));
        }

        /// <summary>
        /// Restarts all coroutines currently running.
        /// </summary>
        /// <param name="t">The first argument to pass into the coroutine.</param>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void RestartAll(T t, bool oneByOne = false)
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            for (int i = 0; i < Coroutines.Count; i++)
            {
                Remove(Coroutines[i]);
                Coroutines[i] = Add(Coroutine(t, oneByOne));
            }
        }

        private IEnumerator Coroutine(T t, bool oneByOne)
        {
            yield return Wait(oneByOne);
            IsRunning = true;

            yield return _enumerator(t);
            IsRunning = false;
        }

        private readonly Func<T, IEnumerator> _enumerator;
    }

    /// <summary>
    /// Advanced coroutine handler. 
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
        /// Starts the coroutine. Unless specified by <paramref name="allowMultiple"/>, it will not be called if this class is in the middle of running the coroutine.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="allowMultiple">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void Start(T1 t1, T2 t2, bool allowMultiple = true, bool oneByOne = false)
        {
            if (!IsRunning || allowMultiple)
                Coroutines.Add(Add(Coroutine(t1, t2, oneByOne)));
        }

        /// <summary>
        /// Starts a coroutine if no coroutines are running, otherwise restarts.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="allowMultiple">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void StartOrRestart(T1 t1, T2 t2, bool allowMultiple = true, bool oneByOne = false)
        {
            if (Coroutines.IsNullOrEmpty())
                Start(t1, t2, allowMultiple, oneByOne);
            else
                Restart(t1, t2, oneByOne);
        }

        /// <summary>
        /// Stops and restarts the first coroutine that was run.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void Restart(T1 t1, T2 t2, bool oneByOne = false)
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            Remove(Coroutines[0]);

            Coroutines[0] = Add(Coroutine(t1, t2, oneByOne));
        }

        /// <summary>
        /// Restarts all coroutines currently running.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void RestartAll(T1 t1, T2 t2, bool oneByOne = false)
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            for (int i = 0; i < Coroutines.Count; i++)
            {
                Remove(Coroutines[i]);
                Coroutines[i] = Add(Coroutine(t1, t2, oneByOne));
            }
        }

        private IEnumerator Coroutine(T1 t1, T2 t2, bool oneByOne)
        {
            yield return Wait(oneByOne);
            IsRunning = true;

            yield return _enumerator(t1, t2);
            IsRunning = false;
        }

        private readonly Func<T1, T2, IEnumerator> _enumerator;
    }

    /// <summary>
    /// Advanced coroutine handler. 
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
        /// Starts the coroutine. Unless specified by <paramref name="allowMultiple"/>, it will not be called if this class is in the middle of running the coroutine.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <param name="allowMultiple">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void Start(T1 t1, T2 t2, T3 t3, bool allowMultiple = true, bool oneByOne = false)
        {
            if (!IsRunning || allowMultiple)
                Coroutines.Add(Add(Coroutine(t1, t2, t3, oneByOne)));
        }

        /// <summary>
        /// Starts a coroutine if no coroutines are running, otherwise restarts.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <param name="allowMultiple">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void StartOrRestart(T1 t1, T2 t2, T3 t3, bool allowMultiple = true, bool oneByOne = false)
        {
            if (Coroutines.IsNullOrEmpty())
                Start(t1, t2, t3, allowMultiple, oneByOne);
            else
                Restart(t1, t2, t3, oneByOne);
        }

        /// <summary>
        /// Stops and restarts the first coroutine that was run.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void Restart(T1 t1, T2 t2, T3 t3, bool oneByOne = false)
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            Remove(Coroutines[0]);

            Coroutines[0] = Add(Coroutine(t1, t2, t3, oneByOne));
        }

        /// <summary>
        /// Restarts all coroutines currently running.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void RestartAll(T1 t1, T2 t2, T3 t3, bool oneByOne = false)
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            for (int i = 0; i < Coroutines.Count; i++)
            {
                Remove(Coroutines[i]);
                Coroutines[i] = Add(Coroutine(t1, t2, t3, oneByOne));
            }
        }

        private IEnumerator Coroutine(T1 t1, T2 t2, T3 t3, bool oneByOne)
        {
            yield return Wait(oneByOne);
            IsRunning = true;

            yield return _enumerator(t1, t2, t3);
            IsRunning = false;
        }

        private readonly Func<T1, T2, T3, IEnumerator> _enumerator;
    }

    /// <summary>
    /// Advanced coroutine handler. 
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
        /// Starts the coroutine. Unless specified by <paramref name="allowMultiple"/>, it will not be called if this class is in the middle of running the coroutine.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <param name="t4">The fourth argument to pass into the coroutine.</param>
        /// <param name="allowMultiple">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void Start(T1 t1, T2 t2, T3 t3, T4 t4, bool allowMultiple = true, bool oneByOne = false)
        {
            if (!IsRunning || allowMultiple)
                Coroutines.Add(Add(Coroutine(t1, t2, t3, t4, oneByOne)));
        }

        /// <summary>
        /// Starts a coroutine if no coroutines are running, otherwise restarts.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <param name="t4">The fourth argument to pass into the coroutine.</param>
        /// <param name="allowMultiple">Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.</param>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void StartOrRestart(T1 t1, T2 t2, T3 t3, T4 t4, bool allowMultiple = true, bool oneByOne = false)
        {
            if (Coroutines.IsNullOrEmpty())
                Start(t1, t2, t3, t4, allowMultiple, oneByOne);
            else
                Restart(t1, t2, t3, t4, oneByOne);
        }

        /// <summary>
        /// Stops and restarts the first coroutine that was run.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <param name="t4">The fourth argument to pass into the coroutine.</param>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void Restart(T1 t1, T2 t2, T3 t3, T4 t4, bool oneByOne = false)
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            Remove(Coroutines[0]);

            Coroutines[0] = Add(Coroutine(t1, t2, t3, t4, oneByOne));
        }

        /// <summary>
        /// Restarts all coroutines currently running.
        /// </summary>
        /// <param name="t1">The first argument to pass into the coroutine.</param>
        /// <param name="t2">The second argument to pass into the coroutine.</param>
        /// <param name="t3">The third argument to pass into the coroutine.</param>
        /// <param name="t4">The fourth argument to pass into the coroutine.</param>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="oneByOne">If called multiple times, waits until the others are finished.</param>
        public void RestartAll(T1 t1, T2 t2, T3 t3, T4 t4, bool oneByOne = false)
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            for (int i = 0; i < Coroutines.Count; i++)
            {
                Remove(Coroutines[i]);
                Coroutines[i] = Add(Coroutine(t1, t2, t3, t4, oneByOne));
            }
        }

        private IEnumerator Coroutine(T1 t1, T2 t2, T3 t3, T4 t4, bool oneByOne)
        {
            yield return Wait(oneByOne);
            IsRunning = true;

            yield return _enumerator(t1, t2, t3, t4);
            IsRunning = false;
        }

        private readonly Func<T1, T2, T3, T4, IEnumerator> _enumerator;
    }
}
