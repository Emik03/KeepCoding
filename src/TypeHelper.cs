
using System;
using System.Collections;
using UnityEngine;

namespace KeepCoding.v14
{
    /// <summary>
    /// Extension methods to help you create the Keep Coding's data types easier.
    /// </summary>
    public static class TypeHelper
    {
        /// <summary>
        /// Converts arguments to a new <see cref="Routine"/>.
        /// </summary>
        /// <param name="func">The function to call when the <see cref="IEnumerator"/> is called.</param>
        /// <param name="monoBehaviour">The instance of the <see cref="MonoBehaviour"/> to start the <see cref="Coroutine"/> from.</param>
        /// <returns>A new <see cref="Routine"/> containing the arguments provided.</returns>
        public static Routine ToRoutine(this Func<IEnumerator> func, MonoBehaviour monoBehaviour) => new Routine(func, monoBehaviour);

        /// <summary>
        /// Converts arguments to a new <see cref="Routine{T}"/>.
        /// </summary>
        /// <param name="func">The function to call when the <see cref="IEnumerator"/> is called.</param>
        /// <param name="monoBehaviour">The instance of the <see cref="MonoBehaviour"/> to start the <see cref="Coroutine"/> from.</param>
        /// <returns>A new <see cref="Routine{T}"/> containing the arguments provided.</returns>
        public static Routine<T> ToRoutine<T>(this Func<T, IEnumerator> func, MonoBehaviour monoBehaviour) => new Routine<T>(func, monoBehaviour);

        /// <summary>
        /// Converts arguments to a new <see cref="Routine{T1, T2}"/>.
        /// </summary>
        /// <param name="func">The function to call when the <see cref="IEnumerator"/> is called.</param>
        /// <param name="monoBehaviour">The instance of the <see cref="MonoBehaviour"/> to start the <see cref="Coroutine"/> from.</param>
        /// <returns>A new <see cref="Routine{T1, T2}"/> containing the arguments provided.</returns>
        public static Routine<T1, T2> ToRoutine<T1, T2>(this Func<T1, T2, IEnumerator> func, MonoBehaviour monoBehaviour) => new Routine<T1, T2>(func, monoBehaviour);

        /// <summary>
        /// Converts arguments to a new <see cref="Routine{T1, T2, T3}"/>.
        /// </summary>
        /// <param name="func">The function to call when the <see cref="IEnumerator"/> is called.</param>
        /// <param name="monoBehaviour">The instance of the <see cref="MonoBehaviour"/> to start the <see cref="Coroutine"/> from.</param>
        /// <returns>A new <see cref="Routine{T1, T2, T3}"/> containing the arguments provided.</returns>
        public static Routine<T1, T2, T3> ToRoutine<T1, T2, T3>(this Func<T1, T2, T3, IEnumerator> func, MonoBehaviour monoBehaviour) => new Routine<T1, T2, T3>(func, monoBehaviour);

        /// <summary>
        /// Converts arguments to a new <see cref="Routine{T1, T2, T3, T4}"/>.
        /// </summary>
        /// <param name="func">The function to call when the <see cref="IEnumerator"/> is called.</param>
        /// <param name="monoBehaviour">The instance of the <see cref="MonoBehaviour"/> to start the <see cref="Coroutine"/> from.</param>
        /// <returns>A new <see cref="Routine{T1, T2, T3, T4}"/> containing the arguments provided.</returns>
        public static Routine<T1, T2, T3, T4> ToRoutine<T1, T2, T3, T4>(this Func<T1, T2, T3, T4, IEnumerator> func, MonoBehaviour monoBehaviour) => new Routine<T1, T2, T3, T4>(func, monoBehaviour);

        /// <summary>
        /// Converts arguments to a new <see cref="Tuple{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of tuple.</typeparam>
        /// <param name="item">The argument to pass into the tuple.</param>
        /// <returns>A new <see cref="Tuple{T}"/> containing <paramref name="item"/>.</returns>
        public static Tuple<T> ToTuple<T>(this T item) => new Tuple<T>(item);

        /// <summary>
        /// Converts arguments to a new <see cref="Tuple{T1, T2}"/>.
        /// </summary>
        /// <typeparam name="T1">The first type of the tuple.</typeparam>
        /// <typeparam name="T2">The second type of the tuple.</typeparam>
        /// <param name="item1">The first argument to pass into the tuple.</param>
        /// <param name="item2">The second argument to pass into the tuple.</param>
        /// <returns>A new <seealso cref="Tuple{T1, T2}"/> containing <paramref name="item1"/> and <paramref name="item2"/></returns>
        public static Tuple<T1, T2> ToTuple<T1, T2>(this T1 item1, T2 item2) => new Tuple<T1, T2>(item1, item2);

