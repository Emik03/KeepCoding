using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeepCoding
{
    /// <summary>
    /// Provides the base <see langword="class"/> for the multiple <see cref="Routine"/> types.
    /// </summary>
    /// <remarks>
    /// <see cref="RoutineBase"/> provides the general functionality that different types of <see cref="Routine"/> share in common with. As each different type of <see cref="Routine"/> gives different amounts of generics, this base <see langword="class"/> is therefore non-generic and provides every method that doesn't require it. This can therefore be used as a way of passing in an ambiguous type of <see cref="Routine"/>.
    /// </remarks>
    /// <example>
    /// The following example illustrates a method for returning a <see cref="Tuple{T1, T2}"/> of the first and last coroutines, using <see cref="TypeHelper.ToTuple{T1, T2}(T1, T2)"/> as shorthand for constructing the tuple. This method needs a <see cref="RoutineBase"/> with at least 1 coroutine, so an exception is raised if <see cref="Count"/> is 0.
    /// <code>
    /// using KeepCoding;
    /// using UnityEngine;
    /// 
    /// public static class CoroutineHelper
    /// {
    ///     public static Tuple&lt;Coroutine, Coroutine&gt; FirstAndLast(RoutineBase routine)
    ///     {
    ///         if (routine.Count == 0)
    ///             throw new EmptyIteratorException("routine");
    ///             
    ///         return routine[0].ToTuple(routine[routine.Count - 1]);
    ///     }
    /// }
    /// </code>
    /// This can be called with anything that inherits from this type to get the coroutines. This example will use the types <see cref="Routine"/> and <see cref="Routine{T}"/>.
    /// <code>
    /// using KeepCoding;
    /// using System.Collections;
    /// using UnityEngine;
    /// 
    /// public sealed class FooModule : ModuleScript
    /// {
    ///     private void Start()
    ///     {
    ///         Routine routine = new Routine(() => NoParameters(), this);
    ///         Routine otherRoutine = new Routine(i => OneParameter(i), this);
    ///         
    ///         // We need to create coroutines before passing them into the method.
    ///         for (int i = 0; i &lt; 5; i++)
    ///         {
    ///             routine.Start();
    ///             
    ///             // This line ends up logging the numbers [ 1, 2, 3, 4, 5 ] due to OneParameter() calling Log()
    ///             otherRoutine.Start(i);
    ///         }
    ///         
    ///         Tuple&lt;Coroutine, Coroutine&gt; coroutineTuple = CoroutineHelper.FirstAndLast(routine)
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
    /// <seealso cref="Count"/>
    /// <seealso cref="Routine"/>
    /// <seealso cref="Tuple{T1, T2}"/>
    /// <seealso cref="TypeHelper.ToTuple{T1, T2}(T1, T2)"/>
    public abstract class RoutineBase : IEnumerable
    {
        private protected RoutineBase(MonoBehaviour monoBehaviour) => _monoBehaviour = monoBehaviour;

        /// <summary>
        /// Indexes into <see cref="Coroutines"/>.
        /// </summary>
        /// <remarks>Given that <see cref="RoutineBase"/> acts as a wrapper for handling mulitple coroutines, all of which stored in a <see cref="List{T}"/>, this acts as shorthand for accessing a specific index from <see cref="Coroutines"/>.</remarks>
        /// <example>
        /// The following example illustrates using one of the implementations of <see cref="RoutineBase"/>, in this case <see cref="Routine"/> to index into <see cref="Coroutines"/>, to show that using the indexer is the same as using <see cref="Coroutines"/>. This is because <see cref="RoutineBase"/> by itself does not allow you to append any coroutines.
        /// <code>
        /// using KeepCoding;
        /// using System.Collections;
        /// using UnityEngine;
        /// 
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         Routine routine = new Routine(Example(), this);
        ///         
        ///         // This creates a coroutine inside of this variable. There is now 1 coroutine which can be indexed.
        ///         routine.Start();
        ///         
        ///         // Because they are the same instance, this expression returns true.
        ///         Log(routine[0] == routine.Coroutines[0]);
        ///     }
        ///     
        ///     private IEnumerator Example()
        ///     {
        ///         yield return null;
        ///     }
        /// }
        /// </code>
        /// This is the output from the console.
        /// <code>
        /// True
        /// </code>
        /// It is important to note that this is a getter-only property. This means that the following statement cannot be done. Use <see cref="Stop"/>, <see cref="StopAll"/>, or other methods by implemented classes to mutate <see cref="Coroutines"/>.
        /// <code>
        /// // Invalid. There is no setter for this indexer.
        /// routine[1] = routine[0];
        /// </code>
        /// </example>
        /// <seealso cref="Coroutines"/>
        /// <seealso cref="Routine"/>
        /// <seealso cref="Stop"/>
        /// <seealso cref="StopAll"/>
        /// <param name="index">The index to index into <see cref="Coroutines"/>.</param>
        /// <exception cref="IndexOutOfRangeException">The parameter <paramref name="index"/> is out of range from <see cref="Coroutines"/>.</exception>
        /// <returns>The coroutine from <see cref="Coroutines"/>.</returns>
        public Coroutine this[int index] => Coroutines[index];

        /// <summary>
        /// Determines whether it is currently running any coroutines.
        /// </summary>
        /// <value>
        /// A <see cref="bool"/> representing the state in which any coroutines are running.
        /// </value>
        /// <remarks>Typically when coroutines are running they act as a black box with no way to access whether they have finished or not. This property allows you to determine if the containing variable is handling any coroutines. Multiple coroutines running at the same time will still return <see langword="true"/>, and there is no way to determine the amount of coroutines running at once.</remarks>
        /// <example>
        /// The following example illustrates using an <see cref="Routine"/> and an <see cref="IEnumerator"/> to run separately despite being called at the same time.
        /// <code>
        /// using KeepCoding;
        /// using System.Collections;
        /// using UnityEngine;
        /// 
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         Routine routine = new Routine(First(), this);
        ///         
        ///         routine.Start();
        ///         
        ///         StartCoroutine(Second(routine));
        ///     }
        ///     
        ///     private IEnumerator First()
        ///     {
        ///         foreach (string log in new[] { "First1", "First2", "First3" }
        ///         {
        ///             Log(log);
        ///             yield return new WaitForSeconds(1);
        ///         }
        ///     }
        ///     
        ///     private IEnumerator Second(Routine routine)
        ///     {
        ///         yield return new WaitWhile(() => routine.IsRunning);
        ///         Log("Second");
        ///     }
        /// }
        /// </code>
        /// This is the output from the console.
        /// <code>
        /// [Foo #1] First1
        /// [Foo #1] First2
        /// [Foo #1] First3
        /// [Foo #1] Second
        /// </code>
        /// </example>
        /// <seealso cref="Routine"/>
        public bool IsRunning { get; private protected set; }

        /// <summary>
        /// The amount of coroutines stored.
        /// </summary>
        /// <remarks>Given that <see cref="RoutineBase"/> acts as a wrapper for handling mulitple coroutines, all of which stored in a <see cref="List{T}"/>, this acts as shorthand for accessing the <see cref="List{T}.Count"/> from <see cref="Coroutines"/>. <see cref="Coroutines"/> will never be <see langword="null"/> which means <see cref="Count"/> never throws an exception. Note that this does not store the amount of coroutines running, as finished coroutines will still be kept inside the <see cref="List{T}"/> <see cref="Coroutines"/>. When <see cref="Stop"/> or <see cref="StopAll"/> is called however, the coroutines to get removed from the <see cref="Coroutines"/> which will change the count and therefore this getter.</remarks>
        /// <example>
        /// The following example illustrates a method that uses <see cref="Stop"/> to remove one entry from <see cref="Coroutines"/> and returns the size of the collection using <see cref="Count"/>.
        /// <code>
        /// using KeepCoding;
        /// 
        /// public static class CoroutineHelper
        /// {
        ///     public static int StopAndCount(RoutineBase routine)
        ///     {
        ///         routine.Stop();
        ///         
        ///         return routine.Count;
        ///     }
        /// }
        /// </code>
        /// This will now be called using <see cref="Routine"/>.
        /// <code>
        /// using KeepCoding;
        /// using System.Collections;
        /// using UnityEngine;
        /// 
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         Routine routine = new Routine(Example(), this);
        ///         
        ///         // This increases the count to 1 because a coroutine gets appended.
        ///         routine.Start();
        ///         
        ///         Log(routine.Count);
        ///         
        ///         // This will stop which removes 1 and return the new length which is 0.
        ///         Log(CoroutineHelper.StopAndCount(routine));
        ///     }
        ///     
        ///     private IEnumerator Example()
        ///     {
        ///         yield return null;
        ///     }
        /// }
        /// </code>
        /// This is the output from the console.
        /// <code>
        /// [Foo #1] 1
        /// [Foo #1] 0
        /// </code>
        /// </example>
        /// <seealso cref="Coroutines"/>
        /// <seealso cref="Routine"/>
        /// <seealso cref="Stop"/>
        /// <seealso cref="StopAll"/>
        public int Count => Coroutines.Count;

        /// <summary>
        /// The <see cref="List{T}"/> of all coroutines.
        /// </summary>
        /// <remarks><see cref="RoutineBase"/> can store multiple coroutines in order to be able to handle multiple coroutines. This <see cref="List{T}"/> starts out empty and will never be <see langword="null"/>.</remarks>
        /// <example>
        /// The following example illustrates how <see cref="Coroutines"/> starts out as empty. A helper method will be first created to check for an empty list.
        /// <code>
        /// using System.Collections;
        /// 
        /// public static class Helper
        /// {
        ///     public static bool IsEmpty(this T list) where T : IList
        ///     {
        ///         if (list == null)
        ///             throw new NullIteratorException("list");
        ///             
        ///         return list.Count;
        ///     }
        /// }
        /// </code>
        /// Now a class which implements <see cref="RoutineBase"/> such as <see cref="Routine"/> can demonstrate this effect.
        /// <code>
        /// using KeepCoding;
        /// using System.Collections;
        /// using UnityEngine;
        /// 
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         // This grabs the list of coroutines right after the constructor is finished, and abanndons the rest of the routine type.
        ///         List&lt;Coroutine&gt; coroutines = new Routine(Example(), this).Coroutines;
        /// 
        ///         // Due to the fact that nothing was done with the routine, this would return true.
        ///         Log(coroutines.IsEmpty());
        ///     }
        ///     
        ///     private IEnumerator Example()
        ///     {
        ///         yield return null;
        ///     }
        /// }
        /// </code>
        /// This is the output from the console.
        /// <code>
        /// True
        /// </code>
        /// </example>
        /// <seealso cref="Routine"/>
        public List<Coroutine> Coroutines { get; private protected set; } = new List<Coroutine>();

        private readonly MonoBehaviour _monoBehaviour;

        /// <summary>
        /// Stops the first coroutine that was called, and removes it from <see cref="Coroutines"/>.
        /// </summary>
        /// <remarks>Every time a coroutine gets added, it does so at the end of the <see cref="List{T}"/>. When <see cref="Stop"/> is called, the first and therefore oldest coroutine gets removed from this list in a similar vein to <see cref="Queue"/>. Note that when the coroutines are finished, they do not get removed from the list. If <see cref="Stop"/> is called on a coroutine which has already stopped, the first coroutine will still be attempted to be stopped, which will in that case do nothing, and be removed from the list.</remarks>
        /// <example>
        /// The following example illustrates running <see cref="Stop"/> three times despite only having two coroutines using the class <see cref="Routine"/> which inherits from <see cref="RoutineBase"/>. As <see cref="Stop"/> expects at least 1 coroutine, the code will cause an <see cref="EmptyIteratorException"/>.
        /// <code>
        /// using KeepCoding;
        /// using System.Collections;
        /// using UnityEngine;
        /// 
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         Routine routine = new Routine(Example(), this);
        ///         
        ///         // This creates the first coroutine.
        ///         routine.Start();
        ///         
        ///         // This creates the second coroutine.
        ///         routine.Start();
        ///         
        ///         // This stops the first coroutine.
        ///         routine.Stop();
        ///         
        ///         // This stops the second coroutine.
        ///         routine.Stop();
        ///         
        ///         // This will cause an error because there are no coroutines to remove.
        ///         routine.Stop();
        ///     }
        ///     
        ///     private IEnumerator Example()
        ///     {
        ///         yield return null;
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <exception cref="EmptyIteratorException"><see cref="Coroutines"/> is empty.</exception>
        /// <seealso cref="Coroutines"/>
        /// <seealso cref="Routine"/>
        public void Stop()
        {
            Coroutines.NullOrEmptyCheck("The list of coroutines is empty.");

            _monoBehaviour.StopCoroutine(Coroutines[0]);

            Coroutines.RemoveAt(0);
        }

        /// <summary>
        /// Stops all coroutines that were called, and makes <see cref="Coroutines"/> empty.
        /// </summary>
        /// <remarks><see cref="StopAll"/> stops and removes all coroutines from <see cref="Coroutines"/>, as such, it cannot be called twice in a row without throwing an exception or adding a coroutine in-between. Note that when the coroutines are finished, they do not get removed from the list. If <see cref="StopAll"/> is called on coroutines which have already stopped, those coroutines will still be attempted to be stopped, which will in that case do nothing, and be removed from the list.</remarks>
        /// <example>
        /// The following example illustrates running <see cref="StopAll"/> twice to demonstrate the error using the class <see cref="Routine"/> which inherits from <see cref="RoutineBase"/>. As <see cref="StopAll"/> expects at least 1 coroutine, the code will cause an <see cref="EmptyIteratorException"/>.
        /// <code>
        /// using KeepCoding;
        /// using System.Collections;
        /// using UnityEngine;
        /// 
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         Routine routine = new Routine(Example(), this);
        ///         
        ///         // This creates the first coroutine.
        ///         routine.Start();
        ///         
        ///         // This creates the second coroutine.
        ///         routine.Start();
        ///         
        ///         // This stops the first and second coroutine.
        ///         routine.StopAll();
        ///         
        ///         // This will cause an error because there are no coroutines to remove.
        ///         routine.StopAll();
        ///     }
        ///     
        ///     private IEnumerator Example()
        ///     {
        ///         yield return null;
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <exception cref="EmptyIteratorException"><see cref="Coroutines"/> is empty.</exception>
        /// <seealso cref="Coroutines"/>
        /// <seealso cref="Routine"/>
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
