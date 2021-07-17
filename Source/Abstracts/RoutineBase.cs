using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace KeepCoding
{
    /// <summary>
    /// Abstract class for the <see cref="Routine"/> datatype, since the different overloads are similar to each other.
    /// </summary>
    public abstract class RoutineBase : IEnumerable
    {
        /// <summary>
        /// Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.
        /// </summary>
        /// <param name="monoBehaviour">The MonoBehaviour to reference when calling the method.</param>
        public RoutineBase(MonoBehaviour monoBehaviour) => _monoBehaviour = monoBehaviour;

        /// <summary>
        /// Indexes into <see cref="Coroutines"/>.
        /// </summary>
        /// <param name="index">The index to index into <see cref="Coroutines"/>.</param>
        /// <returns>The <see cref="Coroutine"/> from <see cref="Coroutines"/>.</returns>
        public Coroutine this[int index] => Coroutines[index];

        /// <summary>
        /// Determines whether it is currently running any coroutines.
        /// </summary>
        public bool IsRunning { get; private protected set; }

        /// <summary>
        /// The amount of coroutines stored.
        /// </summary>
        public int Count => Coroutines.Count;

        /// <summary>
        /// The list of all coroutines currently running.
        /// </summary>
        public List<Coroutine> Coroutines { get; private protected set; } = new List<Coroutine>();

        private readonly MonoBehaviour _monoBehaviour;

        /// <summary>
        /// Stops the first coroutine that was called, and removes it from the list of coroutines.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        public void Stop()
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            _monoBehaviour.StopCoroutine(Coroutines[0]);

            Coroutines = Coroutines.Skip(1).ToList();
        }

        /// <summary>
        /// Stops all instances of the coroutine, and clears the list of coroutines.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        public void StopAll()
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            Coroutines.ForEach(c => _monoBehaviour.StopCoroutine(c));

            Coroutines = new List<Coroutine>();
        }

        /// <summary>
        /// Gets the enumerator of the <see cref="Routine"/>, using <see cref="Coroutines"/>.
        /// </summary>
        /// <returns>The list of <see cref="Coroutines"/> in this <see cref="Routine"/>.</returns>
        public IEnumerator GetEnumerator() => Coroutines.GetEnumerator();

        private protected void Remove(in Coroutine coroutine) => _monoBehaviour.StopCoroutine(coroutine);

        private protected Coroutine Add(in IEnumerator enumerator) => _monoBehaviour.StartCoroutine(enumerator);

        private protected IEnumerator Wait(bool oneByOne)
        {
            if (oneByOne)
                yield return new WaitWhile(() => IsRunning);
        }
    }
}
