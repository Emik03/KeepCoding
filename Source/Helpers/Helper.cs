using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using KeepCoding.Internal;
using UnityEngine;
using static System.Int32;
using static System.Linq.Enumerable;
using static System.Math;
using static System.Reflection.BindingFlags;
using static System.String;
using static UnityEngine.Debug;
using Object = UnityEngine.Object;
using SRandom = System.Random;
using URandom = UnityEngine.Random;

namespace KeepCoding
{
    /// <summary>
    /// General extension class covering both KMFramework and native datatypes.
    /// </summary>
    public static class Helper
    {
#if !LITE
        /// <summary>
        /// The entire English alphabet in Uppercase. From A-Z.
        /// </summary>
        public const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
#endif

        /// <summary>
        /// The entire alphanumeric series, also known as base-62. From 0-9, A-Z, a-z.
        /// </summary>
#if LITE
        public
#else
        internal
#endif
            const string Alphanumeric = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

#if !LITE
        /// <summary>
        /// The entire binary series, also known as base-2. From 0-1.
        /// </summary>
        public const string Binary = "01";

        /// <summary>
        /// The entire decimal series, also known as base-10. From 0-9.
        /// </summary>
        public const string Decimal = "0123456789";
#endif

        /// <summary>
        /// Contains the most commonly used flags, use this as a "catch-all" expression.
        /// </summary>
#if LITE
        public
#else
        internal
#endif
             const BindingFlags Flags = DeclaredOnly | Instance | Static | Public | NonPublic;

        internal const string Null = "null";

#if !LITE
        /// <summary>
        /// Determines if the current game object has a component of a specific type.
        /// </summary>
        /// <remarks>
        /// This uses <see cref="GameObject.GetComponent{T}"/>, meaning that the component must be part of the same game object for this to return true.
        /// </remarks>
        /// <typeparam name="T">The type of component to find.</typeparam>
        /// <param name="obj">The game object to search with.</param>
        /// <param name="component">The variable to store the component in.</param>
        /// <returns>True if a component has been found of type <typeparamref name="T"/> from <paramref name="obj"/>.</returns>
        [CLSCompliant(false)]
        public static bool HasComponent<T>(this GameObject obj, out T component) where T : Component => (component = obj.GetComponent<T>()) is T;
#endif

        /// <summary>
        /// Determines if a <see langword="class"/> implements a given method.
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> to check all <see cref="MethodInfo"/>s.</typeparam>
        /// <param name="_">The discard to get the <see cref="Type"/>.</param>
        /// <param name="method">The method to get.</param>
        /// <param name="flags">The <see cref="BindingFlags"/> to use in <see cref="Type.GetMethod(string, BindingFlags)"/>.</param>
        /// <returns><see langword="true"/> if <typeparamref name="T"/> has <paramref name="method"/>.</returns>
#if LITE
        internal
#else
        public
#endif
            static bool ImplementsMethod<T>(this T _, string method, BindingFlags flags = Flags) => ImplementsMethod<T>(method, flags);

        /// <summary>
        /// Determines if a <see langword="class"/> implements a given method.
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> to check all <see cref="MethodInfo"/>s.</typeparam>
        /// <param name="method">The method to get.</param>
        /// <param name="flags">The <see cref="BindingFlags"/> to use in <see cref="Type.GetMethod(string, BindingFlags)"/>.</param>
        /// <returns><see langword="true"/> if <typeparamref name="T"/> has <paramref name="method"/>.</returns>
#if LITE
        internal
#else
        public
#endif
            static bool ImplementsMethod<T>(this string method, BindingFlags flags = Flags) => ImplementsMethod(typeof(T), method, flags);

        /// <summary>
        /// Determines if a <see langword="class"/> implements a given method.
        /// </summary>
        /// <param name="type">The type to check all <see cref="MethodInfo"/>s.</param>
        /// <param name="method">The method to get.</param>
        /// <param name="flags">The <see cref="BindingFlags"/> to use in <see cref="Type.GetMethod(string, BindingFlags)"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="type"/> has <paramref name="method"/>.</returns>
#if LITE
        internal
#else
        public
#endif
            static bool ImplementsMethod(this Type type, string method, BindingFlags flags = Flags) => type.GetMethods(flags).Any(s => s.Name == method);

        /// <summary>
        /// Determines whether <paramref name="item"/> is equal to any items in <paramref name="comparisons"/>.
        /// </summary>
        /// <typeparam name="T">The type of both parameters, and the type to use equality for.</typeparam>
        /// <param name="item">The type of the initial item to compare.</param>
        /// <param name="comparisons">The <see cref="Array"/> of items to compare to.</param>
        /// <returns><see langword="true"/> if any of the items in <paramref name="comparisons"/> is equal to <paramref name="item"/>.</returns>
#if LITE
        internal
#else
        public
#endif
            static bool IsAny<T>(this T item, params T[] comparisons) => comparisons.Contains(item);

#if !LITE
        /// <summary>
        /// Determines whether <paramref name="item"/> is equal to all items in <paramref name="comparisons"/>.
        /// </summary>
        /// <typeparam name="T">The type of both parameters, and the type to use equality for.</typeparam>
        /// <param name="item">The type of the initial item to compare.</param>
        /// <param name="comparisons">The <see cref="Array"/> of items to compare to.</param>
        /// <returns><see langword="true"/> if all items in <paramref name="comparisons"/> is equal to <paramref name="item"/>.</returns>
        public static bool IsAll<T>(this T item, params T[] comparisons) => comparisons.All(t => t is null ? item is null : t.Equals(item));
#endif

        /// <summary>
        /// Determines whether the number is equal or in-between 2 values.
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="min">The minimum value required to return <see langword="true"/>.</param>
        /// <param name="max">The maximum value required to return <see langword="true"/>.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <paramref name="min"/> and less than or equal <paramref name="max"/>.</returns>
        public static bool IsBetween(this char comparison, char min, char max) => comparison >= min && comparison <= max;

#if !LITE
        /// <summary>
        /// Determines whether the number is equal or in-between a tuple's <see cref="Tuple{T}.Item1"/> (minimum) and <see cref="Tuple{T1, T2}.Item2"/> (maximum).
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="range">The minimum and maximum value required to return <see langword="true"/>.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <see cref="Tuple{T}.Item1"/> and less than or equal <see cref="Tuple{T1, T2}.Item2"/>.</returns>
        public static bool IsBetween(this char comparison, Tuple<char, char> range) => comparison >= range.Item1 && comparison <= range.Item2;
#endif

        /// <summary>
        /// Determines whether the number is equal or in-between 2 values.
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="min">The minimum value required to return <see langword="true"/>.</param>
        /// <param name="max">The maximum value required to return <see langword="true"/>.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <paramref name="min"/> and less than or equal <paramref name="max"/>.</returns>
        public static bool IsBetween(this int comparison, int min, int max) => comparison >= min && comparison <= max;

#if !LITE
        /// <summary>
        /// Determines whether the number is equal or in-between a tuple's <see cref="Tuple{T}.Item1"/> (minimum) and <see cref="Tuple{T1, T2}.Item2"/> (maximum).
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="range">The minimum and maximum value required to return <see langword="true"/>.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <see cref="Tuple{T}.Item1"/> and less than or equal <see cref="Tuple{T1, T2}.Item2"/>.</returns>
        public static bool IsBetween(this int comparison, Tuple<int, int> range) => comparison >= range.Item1 && comparison <= range.Item2;
#endif

        /// <summary>
        /// Determines whether the number is equal or in-between 2 values.
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="min">The minimum value required to return <see langword="true"/>.</param>
        /// <param name="max">The maximum value required to return <see langword="true"/>.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <paramref name="min"/> and less than or equal <paramref name="max"/>.</returns>
        public static bool IsBetween(this float comparison, float min, float max) => comparison >= min && comparison <= max;

#if !LITE
        /// <summary>
        /// Determines whether the number is equal or in-between a tuple's <see cref="Tuple{T}.Item1"/> (minimum) and <see cref="Tuple{T1, T2}.Item2"/> (maximum).
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="range">The minimum and maximum value required to return <see langword="true"/>.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <see cref="Tuple{T}.Item1"/> and less than or equal <see cref="Tuple{T1, T2}.Item2"/>.</returns>
        public static bool IsBetween(this float comparison, Tuple<float, float> range) => comparison >= range.Item1 && comparison <= range.Item2;

