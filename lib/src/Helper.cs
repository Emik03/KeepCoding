using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using UnityEngine;
using Random = UnityEngine.Random;

namespace KeepCodingAndNobodyExplodes
{
    /// <summary>
    /// General extension class covering both KMFramework and native datatypes. Written by Emik.
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Contains the most commonly used flags, use this as a "catch-all" expression.
        /// </summary>
        public const BindingFlags Flags = BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

        /// <summary>
        /// The entire alphanumeric series, also known as base-62. From 0-9, A-Z, a-z.
        /// </summary>
        public const string Alphanumeric = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// The entire decimal series, also known as base-10. From 0-9.
        /// </summary>
        public const string Decimal = "0123456789";

        /// <summary>
        /// The entire binary series, also known as base-2. From 0-1.
        /// </summary>
        public const string Binary = "01";

        internal const string
            DumpTemplate = "[{0} #{1}]: <DUMP>{2}\n",
            Null = "<null>",
            Unknown = "<unknown>",
            VariableTemplate = "\n\n[{0}] {1}\n({2})\n{3}";

        /// <summary>
        /// Throws an exception if the <see cref="Array"/> is null or empty.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="array">The <see cref="Array"/> to check for null and empty.</param>
        /// <param name="message">The optional message to throw if null or empty. Leaving it default will throw a default message.</param>
        public static void AssertNotNullOrEmpty(this Array array, string message = null)
        {
            if (array is null)
                throw new NullIteratorException(message ?? $"While asserting for null or empty, the variable {nameof(array)} ended up being null.");

            if (array.Length == 0)
                throw new EmptyIteratorException(message ?? $"While asserting for null or empty, the variable {nameof(array)} ended up being null.");
        }

        /// <summary>
        /// Throws an exception if the <see cref="string"/> is null or empty.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="str">The string to check for null and empty.</param>
        /// <param name="message">The optional message to throw if null or empty. Leaving it default will throw a default message.</param>
        public static void AssertNotNullOrEmpty(this string str, string message = null)
        {
            if (str is null)
                throw new NullIteratorException(message ?? $"While asserting for null or empty, the variable {nameof(str)} ended up being null.");

            if (str.Length == 0)
                throw new EmptyIteratorException(message ?? $"While asserting for null or empty, the variable {nameof(str)} ended up being null.");
        }

        /// <summary>
        /// Converts any base number to base-10.
        /// </summary>
        /// <exception cref="FormatException"></exception>
        /// <param name="value">The value to convert.</param>
        /// <param name="baseChars">All of the base characters for the conversion from the base number, use <see cref="Alphanumeric"/> for Base-62, use <see cref="Decimal"/> for Base-10, use <see cref="Binary"/> for Base-2. The length of the array is the base number.</param>
        /// <returns><paramref name="value"/>, but in the base specified.</returns>
        public static long BaseToLong(this string value, string baseChars = Binary)
        {
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
                result += x * (long)Math.Pow(n, m--);
            }

