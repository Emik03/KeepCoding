using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace KeepCoding
{
    /// <summary>
    /// Abstract class for the <see cref="Routine"/> datatype, since the different overloads are similar to each other. Written by Emik.
    /// </summary>
    public abstract class RoutineBase
    {
        internal RoutineBase(MonoBehaviour monoBehaviour)
        {
            Coroutines = new List<Coroutine>();
            MonoBehaviour = monoBehaviour;
        }

        /// <value>
        /// Determines whether it is currently running any coroutines.
        /// </value>
        public bool IsRunning { get; private protected set; }

        /// <value>
        /// The amount of coroutines stored.
        /// </value>
        public int Count => Coroutines.Count;

        /// <value>
        /// The list of all coroutines currently running.
        /// </value>
        public List<Coroutine> Coroutines { get; set; }

        /// <value>
        /// The MonoBehaviour that is being used to start the coroutines.
        /// </value>
        private protected MonoBehaviour MonoBehaviour { get; set; }

        /// <summary>
        /// Stops the first coroutine that was called, and removes it from the list of coroutines.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        public void Stop()
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            MonoBehaviour.StopCoroutine(Coroutines[0]);

            Coroutines = Coroutines.Skip(1).ToList();
        }

        /// <summary>
        /// Stops all instances of the coroutine, and clears the list of coroutines.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        public void StopAll()
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            Coroutines.ForEach(c => MonoBehaviour.StopCoroutine(c));

            Coroutines = new List<Coroutine>();
        }

        private protected void Remove(Coroutine coroutine) => MonoBehaviour.StopCoroutine(coroutine);

        private protected Coroutine Add(IEnumerator enumerator) => MonoBehaviour.StartCoroutine(enumerator);

        private protected IEnumerator Wait(bool oneByOne)
        {
            if (oneByOne)
                yield return new WaitWhile(() => IsRunning);
        }
    }
}