        /// <summary>
        /// Determines whether the number is equal or in-between 2 values.
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="min">The minimum value required to return <see langword="true"/>.</param>
        /// <param name="max">The maximum value required to return <see langword="true"/>.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <paramref name="min"/> and less than or equal <paramref name="max"/>.</returns>
        public static bool IsBetween(this long comparison, long min, long max) => comparison >= min && comparison <= max;

        /// <summary>
        /// Determines whether the number is equal or in-between a tuple's <see cref="Tuple{T}.Item1"/> (minimum) and <see cref="Tuple{T1, T2}.Item2"/> (maximum).
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="range">The minimum and maximum value required to return <see langword="true"/>.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <see cref="Tuple{T}.Item1"/> and less than or equal <see cref="Tuple{T1, T2}.Item2"/>.</returns>
        public static bool IsBetween(this long comparison, Tuple<long, long> range) => comparison >= range.Item1 && comparison <= range.Item2;
        /// <summary>
        /// Determines whether the number is equal or in-between 2 values.
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="min">The minimum value required to return <see langword="true"/>.</param>
        /// <param name="max">The maximum value required to return <see langword="true"/>.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <paramref name="min"/> and less than or equal <paramref name="max"/>.</returns>
        [CLSCompliant(false)]
        public static bool IsBetween(this uint comparison, uint min, uint max) => comparison >= min && comparison <= max;

        /// <summary>
        /// Determines whether the number is equal or in-between a tuple's <see cref="Tuple{T}.Item1"/> (minimum) and <see cref="Tuple{T1, T2}.Item2"/> (maximum).
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="range">The minimum and maximum value required to return <see langword="true"/>.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <see cref="Tuple{T}.Item1"/> and less than or equal <see cref="Tuple{T1, T2}.Item2"/>.</returns>
        [CLSCompliant(false)]
        public static bool IsBetween(this uint comparison, Tuple<uint, uint> range) => comparison >= range.Item1 && comparison <= range.Item2;

        /// <summary>
        /// Determines whether the number is equal or in-between 2 values.
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="min">The minimum value required to return <see langword="true"/>.</param>
        /// <param name="max">The maximum value required to return <see langword="true"/>.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <paramref name="min"/> and less than or equal <paramref name="max"/>.</returns>
        [CLSCompliant(false)]
        public static bool IsBetween(this ulong comparison, ulong min, ulong max) => comparison >= min && comparison <= max;

        /// <summary>
        /// Determines whether the number is equal or in-between a tuple's <see cref="Tuple{T}.Item1"/> (minimum) and <see cref="Tuple{T1, T2}.Item2"/> (maximum).
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="range">The minimum and maximum value required to return <see langword="true"/>.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <see cref="Tuple{T}.Item1"/> and less than or equal <see cref="Tuple{T1, T2}.Item2"/>.</returns>
        [CLSCompliant(false)]
        public static bool IsBetween(this ulong comparison, Tuple<ulong, ulong> range) => comparison >= range.Item1 && comparison <= range.Item2;

        /// <summary>
        /// Determines if the index is pointing to null in any way.
        /// </summary>
        /// <param name="source">The array to index with.</param>
        /// <param name="index">The index.</param>
        /// <returns>True if <paramref name="source"/> is null, if <paramref name="index"/> is out of range, or if the element is null.</returns>
        public static bool IsIndexNull<T>(this IEnumerable<T> source, int index) => source is null || !index.IsBetween(0, source.GetUpperBound()) || source.ElementAt(index) is null;

        /// <summary>
        /// Determines if the item is an iterator type.
        /// </summary>
        /// <param name="item">The item to check the type for.</param>
        /// <returns><paramref name="item"/> is either <see cref="IEnumerable"/>, or <see cref="IEnumerator"/>.</returns>
        public static bool IsIterator<T>(this T item) => item is IEnumerable || item is IEnumerator;

        /// <summary>
        /// Determines if the string is null or empty.
        /// </summary>
        /// <param name="str">The string to check for.</param>
        /// <returns>True if <paramref name="str"/> is equal to null, or empty.</returns>
        public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);
#endif

        /// <summary>
        /// Determines if the <see cref="IEnumerable{T}"/> is null or empty.
        /// </summary>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to check for.</param>
        /// <returns>True if <paramref name="source"/> is equal to null, or empty.</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source) => source is null || !source.Any();

#if !LITE
        /// <summary>
        /// Determines if the <see cref="IEnumerator{T}"/> is null or empty.
        /// </summary>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to check for.</param>
        /// <returns>True if <paramref name="source"/> is equal to null, or empty.</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerator<T> source) => source is null || !source.AsEnumerable().Any();
#endif

        /// <summary>
        /// Determines if the <see cref="KMSelectable"/> is a parent of another <see cref="KMSelectable"/>.
        /// </summary>
        /// <param name="kmSelectable">This is required to check the children field.</param>
        /// <returns>True if <see cref="KMSelectable.Children"/> is empty.</returns>
#if LITE
        internal
#else
        [CLSCompliant(false)]
        public
#endif
            static bool IsParent(this KMSelectable kmSelectable) => !kmSelectable.Children.IsNullOrEmpty();

#if !LITE
        /// <summary>
        /// Generates a random boolean.
        /// </summary>
        /// <remarks>
        /// As this uses <see cref="URandom"/>, you may not use this in a constructor. Use it in <c>Awake()</c> or <c>Start()</c> in that case.
        /// </remarks>
        /// <param name="weighting">The odds of the boolean being true.</param>
        /// <returns>A random boolean, with probability based off of <paramref name="weighting"/>.</returns>
        public static bool RandomBoolean(float weighting = 0.5f) => URandom.Range(0, 1f) < weighting;

        /// <summary>
        /// Creates an <see cref="Array"/> of random boolean values.
        /// </summary>
        /// <remarks>
        /// As this uses <see cref="URandom"/>, you may not use this in a constructor. Use it in <c>Awake()</c> or <c>Start()</c> in that case.
        /// </remarks>
        /// <param name="length">The length of the array.</param>
        /// <param name="weighting">The odds of the boolean being true.</param>
        /// <returns>An array of random booleans of length <paramref name="length"/>, with probability based off of <paramref name="weighting"/>.</returns>
        /// <returns>An <see cref="Array"/> of <see cref="bool"/> in which each index is randomly <see langword="true"/> or <see langword="false"/> based on <paramref name="weighting"/>.</returns>
        public static bool[] RandomBooleans(this int length, float weighting = 0.5f) => Range(length).Select(i => RandomBoolean(weighting)).ToArray();
#endif

        /// <summary>
        /// Converts a character to a number.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="source">The character to convert.</param>
        /// <returns><paramref name="source"/> as <see cref="byte"/>.</returns>
        public static byte ToNumber(this char source) => char.IsDigit(source) ? (byte)(source - '0') : throw new UnrecognizedValueException($"Character must be a number: {source}");

        /// <summary>
        /// Converts a character to lowercase.
        /// </summary>
        /// <param name="source">The character to convert.</param>
        /// <returns><paramref name="source"/> as lowercase.</returns>
        public static char ToLower(this char source) => char.ToLowerInvariant(source);

        /// <summary>
        /// Converts a character to uppercase.
        /// </summary>
        /// <param name="source">The character to convert.</param>
        /// <returns><paramref name="source"/> as uppercase.</returns>
        public static char ToUpper(this char source) => char.ToUpperInvariant(source);

#if !LITE
        /// <summary>
        /// Gets the digital root of the number, which is obtained by repeatedly getting the sum of all digits until 1 digit remains.
        /// </summary>
        /// <param name="number">The number to get the digital root of.</param>
        /// <returns>The digital root of <paramref name="number"/>.</returns>
        public static int DigitalRoot(this int number) => (number - 1) % 9 + 1;

