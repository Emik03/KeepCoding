using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using UnityEngine;
using Random = UnityEngine.Random;

namespace KeepCoding
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
        /// Determines whether the number is equal or in-between 2 values.
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="min">The minimum value required to return true.</param>
        /// <param name="max">The maximum value required to return true.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <paramref name="min"/> and less than or equal <paramref name="max"/>.</returns>
        public static bool IsBetween(this int comparison, int min, int max) => comparison >= min && comparison <= max;

        /// <summary>
        /// Determines whether the number is equal or in-between 2 values.
        /// </summary>
        /// <param name="comparison">The number to use as comparison.</param>
        /// <param name="min">The minimum value required to return true.</param>
        /// <param name="max">The maximum value required to return true.</param>
        /// <returns>True if <paramref name="comparison"/> is more than or equal <paramref name="min"/> and less than or equal <paramref name="max"/>.</returns>
        public static bool IsBetween(this float comparison, float min, float max) => comparison >= min && comparison <= max;

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
        /// Determines if the item is an iterator type.
        /// </summary>
        /// <param name="item">The item to check the type for.</param>
        /// <returns><paramref name="item"/> is either <see cref="string"/>, <see cref="IEnumerable"/>, or <see cref="IEnumerator"/>.</returns>
        public static bool IsIterator(this object item) => item is string or IEnumerable or IEnumerator;

        /// <summary>
        /// Determines if the string is null or empty.
        /// </summary>
        /// <param name="str">The string to check for.</param>
        /// <returns>True if <paramref name="str"/> is equal to null, or empty.</returns>
        public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);

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
        /// Creates an <see cref="Array"/> of random boolean values.
        /// </summary>
        /// <remarks>
        /// As this uses <see cref="Random"/>, you may not use this in a constructor. Use it in <c>Awake()</c> or <c>Start()</c> in that case.
        /// </remarks>
        /// <param name="length">The length of the array.</param>
        /// <param name="weighting">The odds of the boolean being true.</param>
        /// <returns>An array of random booleans of length <paramref name="length"/>, with probability based off of <paramref name="weighting"/>.</returns>
        /// <returns></returns>
        public static bool[] RandomBooleans(this int length, float weighting = 0.5f) => Enumerable.Range(0, length).Select(i => Helper.RandomBoolean(weighting)).ToArray();

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
        /// Returns the length of the <see cref="IEnumerable{T}"/>, or if null, the default value 0.
        /// </summary>
        /// <param name="source">The <see cref="IEnumerable{T}"/> to check its length.</param>
        /// <returns><paramref name="source"/>'s length, or 0.</returns>
        public static int LengthOrDefault<T>(this IEnumerable<T> source) => source is not null ? source.Count() : default;

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
        /// Sets or replaces the value of a dictionary with a given function.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">Type of the key of the dictionary.</typeparam>
        /// <param name="source">Dictionary to operate on.</param>
        /// <param name="key">Key at which the list is located in the dictionary.</param>
        /// <param name="func">The function that returns the new value.</param>
        /// <returns>The new value at the specified key.</returns>
        public static int SetOrReplace<T>(this IDictionary<T, int> source, T key, Func<int, int> func) => source.NullCheck("The dictionary cannot be null.")[key.NullCheck("Null values cannot be used for keys in dictionaries.")] = func(source.ContainsKey(key) ? source[key] : default);

        /// <summary>
        /// Generates a random set of integers.
        /// </summary>
        /// <remarks>
        /// As this uses <see cref="Random"/>, you may not use this in a constructor. Use it in <c>Awake()</c> or <c>Start()</c> in that case.
        /// </remarks>
        /// <param name="length">The length of the array.</param>
        /// <param name="min">The minimum value for each index. (inclusive)</param>
        /// <param name="max">The maximum value for each index. (exclusive)</param>
        /// <returns>Random integer array of length <paramref name="length"/> between <paramref name="min"/> and <paramref name="max"/>.</returns>
        public static int[] Ranges(this int length, int min, int max) => Enumerable.Range(0, length).Select(i => Random.Range(min, max)).ToArray();

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
        /// Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.
        /// </summary>
        /// <param name="number">The left-hand side operator</param>
        /// <param name="modulo">The right-hand side operator.</param>
        /// <returns><paramref name="number"/> mod <paramref name="modulo"/>.</returns>
        public static float Modulo(this float number, float modulo) => ((number % modulo) + modulo) % modulo;

        /// <summary>
        /// Generates a random set of floats.
        /// </summary>
        /// <remarks>
        /// As this uses <see cref="Random"/>, you may not use this in a constructor. Use it in <c>Awake()</c> or <c>Start()</c> in that case.
        /// </remarks>
        /// <param name="length">The length of the array.</param>
        /// <param name="min">The minimum value for each index. (inclusive)</param>
        /// <param name="max">The maximum value for each index. (inclusive)</param>
        /// <returns>Random float array of length <paramref name="length"/> between <paramref name="min"/> and <paramref name="max"/>.</returns>
        public static float[] Ranges(this int length, float min, float max) => Enumerable.Range(0, length).Select(i => Random.Range(min, max)).ToArray();

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
        /// Converts any base number to base-10.
        /// </summary>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="value">The value to convert.</param>
        /// <param name="baseChars">All of the base characters for the conversion from the base number, use <see cref="Alphanumeric"/> for Base-62, use <see cref="Decimal"/> for Base-10, use <see cref="Binary"/> for Base-2. The length of the array is the base number.</param>
        /// <returns><paramref name="value"/>, but in the base specified.</returns>
        public static long BaseToLong(this string value, string baseChars = Binary)
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
                result += x * (long)Math.Pow(n, m--);
            }

            return result;
        }

        /// <summary>
        /// Converts any base number to any base-10.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="baseNumber">Which base it currently is.</param>
        /// <returns>The integer, but in the base specified.</returns>
        public static long BaseToLong(this string value, int baseNumber) => value.BaseToLong(new string(Alphanumeric.Take(baseNumber).ToArray()));

        /// <summary>
        /// Formats the string. Shorthand for <see cref="string.Format(string, object[])"/>.
        /// </summary>
        /// <param name="str">The string to format. Typically with placeholders involving {0}, {1}, {2}...</param>
        /// <param name="args">All of the arguments to put into <paramref name="str"/>.</param>
        /// <returns>The formatted <see cref="string"/>.</returns>
        public static string Form(this string str, params object[] args) => string.Format(str, args.Select(o => o.UnwrapToString()).ToArray());

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
        /// Throws an exception if the <see cref="string"/> is null or empty.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="source">The string to check for null and empty.</param>
        /// <param name="message">The optional message to throw if null or empty. Leaving it default will throw a default message.</param>
        public static string NullOrEmptyCheck(this string source, string message = null) => string.Concat(source.AsEnumerable().NullOrEmptyCheck(message));

        /// <summary>
        /// Converts any base-10 number to any base.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="value">The value to convert.</param>
        /// <param name="baseChars">All of the base characters for the conversion to the base number, use <see cref="Alphanumeric"/> for Base-62, use <see cref="Decimal"/> for Base-10, use <see cref="Binary"/> for Base-2. The length of the array is the base number.</param>
        /// <returns><paramref name="value"/>, but in the base specified.</returns>
        public static string LongToBase(this long value, string baseChars = Alphanumeric)
        {
            baseChars.NullCheck($"{nameof(baseChars)} cannot be null when converting bases.");

            long targetBase = baseChars.Length;

            char[] buffer = new char[Math.Max((int)Math.Ceiling(Math.Log(value + 1, targetBase)), 1)];

            int i = buffer.Length;

            do
            {
                buffer[--i] = baseChars[(int)(value % targetBase)];
                value /= targetBase;
            }
            while (value > 0);

            return new(buffer, i, buffer.Length - i);
        }

        /// <summary>
        /// Converts any base-10 number to any base.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="baseNumber">Which base to convert it to.</param>
        /// <returns>The integer, but in the base specified.</returns>
        public static string LongToBase(this long value, int baseNumber) => value.LongToBase(new string(Alphanumeric.Take(baseNumber).ToArray()));

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
        /// Unwraps any object, whether it be a class, list, tuple, or any other data.
        /// </summary>
        /// <param name="source">The object to unwrap.</param>
        /// <param name="isRecursive">Whether it should search inside the variable and yield return the elements inside <paramref name="source"/>.</param>
        /// <returns>An <see cref="object"/> <see cref="Array"/> of all elements within <paramref name="source"/>.</returns>
        public static object[] Unwrap(this object source, bool isRecursive = false) => (source switch
        {
            null => new[] { Helper.Null },
            string => new[] { source },
            Tuple tuple => tuple.ToArray.Unwrap(),
            IEnumerable ienumerable => ienumerable.Unwrap(),
            IEnumerator ienumerator => ienumerator.AsEnumerable().Unwrap(),
            _ => isRecursive ? source.GetAllValues().Cast<object>().Prepend(source) : new[] { source },
        }).ToArray();

        /// <summary>
        /// Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.
        /// </summary>
        /// <param name="item">The left-hand side operator.</param>
        /// <param name="bigInteger">The right-hand side operator.</param>
        /// <returns>Itself mod <paramref name="bigInteger"/>.</returns>
        public static BigInteger Modulo(this object item, BigInteger bigInteger) => ((item % bigInteger) + bigInteger) % bigInteger;

        /// <summary>
        /// Gets the appropriate <see cref="Exception"/> based on the data type.
        /// </summary>
        /// <param name="item">The item to check the type for.</param>
        /// <returns><see cref="NullIteratorException"/> if <paramref name="item"/> is an iterator, evaluated with <see cref="IsIterator(object)"/>, otherwise <see cref="NullReferenceException"/></returns>
        public static Func<string, Exception> GetNullException(this object item) => s => item.IsIterator() ? new NullIteratorException(s) : new NullReferenceException(s);

        /// <summary>
        /// Gets the method info from an expression.
        /// </summary>
        /// <typeparam name="T">The type of the action.</typeparam>
        /// <param name="expression">The expression that retrieves the method.</param>
        /// <returns>The method info of the function.</returns>
        public static MethodInfo GetMethodInfo<T>(this Expression<Action<T>> expression) => expression.Body is MethodCallExpression member ? member.Method : throw new ArgumentException("Expression is not a method", "expression");

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
        /// Gets all fields and properties of the item using reflection.
        /// </summary>
        /// <param name="source">The item to get all fields and properties.</param>
        /// <returns>All fields and properties of <paramref name="source"/>.</returns>
        public static IEnumerable<string> GetAllValues(this object source) => source?.GetType()?.GetFields(Helper.Flags).Select(f => $"\n{f} (Field): {f?.GetValue(source).UnwrapToString()}").Concat(source?.GetType()?.GetProperties(Helper.Flags).Select(p => $"\n{p} (Property): {p?.GetValue(source, null).UnwrapToString()}"));

        /// <summary>
        /// Unwraps any <see cref="IEnumerable"/> of type <see cref="object"/>, which ends up flattening it as a <see cref="Array"/> of type <see cref="object"/>.
        /// </summary>
        /// <param name="source">The object to unwrap.</param>
        /// <param name="isRecursive">Whether it should search inside the variable and yield return the elements inside <paramref name="source"/>.</param>
        /// <returns>An <see cref="object"/> <see cref="Array"/> of all elements within <paramref name="source"/>.</returns>
        public static IEnumerable<object> Unwrap(this IEnumerable source, bool isRecursive = false)
        {
            foreach (object item in source)
            {
                object[] items = item.Unwrap(isRecursive);

                foreach (object o in items)
                    yield return o;
            }
        }

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
        /// Throws a <see cref="NullReferenceException"/> or <see cref="NullIteratorException"/> if the parameter provided is null.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="item">The parameter to check null for.</param>
        /// <param name="message">The optional message to throw if null.</param>
        /// <returns><paramref name="item"/></returns>
        public static T NullCheck<T>(this T item, string message = "While asserting for null, the variable ended up null.") => item is null ? throw GetNullException(item)(message) : item;

        /// <summary>
        /// Appends the element provided to the array.
        /// </summary>
        /// <typeparam name="T">The datatype of both the array and element.</typeparam>
        /// <param name="array">The array to be appended with.</param>
        /// <param name="item">The element to append to the <paramref name="array"/>.</param>
        /// <returns><paramref name="array"/>, but with an added <paramref name="item"/> as the last index.</returns>
        public static T[] Append<T>(this T[] array, T item) => (T[])array.Resize(array.Length + 1).Set(item, array.Length);

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

        /// <summary>
        /// Prepends the element provided to the array.
        /// </summary>
        /// <typeparam name="T">The datatype of both the array and element.</typeparam>
        /// <param name="array">The array to be appended with.</param>
        /// <param name="item">The element to append to the <paramref name="array"/>.</param>
        /// <returns><paramref name="array"/>, but with an added <paramref name="item"/> as the first index.</returns>
        public static T[] Prepend<T>(this T[] array, T item) => (T[])array.Resize(array.Length + 1).Copy(0, array, 1, array.Length).Set(item, 0);


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

        /// <summary>
        /// Invokes a method of <typeparamref name="TInput"/> to <typeparamref name="TOutput"/> and then returns the argument provided.
        /// </summary>
        /// <remarks>
        /// This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.
        /// </remarks>
        /// <typeparam name="TInput">The type of <paramref name="item"/>.</typeparam>
        /// <typeparam name="TOutput">The type to return.</typeparam>
        /// <param name="item">The item to use as reference and modify.</param>
        /// <param name="func">The function to apply <paramref name="item"/> to.</param>
        /// <returns>The item <paramref name="item"/> after <paramref name="func"/>.</returns>
        public static TOutput Apply<TInput, TOutput>(this TInput item, Func<TInput, TOutput> func) => func(item);
    }
}
