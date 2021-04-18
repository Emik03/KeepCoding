using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace KeepCoding.v14
{
    /// <summary>
    /// Extension methods for <see cref="IEnumerable"/>. Written by Emik.
    /// </summary>
    public static class CollectionHelper
    {
        /// <summary>
        /// Determines if the index is pointing to null in any way.
        /// </summary>
        /// <param name="source">The array to index with.</param>
        /// <param name="index">The index.</param>
        /// <returns>True if <paramref name="source"/> is null, if <paramref name="index"/> is out of range, or if the element is null.</returns>
        public static bool IsIndexNull<T>(this IEnumerable<T> source, int index) => source is null || !index.IsBetween(0, source.GetUpperBound()) || source.ElementAt(index) is null;

        /// <summary>
        /// Determines if the <see cref="IEnumerable{T}"/> is null or empty.
        /// </summary>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to check for.</param>
        /// <returns>True if <paramref name="source"/> is equal to null, or empty.</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source) => source is null || source.Any();

        /// <summary>
        /// Determines if the <see cref="IEnumerator{T}"/> is null or empty.
        /// </summary>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to check for.</param>
        /// <returns>True if <paramref name="source"/> is equal to null, or empty.</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerator<T> source) => source is null || source.AsEnumerable().Any();

        /// <summary>
        /// Returns the last index of the <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to check length for.</param>
        /// <returns><paramref name="source"/>.Count() - 1</returns>
        public static int GetUpperBound<T>(this IEnumerable<T> source) => source.IsNullOrEmpty() ? throw new EmptyIteratorException("The iterator is null or empty, meaning that the upper bound doesn't exist.") : source.Count() - 1;

        /// <summary>
        /// Returns the length of the <see cref="IEnumerable{T}"/>, or if null, the default value 0.
        /// </summary>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to check its length.</param>
        /// <returns><paramref name="source"/>'s length, or 0.</returns>
        public static int LengthOrDefault<T>(this IEnumerable<T> source) => source is not null ? source.Count() : default;

        /// <summary>
        /// Unwraps any <see cref="IEnumerable"/>, which ends up flattening it as a <see cref="IEnumerable"/> of type <see cref="object"/>.
        /// </summary>
        /// <param name="source">The object to unwrap.</param>
        /// <returns>An <see cref="object"/> <see cref="Array"/> of all elements within <paramref name="source"/>.</returns>
        public static object[] Unwrap(this IEnumerable<object> source) => source.SelectMany(x => Unwrap(x as IEnumerable<object>) ?? new[] { x }).ToArray();

        /// <summary>
        /// Unwraps any object, whether it be a class, list, tuple, or any other data.
        /// </summary>
        /// <param name="source">The object to unwrap.</param>
        /// <param name="isRecursive">Whether it should search inside the variable and yield return the elements inside <paramref name="source"/>.</param>
        /// <returns>An <see cref="object"/> <see cref="Array"/> of all elements within <paramref name="source"/>.</returns>
        public static object[] Unwrap(this object source, bool isRecursive = false) => (source switch
        {
            null => new[] { Helper.Null },
            string => new[] { source },
            Tuple tuple => Unwrap(tuple.ToArray),
            IEnumerable ienumerable => Unwrap(ienumerable),
            IEnumerator ienumerator => Unwrap(ienumerator.ToIEnumerable()),
            _ => isRecursive ? source.GetAllValues().Cast<object>().Prepend(source) : new[] { source },
        }).ToArray();

        /// <summary>
        /// Converts an <see cref="IEnumerator"/> to an <see cref="IEnumerable"/>.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="source">The <see cref="IEnumerator"/> to convert.</param>
        /// <returns><paramref name="source"/> as an <see cref="IEnumerable"/>.</returns>
        public static IEnumerable ToIEnumerable(this IEnumerator source)
        {
            source.NullCheck("The enumerator cannot be null.");

            while (source.MoveNext())
                yield return source.Current;
        }

        /// <summary>
        /// Gets all fields and properties of the item using reflection.
        /// </summary>
        /// <param name="source">The item to get all fields and properties.</param>
        /// <returns>All fields and properties of <paramref name="source"/>.</returns>
        public static IEnumerable<string> GetAllValues(this object source) => source?.GetType()?.GetFields(Helper.Flags).Select(f => $"\n{f} (Field): {f?.GetValue(source).UnwrapToString()}").Concat(source?.GetType()?.GetProperties(Helper.Flags).Select(p => $"\n{p} (Property): {p?.GetValue(source, null).UnwrapToString()}"));

        /// <summary>
        /// Returns the element of an array, pretending that the array wraps around or is circular.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="source">The array itself.</param>
        /// <param name="index">The index, which will wrap around if it's larger than the array.</param>
        /// <returns>The element in <paramref name="source"/> using <paramref name="index"/> with rem-euclid modulo.</returns>
        public static T ElementAtWrap<T>(this IEnumerable<T> source, int index) => source.NullOrEmptyCheck($"The variable {nameof(source)} cannot be null.").NullOrEmptyCheck($"The variable {nameof(source)} cannot be empty.").ElementAt(index.Modulo(source.Count()));

        /// <summary>
        /// Returns the first element which doesn't return null, or null if all of them return null.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of array, and method.</typeparam>
        /// <param name="source">The array to iterate on.</param>
        /// <param name="func">The method which returns</param>
        /// <returns>The first value from <paramref name="source"/> where <paramref name="func"/> doesn't return null, or null.</returns>
        public static T FirstValue<T>(this IEnumerable<T> source, Func<T, T> func) where T : class => source.NullCheck("The source cannot be null.").FirstOrDefault(t => func.NullCheck("The function cannot be null.")(t) is T);

        /// <summary>
        /// Returns the last element which doesn't return null, or null if all of them return null.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of array, and method.</typeparam>
        /// <param name="source">The array to iterate on.</param>
        /// <param name="func">The method which returns</param>
        /// <returns>The last value from <paramref name="source"/> where <paramref name="func"/> doesn't return null, or null.</returns>
        public static T LastValue<T>(this IEnumerable<T> source, Func<T, T> func) where T : class => source.Reverse().FirstValue(func.NullCheck("The function cannot be null."));

        /// <summary>
        /// Invokes a method of <typeparamref name="T"/> and then returns the argument provided.
        /// </summary>
        /// <remarks>
        /// This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.
        /// </remarks>
        /// <exception cref="NullIteratorException"></exception>
        /// <typeparam name="T">The type of <paramref name="source"/> and <paramref name="action"/>.</typeparam>
        /// <param name="source">The item to use as reference and modify.</param>
        /// <param name="action">The action to apply <paramref name="source"/> to.</param>
        /// <returns>The item <paramref name="source"/>.</returns>
        public static T[] Call<T>(this T[] source, Action<T, int> action) => source.Select((i, n) => { action(i, n); return i; }).ToArray();

        /// <summary>
        /// Appends the element provided to the <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The datatype of both the <see cref="IEnumerable{T}"/> and element.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to be modified.</param>
        /// <param name="item">The element to append to the <paramref name="source"/>.</param>
        /// <returns><paramref name="source"/>, but with an added <paramref name="item"/> as the last index.</returns>
        public static IEnumerable<T> Append<T>(this IEnumerable<T> source, T item) => source.Concat(new T[] { item });

        /// <summary>
        /// Converts an <see cref="IEnumerator"/> to an <see cref="IEnumerable"/>.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <typeparam name="T">The parameter and return type.</typeparam>
        /// <param name="source">The <see cref="IEnumerator"/> to convert.</param>
        /// <returns><paramref name="source"/> as an <see cref="IEnumerable"/>.</returns>
        public static IEnumerable<T> AsEnumerable<T>(this IEnumerator<T> source)
        {
            source.NullCheck("The enumerator cannot be null.");

            while (source.MoveNext())
                yield return source.Current;
        }

        /// <summary>
        /// Removes the elements whose index matches any of the indices.
        /// </summary>
        /// <typeparam name="T">The datatype of both the <see cref="IEnumerable{T}"/>.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to be modified.</param>
        /// <param name="indices">The indices to exclude from <paramref name="source"/>.</param>
        /// <returns><paramref name="source"/>, but without the element indexing <paramref name="indices"/>.</returns>
        public static IEnumerable<T> Exclude<T>(this IEnumerable<T> source, params int[] indices) => source.Where((_, i) => !indices.Contains(i));

        /// <summary>
        /// Removes the elements whose index does not match any of the indices.
        /// </summary>
        /// <typeparam name="T">The datatype of both the <see cref="IEnumerable{T}"/>.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to be modified.</param>
        /// <param name="indices">The indices to include in <paramref name="source"/>.</param>
        /// <returns><paramref name="source"/>, but without the element indexing <paramref name="indices"/>.</returns>
        public static IEnumerable<T> Include<T>(this IEnumerable<T> source, params int[] indices) => source.Where((_, i) => indices.Contains(i));

        /// <summary>
        /// Filters an <see cref="IEnumerable{T}"/>, only allowing duplicated items.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="IEnumerable{T}"/>.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to filter through.</param>
        /// <returns>A new instance of <paramref name="source"/> that only includes elements which are repeated in the array.</returns>
        public static IEnumerable<T> Indistinct<T>(this IEnumerable<T> source) => source.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key);

        /// <summary>
        /// Throws an exception if the <see cref="IEnumerable{T}"/> is null or empty.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="source">The <see cref="Array"/> to check for null and empty.</param>
        /// <param name="message">The optional message to throw if null or empty. Leaving it default will throw a default message.</param>
        public static IEnumerable<T> NullOrEmptyCheck<T>(this IEnumerable<T> source, string message = null) => source.NullCheck(message ?? $"While asserting for null or empty, the variable ended up being null.").Any() ? source : throw new EmptyIteratorException(message ?? $"While asserting for null or empty, the variable ended up being empty.");

        /// <summary>
        /// Prepends the element provided to the <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The datatype of both the <see cref="IEnumerable{T}"/>.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to be modified.</param>
        /// <param name="item">The element to append to the <paramref name="source"/>.</param>
        /// <returns><paramref name="source"/>, but with an added <paramref name="item"/> as the first index.</returns>
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, T item) => new T[] { item }.Concat(source);

        /// <summary>
        /// Replaces an index in the <see cref="IEnumerable{T}"/> and returns the new one.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <typeparam name="T">The type of the <see cref="IEnumerable"/>.</typeparam>
        /// <param name="source">The initial source.</param>
        /// <param name="index">The index to change.</param>
        /// <param name="value">The value to replace at <paramref name="source"/>'s <paramref name="index"/> element.</param>
        /// <returns><paramref name="source"/> but the <paramref name="index"/> element is <paramref name="value"/> instead.</returns>
        public static IEnumerable<T> Replace<T>(this IEnumerable<T> source, int index, T value) => source.NullCheck("The source cannot be null.").Select((t, i) => i == index ? value.NullCheck("The item cannot be null.") : t);

        /// <summary>
        /// Returns a slice of an <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <typeparam name="T">The type of the <paramref name="source"/> and return type.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to take a slice of.</param>
        /// <param name="start">The starting index of the slice.</param>
        /// <param name="count">The amount of items to take.</param>
        /// <returns>A slice of <paramref name="source"/> based on <paramref name="start"/> and <paramref name="count"/>.</returns>
        public static IEnumerable<T> Slice<T>(this IEnumerable<T> source, int start, int count) => source.NullCheck("The source cannot be null.").Skip(start).Take(count);

        /// <summary>
        /// Throws an exception if the <see cref="IEnumerator{T}"/> is null or empty.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="source">The string to check for null and empty.</param>
        /// <param name="message">The optional message to throw if null or empty. Leaving it default will throw a default message.</param>
        public static IEnumerator<T> NullOrEmptyCheck<T>(this IEnumerator<T> source, string message = null) => (IEnumerator<T>)source.AsEnumerable().NullOrEmptyCheck(message);

        /// <summary>
        /// Reverses a list and returns the new list.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="source">The list to reverse.</param>
        /// <returns><paramref name="source"/> with the elements reversed.</returns>
        public static List<T> Rev<T>(this List<T> source)
        {
            source.NullCheck("The source cannot be null.").Reverse();
            return source;
        }
    }
}