        /// <summary>
        /// Returns the last index of the string.
        /// </summary>
        /// <param name="str">The string to check length for.</param>
        /// <returns><see cref="string.Length"/> - 1</returns>
        public static int GetUpperBound(this string str) => str.IsNullOrEmpty() ? throw new FormatException("The string is null or empty, meaning that the upper bound doesn't exist.") : str.Length - 1;

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
        public static int LengthOrDefault<T>(this IEnumerable<T> source) => source is null ? default : source.Count();

        /// <summary>
        /// Counts the number of members in an enum.
        /// </summary>
        /// <typeparam name="T">The enum to check the length for.</typeparam>
        /// <returns>The number of members in <typeparamref name="T"/>.</returns>
        public static int MemberCount<T>() where T : struct, Enum => Enum.GetValues(typeof(T)).Length;
#endif

        /// <summary>
        /// Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.
        /// </summary>
        /// <exception cref="DivideByZeroException"></exception>
        /// <param name="number">The left-hand side operator</param>
        /// <param name="modulo">The right-hand side operator.</param>
        /// <returns><paramref name="number"/> mod <paramref name="modulo"/>.</returns>
        public static int Modulo(this int number, int modulo) => (number %= modulo) < 0 == modulo > 0 ? number + modulo : number;

#if !LITE
        /// <summary>
        /// Generates a random set of integers.
        /// </summary>
        /// <remarks>
        /// As this uses <see cref="URandom"/>, you may not use this in a constructor. Use it in <c>Awake()</c> or <c>Start()</c> in that case.
        /// </remarks>
        /// <param name="length">The length of the array.</param>
        /// <param name="min">The minimum value for each index. (inclusive)</param>
        /// <param name="max">The maximum value for each index. (exclusive)</param>
        /// <returns>Random integer array of length <paramref name="length"/> between <paramref name="min"/> and <paramref name="max"/>.</returns>
        public static int[] Ranges(this int length, int min, int max) => Range(length).Select(i => URandom.Range(min, max)).ToArray();

        /// <summary>
        /// Generates a random set of integers.
        /// </summary>
        /// <remarks>
        /// As this uses <see cref="URandom"/>, you may not use this in a constructor. Use it in <c>Awake()</c> or <c>Start()</c> in that case.
        /// </remarks>
        /// <param name="length">The length of the array.</param>
        /// <param name="range">The minimum (inclusive) and maximum (exclusive) values.</param>
        /// <returns>Random integer array of length <paramref name="length"/> between <paramref name="range"/>'s values.</returns>
        public static int[] Ranges(this int length, Tuple<int, int> range) => Range(length).Select(i => URandom.Range(range.Item1, range.Item2)).ToArray();
#endif

        /// <summary>
        /// Parses each element of an array into a number. If it succeeds it returns the integer array, if it fails then it returns null.
        /// </summary>
        /// <param name="ts">The array to convert to an integer.</param>
        /// <param name="min">The minimum acceptable value of any given index. (inclusive)</param>
        /// <param name="max">The maximum acceptable value of any given index. (inclusive)</param>
        /// <param name="minLength">The minimum acceptable length of the array. (inclusive)</param>
        /// <param name="maxLength">The maximum acceptable length of the array. (inclusive)</param>
        /// <returns>The array as integers, or null if it fails.</returns>
        public static int[] ToNumbers<T>(this T[] ts, int? min = null, int? max = null, int? minLength = null, int? maxLength = null) where T : notnull => (minLength is null || minLength.Value <= ts.Length) && (maxLength is null || maxLength.Value >= ts.Length) && ts.All(t => TryParse(t.ToString(), out int i) && (min is null || min.Value <= i) && (max is null || max.Value >= i)) ? ts.Select(t => Parse(t.ToString())).ToArray() : null;

        /// <summary>
        /// Converts any base number to any base-10.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="baseNumber">Which base it currently is.</param>
        /// <returns>The integer, but in the base specified.</returns>
        public static long BaseToLong(this string value, int baseNumber) => value.BaseToLong(new string(Alphanumeric.Take(baseNumber).ToArray()));

        /// <summary>
        /// Converts any base number to base-10.
        /// </summary>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="value">The value to convert.</param>
        /// <param name="baseChars">All of the base characters for the conversion from the base number, use <see cref="Alphanumeric"/> for Base-62, use <see cref="Decimal"/> for Base-10, use <see cref="Binary"/> for Base-2. The length of the array is the base number.</param>
        /// <returns><paramref name="value"/>, but in the base specified.</returns>
        public static long BaseToLong(this string value, string baseChars)
        {
            value.NullCheck($"{nameof(value)} cannot be null when converting bases.");

            baseChars.NullCheck($"{nameof(baseChars)} cannot be null when converting bases.");

            if (value.Any(c => !baseChars.Contains(c)))
                throw new FormatException($"The value provided {value} contains at least 1 or more characters not part of the character list {baseChars}.");

            var dictionary = baseChars.Select((c, i) => new { Char = c, Index = i }).ToDictionary(c => c.Char, c => c.Index);

            char[] chrs = value.ToCharArray();

            int m = chrs.Length - 1,
                n = baseChars.Length,
                x;

            long result = 0;

            for (int i = 0; i < chrs.Length; i++)
            {
                x = dictionary[chrs[i]];
                result += x * (long)Pow(n, m--);
            }

            return result;
        }

        /// <summary>
        /// Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.
        /// </summary>
        /// <exception cref="DivideByZeroException"></exception>
        /// <param name="number">The left-hand side operator</param>
        /// <param name="modulo">The right-hand side operator.</param>
        /// <returns><paramref name="number"/> mod <paramref name="modulo"/>.</returns>
        public static float Modulo(this float number, float modulo) => (number %= modulo) < 0 == modulo > 0 ? number + modulo : number;

#if !LITE
        /// <summary>
        /// Generates a random set of floats.
        /// </summary>
        /// <remarks>
        /// As this uses <see cref="URandom"/>, you may not use this in a constructor. Use it in <c>Awake()</c> or <c>Start()</c> in that case.
        /// </remarks>
        /// <param name="length">The length of the array.</param>
        /// <param name="min">The minimum value for each index. (inclusive)</param>
        /// <param name="max">The maximum value for each index. (inclusive)</param>
        /// <returns>Random float array of length <paramref name="length"/> between <paramref name="min"/> and <paramref name="max"/>.</returns>
        public static float[] Ranges(this int length, float min, float max) => Enumerable.Range(0, length).Select(i => URandom.Range(min, max)).ToArray();

        /// <summary>
        /// Generates a random set of integers.
        /// </summary>
        /// <remarks>
        /// As this uses <see cref="URandom"/>, you may not use this in a constructor. Use it in <c>Awake()</c> or <c>Start()</c> in that case.
        /// </remarks>
        /// <param name="length">The length of the array.</param>
        /// <param name="range">The minimum (inclusive) and maximum (exclusive) values.</param>
        /// <returns>Random integer array of length <paramref name="length"/> between <paramref name="range"/>'s values.</returns>
        public static float[] Ranges(this int length, Tuple<float, float> range) => Enumerable.Range(0, length).Select(i => URandom.Range(range.Item1, range.Item2)).ToArray();
#endif

        /// <summary>
        /// Converts any base number to any base.
        /// </summary>a
        /// <param name="value">The value to convert.</param>
        /// <param name="fromBaseChars">All of the base characters for the conversion from the base number, use <see cref="Alphanumeric"/> for Base-62, use <see cref="Decimal"/> for Base-10, use <see cref="Binary"/> for Base-2. The length of the array is the base number.</param>
        /// <param name="toBaseChars">All of the base characters for the conversion to the base number, use <see cref="Alphanumeric"/> for Base-62, use <see cref="Decimal"/> for Base-10, use <see cref="Binary"/> for Base-2. The length of the array is the base number.</param>
        /// <returns><paramref name="value"/>, but in the base specified.</returns>
        public static string Base(this string value, string fromBaseChars, string toBaseChars) => LongToBase(BaseToLong(value, fromBaseChars), toBaseChars);