        /// <summary>
        /// Converts arguments to a new <see cref="Tuple{T1, T2, T3}"/>.
        /// </summary>
        /// <typeparam name="T1">The first type of the tuple.</typeparam>
        /// <typeparam name="T2">The second type of the tuple.</typeparam>
        /// <typeparam name="T3">The third type of the tuple.</typeparam>
        /// <param name="item1">The first argument to pass into the tuple.</param>
        /// <param name="item2">The second argument to pass into the tuple.</param>
        /// <param name="item3">The third argument to pass into the tuple.</param>
        /// <returns>A new <seealso cref="Tuple{T1, T2, T3}"/> containing <paramref name="item1"/>, <paramref name="item2"/>, and <paramref name="item3"/></returns>
        public static Tuple<T1, T2, T3> ToTuple<T1, T2, T3>(this T1 item1, T2 item2, T3 item3) => new Tuple<T1, T2, T3>(item1, item2, item3);

        /// <summary>
        /// Converts arguments to a new <see cref="Tuple{T1, T2, T3, T4}"/>.
        /// </summary>
        /// <typeparam name="T1">The first type of the tuple.</typeparam>
        /// <typeparam name="T2">The second type of the tuple.</typeparam>
        /// <typeparam name="T3">The third type of the tuple.</typeparam>
        /// <typeparam name="T4">The fourth type of the tuple.</typeparam>
        /// <param name="item1">The first argument to pass into the tuple.</param>
        /// <param name="item2">The second argument to pass into the tuple.</param>
        /// <param name="item3">The third argument to pass into the tuple.</param>
        /// <param name="item4">The fourth argument to pass into the tuple.</param>
        /// <returns>A new <seealso cref="Tuple{T1, T2, T3, T4}"/> containing <paramref name="item1"/>, <paramref name="item2"/>, <paramref name="item3"/>, and <paramref name="item4"/></returns>
        public static Tuple<T1, T2, T3, T4> ToTuple<T1, T2, T3, T4>(this T1 item1, T2 item2, T3 item3, T4 item4) => new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);

        /// <summary>
        /// Converts argument to a new <see cref="Work"/>
        /// </summary>
        /// <param name="action">The action to run when the thread is active.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        /// <returns>A new <see cref="Work"/> consisting of the arguments provided.</returns>
        public static Work ToWork(this Action action, bool allowSimultaneousActive = false, uint maximumThreadsActive = 1) => new Work(action, allowSimultaneousActive, maximumThreadsActive);

        /// <summary>
        /// Converts argument to a new <see cref="Work{T}"/>
        /// </summary>
        /// <param name="func">The action to run when the thread is active.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        /// <returns>A new <see cref="Work{T}"/> consisting of the arguments provided.</returns>
        public static Work<T> ToWork<T>(this Func<T> func, bool allowSimultaneousActive = false, uint maximumThreadsActive = 1) => new Work<T>(func, allowSimultaneousActive, maximumThreadsActive);

        /// <summary>
        /// Converts argument to a new <see cref="Work{T, TResult}"/>
        /// </summary>
        /// <param name="func">The action to run when the thread is active.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        /// <returns>A new <see cref="Work{T, TResult}"/> consisting of the arguments provided.</returns>
        public static Work<T, TResult> ToWork<T, TResult>(this Func<T, TResult> func, bool allowSimultaneousActive = false, uint maximumThreadsActive = 1) => new Work<T, TResult>(func, allowSimultaneousActive, maximumThreadsActive);

        /// <summary>
        /// Converts argument to a new <see cref="Work{T1, T2, TResult}"/>
        /// </summary>
        /// <param name="func">The action to run when the thread is active.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        /// <returns>A new <see cref="Work{T1, T2, TResult}"/> consisting of the arguments provided.</returns>
        public static Work<T1, T2, TResult> ToWork<T1, T2, TResult>(this Func<T1, T2, TResult> func, bool allowSimultaneousActive = false, uint maximumThreadsActive = 1) => new Work<T1, T2, TResult>(func, allowSimultaneousActive, maximumThreadsActive);

        /// <summary>
        /// Converts argument to a new <see cref="Work{T1, T2, T3, TResult}"/>
        /// </summary>
        /// <param name="func">The action to run when the thread is active.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        /// <returns>A new <see cref="Work{T1, T2, T3, TResult}"/> consisting of the arguments provided.</returns>
        public static Work<T1, T2, T3, TResult> ToWork<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, bool allowSimultaneousActive = false, uint maximumThreadsActive = 1) => new Work<T1, T2, T3, TResult>(func, allowSimultaneousActive, maximumThreadsActive);

        /// <summary>
        /// Converts argument to a new <see cref="Work{T1, T2, T3, T4, TResult}"/>
        /// </summary>
        /// <param name="func">The action to run when the thread is active.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        /// <returns>A new <see cref="Work{T1, T2, T3, T4, TResult}"/> consisting of the arguments provided.</returns>
        public static Work<T1, T2, T3, T4, TResult> ToWork<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, bool allowSimultaneousActive = false, uint maximumThreadsActive = 1) => new Work<T1, T2, T3, T4, TResult>(func, allowSimultaneousActive, maximumThreadsActive);
    }
}
