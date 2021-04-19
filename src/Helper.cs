using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using UnityEngine;
using Random = UnityEngine.Random;

namespace KeepCoding.v14
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
        /// Determines if the item is an iterator type.
        /// </summary>
        /// <param name="item">The item to check the type for.</param>
        /// <returns><paramref name="item"/> is either <see cref="string"/>, <see cref="IEnumerable"/>, or <see cref="IEnumerator"/>.</returns>
        public static bool IsIterator(this object item) => item is string or IEnumerable or IEnumerator;

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
        /// Throws an exception if the <see cref="string"/> is null or empty.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <param name="source">The string to check for null and empty.</param>
        /// <param name="message">The optional message to throw if null or empty. Leaving it default will throw a default message.</param>
        public static string NullOrEmptyCheck(this string source, string message = null) => string.Concat(source.AsEnumerable().NullOrEmptyCheck(message));

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
        public static string Form(this string str, params object[] args) => string.Format(str, args.Select(o => o.UnwrapToString()).ToArray());

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
        public static string UnwrapToString(this object item, bool getVariables = false, string delimiter = ", ") => string.Join(delimiter, CollectionHelper.Unwrap(item, getVariables).Select(o => o.ToString()).ToArray());

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
        public static Func<string, Exception> GetNullException(this object item) => s => item.IsIterator() ? (Exception)new NullIteratorException(s) : new NullReferenceException(s);

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