        /// <summary>
        /// Converts any base number to any base.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="fromBaseNumber">Which base it currently is.</param>
        /// <param name="toBaseNumber">Which base to convert it to.</param>
        /// <returns>The integer, but in the base specified.</returns>
        public static string Base(this string value, int fromBaseNumber, int toBaseNumber) => value.Base(new string(Alphanumeric.Take(fromBaseNumber).ToArray()), new string(Alphanumeric.Take(toBaseNumber).ToArray()));

        /// <summary>
        /// Conbines the iterator into one long <see cref="string"/>.
        /// </summary>
        /// <typeparam name="T">The type of the <paramref name="source"/>.</typeparam>
        /// <param name="source">The iterator.</param>
        /// <param name="delimiter">The separator between each element.</param>
        /// <returns>A <see cref="string"/> representing all elements in <paramref name="source"/> with the separator <paramref name="delimiter"/>.</returns>
        public static string Combine<T>(this T source, string delimiter = ", ") => source switch
        {
            string s => s,
            IEnumerable enumerable => Join(delimiter, enumerable.Cast<object>().Select(o => Combine(o, delimiter)).ToArray()),
            IEnumerator enumerator => Combine(AsEnumerable(enumerator)),
            _ => source?.ToString() ?? ""
        };

        /// <summary>
        /// Finds a file name within a list of directories, or <see langword="null"/> if none is found.
        /// </summary>
        /// <param name="directories">The list of directories.</param>
        /// <param name="file">The file to search for.</param>
        /// <returns>The directory containing the path to the file searched for, or <see langword="null"/>.</returns>
#if LITE
        internal
#else
        public
#endif
            static string Find(this List<string> directories, string file) => directories.FirstOrDefault(x => Directory.GetFiles(x, file).Any());

#if !LITE
        /// <summary>
        /// Formats the string. Shorthand for <see cref="string.Format(string, object[])"/>.
        /// </summary>
        /// <param name="str">The string to format. Typically with placeholders involving {0}, {1}, {2}...</param>
        /// <param name="args">All of the arguments to put into <paramref name="str"/>.</param>
        /// <returns>The formatted <see cref="string"/>.</returns>
        public static string Form(this string str, params object[] args) => Format(str, args.Select(o => o.Combine()).ToArray());
#endif

        /// <summary>
        /// Replaces whitespace characters with line breaks based on the line length.
        /// </summary>
        /// <remarks>
        /// This can be useful to prevent a <see cref="TextMesh"/> from going outside its boundaries. A monospaced font is recommended in this case.
        /// </remarks>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="NegativeNumberException"></exception>
        /// <param name="condition">The string to insert line breaks with.</param>
        /// <param name="maxLineLength">The maximum number of characters in one line.</param>
        /// <returns><paramref name="condition"/> with a line break every <paramref name="maxLineLength"/> or less characters.</returns>
        public static string InsertNewlines(this string condition, int maxLineLength)
        {
            if (maxLineLength < 0)
                throw new NegativeNumberException($"{nameof(maxLineLength)} must be a positive integer.");

            if (maxLineLength is 0)
                throw new FormatException($"{nameof(maxLineLength)} cannot be 0 because that would insert infinite linebreaks for each character.");

            condition = condition.NullCheck("Line breaks cannot be inserted in a null string.").Replace('\n', ' ');

            var builder = new StringBuilder(condition);
            int floor = -1;

            for (int i = maxLineLength - 1; i <= builder.Length; i--)
            {
                if (floor >= i)
                {
                    floor += maxLineLength;
                    i = floor + maxLineLength;

                    builder.Insert(floor, "\n");
                    continue;
                }

                if (char.IsWhiteSpace(builder[i]))
                {
                    builder[i] = '\n';

                    floor = i + 1;
                    i += maxLineLength;
                }
            }

            return builder.ToString();
        }

        /// <summary>
        /// Converts any base-10 number to any base.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="value">The value to convert.</param>
        /// <param name="baseChars">All of the base characters for the conversion to the base number, use <see cref="Alphanumeric"/> for Base-62, use <see cref="Decimal"/> for Base-10, use <see cref="Binary"/> for Base-2. The length of the array is the base number.</param>
        /// <returns><paramref name="value"/>, but in the base specified.</returns>
        public static string LongToBase(this long value, string baseChars)
        {
            baseChars.NullCheck($"{nameof(baseChars)} cannot be null when converting bases.");

            long targetBase = baseChars.Length;

            char[] buffer = new char[Max((int)Ceiling(Log(value + 1, targetBase)), 1)];

            int i = buffer.Length;

            do
            {
                buffer[--i] = baseChars[(int)(value % targetBase)];
                value /= targetBase;
            }
            while (value > 0);

            return new string(buffer, i, buffer.Length - i);
        }

        /// <summary>
        /// Converts any base-10 number to any base.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="baseNumber">Which base to convert it to.</param>
        /// <returns>The integer, but in the base specified.</returns>
        public static string LongToBase(this long value, int baseNumber) => value.LongToBase(new string(Alphanumeric.Take(baseNumber).ToArray()));

        /// <summary>
        /// Gets the assembly name where a <see cref="Type"/> comes from.
        /// </summary>
        /// <param name="type">The type to get the assembly name from.</param>
        /// <returns>The <see cref="Assembly"/> name from <paramref name="type"/>.</returns>
#if LITE
        public
#else
        internal
#endif
            static string NameOfAssembly(this Type type) => type.Assembly.GetName().Name;

#if !LITE
        /// <summary>
        /// Throws an exception if the <see cref="string"/> is null or empty.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="source">The string to check for null and empty.</param>
        /// <param name="message">The optional message to throw if null or empty. Leaving it default will throw a default message.</param>
        public static string NullOrEmptyCheck(this string source, string message = null) => source.NullCheck(message ?? $"While asserting for null or empty, the variable ended up being null.").Length is 0 ? throw new EmptyIteratorException(message ?? $"While asserting for null or empty, the variable ended up being empty.") : source;
#endif

        /// <summary>
        /// Reverses a string.
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="source">The string to reverse.</param>
        /// <returns><paramref name="source"/> where contents are oredered backwards.</returns>
        public static string Reverse(this string source) => source is { } ?
#if LITE
            new string(source.ToCharArray().Reverse().ToArray())
#else
            new string(source.ToCharArray().Reverse())
#endif
            : throw new NullReferenceException($"The source cannot be null.");

#if !LITE
        /// <summary>
        /// Splits the <see cref="string"/> based on the separator.
        /// </summary>
        /// <param name="source">The <see cref="string"/> of characters to split by.</param>
        /// <param name="separator">The separator to split <paramref name="source"/> by.</param>
        /// <returns>An <see cref="Array"/> where each index is where <paramref name="separator"/> was found in <paramref name="source"/>.</returns>
        public static string[] Split(this string source, string separator) => source.Split(new string[] { separator }, StringSplitOptions.None);
#endif

