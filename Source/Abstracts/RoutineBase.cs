using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace KeepCoding
{
    /// <summary>
    /// Provides the base class for the multiple <see cref="Routine"/> types.
    /// </summary>
    /// <remarks>
    /// <para>
    /// <see cref="RoutineBase"/> provides the general functionality that different types of <see cref="Routine"/> share in common with.
    /// As each different type of <see cref="Routine"/> gives different amounts of generics, this base class is therefore non-generic and provides every method that doesn't require it.
    /// This can therefore be used as a way of passing in an ambiguous type of <see cref="Routine"/>.
    /// </para>
    /// </remarks>
    /// <example>
    /// The following example illustrates a method for returning a <see cref="Tuple{T1, T2}"/> of the first and last <see href="https://docs.unity3d.com/2017.4/Documentation/Manual/Coroutines.html"/>Coroutine</see>, using <see cref="TypeHelper.ToTuple{T1, T2}(T1, T2)"/> as shorthand for constructing the tuple.
    /// <code>
    /// public static class CoroutineHelper
    /// {
    ///     public static Tuple<Coroutine, Coroutine> FirstAndLast(RoutineBase routine)
    ///     {
    ///         if (routine.Coroutines.Count == 0)
    ///             throw new EmptyIteratorException("The routine has no coroutines running!");
    ///         return routine[0].ToTuple(routine[routine.Count - 1]);
    ///     }
    /// }
    /// </code>
    /// This can be called with anything that inherits from this type to get the <see href="https://docs.unity3d.com/2017.4/Documentation/Manual/Coroutines.html"/>Coroutine</see>s. This example will the type <see cref="Routine"/> and <see cref="Routine{T}"/>.
    /// <code>
    /// public sealed class FooModule : ModuleScript
    /// {
    ///     private void Start()
    ///     {
    ///         Routine routine = new Routine(() => NoParameters(), this);
    ///         Routine otherRoutine = new Routine(i => NoParameters(i), this);
    ///         
    ///         // We need to create coroutines before passing them into the method.
    ///         for (int i = 0; i < 5; i++)
    ///         {
    ///             routine.Start();
    ///             
    ///             // This line ends up logging the numbers [ 1, 2, 3, 4, 5 ] due to OneParameter() calling Log()
    ///             otherRoutine.Start(i);
    ///         }
    ///         
    ///         Tuple<Coroutine, Coroutine> coroutineTuple = CoroutineHelper.FirstAndLast(routine)
    ///         
    ///         // Stops the first coroutine.
    ///         StopCoroutine(coroutineTuple.Item1);
    ///         
    ///         coroutineTuple = CoroutineHelper.FirstAndLast(otherRoutine);
    ///         
    ///         // Stops the last coroutine.
    ///         StopCoroutine(coroutineTuple.Item2);
    ///         
    ///         // This empties the list of coroutines it has internally.
    ///         routine.StopAll();
    ///         
    ///         // Uncomment this line below to see an EmptyIteratorException being thrown due to the above line clearing the list.
    ///         // coroutineTuple = CoroutineHelper.FirstAndLast(routine);
    ///     }
    ///     
    ///     private IEnumerator NoParameters()
    ///     {
    ///         yield return null;
    ///     }
    ///     
    ///     private IEnumerator OneParameter(int i)
    ///     {
    ///         Log(i);
    ///         yield return null;
    ///     }
    /// }
    /// </code>
    /// </example>
    /// <seealso cref="Routine"/>
    public abstract class RoutineBase : IEnumerable
    {
        /// <summary>
        /// Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.
        /// </summary>
        /// <param name="monoBehaviour">The MonoBehaviour to reference when calling the method.</param>
        protected RoutineBase(MonoBehaviour monoBehaviour) => _monoBehaviour = monoBehaviour;

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