            return result;
        }

        /// <summary>
        /// Converts any base-10 number to any base.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="baseChars">All of the base characters for the conversion to the base number, use <see cref="Alphanumeric"/> for Base-62, use <see cref="Decimal"/> for Base-10, use <see cref="Binary"/> for Base-2. The length of the array is the base number.</param>
        /// <returns><paramref name="value"/>, but in the base specified.</returns>
        public static string LongToBase(this long value, string baseChars = Alphanumeric)
        {
            long targetBase = baseChars.Length;

            char[] buffer = new char[Math.Max((int)Math.Ceiling(Math.Log(value + 1, targetBase)), 1)];

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
        /// Returns the name of a variable.
        /// </summary>
        /// <param name="e">The <see cref="Expression"/> which returns the object you want the name of.</param>
        /// <returns>The name of the variable, or if it cannot find it, <see cref="Unknown"/>.</returns>
        public static string NameOfVariable(this Expression<Func<object>> e)
        {
            try
            {
                return ((MemberExpression)e.Body).Member.Name;
            }
            catch (InvalidCastException)
            {
                return e.Compile()().ToString() ?? Unknown;
            }
        }

        /// <summary>
        /// Unwraps any object, whether it be a class, list, tuple, or any other data.
        /// </summary>
        /// <param name="item">The object to unwrap.</param>
        /// <param name="getVariables">Whether it should search inside the variable and yield return the elements inside <paramref name="item"/>.</param>
        /// <returns>An <see cref="object"/> <see cref="Array"/> of all elements within <paramref name="item"/>.</returns>
        public static object[] Unwrap(this object item, bool getVariables = false)
        {
            IEnumerable<object> Recursion(IEnumerable ienumerable)
            {
                foreach (object i in ienumerable)
                {
                    object[] array = i.Unwrap(getVariables);

                    foreach (object o in array)
                        yield return o;
                }
            }

            object[] @default = new object[] { item };

            return (item switch
            {
                null => new object[] { Null },
                string => @default,
                Tuple tuple => Recursion(tuple.ToArray),
                IEnumerable ienumerable => Recursion(ienumerable),
                IEnumerator ienumerator => Recursion(ienumerator.ToIEnumerable()),
                _ => getVariables ? item.GetAllValues().Prepend(item) : @default,
            }).ToArray();
        }

        /// <summary>
        /// Gets all fields and properties of the item using reflection.
        /// </summary>
        /// <param name="item">The item to get all fields and properties.</param>
        /// <returns>All fields and properties of <paramref name="item"/>.</returns>
        public static IEnumerable<object> GetAllValues(this object item)
        {
            foreach (var descriptor in item?.GetType()?.GetFields(Flags))
                yield return $"\n{descriptor} (Field): {descriptor?.GetValue(item) ?? Null}";

            foreach (var descriptor in item?.GetType()?.GetProperties(Flags))
                yield return $"\n{descriptor} (Property): {descriptor?.GetValue(item, null) ?? Null}";
        }

        /// <summary>
        /// Sets or replaces the value of a dictionary with a given function.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <typeparam name="T">Type of the key of the dictionary.</typeparam>
        /// <param name="source">Dictionary to operate on.</param>
        /// <param name="key">Key at which the list is located in the dictionary.</param>
        /// <param name="func">The function that returns the new value.</param>
        /// <returns>The new value at the specified key.</returns>
        public static int SetOrReplace<T>(this IDictionary<T, int> source, T key, Func<int, int> func)
        {
            if (source is null)
                throw new ArgumentNullException("source");

            if (key is null)
                throw new ArgumentNullException("key", "Null values cannot be used for keys in dictionaries.");

            return source[key] = func(source.ContainsKey(key) ? source[key] : default);
        }

        /// <summary>
        /// Invokes a method of <typeparamref name="T"/> and then returns the argument provided.
        /// </summary>
        /// <remarks>
        /// This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.
        /// </remarks>
        /// <typeparam name="T">The type of <paramref name="item"/> and <paramref name="action"/>.</typeparam>
        /// <param name="item">The item to use as reference and modify.</param>
        /// <param name="action">The action to apply it to.</param>
        /// <returns>The item <paramref name="item"/>.</returns>
        public static T Call<T>(this T item, Action<T> action)
        {
            action(item);
            return item;
        }

        /// <summary>
        /// Invokes a method of <typeparamref name="T"/> and then returns the argument provided.
        /// </summary>
        /// <remarks>
        /// This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.
        /// </remarks>
        /// <typeparam name="T">The type of <paramref name="items"/> and <paramref name="action"/>.</typeparam>
        /// <param name="items">The item to use as reference and modify.</param>
        /// <param name="action">The action to apply it to.</param>
        /// <returns>The item <paramref name="items"/>.</returns>
        public static T[] Call<T>(this T[] items, Action<T, int> action)
        {
            if (items is null)
                throw new NullIteratorException($"The variable {nameof(items)} cannot be null.");

            for (int i = 0; i < items.Length; i++)
                action(items[i], i);
            return items;
        }

        /// <summary>
        /// Returns the first element which doesn't return null, or null if all of them return null.
        /// </summary>
        /// <typeparam name="T">The type of array, and method.</typeparam>
        /// <param name="source">The array to iterate on.</param>
        /// <param name="func">The method which returns</param>
        /// <returns>The first value from <paramref name="source"/> where <paramref name="func"/> doesn't return null, or null.</returns>
        public static T FirstValue<T>(this IEnumerable<T> source, Func<T, T> func) where T : class
        {
            if (source is null)
                throw new NullIteratorException($"The variable {nameof(source)} cannot be null.");

            foreach (var v in source)
            {
                var t = func(v);

                if (t is null)
                    continue;

                return t;
            }

            return null;
        }

        /// <summary>
        /// Returns the last element which doesn't return null, or null if all of them return null.
        /// </summary>
        /// <typeparam name="T">The type of array, and method.</typeparam>
        /// <param name="source">The array to iterate on.</param>
        /// <param name="func">The method which returns</param>
        /// <returns>The last value from <paramref name="source"/> where <paramref name="func"/> doesn't return null, or null.</returns>
        public static T LastValue<T>(this IEnumerable<T> source, Func<T, T> func) where T : class
        {
            if (source is null)
                throw new NullIteratorException($"The variable {nameof(source)} cannot be null.");

            for (int i = source.GetUpperBound(); i >= 0; i--)
            {
                var t = func(source.ElementAt(i));

                if (t is null)
                    continue;

                return t;
            }

            return null;
        }

        /// <summary>
        /// Returns the element of an array, pretending that the array wraps around or is circular.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="source">The array itself.</param>
        /// <param name="i">The index, which will wrap around if it's larger than the array.</param>
        /// <returns>The element in <paramref name="source"/> using <paramref name="i"/> with rem-euclid modulo.</returns>
        public static T ElementAtWrap<T>(this IEnumerable<T> source, int i)
        {
            int count = source is null
                ? throw new NullIteratorException($"The variable {nameof(source)} cannot be null.")
                : source.Count();

            return count == 0
                ? throw new EmptyIteratorException($"The variable {nameof(source)} cannot be empty.")
                : source.ElementAt(i.Modulo(count));
        }

        /// <summary>
        /// Reverses a list and returns the new list.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="source">The list to reverse.</param>
        /// <returns><paramref name="source"/> with the elements reversed.</returns>
        public static List<T> Backwards<T>(this List<T> source)
        {
            if (source is null)
                throw new NullIteratorException($"The variable {nameof(source)} cannot be null.");

            source.Reverse();
            return source;
        }

        /// <summary>
        /// Replaces an index in the <see cref="IEnumerable{T}"/> and returns the new one.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="IEnumerable"/>.</typeparam>
        /// <param name="source">The initial source.</param>
        /// <param name="index">The index to change.</param>
        /// <param name="value">The value to replace at <paramref name="source"/>'s <paramref name="index"/> element.</param>
        /// <returns><paramref name="source"/> but the <paramref name="index"/> element is <paramref name="value"/> instead.</returns>
        public static IEnumerable<T> Replace<T>(this IEnumerable<T> source, int index, T value)
        {
            if (source is null)
                throw new NullIteratorException($"The variable {nameof(source)} cannot be null.");

            int current = 0;

            foreach (var item in source)
            {
                yield return current == index ? value : item;
                current++;
            }
        }

        /// <summary>
        /// Converts an <see cref="IEnumerator"/> to an <see cref="IEnumerable"/>.
        /// </summary>
        /// <param name="enumerator">The <see cref="IEnumerator"/> to convert.</param>
        /// <returns><paramref name="enumerator"/> as an <see cref="IEnumerable"/>.</returns>
        public static IEnumerable ToIEnumerable(this IEnumerator enumerator)
        {
            while (enumerator.MoveNext())
                yield return enumerator.Current;
        }

        /// <summary>
        /// Converts an <see cref="IEnumerator"/> to an <see cref="IEnumerable"/>.
        /// </summary>
        /// <typeparam name="T">The parameter and return type.</typeparam>
        /// <param name="enumerator">The <see cref="IEnumerator"/> to convert.</param>
        /// <returns><paramref name="enumerator"/> as an <see cref="IEnumerable"/>.</returns>
        public static IEnumerable<T> ToIEnumerable<T>(this IEnumerator<T> enumerator)
        {
            while (enumerator.MoveNext())
                yield return enumerator.Current;
        }

        /// <summary>
        /// Returns a slice of an <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of the <paramref name="source"/> and return type.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to take a slice of.</param>
        /// <param name="start">The starting index of the slice.</param>
        /// <param name="count">The amount of items to take.</param>
        /// <returns>A slice of <paramref name="source"/> based on <paramref name="start"/> and <paramref name="count"/>.</returns>
        public static IEnumerable<T> Slice<T>(this IEnumerable<T> source, int start, int count)
        {
            if (source is null)
                throw new NullIteratorException($"The variable {nameof(source)} cannot be null.");

            return source.Skip(start).Take(count);
        }

        /// <summary>
        /// Gets the method info from an expression.
        /// </summary>
        /// <typeparam name="T">The type of the action.</typeparam>
        /// <param name="expression">The expression that retrieves the method.</param>
        /// <returns>The method info of the function.</returns>
        public static MethodInfo GetMethodInfo<T>(this Expression<Action<T>> expression) => expression.Body is MethodCallExpression member ? member.Method : throw new ArgumentException("Expression is not a method", "expression");

        /// <summary>
        /// Determines if the current game object has a component of a specific type.
        /// </summary>
        /// <remarks>
        /// This uses <see cref="GameObject.GetComponent{T}"/>, meaning that the component must be part of the same game object for this to return true.
        /// </remarks>
        /// <typeparam name="T">The type of component to find.</typeparam>
        /// <param name="obj">The game object to search with.</param>
        /// <returns>True if a component has been found of type <typeparamref name="T"/> from <paramref name="obj"/>.</returns>
        public static bool HasComponent<T>(this GameObject obj) where T : Component => obj.GetComponent<T>() is not null;

        /// <summary>
        /// Determines if the index is pointing to null in any way.
        /// </summary>
        /// <param name="array">The array to index with.</param>
        /// <param name="index">The index.</param>
        /// <returns>True if <paramref name="array"/> is null, if <paramref name="index"/> is out of range, or if the element is null.</returns>
        public static bool IsIndexNull<T>(this T[] array, int index) => array is null || index >= array.Length || index < 0 || array[index] is null;

        /// <summary>
        /// Determines whether the number is equal or in-between 2 values.
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="min">The minimum value required to return true.</param>
        /// <param name="max">The maximum value required to return true.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <paramref name="min"/> and less than or equal <paramref name="max"/>.</returns>
        public static bool IsInRange(this int comparison, int min, int max) => comparison >= min && comparison <= max;

        /// <summary>
        /// Determines whether the number is equal or in-between 2 values.
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="min">The minimum value required to return true.</param>
        /// <param name="max">The maximum value required to return true.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <paramref name="min"/> and less than or equal <paramref name="max"/>.</returns>
        public static bool IsInRange(this float comparison, float min, float max) => comparison >= min && comparison <= max;

        /// <summary>
        /// Determines if the <see cref="Array"/> is null or empty.
        /// </summary>
        /// <param name="array">The <see cref="Array"/> to check for.</param>
        /// <returns>True if the <paramref name="array"/> is equal to null, or empty.</returns>
        public static bool IsNullOrEmpty(this Array array) => array is null || array.Length == 0;

        /// <summary>
        /// Determines if the string is null or empty.
        /// </summary>
        /// <param name="str">The string to check for.</param>
        /// <returns>True if <paramref name="str"/> is equal to null, or empty.</returns>
        public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);

        /// <summary>
        /// Determines if the <see cref="IEnumerable{T}"/> is null or empty.
        /// </summary>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to check for.</param>
        /// <returns>True if <paramref name="source"/> is equal to null, or empty.</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source) => source is null || source.Count() == 0;

        /// <summary>
        /// Determines if the <see cref="KMSelectable"/> is a parent of another <see cref="KMSelectable"/>.
        /// </summary>
        /// <param name="kmSelectable">This is required to check the children field.</param>
        /// <returns>True if <see cref="KMSelectable.Children"/> is empty.</returns>
        public static bool IsParent(this KMSelectable kmSelectable) => kmSelectable.Children.Length > 0;

        /// <summary>
        /// Generates a random boolean.
        /// </summary>
        /// <remarks>
        /// As this uses <see cref="Random"/>, you may not use this in a constructor. Use it in <c>Awake()</c> or <c>Start()</c> in that case.
        /// </remarks>
        /// <param name="weighting">The odds of the boolean being true.</param>
        /// <returns>A random boolean, with probability based off of <paramref name="weighting"/>.</returns>
        public static bool RandomBoolean(float weighting = 0.5f) => Random.Range(0, 1f) < weighting;

        /// <summary>
        /// Generates a random set of booleans.
        /// </summary>
        /// <remarks>
        /// As this uses <see cref="Random"/>, you may not use this in a constructor. Use it in <c>Awake()</c> or <c>Start()</c> in that case.
        /// </remarks>
        /// <param name="length">The length of the array.</param>
        /// <param name="weighting">The odds of the boolean being true.</param>
        /// <returns>Random boolean array of length <paramref name="length"/>, with probability based off of <paramref name="weighting"/>.</returns>
        public static bool[] RandomBooleans(this int length, float weighting = 0.5f) => Enumerable.Range(0, length).Select(b => RandomBoolean(weighting)).ToArray();

        /// <summary>
        /// Converts a character to a number.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="source">The character to convert.</param>
        /// <returns><paramref name="source"/> as <see cref="byte"/>.</returns>
        public static byte ToNumber(this char source) => char.IsDigit(source) ? (byte)char.GetNumericValue(source) : throw new UnrecognizedValueException($"Character must be a number: {source}");

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

        /// <summary>
        /// Gets the digital root of the number, which is obtained by repeatedly getting the sum of all digits until 1 digit remains.
        /// </summary>
        /// <param name="number">The number to get the digital root of.</param>
        /// <returns>The digital root of <paramref name="number"/>.</returns>
        public static int DigitalRoot(this int number) => ((number - 1) % 9) + 1;

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
        /// Returns the length of the array, or if null, the default value 0.
        /// </summary>
        /// <param name="array">The array to check its length.</param>
        /// <returns><paramref name="array"/>'s length, or 0.</returns>
        public static int LengthOrDefault(this Array array) => array is not null ? array.Length : default;

        /// <summary>
        /// Counts the number of members in an enum.
        /// </summary>
        /// <typeparam name="T">The enum to check the length for.</typeparam>
        /// <returns>The number of members in <typeparamref name="T"/>.</returns>
        public static int MemberCount<T>() where T : struct, Enum, IConvertible => Enum.GetNames(typeof(T)).Length;

        /// <summary>
        /// Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.
        /// </summary>
        /// <param name="number">The left-hand side operator</param>
        /// <param name="modulo">The right-hand side operator.</param>
        /// <returns><paramref name="number"/> mod <paramref name="modulo"/>.</returns>
        public static int Modulo(this int number, int modulo) => ((number % modulo) + modulo) % modulo;

        /// <summary>
        /// Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.
        /// </summary>
        /// <param name="number">The left-hand side operator</param>
        /// <param name="modulo">The right-hand side operator.</param>
        /// <returns><paramref name="number"/> mod <paramref name="modulo"/>.</returns>
        public static float Modulo(this float number, float modulo) => ((number % modulo) + modulo) % modulo;

        /// <summary>
        /// Parses each element of an array into a number. If it succeeds it returns the integer array, if it fails then it returns null.
        /// </summary>
        /// <param name="ts">The array to convert to an integer.</param>
        /// <param name="min">The minimum acceptable value of any given index. (inclusive)</param>
        /// <param name="max">The maximum acceptable value of any given index. (inclusive)</param>
        /// <param name="minLength">The minimum acceptable length of the array. (inclusive)</param>
        /// <param name="maxLength">The maximum acceptable length of the array. (inclusive)</param>
        /// <returns>The array as integers, or null if it fails.</returns>
        public static int[] ToNumbers<T>(this T[] ts, int? min = null, int? max = null, int? minLength = null, int? maxLength = null) => (minLength is null || minLength.Value <= ts.Length) && (maxLength is null || maxLength.Value >= ts.Length) && ts.All(t => int.TryParse(t.ToString(), out int i) && (min is null || min.Value <= i) && (max is null || max.Value >= i)) ? ts.Select(t => int.Parse(t.ToString())).ToArray() : null;

        /// <summary>
        /// Generates a random set of integers.
        /// </summary>
        /// <remarks>
        /// As this uses <see cref="Random"/>, you may not use this in a constructor. Use it in <c>Awake()</c> or <c>Start()</c> in that case.
        /// </remarks>
        /// <param name="min">The minimum value for each index. (inclusive)</param>
        /// <param name="max">The maximum value for each index. (exclusive)</param>
        /// <param name="length">The length of the array.</param>
        /// <returns>Random integer array of length <paramref name="length"/> between <paramref name="min"/> and <paramref name="max"/>.</returns>
        public static int[] Ranges(int min, int max, int length) => Enumerable.Range(0, length).Select(i => i = Random.Range(min, max)).ToArray();

        /// <summary>
        /// Generates a random set of floats.
        /// </summary>
        /// <remarks>
        /// As this uses <see cref="Random"/>, you may not use this in a constructor. Use it in <c>Awake()</c> or <c>Start()</c> in that case.
        /// </remarks>
        /// <param name="min">The minimum value for each index. (inclusive)</param>
        /// <param name="max">The maximum value for each index. (inclusive)</param>
        /// <param name="length">The length of the array.</param>
        /// <returns>Random float array of length <paramref name="length"/> between <paramref name="min"/> and <paramref name="max"/>.</returns>
        public static float[] Ranges(float min, float max, int length) => new float[length].Select(i => i = Random.Range(min, max)).ToArray();

        /// <summary>
        /// Converts any base number to any base.
        /// </summary>a
        /// <param name="value">The value to convert.</param>
        /// <param name="fromBaseChars">All of the base characters for the conversion from the base number, use <see cref="Alphanumeric"/> for Base-62, use <see cref="Decimal"/> for Base-10, use <see cref="Binary"/> for Base-2. The length of the array is the base number.</param>
        /// <param name="toBaseChars">All of the base characters for the conversion to the base number, use <see cref="Alphanumeric"/> for Base-62, use <see cref="Decimal"/> for Base-10, use <see cref="Binary"/> for Base-2. The length of the array is the base number.</param>
        /// <returns><paramref name="value"/>, but in the base specified.</returns>
        public static string Base(this string value, string fromBaseChars = Binary, string toBaseChars = Alphanumeric) => LongToBase(BaseToLong(value, fromBaseChars), toBaseChars);

        /// <summary>
        /// Converts any base number to any base.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="fromBaseNumber">Which base it currently is.</param>
        /// <param name="toBaseNumber">Which base to convert it to.</param>
        /// <returns>The integer, but in the base specified.</returns>
        public static string Base(this string value, int fromBaseNumber, int toBaseNumber) => value.Base(new string(Alphanumeric.Take(fromBaseNumber).ToArray()), new(Alphanumeric.Take(toBaseNumber).ToArray()));

        /// <summary>
        /// Converts any base number to any base-10.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="baseNumber">Which base it currently is.</param>
        /// <returns>The integer, but in the base specified.</returns>
        public static long BaseToLong(this string value, int baseNumber) => value.BaseToLong(new string(Alphanumeric.Take(baseNumber).ToArray()));

        /// <summary>
        /// Converts any base-10 number to any base.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="baseNumber">Which base to convert it to.</param>
        /// <returns>The integer, but in the base specified.</returns>
        public static string LongToBase(this long value, int baseNumber) => value.LongToBase(new string(Alphanumeric.Take(baseNumber).ToArray()));

        /// <summary>
        /// Formats the string. Shorthand for <see cref="string.Format(string, object[])"/>.
        /// </summary>
        /// <param name="str">The string to format. Typically with placeholders involving {0}, {1}, {2}...</param>
        /// <param name="args">All of the arguments to put into <paramref name="str"/>.</param>
        /// <returns>The formatted <see cref="string"/>.</returns>
        public static string Form(this string str, params object[] args) => string.Format(str, args);

        /// <summary>
        /// Converts a number to the ordinal as <see cref="string"/>.
        /// </summary>
        /// <param name="i">The number to convert to an ordinal.</param>
        /// <returns><paramref name="i"/> as an ordinal. (<see cref="string"/>)</returns>
        public static string ToOrdinal(this int i) => $"{(i < 0 ? "-" : "")}{i}" + (Math.Abs(i) / 10 % 10 == 1 ? 0 : Math.Abs(i) % 10) switch
        {
            1 => "st",
            2 => "nd",
            3 => "rd",
            _ => "th",
        };

        /// <summary>
        /// Unwraps any object, whether it be a class, list, tuple, or any other data and concatenates it into a string.
        /// </summary>
        /// <param name="item">The object to unwrap.</param>
        /// <param name="getVariables">Whether it should search recursively inside the variable and yield return the elements inside <paramref name="item"/>.</param>
        /// <param name="delimiter">The characters in-between each element.</param>
        /// <returns>A string consisting of all values from <paramref name="item"/>.</returns>
        public static string UnwrapToString(this object item, bool getVariables = false, string delimiter = ", ") => string.Join(delimiter, Unwrap(item, getVariables).Select(o => o.ToString()).ToArray());

        /// <summary>
        /// Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.
        /// </summary>
        /// <param name="item">The left-hand side operator.</param>
        /// <param name="bigInteger">The right-hand side operator.</param>
        /// <returns>Itself mod <paramref name="bigInteger"/>.</returns>
        public static BigInteger Modulo(this object item, BigInteger bigInteger) => ((item % bigInteger) + bigInteger) % bigInteger;

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

        /// <summary>
        /// Filters an <see cref="IEnumerable{T}"/>, only allowing duplicated items.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="IEnumerable{T}"/>.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to filter through.</param>
        /// <returns>A new instance of <paramref name="source"/> that only includes elements which are repeated in the array.</returns>
        public static IEnumerable<T> Indistinct<T>(this IEnumerable<T> source) => source.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key);

        /// <summary>
        /// Prepends the element provided to the <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The datatype of both the <see cref="IEnumerable{T}"/>.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to be modified.</param>
        /// <param name="item">The element to append to the <paramref name="source"/>.</param>
        /// <returns><paramref name="source"/>, but with an added <paramref name="item"/> as the first index.</returns>
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, T item) => new T[] { item }.Concat(source);

        /// <summary>
        /// Appends the element provided to the array.
        /// </summary>
        /// <typeparam name="T">The datatype of both the array and element.</typeparam>
        /// <param name="array">The array to be appended with.</param>
        /// <param name="item">The element to append to the <paramref name="array"/>.</param>
        /// <returns><paramref name="array"/>, but with an added <paramref name="item"/> as the last index.</returns>
        public static T[] Append<T>(this T[] array, T item) => (T[])array.Resize(array.Length + 1).Set(item, array.Length);

        /// <summary>
        /// Returns all elements of an enum as one array, in order.
        /// </summary>
        /// <typeparam name="T">The type of the enum.</typeparam>
        /// <returns>The enum as an array, ordered by smallest value to largest.</returns>
        public static T[] GetValues<T>() where T : struct, Enum, IConvertible => (T[])Enum.GetValues(typeof(T));

        /// <summary>
        /// Filters an array into elements that exist multiple times in <paramref name="source"/>.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="source"/>.</typeparam>
        /// <param name="source">The array to filter through.</param>
        /// <returns>A new array containing only duplicated items of <paramref name="source"/>.</returns>
        public static T[] Indistinct<T>(this T[] source) => source.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToArray();

        /// <summary>
        /// Prepends the element provided to the array.
        /// </summary>
        /// <typeparam name="T">The datatype of both the array and element.</typeparam>
        /// <param name="array">The array to be appended with.</param>
        /// <param name="item">The element to append to the <paramref name="array"/>.</param>
        /// <returns><paramref name="array"/>, but with an added <paramref name="item"/> as the first index.</returns>
        public static T[] Prepend<T>(this T[] array, T item) => (T[])array.Resize(array.Length + 1).Copy(0, array, 1, array.Length).Set(item, 0);

        /// <summary>
        /// Converts arguments to a new tuple.
        /// </summary>
        /// <typeparam name="T">The type of tuple.</typeparam>
        /// <param name="item1">The argument to pass into the tuple.</param>
        /// <returns>A new <see cref="Tuple{T}"/> containing <paramref name="item1"/>.</returns>
        public static Tuple<T> ToTuple<T>(this T item1) => new Tuple<T>(item1);

        /// <summary>
        /// Converts arguments to a new tuple.
        /// </summary>
        /// <typeparam name="T1">The first type of the tuple.</typeparam>
        /// <typeparam name="T2">The second type of the tuple.</typeparam>
        /// <param name="item1">The first argument to pass into the tuple.</param>
        /// <param name="item2">The second argument to pass into the tuple.</param>
        /// <returns>A new <seealso cref="Tuple{T1, T2}"/> containing <paramref name="item1"/> and <paramref name="item2"/></returns>
        public static Tuple<T1, T2> ToTuple<T1, T2>(this T1 item1, T2 item2) => new Tuple<T1, T2>(item1, item2);

        /// <summary>
        /// Converts arguments to a new tuple.
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
        /// Converts arguments to a new tuple.
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
    }
}