        /// <summary>
        /// Converts <paramref name="source"/> into a <see cref="string"/> representation of <paramref name="source"/>.
        /// </summary>
        /// <remarks>
        /// Unlike <see cref="object.ToString"/>, the individual items inside <paramref name="source"/> if it is an iterator is deconstructed.
        /// </remarks>
        /// <typeparam name="T">The format of the string.</typeparam>
        /// <param name="source">The item to represent as a <see cref="string"/></param>
        /// <param name="format">Determines how it is formatted.</param>
        /// <returns><paramref name="source"/> as a <see cref="string"/>.</returns>
        public static string Stringify<T>(this T source, StringifyFormat format = null)
        {
            static string Recursion(IEnumerable enumerable, string join, StringifyFormat format) => Join(join, enumerable
                .Cast<object>()
                .Select(o => Stringify(o, format))
                .ToArray());

            format ??= new StringifyFormat();

            return source switch
            {
                null => format.NullArg,
                bool b => b ? format.TrueArg : format.FalseArg,
                char c => $"{format.CharIndicator}{c}{format.CharIndicator}",
                string s => $"{format.StringIndicator}{s}{format.StringIndicator}",
                float f => f.ToString(format.DecimalFormat),
                double d => d.ToString(format.DecimalFormat),
                decimal de => de.ToString(format.DecimalFormat),
#if !LITE
                Tuple tuple => $"{format.TupleStart}{Recursion(tuple.Items, format.TupleSeparator, format)}{format.TupleEnd}",
#endif
                IDictionary dictionary => $"{format.DictionaryStart}{Join(format.DictionarySeparator, AsEnumerable(dictionary.GetEnumerator()).Cast<object>().Select(o => $"{Stringify(((DictionaryEntry)o).Key)}{format.KeyValuePairSeparator}{Stringify(((DictionaryEntry)o).Value)}").ToArray())}{format.DictionaryEnd}",
                IEnumerable enumerable => $"{format.ArrayStart}{Recursion(enumerable, format.ArraySeparator, format)}{format.ArrayEnd}",
                IEnumerator enumerator => Stringify(AsEnumerable(enumerator)),
                _ => source.ToString()
            };
        }

        /// <summary>
        /// Converts a number to the ordinal as <see cref="string"/>.
        /// </summary>
        /// <param name="i">The number to convert to an ordinal.</param>
        /// <returns><paramref name="i"/> as an ordinal. (<see cref="string"/>)</returns>
        public static string ToOrdinal(this int i) => $"{(i < 0 ? "-" : "")}{i}" + (Abs(i) / 10 % 10 == 1 ? 0 : Abs(i) % 10) switch
        {
            1 => "st",
            2 => "nd",
            3 => "rd",
            _ => "th",
        };

        /// <summary>
        /// Gets the appropriate log method depending on the type of <see cref="LogType"/>.
        /// </summary>
        /// <param name="logType">The type of method to get.</param>
        /// <returns>The log method representing the enum <paramref name="logType"/>.</returns>
#if LITE
        internal
#else
        [CLSCompliant(false)]
        public
#endif
            static Action<object> Method(this LogType logType) => logType switch
        {
            LogType.Error => LogError,
            LogType.Assert => o => LogAssertion(o),
            LogType.Warning => LogWarning,
            LogType.Log => Log,
            LogType.Exception => o => LogException((Exception)o),
            _ => throw new UnrecognizedValueException($"{logType} is not a valid log type."),
        };

        /// <summary>
        /// Stops the coroutines only if they aren't <see langword="null"/>.
        /// </summary>
        /// <param name="monoBehaviour">The <see cref="MonoBehaviour"/> instance needed to stop coroutines.</param>
        /// <param name="coroutines">The <see cref="Coroutine"/>s to stop.</param>
        /// <returns>The array of <see cref="Coroutine"/>s given.</returns>
        [CLSCompliant(false)]
        public static Coroutine[] Stop(this MonoBehaviour monoBehaviour, params Coroutine[] coroutines) => coroutines?.ForEach((Coroutine c) =>
        {
            if (c is { })
                monoBehaviour.StopCoroutine(c);
        });

#if !LITE
        /// <summary>
        /// Gets the appropriate <see cref="Exception"/> based on the data type.
        /// </summary>
        /// <param name="item">The item to check the type for.</param>
        /// <returns><see cref="NullIteratorException"/> if <paramref name="item"/> is an iterator, evaluated with <see cref="IsIterator{T}(T)"/>, otherwise <see cref="NullReferenceException"/></returns>
        public static Func<string, Exception> GetNullException<T>(this T item) => s => item.IsIterator() ? (Exception)new NullIteratorException(s) : new NullReferenceException(s);
#endif

        /// <summary>
        /// Converts an <see cref="IEnumerator"/> to an <see cref="IEnumerable"/>.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="source">The <see cref="IEnumerator"/> to convert.</param>
        /// <returns><paramref name="source"/> as an <see cref="IEnumerable"/>.</returns>
        public static IEnumerable AsEnumerable(this IEnumerator source)
        {
            source.NullCheck("The enumerator cannot be null.");

            while (source.MoveNext())
                yield return source.Current;
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> spanning from 0 to the number specified - 1.
        /// </summary>
        /// <param name="count">The length of the <see cref="IEnumerable"/>.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> from 0 to <paramref name="count"/> - 1.</returns>
        public static IEnumerable<int> Range(this int count) => Enumerable.Range(0, count);

#if !LITE
        /// <summary>
        /// Gets all fields and properties of the item using reflection.
        /// </summary>
        /// <param name="source">The item to get all fields and properties.</param>
        /// <returns>All fields and properties of <paramref name="source"/>.</returns>
        public static IEnumerable<string> ReflectAll<T>(this T source) => source?.GetType().GetFields(Flags).Select(f => $"\n{f} (Field): {f?.GetValue(source).Stringify()}").Concat(source?.GetType().GetProperties(Flags).Select(p => $"\n{p} (Property): {p?.GetValue(source, null).Stringify()}")) ?? Empty<string>();
#endif

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

#if !LITE
        /// <summary>
        /// Appends the element provided to the <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The datatype of both the <see cref="IEnumerable{T}"/> and element.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to be modified.</param>
        /// <param name="item">The element to append to the <paramref name="source"/>.</param>
        /// <returns><paramref name="source"/>, but with an added <paramref name="item"/> as the last index.</returns>
        public static IEnumerable<T> Append<T>(this IEnumerable<T> source, T item) => source.Concat(new T[] { item });

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
#endif

        /// <summary>
        /// Filters an <see cref="IEnumerable{T}"/>, only allowing duplicated items.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="IEnumerable{T}"/>.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to filter through.</param>
        /// <returns>A new instance of <paramref name="source"/> that only includes elements which are repeated in the array.</returns>
        public static IEnumerable<T> Indistinct<T>(this IEnumerable<T> source) => source.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key);

#if !LITE
        /// <summary>
        /// Prepends the element provided to the <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The datatype of both the <see cref="IEnumerable{T}"/>.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to be modified.</param>
        /// <param name="item">The element to append to the <paramref name="source"/>.</param>
        /// <returns><paramref name="source"/>, but with an added <paramref name="item"/> as the first index.</returns>
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, T item) => new T[] { item }.Concat(source);
#endif

        /// <summary>
        /// Shuffles a collection of items using <see cref="URandom"/>.
        /// </summary>
        /// <typeparam name="T">The type of <see cref="IEnumerable{T}"/> to shuffle.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to shuffle.</param>
        /// <returns><paramref name="source"/> in a random order.</returns>
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source) => source.Randomize(URandom.Range);

        /// <summary>
        /// Shuffles a collection of items using a specified <see cref="SRandom"/>.
        /// </summary>
        /// <typeparam name="T">The type of <see cref="IEnumerable{T}"/> to shuffle.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to shuffle.</param>
        /// <param name="rng">The <see cref="SRandom"/> to generate numbers by.</param>
        /// <returns><paramref name="source"/> in a random order.</returns>
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source, SRandom rng) => source.Randomize(rng.Next);

        /// <summary>
        /// Shuffles a collection of items using a user-specified algorithm.
        /// </summary>
        /// <typeparam name="T">The type of <see cref="IEnumerable{T}"/> to shuffle.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to shuffle.</param>
        /// <param name="randomizer">The method to take the current and maximum indices, and return a new number to swap the current with.</param>
        /// <returns><paramref name="source"/> in a random order.</returns>
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source, Func<int, int, int> randomizer)
        {
            randomizer.NullCheck("The randomiser cannot be null.");

            var buffer = source.NullCheck("The source cannot be null.").ToList();

            for (int i = 0; i < buffer.Count; i++)
            {
                int j = randomizer(i, buffer.Count);

                yield return j.IsBetween(0, buffer.Count - 1) ? buffer[j] : throw new IndexOutOfRangeException($"The method provided returned a number that was out of range. Range: 0-{buffer.Count - 1}, returned value: {j}.");

                buffer[j] = buffer[i];
            }
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> where each element is the return of a <see cref="Func{TResult}"/>.
        /// </summary>
        /// <exception cref="NegativeNumberException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of the <see cref="Func{TResult}"/> as well as the return.</typeparam>
        /// <param name="times">The amount of times to run the method.</param>
        /// <param name="func">The encapsulated method to return for each value.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of length <paramref name="times"/> where each element is the return of <paramref name="func"/>.</returns>
        public static IEnumerable<T> Repeat<T>(this int times, Func<T> func)
        {
            func.NullCheck("The function cannot be null.");

            if (times < 0)
                throw new NegativeNumberException("The number cannot be negative.");

            for (int i = 0; i < times; i++)
                yield return func();
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> where each element gets passed in an <see cref="int"/> in <see cref="Func{T, TResult}"/> and returns <typeparamref name="T"/>.
        /// </summary>
        /// <exception cref="NegativeNumberException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of the <see cref="Func{TResult}"/> as well as the return.</typeparam>
        /// <param name="times">The amount of times to run the method.</param>
        /// <param name="func">The encapsulated method to return for each value, passing in the index of the for-loop.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of length <paramref name="times"/> where each element is the return of <paramref name="func"/> after the index is passed in.</returns>
        public static IEnumerable<T> Repeat<T>(this int times, Func<int, T> func)
        {
            func.NullCheck("The function cannot be null.");

            if (times < 0)
                throw new NegativeNumberException("The number cannot be negative.");

            for (int i = 0; i < times; i++)
                yield return func(i);
        }

#if !LITE
        /// <summary>
        /// Replaces an index in the <see cref="IEnumerable{T}"/> and returns the new one.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <typeparam name="T">The type of the <see cref="IEnumerable"/>.</typeparam>
        /// <param name="source">The initial source.</param>
        /// <param name="index">The index to change.</param>
        /// <param name="value">The value to replace at <paramref name="source"/>'s <paramref name="index"/> element.</param>
        /// <returns><paramref name="source"/> but the <paramref name="index"/> element is <paramref name="value"/> instead.</returns>
        public static IEnumerable<T> Replace<T>(this IEnumerable<T> source, int index, T value) => source.NullCheck("The source cannot be null.").Select((t, i) => i == index ? value : t);

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
        /// Chops the <see cref="IEnumerable{T}"/> into multiple <see cref="IEnumerable{T}"/>s, based on the length provided.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of <paramref name="source"/>.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to split.</param>
        /// <param name="length">The length of each <see cref="IEnumerable{T}"/> within the containing <see cref="IEnumerable{T}"/>.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="IEnumerable{T}"/>s, where each <see cref="IEnumerable{T}"/> is as long as <paramref name="length"/>.</returns>
        public static IEnumerable<IEnumerable<T>> SplitEvery<T>(this IEnumerable<T> source, int length) => length > 0 ? source.NullCheck("The source cannot be null.").Select((item, inx) => new { item, inx }).GroupBy(x => x.inx / length).Select(g => g.Select(x => x.item)) : throw new ArgumentException($"The variable {nameof(length)} must be a positive number.");

        /// <summary>
        /// Produces a sequence of tuples with elements from the two specified sequences.
        /// </summary>
        /// <typeparam name="T1">The type of the elements of the first input sequence.</typeparam>
        /// <typeparam name="T2">The type of the elements of the second input sequence.</typeparam>
        /// <param name="first">The first sequence to merge.</param>
        /// <param name="second">The second sequence to merge.</param>
        /// <returns>A sequence of tuples with elements taken from the first and second sequences, in that order.</returns>
        public static IEnumerable<Tuple<T1, T2>> Zip<T1, T2>(this IEnumerable<T1> first, IEnumerable<T2> second) => Zip(first, second, (a, b) => a.ToTuple(b));

        /// <summary>
        /// Applies a specified function to the corresponding elements of two sequences, producing a sequence of the results.
        /// </summary>
        /// <typeparam name="T1">The type of the elements of the first input sequence.</typeparam>
        /// <typeparam name="T2">The type of the elements of the second input sequence.</typeparam>
        /// <typeparam name="TResult">The type of the elements of the result sequence.</typeparam>
        /// <param name="first">The first sequence to merge.</param>
        /// <param name="second">The second sequence to merge.</param>
        /// <param name="selector">A function that specifies how to merge the elements from the two sequences.</param>
        /// <exception cref="NullReferenceException"></exception>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains merged elements of two input sequences.</returns>
        public static IEnumerable<TResult> Zip<T1, T2, TResult>(this IEnumerable<T1> first, IEnumerable<T2> second, Func<T1, T2, TResult> selector)
        {
            selector.NullCheck("The selector cannot be null.");

            IEnumerator<T1> e1 = first.NullCheck("The first enumerator cannot be null.").GetEnumerator();
            IEnumerator<T2> e2 = second.NullCheck("The second enumerator cannot be null.").GetEnumerator();

            while (e1.MoveNext() & e2.MoveNext())
                yield return selector(e1.Current, e2.Current);
        }
#endif

        /// <summary>
        /// Flattens an <see cref="IEnumerator"/> such that nested <see cref="IEnumerator"/> calls get replaced with the output of those calls.
        /// </summary>
        /// <param name="source">The <see cref="IEnumerator"/> to flatten.</param>
        /// <param name="except">If <see langword="false"/>, <see cref="Flatten(IEnumerator, Predicate{IEnumerator})"/> gets called recursively and each item from that output gets returned individually, otherwise the item is simply returned.</param>
        /// <returns><paramref name="source"/> where <see langword="yield"/> <see langword="return"/> <see cref="IEnumerator"/>s gets replaced with the output of those calls.</returns>
        public static IEnumerator Flatten(this IEnumerator source, Predicate<IEnumerator> except = null)
        {
            except ??= _ => false;

            while (source.MoveNext())
            {
                object current = source.Current;

                if (current is IEnumerable enumerable)
                    current = enumerable.GetEnumerator();

                if (!(current is IEnumerator enumerator) || except(enumerator))
                {
                    yield return source.Current;
                    continue;
                }

                IEnumerator result = enumerator.Flatten(except);

                while (result.MoveNext())
                    yield return result.Current;
            }
        }

        /// <summary>
        /// Gives list of module names that are unsolved.
        /// </summary>
        /// <param name="bombInfo">The instance of <see cref="KMBombInfo"/> needed to get the modules.</param>
        /// <returns>A list of unsolved module names.</returns>
        [CLSCompliant(false)]
        public static List<string> GetUnsolvedModuleIDs(this KMBombInfo bombInfo)
        {
            List<string> modules = bombInfo.GetSolvableModuleIDs();
            bombInfo.GetSolvedModuleIDs().ForEach(m => modules.Remove(m));
            return modules;
        }

        /// <summary>
        /// Gives list of module names that are unsolved.
        /// </summary>
        /// <param name="bombInfo">The instance of <see cref="KMBombInfo"/> needed to get the modules.</param>
        /// <returns>A list of unsolved modules.</returns>
        [CLSCompliant(false)]
        public static List<string> GetUnsolvedModuleNames(this KMBombInfo bombInfo)
        {
            List<string> modules = bombInfo.GetSolvableModuleNames();
            bombInfo.GetSolvedModuleNames().ForEach(m => modules.Remove(m));
            return modules;
        }

#if !LITE
        /// <summary>
        /// Reverses a list and returns the new list.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="source">The list to reverse.</param>
        /// <returns><paramref name="source"/> with the elements reversed.</returns>
        public static List<T> Rev<T>(this List<T> source) => source.NullCheck("The source cannot be null.").Rev(0, source.Count);

        /// <summary>
        /// Reverses part of the list and returns the new list.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="source">The list to reverse.</param>
        /// <param name="index">The index to start from.</param>
        /// <param name="count">The amount of elements to reverse.</param>
        /// <returns><paramref name="source"/> with the elements reversed specified by <paramref name="index"/> and <paramref name="count"/>.</returns>
        public static List<T> Rev<T>(this List<T> source, int index, int count)
        {
            if (index < 0 || count < 0)
                throw new NegativeNumberException("Either arguments cannot be less than zero.");

            if (source.Count - index < count)
                throw new ArgumentOutOfRangeException($"The length of the list {source.Count} is not large enough to flip the {count} indices starting from {index}");

            source.NullCheck("The source cannot be null.").Reverse(index, count);

            return source;
        }
#endif

        /// <summary>
        /// Gets the method info from an expression.
        /// </summary>
        /// <typeparam name="T">The type of the action.</typeparam>
        /// <param name="expression">The expression that retrieves the method.</param>
        /// <returns>The method info of the function.</returns>
#if LITE
        internal
#else
        public
#endif
            static MethodInfo GetMethodInfo<T>(this Expression<Action<T>> expression) => expression.Body is MethodCallExpression member ? member.Method : throw new ArgumentException($"The expression {nameof(expression)} is not a method");

#if !LITE
        /// <summary>
        /// Splits an <see cref="IEnumerable"/> in two based on a method provided.
        /// </summary>
        /// <typeparam name="T">The type of the collection.</typeparam>
        /// <param name="source">The collection to split.</param>
        /// <param name="predicate">The method that decides where the item ends up.</param>
        /// <returns>A <see cref="Tuple{T1, T2}"/> consisting of items from <paramref name="source"/> where <see cref="Tuple{T}.Item1"/> contains items that returned true in <paramref name="predicate"/>, and <see cref="Tuple{T1, T2}.Item2"/> otherwise.</returns>
        public static Tuple<List<T>, List<T>> SplitBy<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            source.NullCheck("The enumerator cannot be null");

            List<T> t = new List<T>(),
                f = new List<T>();

            foreach (T item in source)
            {
                if (predicate(item))
                    t.Add(item);
                else
                    f.Add(item);
            }

            return t.ToTuple(f);
        }
#endif

        /// <summary>
        /// Throws am <see cref="AssertionException"/> if the <see cref="Object"/> given is <see langword="null"/>, then returning the <see cref="Object"/> <paramref name="obj"/>.
        /// </summary>
        /// <typeparam name="T">The type of <see cref="Object"/>.</typeparam>
        /// <param name="obj">The <see cref="Object"/> to do a <see langword="null"/> check on.</param>
        /// <returns><paramref name="obj"/></returns>
        [CLSCompliant(false)]
        public static T Assert<T>(this T obj) where T : Object => obj ? obj : throw new AssertionException(typeof(T).Name, obj, "not null");

        /// <summary>
        /// Throws an <see cref="AssertionException"/> if the argument passed in is <see langword="null"/>
        /// </summary>
        /// <typeparam name="T">The type of the item to assert for non-nullability.</typeparam>
        /// <param name="item">The item to use a <see langword="null"/> check on.</param>
        /// <param name="name">The name of <paramref name="item"/>.</param>
        /// <returns><paramref name="item"/></returns>
        public static T Assert<T>(this T item, string name = null) => item ?? throw new AssertionException(name, item, "not null");

        /// <summary>
        /// Throws an <see cref="AssertionException"/> if the method passed in <see langword="return"/>s <see langword="false"/>.
        /// </summary>
        /// <typeparam name="T">The type of the initial comparison.</typeparam>
        /// <param name="item">The item to pass into the method.</param>
        /// <param name="assertion">The assertion, <see langword="true"/> indicates success and will <see langword="return"/> <paramref name="item"/>, <see langword="false"/> will throw an <see cref="AssertionException"/>.</param>
        /// <param name="name">The name of <paramref name="item"/>.</param>
        /// <param name="expect">The string representation of what <paramref name="assertion"/> does and expects.</param>
        /// <returns><paramref name="item"/></returns>
        public static T Assert<T>(this T item, Predicate<T> assertion, string name = null, string expect = "assertion predicate to return true") => assertion(item) ? item : throw new AssertionException(name, item, expect);

        /// <summary>
        /// Throws an <see cref="AssertionException"/> if both arguments passed in <see langword="return"/> <see langword="false"/> on <see cref="object.Equals(object)"/>.
        /// </summary>
        /// <typeparam name="T">The type of the initial comparison.</typeparam>
        /// <typeparam name="TOther">The type of the item to compare.</typeparam>
        /// <param name="item">The item to use as comparison.</param>
        /// <param name="comparison">The item to compare to.</param>
        /// <param name="name">The name of <paramref name="item"/>.</param>
        /// <returns><paramref name="item"/></returns>
        public static T Assert<T, TOther>(this T item, TOther comparison, string name = null) => item.Equals(comparison) ? item : throw new AssertionException(name, item, comparison);

        /// <summary>
        /// Invokes a method of <typeparamref name="T"/> and then returns the argument provided.
        /// </summary>
        /// <remarks>
        /// This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.
        /// </remarks>
        /// <typeparam name="T">The type of <paramref name="item"/> and <paramref name="action"/>.</typeparam>
        /// <param name="item">The item to use as reference and modify.</param>
        /// <param name="action">The action to apply <paramref name="item"/> to.</param>
        /// <returns>The item <paramref name="item"/>.</returns>
        public static T Call<T>(this T item, Action<T> action)
        {
            action.NullCheck("The action cannot be null.")(item);
            return item;
        }

        /// <summary>
        /// Invokes a logging method and then returns the argument provided.
        /// </summary>
        /// <typeparam name="T">The type of logging.</typeparam>
        /// <param name="item">The item to log</param>
        /// <param name="logType">The type of logging.</param>
        /// <returns>The item <paramref name="item"/>.</returns>
        [CLSCompliant(false)]
        public static T Call<T>(this T item, LogType logType = LogType.Log) => item.Call(t => logType.Method()(t.Stringify()));

        /// <summary>
        /// Returns the element of an array, pretending that the array wraps around or is circular.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="source">The array itself.</param>
        /// <param name="index">The index, which will wrap around if it's larger than the array.</param>
        /// <returns>The element in <paramref name="source"/> using <paramref name="index"/> with rem-euclid modulo.</returns>
        public static T ElementAtWrap<T>(this IEnumerable<T> source, int index) => source.NullOrEmptyCheck($"The source cannot be null or empty.").ElementAt(index.Modulo(source.Count()));

#if !LITE
        /// <summary>
        /// Returns the first element which doesn't <see langword="return"/> <see langword="null"/>, or <see langword="null"/> if all of them <see langword="return"/> <see langword="null"/>.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of array, and method.</typeparam>
        /// <param name="source">The array to iterate on.</param>
        /// <returns>The first value from <paramref name="source"/> where it isn't <see langword="null"/>, or <see langword="null"/>.</returns>
        public static T FirstValue<T>(this IEnumerable<T> source) => source.NullCheck("The source cannot be null.").FirstOrDefault(t => t is T);

        /// <summary>
        /// Returns the first element which doesn't <see langword="return"/> <see langword="null"/>, or <see langword="null"/> if all of them <see langword="return"/> <see langword="null"/>.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of array, and method.</typeparam>
        /// <param name="source">The array to iterate on.</param>
        /// <param name="func">The method which returns something or <see langword="null"/>.</param>
        /// <returns>The first value from <paramref name="source"/> where <paramref name="func"/> doesn't return <see langword="null"/>, or <see langword="null"/>.</returns>
        public static T FirstValue<T>(this IEnumerable<T> source, Func<T, T> func) => source.NullCheck("The source cannot be null.").FirstOrDefault(t => func.NullCheck("The function cannot be null.")(t) is T);

        /// <summary>
        /// Returns the last element which doesn't <see langword="return"/> <see langword="null"/>, or <see langword="null"/> if all of them <see langword="return"/> <see langword="null"/>.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of array, and method.</typeparam>
        /// <param name="source">The array to iterate on.</param>
        /// <returns>The last value from <paramref name="source"/> where it isn't <see langword="null"/>, or <see langword="null"/>.</returns>
        public static T LastValue<T>(this IEnumerable<T> source) => source.Reverse().FirstValue();

        /// <summary>
        /// Returns the last element which doesn't <see langword="return"/> <see langword="null"/>, or <see langword="null"/> if all of them <see langword="null"/>return <see langword="null"/>.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of array, and method.</typeparam>
        /// <param name="source">The array to iterate on.</param>
        /// <param name="func">The method which returns something or <see langword="null"/>.</param>
        /// <returns>The last value from <paramref name="source"/> where <paramref name="func"/> doesn't <see langword="return"/> <see langword="null"/>, or <see langword="null"/>.</returns>
        public static T LastValue<T>(this IEnumerable<T> source, Func<T, T> func) => source.Reverse().FirstValue(func.NullCheck("The function cannot be null."));
#endif

        /// <summary>
        /// Throws a <see cref="NullReferenceException"/> or <see cref="NullIteratorException"/> if the parameter provided is null.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="item">The parameter to check null for.</param>
        /// <param name="message">The optional message to throw if null.</param>
        /// <returns><paramref name="item"/></returns>
#if LITE
        public
#else
        internal
#endif
            static T NullCheck<T>(this T item, string message = "While asserting for null, the variable ended up null.") => item is null ? throw
#if LITE
            new NullReferenceException(message)
#else
            GetNullException(item)(message)
#endif
            : item;

        /// <summary>
        /// Throws a <see cref="NullReferenceException"/> or <see cref="NullIteratorException"/> if the parameter provided is null.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="item">The parameter to check null for.</param>
        /// <param name="message">The optional message to throw if null.</param>
        /// <returns><paramref name="item"/></returns>
#if LITE
        public
#else
        internal
#endif
            static T NullCheck<T>(this T? item, string message = "While asserting for null, the variable ended up null.") where T : struct => item is null ? throw
#if LITE
            new NullReferenceException(message)
#else
            GetNullException(item)(message)
#endif
            : item.Value;

        /// <summary>
        /// Throws an exception if the <see cref="IEnumerable{T}"/> is null or empty.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="source">The <see cref="Array"/> to check for null and empty.</param>
        /// <param name="message">The optional message to throw if null or empty. Leaving it default will throw a default message.</param>
        public static T NullOrEmptyCheck<T>(this T source, string message = null) where T : IEnumerable => source.NullCheck(message ?? $"While asserting for null or empty, the variable ended up being null.").GetEnumerator().MoveNext() ? source : throw new EmptyIteratorException(message ?? $"While asserting for null or empty, the variable ended up being empty.");

        /// <summary>
        /// Throws an exception if the <see cref="IEnumerable{T}"/> is null or empty.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="source">The <see cref="Array"/> to check for null and empty.</param>
        /// <param name="message">The optional message to throw if null or empty. Leaving it default will throw a default message.</param>
        public static T NullOrEmptyCheck<T>(this T? source, string message = null) where T : struct, IEnumerable => source.NullCheck(message ?? $"While asserting for null or empty, the variable ended up being null.").GetEnumerator().MoveNext() ? source!.Value : throw new EmptyIteratorException(message ?? $"While asserting for null or empty, the variable ended up being empty.");

        /// <summary>
        /// Invokes a method of <typeparamref name="T"/> to <typeparamref name="TResult"/> and then returns the argument provided.
        /// </summary>
        /// <remarks>
        /// This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.
        /// </remarks>
        /// <typeparam name="T">The type of <paramref name="item"/>.</typeparam>
        /// <typeparam name="TResult">The type to return.</typeparam>
        /// <param name="item">The item to use as reference and modify.</param>
        /// <param name="func">The function to apply <paramref name="item"/> to.</param>
        /// <returns>The item <paramref name="item"/> after <paramref name="func"/>.</returns>
        public static TResult Apply<T, TResult>(this T item, Func<T, TResult> func) => func(item);

#if !LITE
        /// <summary>
        /// Appends the element provided to the array.
        /// </summary>
        /// <typeparam name="T">The datatype of both the array and element.</typeparam>
        /// <param name="array">The array to be appended with.</param>
        /// <param name="item">The element to append to the <paramref name="array"/>.</param>
        /// <returns><paramref name="array"/>, but with an added <paramref name="item"/> as the last index.</returns>
        public static T[] Append<T>(this T[] array, T item) where T : notnull => (T[])array.Resize(array.Length + 1).Set(item, array.Length);

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
        public static T[] Call<T>(this T[] source, Action<T, int> action) => source.Call(s => Enumerable.Range(0, s.Length).ForEach(i => action(s[i], i)));
#endif

        /// <summary>
        /// Gets all the values of an <see cref="Enum"/> as an <see cref="Array"/>.
        /// </summary>
        /// <typeparam name="T">The type of <see cref="Enum"/>.</typeparam>
        /// <returns>An <see cref="Array"/> of <typeparamref name="T"/> containing all the values of that enum.</returns>
        public static T[] GetValues<T>() where T : struct, Enum => (T[])Enum.GetValues(typeof(T));

        /// <summary>
        /// Gets all the values of an <see cref="Enum"/> as an <see cref="Array"/>.
        /// </summary>
        /// <typeparam name="T">The type of <see cref="Enum"/>.</typeparam>
        /// <param name="_">A discard value, which can implicitly let the method know the type.</param>
        /// <returns>An <see cref="Array"/> of <typeparamref name="T"/> containing all the values of that enum.</returns>
        public static T[] GetValues<T>(this T _) where T : struct, Enum => GetValues<T>();

#if !LITE
        /// <summary>
        /// Prepends the element provided to the array.
        /// </summary>
        /// <typeparam name="T">The datatype of both the array and element.</typeparam>
        /// <param name="array">The array to be appended with.</param>
        /// <param name="item">The element to append to the <paramref name="array"/>.</param>
        /// <returns><paramref name="array"/>, but with an added <paramref name="item"/> as the first index.</returns>
        public static T[] Prepend<T>(this T[] array, T item) where T : notnull => (T[])array.Resize(array.Length + 1).Copy(0, array, 1, array.Length).Set(item, 0);
#endif

        /// <summary>
        /// Sets or replaces the value of a dictionary with a given function.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="TKey">Type of the key of the dictionary.</typeparam>
        /// <typeparam name="TValue">Type of the value of the dictionary.</typeparam>
        /// <param name="source">Dictionary to operate on.</param>
        /// <param name="key">Key at which the list is located in the dictionary.</param>
        /// <param name="func">The function that returns the new value.</param>
        /// <returns>The new value at the specified key.</returns>
        public static TValue SetOrReplace<TKey, TValue>(this IDictionary<TKey, TValue> source, TKey key, Func<TValue, TValue> func) => key is null ? throw new NullReferenceException("The key cannot be null.") : source.NullCheck("The dictionary cannot be null.")[key] = func(source.ContainsKey(key) ? source[key] : default);

#if !LITE
        /// <summary>
        /// Invokes a method of <typeparamref name="T"/> to <typeparamref name="TResult"/> and then returns the argument provided.
        /// </summary>
        /// <remarks>
        /// This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.
        /// </remarks>
        /// <typeparam name="T">The type of <paramref name="items"/>.</typeparam>
        /// <typeparam name="TResult">The type to return.</typeparam>
        /// <param name="items">The item to use as reference and modify.</param>
        /// <param name="func">The function to apply <paramref name="items"/> to.</param>
        /// <returns>The item <paramref name="items"/> after <paramref name="func"/>.</returns>
        public static TResult[] Apply<T, TResult>(this T[] items, Func<T, int, TResult> func) => items.Select((i, n) => func(i, n)).ToArray();
#endif
    }
}
