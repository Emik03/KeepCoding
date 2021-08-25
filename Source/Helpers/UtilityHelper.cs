using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Reflection.BindingFlags;

namespace KeepCoding
{
    /// <summary>
    /// Wad of extension methods from RT Util Core.
    /// </summary>
    /// <remarks>
    /// <see href="https://github.com/RT-Projects/RT.Util/tree/master/RT.Util.Core/ExtensionMethods"/>
    /// </remarks>
    public static class UtilityHelper
    {
        /// <summary>Selects how the escaped JS string should be put into quotes.</summary>
        public enum JsQuotes
        {
            /// <summary>Put single quotes around the output. Single quotes are allowed in JavaScript only, but not in JSON.</summary>
            Single,
            /// <summary>Put double quotes around the output. Double quotes are allowed both in JavaScript and JSON.</summary>
            Double,
            /// <summary>Do not put any quotes around the output. The escaped output may be surrounded with either type of quotes.</summary>
            None
        }

        private const BindingFlags Flags = DeclaredOnly | Instance | Public | NonPublic;

        /// <summary>
        ///     Similar to <see cref="string.Substring(int)"/>, but for arrays. Returns a new array containing all items from
        ///     the specified <paramref name="startIndex"/> onwards.</summary>
        /// <remarks>
        ///     Returns a new copy of the array even if <paramref name="startIndex"/> is 0.</remarks>
        public static T[] Subarray<T>(this T[] array, int startIndex) => array is null ? throw new ArgumentNullException(nameof(array)) : Subarray(array, startIndex, array.Length - startIndex);

        /// <summary>
        ///     Similar to <see cref="string.Substring(int,int)"/>, but for arrays. Returns a new array containing <paramref
        ///     name="length"/> items from the specified <paramref name="startIndex"/> onwards.</summary>
        /// <remarks>
        ///     Returns a new copy of the array even if <paramref name="startIndex"/> is 0 and <paramref name="length"/> is
        ///     the length of the input array.</remarks>
        public static T[] Subarray<T>(this T[] array, int startIndex, int length)
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array));

            if (startIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex cannot be negative.");

            if (length < 0 || startIndex + length > array.Length)
                throw new ArgumentOutOfRangeException(nameof(length), "length cannot be negative or extend beyond the end of the array.");

            var result = new T[length];

            Array.Copy(array, startIndex, result, 0, length);

            return result;
        }

        /// <summary>
        ///     Similar to <see cref="string.Remove(int)"/>, but for arrays. Returns a new array containing only the items
        ///     before the specified <paramref name="startIndex"/>.</summary>
        /// <remarks>
        ///     Returns a new copy of the array even if <paramref name="startIndex"/> is the length of the array.</remarks>
        public static T[] Remove<T>(this T[] array, int startIndex)
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array));

            if (startIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex cannot be negative.");

            if (startIndex > array.Length)
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex cannot be greater than the length of the array.");

            var result = new T[startIndex];

            Array.Copy(array, 0, result, 0, startIndex);

            return result;
        }

        /// <summary>
        ///     Similar to <see cref="string.Remove(int,int)"/>, but for arrays. Returns a new array containing everything
        ///     except the <paramref name="length"/> items starting from the specified <paramref name="startIndex"/>.</summary>
        /// <remarks>
        ///     Returns a new copy of the array even if <paramref name="length"/> is 0.</remarks>
        public static T[] Remove<T>(this T[] array, int startIndex, int length)
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array));

            if (startIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex cannot be negative.");

            if (length < 0 || startIndex + length > array.Length)
                throw new ArgumentOutOfRangeException(nameof(length), "length cannot be negative or extend beyond the end of the array.");

            var result = new T[array.Length - length];
            Array.Copy(array, 0, result, 0, startIndex);
            Array.Copy(array, startIndex + length, result, startIndex, array.Length - length - startIndex);

            return result;
        }

        /// <summary>
        ///     Similar to <see cref="string.Insert(int, string)"/>, but for arrays. Returns a new array with the <paramref
        ///     name="values"/> inserted starting from the specified <paramref name="startIndex"/>.</summary>
        /// <remarks>
        ///     Returns a new copy of the array even if <paramref name="values"/> is empty.</remarks>
        public static T[] Insert<T>(this T[] array, int startIndex, params T[] values)
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array));

            if (values is null)
                throw new ArgumentNullException(nameof(values));

            if (startIndex < 0 || startIndex > array.Length)
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex must be between 0 and the size of the input array.");

            var result = new T[array.Length + values.Length];

            Array.Copy(array, 0, result, 0, startIndex);
            Array.Copy(values, 0, result, startIndex, values.Length);
            Array.Copy(array, startIndex, result, startIndex + values.Length, array.Length - startIndex);

            return result;
        }

        /// <summary>
        ///     Similar to <see cref="string.Insert(int, string)"/>, but for arrays and for a single value. Returns a new
        ///     array with the <paramref name="value"/> inserted at the specified <paramref name="startIndex"/>.</summary>
        public static T[] Insert<T>(this T[] array, int startIndex, T value)
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array));

            if (startIndex < 0 || startIndex > array.Length)
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex must be between 0 and the size of the input array.");

            var result = new T[array.Length + 1];

            Array.Copy(array, 0, result, 0, startIndex);

            result[startIndex] = value;

            Array.Copy(array, startIndex, result, startIndex + 1, array.Length - startIndex);

            return result;
        }

        /// <summary>
        ///     Concatenates two arrays.</summary>
        /// <remarks>
        ///     Returns a new copy of the array even if one of the input arrays is empty.</remarks>
        public static T[] Concat<T>(this T[] array, T[] otherArray)
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array));

            if (otherArray is null)
                throw new ArgumentNullException(nameof(otherArray));

            if (otherArray.Length is 0)
                return (T[])array.Clone();

            if (array.Length is 0)
                return (T[])otherArray.Clone();

            var result = new T[array.Length + otherArray.Length];

            Array.Copy(array, 0, result, 0, array.Length);
            Array.Copy(otherArray, 0, result, array.Length, otherArray.Length);
            return result;
        }

        /// <summary>
        ///     Returns a new array in which a single element has been replaced.</summary>
        /// <param name="array">
        ///     The array from which to create a new array with one element replaced.</param>
        /// <param name="index">
        ///     The index at which to replace one element.</param>
        /// <param name="element">
        ///     The new element to replace the old element with.</param>
        public static T[] Replace<T>(this T[] array, int index, T element)
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array));

            if (!index.IsBetween(0, array.Length))
                throw new ArgumentOutOfRangeException(nameof(index), "index must be between 0 and the size of the input array.");

            var result = (T[])array.Clone();

            result[index] = element;

            return result;
        }

        /// <summary>
        ///     Determines whether a subarray within the current array is equal to the specified other array.</summary>
        /// <param name="sourceArray">
        ///     First array to examine.</param>
        /// <param name="sourceStartIndex">
        ///     Start index of the subarray within the first array to compare.</param>
        /// <param name="otherArray">
        ///     Array to compare the subarray against.</param>
        /// <param name="comparer">
        ///     Optional equality comparer.</param>
        /// <returns>
        ///     True if the current array contains the specified subarray at the specified index; false otherwise.</returns>
        public static bool SubarrayEquals<T>(this T[] sourceArray, int sourceStartIndex, T[] otherArray, IEqualityComparer<T>? comparer = null) => otherArray is null
                ? throw new ArgumentNullException(nameof(otherArray))
                : SubarrayEquals(sourceArray, sourceStartIndex, otherArray, 0, otherArray.Length, comparer);

        /// <summary>
        ///     Determines whether the two arrays contain the same content in the specified location.</summary>
        /// <param name="sourceArray">
        ///     First array to examine.</param>
        /// <param name="sourceStartIndex">
        ///     Start index of the subarray within the first array to compare.</param>
        /// <param name="otherArray">
        ///     Second array to examine.</param>
        /// <param name="otherStartIndex">
        ///     Start index of the subarray within the second array to compare.</param>
        /// <param name="length">
        ///     Length of the subarrays to compare.</param>
        /// <param name="comparer">
        ///     Optional equality comparer.</param>
        /// <returns>
        ///     True if the two arrays contain the same subarrays at the specified indexes; false otherwise.</returns>
        public static bool SubarrayEquals<T>(this T[] sourceArray, int sourceStartIndex, T[] otherArray, int otherStartIndex, int length, IEqualityComparer<T>? comparer = null)
        {
            if (sourceArray is null)
                throw new ArgumentNullException(nameof(sourceArray));

            if (sourceStartIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(sourceStartIndex), "The sourceStartIndex argument must be non-negative.");

            if (otherArray is null)
                throw new ArgumentNullException(nameof(otherArray));

            if (otherStartIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(otherStartIndex), "The otherStartIndex argument must be non-negative.");

            if (length < 0 || sourceStartIndex + length > sourceArray.Length || otherStartIndex + length > otherArray.Length)
                throw new ArgumentOutOfRangeException(nameof(length), "The length argument must be non-negative and must be such that both subarrays are within the bounds of the respective source arrays.");

            if (comparer is null)
                comparer = EqualityComparer<T>.Default;

            for (int i = 0; i < length; i++)
            {
                if (!comparer.Equals(sourceArray[sourceStartIndex + i], otherArray[otherStartIndex + i]))
                    return false;
            }

            return true;
        }

        /// <summary>
        ///     Searches the current array for a specified subarray and returns the index of the first occurrence, or -1 if
        ///     not found.</summary>
        /// <param name="sourceArray">
        ///     Array in which to search for the subarray.</param>
        /// <param name="findWhat">
        ///     Subarray to search for.</param>
        /// <param name="comparer">
        ///     Optional equality comparer.</param>
        /// <returns>
        ///     The index of the first match, or -1 if no match is found.</returns>
        public static int IndexOfSubarray<T>(this T[] sourceArray, T[] findWhat, IEqualityComparer<T>? comparer = null)
        {
            if (sourceArray is null)
                throw new ArgumentNullException(nameof(sourceArray));

            if (findWhat is null)
                throw new ArgumentNullException(nameof(findWhat));

            for (int i = 0; i <= sourceArray.Length - findWhat.Length; i++)
            {
                if (sourceArray.SubarrayEquals(i, findWhat, 0, findWhat.Length, comparer))
                    return i;
            }

            return -1;
        }

        /// <summary>
        ///     Searches the current array for a specified subarray and returns the index of the first occurrence, or -1 if
        ///     not found.</summary>
        /// <param name="sourceArray">
        ///     Array in which to search for the subarray.</param>
        /// <param name="findWhat">
        ///     Subarray to search for.</param>
        /// <param name="startIndex">
        ///     Index in <paramref name="sourceArray"/> at which to start searching.</param>
        /// <param name="sourceLength">
        ///     Maximum length of the source array to search starting from <paramref name="startIndex"/>. The greatest index
        ///     that can be returned is this minus the length of <paramref name="findWhat"/> plus <paramref
        ///     name="startIndex"/>.</param>
        /// <param name="comparer">
        ///     Optional equality comparer.</param>
        /// <returns>
        ///     The index of the first match, or -1 if no match is found.</returns>
        public static int IndexOfSubarray<T>(this T[] sourceArray, T[] findWhat, int startIndex, int? sourceLength = null, IEqualityComparer<T>? comparer = null)
        {
            if (sourceArray is null)
                throw new ArgumentNullException(nameof(sourceArray));

            if (findWhat is null)
                throw new ArgumentNullException(nameof(findWhat));

            if (startIndex < 0 || startIndex > sourceArray.Length)
                throw new ArgumentOutOfRangeException(nameof(startIndex));

            if (sourceLength is { } && (sourceLength < 0 || sourceLength + startIndex > sourceArray.Length))
                throw new ArgumentOutOfRangeException(nameof(sourceLength));

            int maxIndex = (sourceLength is null ? sourceArray.Length : startIndex + sourceLength.Value) - findWhat.Length;

            for (int i = startIndex; i <= maxIndex; i++)
            {
                if (sourceArray.SubarrayEquals(i, findWhat, 0, findWhat.Length, comparer))
                    return i;
            }

            return -1;
        }

        /// <summary>Reverses an array in-place and returns the same array.</summary>
        public static T[] ReverseInplace<T>(this T[] input)
        {
            Array.Reverse(input);
            return input;
        }

        /// <summary>
        ///     Performs a binary search for the specified key on a <see cref="SortedList&lt;TK,TV&gt;"/>. When no match
        ///     exists, returns the nearest indices for interpolation/extrapolation purposes.</summary>
        /// <remarks>
        ///     If an exact match exists, index1 == index2 == the index of the match. If an exact match is not found, index1
        ///     &lt; index2. If the key is less than every key in the list, index1 is int.MinValue and index2 is 0. If it's
        ///     greater than every key, index1 = last item index and index2 = int.MaxValue. Otherwise index1 and index2 are
        ///     the indices of the items that would surround the key were it present in the list.</remarks>
        /// <param name="list">
        ///     List to operate on.</param>
        /// <param name="key">
        ///     The key to look for.</param>
        /// <param name="index1">
        ///     Receives the value of the first index (see remarks).</param>
        /// <param name="index2">
        ///     Receives the value of the second index (see remarks).</param>
        public static void BinarySearch<TK, TV>(this SortedList<TK, TV> list, TK key, out int index1, out int index2)
        {
            if (list is null)
                throw new ArgumentNullException(nameof(list));

            if (key is null)
                throw new ArgumentNullException(nameof(key), "Null values cannot be used for keys in SortedList.");

            IList<TK> keys = list.Keys;
            Comparer<TK> comparer = Comparer<TK>.Default;

            int imin = 0;
            int imax = 0 + keys.Count - 1;
            while (imin <= imax)
            {
                int inew = imin + ((imax - imin) >> 1);

                int cmp_res;
                try
                {
                    cmp_res = comparer.Compare(keys[inew], key);
                }
                catch (Exception exception)
                {
                    throw new InvalidOperationException("SortedList.BinarySearch could not compare keys due to a comparer exception.", exception);
                }

                if (cmp_res is 0)
                {
                    index1 = index2 = inew;
                    return;
                }
                else if (cmp_res < 0)
                {
                    imin = inew + 1;
                }
                else
                {
                    imax = inew - 1;
                }
            }

            index1 = imax;
            index2 = imin;
            if (imax < 0)
                index1 = int.MinValue;
            if (imin >= keys.Count)
                index2 = int.MaxValue;
        }

        /// <summary>
        ///     Enqueues several values into a <see cref="Queue&lt;T&gt;"/>.</summary>
        /// <typeparam name="T">
        ///     Type of the elements in the queue.</typeparam>
        /// <param name="queue">
        ///     Queue to insert items into.</param>
        /// <param name="values">
        ///     Values to enqueue.</param>
        public static void EnqueueRange<T>(this Queue<T> queue, IEnumerable<T> values) => values.ForEach(queue.Enqueue);

        /// <summary>
        ///     Adds several values into a <see cref="HashSet&lt;T&gt;"/>.</summary>
        /// <typeparam name="T">
        ///     Type of the elements in the hash set.</typeparam>
        /// <param name="set">
        ///     The set to add the items to.</param>
        /// <param name="values">
        ///     Values to add.</param>
        public static void AddRange<T>(this HashSet<T> set, IEnumerable<T> values) => values.ForEach(v => set.Add(v));

        /// <summary>
        ///     Removes several values from a <see cref="List&lt;T&gt;"/>.</summary>
        /// <typeparam name="T">
        ///     Type of the elements in the list.</typeparam>
        /// <param name="list">
        ///     The list to remove the items from.</param>
        /// <param name="values">
        ///     Values to remove.</param>
        public static void RemoveRange<T>(this List<T> list, IEnumerable<T> values) => values.ForEach(v => list.Remove(v));

        /// <summary>
        ///     Pops the specified number of elements from the stack. There must be at least that many items on the stack,
        ///     otherwise an exception is thrown.</summary>
        public static void Pop<T>(this Stack<T> stack, int count)
        {
            for (int i = 0; i < count; i++)
                stack.Pop();
        }

        /// <summary>Determines whether the current HashSet-in-a-Dictionary contains the specified key and value.</summary>
        public static bool Contains<TKey, TValue>(this IDictionary<TKey, HashSet<TValue>> source, TKey key, TValue value) => source is null ? throw new ArgumentNullException(nameof(source))
                : key is null ? throw new ArgumentNullException(nameof(key), "Null values cannot be used for keys in dictionaries.")
                : source.ContainsKey(key) && source[key].Contains(value);

        /// <summary>
        ///     Determines whether the current two-level dictionary contains the specified combination of keys.</summary>
        /// <typeparam name="TKey1">
        ///     Type of the first-level key.</typeparam>
        /// <typeparam name="TKey2">
        ///     Type of the second-level key.</typeparam>
        /// <typeparam name="TValue">
        ///     Type of values in the dictionary.</typeparam>
        /// <param name="source">
        ///     Source dictionary to examine.</param>
        /// <param name="key1">
        ///     The first key to check for.</param>
        /// <param name="key2">
        ///     The second key to check for.</param>
        public static bool ContainsKeys<TKey1, TKey2, TValue>(this IDictionary<TKey1, Dictionary<TKey2, TValue>> source, TKey1 key1, TKey2 key2) =>
            source is null ? throw new ArgumentNullException(nameof(source)) : source.TryGetValue(key1, out Dictionary<TKey2, TValue> dic) && dic.ContainsKey(key2);

        /// <summary>
        ///     Gets the value associated with the specified combination of keys.</summary>
        /// <typeparam name="TKey1">
        ///     Type of the first-level key.</typeparam>
        /// <typeparam name="TKey2">
        ///     Type of the second-level key.</typeparam>
        /// <typeparam name="TValue">
        ///     Type of values in the dictionary.</typeparam>
        /// <param name="source">
        ///     Source dictionary to examine.</param>
        /// <param name="key1">
        ///     The first key to check for.</param>
        /// <param name="key2">
        ///     The second key to check for.</param>
        /// <param name="value">
        ///     When this method returns, the value associated with the specified keys, if the keys are found; otherwise, the
        ///     default value for the type of the <paramref name="value"/> parameter. This parameter is passed uninitialized.</param>
        /// <returns>
        ///     <c>true</c> if the two-level dictionary contains an element with the specified combination of keys; otherwise,
        ///     <c>false</c>.</returns>
        public static bool TryGetValue<TKey1, TKey2, TValue>(this IDictionary<TKey1, Dictionary<TKey2, TValue>> source, TKey1 key1, TKey2 key2, out TValue value)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            value = default!;

            return source.TryGetValue(key1, out Dictionary<TKey2, TValue> dic) && dic.TryGetValue(key2, out value);
        }

        /// <summary>
        ///     Compares two dictionaries for equality, member-wise. Two dictionaries are equal if they contain all the same
        ///     key-value pairs.</summary>
        public static bool DictionaryEqual<TK, TV>(this IDictionary<TK, TV> dictA, IDictionary<TK, TV> dictB)
            where TV : IEquatable<TV>
        {
            if (dictA is null)
                throw new ArgumentNullException(nameof(dictA));

            if (dictB is null)
                throw new ArgumentNullException(nameof(dictB));

            if (dictA.Count != dictB.Count)
                return false;

            foreach (TK key in dictA.Keys)
            {
                if (!dictB.ContainsKey(key) || !dictA[key].Equals(dictB[key]))
                    return false;
            }

            return true;
        }

        /// <summary>
        ///     Gets a value from a dictionary by key. If the key does not exist in the dictionary, the default value is
        ///     returned instead.</summary>
        /// <param name="dict">
        ///     Dictionary to operate on.</param>
        /// <param name="key">
        ///     Key to look up.</param>
        /// <param name="defaultVal">
        ///     Value to return if <paramref name="key"/> is not contained in the dictionary.</param>
        public static TValue Get<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue defaultVal) => dict is null ? throw new ArgumentNullException(nameof(dict))
                : key is null ? throw new ArgumentNullException(nameof(key), "Null values cannot be used for keys in dictionaries.")
                : dict.TryGetValue(key, out TValue value) ? value : defaultVal;

        /// <summary>
        ///     Gets a value from a dictionary by key. If the key does not exist in the dictionary, the default value is
        ///     returned instead.</summary>
        /// <param name="dict">
        ///     Dictionary to operate on.</param>
        /// <param name="key">
        ///     Key to look up.</param>
        /// <param name="defaultVal">
        ///     Value to return if <paramref name="key"/> is not contained in the dictionary.</param>
        public static TValue? Get<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue? defaultVal = null) where TValue : struct => dict is null ? throw new ArgumentNullException(nameof(dict))
                : key is null ? throw new ArgumentNullException(nameof(key), "Null values cannot be used for keys in dictionaries.")
                : dict.TryGetValue(key, out TValue value) ? value : defaultVal;

        /// <summary>
        ///     Gets a value from a two-level dictionary by key. If the keys don’t exist in the dictionary, the default value
        ///     is returned instead.</summary>
        /// <param name="dict">
        ///     Dictionary to operate on.</param>
        /// <param name="key1">
        ///     Key to look up in the first level.</param>
        /// <param name="key2">
        ///     Key to look up in the second level.</param>
        /// <param name="defaultVal">
        ///     Value to return if key1 or key2 is not contained in the relevant dictionary.</param>
        public static TValue Get<TKey1, TKey2, TValue>(this IDictionary<TKey1, Dictionary<TKey2, TValue>> dict, TKey1 key1, TKey2 key2, TValue defaultVal) => dict is null ? throw new ArgumentNullException(nameof(dict))
                : key1 is null ? throw new ArgumentNullException(nameof(key1), "Null values cannot be used for keys in dictionaries.")
                : key2 is null ? throw new ArgumentNullException(nameof(key2), "Null values cannot be used for keys in dictionaries.")
                : dict.TryGetValue(key1, out Dictionary<TKey2, TValue> innerDic) && innerDic.TryGetValue(key2, out TValue value) ? value : defaultVal;

        /// <summary>
        ///     Removes all entries from a dictionary that satisfy a specified predicate.</summary>
        /// <typeparam name="TKey">
        ///     Type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TVal">
        ///     Type of the values in the dictionary.</typeparam>
        /// <param name="dict">
        ///     Dictionary to operate on.</param>
        /// <param name="predicate">
        ///     Specifies a predicate that determines which entries should be removed from the dictionary.</param>
        public static void RemoveAll<TKey, TVal>(this IDictionary<TKey, TVal> dict, Func<KeyValuePair<TKey, TVal>, bool> predicate) => dict.Where(kvp => predicate(kvp)).ToArray().ForEach(kvp => dict.Remove(kvp.Key));

        /// <summary>
        ///     Removes all entries from a dictionary whose keys satisfy a specified predicate.</summary>
        /// <typeparam name="TKey">
        ///     Type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TVal">
        ///     Type of the values in the dictionary.</typeparam>
        /// <param name="dict">
        ///     Dictionary to operate on.</param>
        /// <param name="predicate">
        ///     Specifies a predicate that determines which entries should be removed from the dictionary.</param>
        public static void RemoveAllByKey<TKey, TVal>(this IDictionary<TKey, TVal> dict, Func<TKey, bool> predicate) => dict.Where(kvp => predicate(kvp.Key)).ToArray().ForEach(kvp => dict.Remove(kvp.Key));

        /// <summary>
        ///     Removes all entries from a dictionary whose values satisfy a specified predicate.</summary>
        /// <typeparam name="TKey">
        ///     Type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TVal">
        ///     Type of the values in the dictionary.</typeparam>
        /// <param name="dict">
        ///     Dictionary to operate on.</param>
        /// <param name="predicate">
        ///     Specifies a predicate that determines which entries should be removed from the dictionary.</param>
        public static void RemoveAllByValue<TKey, TVal>(this IDictionary<TKey, TVal> dict, Func<TVal, bool> predicate) => dict.Where(kvp => predicate(kvp.Value)).ToArray().ForEach(kvp => dict.Remove(kvp.Key));

        /// <summary>
        ///     Creates a new dictionary containing the union of the key/value pairs contained in the specified dictionaries.
        ///     Keys in <paramref name="second"/> overwrite keys in <paramref name="first"/>.</summary>
        public static IDictionary<TKey, TValue> CopyMerge<TKey, TValue>(this IDictionary<TKey, TValue> first, IDictionary<TKey, TValue> second)
        {
            if (first is null)
                throw new ArgumentNullException(nameof(first));

            if (second is null)
                throw new ArgumentNullException(nameof(second));

            var dict = new Dictionary<TKey, TValue>(first);

            second.ForEach(kvp => dict.Add(kvp.Key, kvp.Value));

            return dict;
        }

        /// <summary>
        ///     Adds an element to a List&lt;V&gt; stored in the current IDictionary&lt;K, List&lt;V&gt;&gt;. If the specified
        ///     key does not exist in the current IDictionary, a new List is created.</summary>
        /// <typeparam name="K">
        ///     Type of the key of the IDictionary.</typeparam>
        /// <typeparam name="V">
        ///     Type of the values in the Lists.</typeparam>
        /// <param name="dic">
        ///     IDictionary to operate on.</param>
        /// <param name="key">
        ///     Key at which the list is located in the IDictionary.</param>
        /// <param name="value">
        ///     Value to add to the List located at the specified Key.</param>
        public static void AddSafe<K, V>(this IDictionary<K, List<V>> dic, K key, V value)
        {
            if (dic is null)
                throw new ArgumentNullException(nameof(dic));

            if (key is null)
                throw new ArgumentNullException(nameof(key), "Null values cannot be used for keys in dictionaries.");

            if (!dic.ContainsKey(key))
                dic[key] = new List<V>();

            dic[key].Add(value);
        }

        /// <summary>
        ///     Adds an element to a HashSet&lt;V&gt; stored in the current IDictionary&lt;K, HashSet&lt;V&gt;&gt;. If the
        ///     specified key does not exist in the current IDictionary, a new HashSet is created.</summary>
        /// <typeparam name="K">
        ///     Type of the key of the IDictionary.</typeparam>
        /// <typeparam name="V">
        ///     Type of the values in the HashSets.</typeparam>
        /// <param name="dic">
        ///     IDictionary to operate on.</param>
        /// <param name="key">
        ///     Key at which the HashSet is located in the IDictionary.</param>
        /// <param name="value">
        ///     Value to add to the HashSet located at the specified Key.</param>
        public static bool AddSafe<K, V>(this IDictionary<K, HashSet<V>> dic, K key, V value)
        {
            if (dic is null)
                throw new ArgumentNullException(nameof(dic));

            if (key is null)
                throw new ArgumentNullException(nameof(key), "Null values cannot be used for keys in dictionaries.");

            if (!dic.ContainsKey(key))
                dic[key] = new HashSet<V>();

            return dic[key].Add(value);
        }

        /// <summary>
        ///     Adds an element to a two-level Dictionary&lt;,&gt;. If the specified key does not exist in the outer
        ///     Dictionary, a new Dictionary is created.</summary>
        /// <typeparam name="K1">
        ///     Type of the key of the outer Dictionary.</typeparam>
        /// <typeparam name="K2">
        ///     Type of the key of the inner Dictionary.</typeparam>
        /// <typeparam name="V">
        ///     Type of the values in the inner Dictionary.</typeparam>
        /// <param name="dic">
        ///     Dictionary to operate on.</param>
        /// <param name="key1">
        ///     Key at which the inner Dictionary is located in the outer Dictionary.</param>
        /// <param name="key2">
        ///     Key at which the value is located in the inner Dictionary.</param>
        /// <param name="value">
        ///     Value to add to the inner Dictionary.</param>
        /// <param name="comparer">
        ///     Optional equality comparer to pass into the inner dictionary if a new one is created.</param>
        public static void AddSafe<K1, K2, V>(this IDictionary<K1, Dictionary<K2, V>> dic, K1 key1, K2 key2, V value, IEqualityComparer<K2>? comparer = null)
        {
            if (dic is null)
                throw new ArgumentNullException(nameof(dic));

            if (key1 is null)
                throw new ArgumentNullException(nameof(key1), "Null values cannot be used for keys in dictionaries.");

            if (key2 is null)
                throw new ArgumentNullException(nameof(key2), "Null values cannot be used for keys in dictionaries.");

            if (!dic.ContainsKey(key1))
                dic[key1] = comparer is null ? new Dictionary<K2, V>() : new Dictionary<K2, V>(comparer);

            dic[key1][key2] = value;
        }

        /// <summary>
        ///     Removes an element from a two-level Dictionary&lt;,&gt;. If this leaves the inner dictionary empty, the key is
        ///     removed from the outer Dictionary.</summary>
        /// <typeparam name="K1">
        ///     Type of the key of the outer Dictionary.</typeparam>
        /// <typeparam name="K2">
        ///     Type of the key of the inner Dictionary.</typeparam>
        /// <typeparam name="V">
        ///     Type of the values in the inner Dictionary.</typeparam>
        /// <param name="dic">
        ///     Dictionary to operate on.</param>
        /// <param name="key1">
        ///     Key at which the inner Dictionary is located in the outer Dictionary.</param>
        /// <param name="key2">
        ///     Key at which the value is located in the inner Dictionary.</param>
        /// <returns>
        ///     A value indicating whether a value was removed or not.</returns>
        public static bool RemoveSafe<K1, K2, V>(this IDictionary<K1, Dictionary<K2, V>> dic, K1 key1, K2 key2)
        {
            if (dic is null)
                throw new ArgumentNullException(nameof(dic));

            if (key1 is null)
                throw new ArgumentNullException(nameof(key1), "Null values cannot be used for keys in dictionaries.");

            if (key2 is null)
                throw new ArgumentNullException(nameof(key2), "Null values cannot be used for keys in dictionaries.");

            if (!dic.TryGetValue(key1, out Dictionary<K2, V> inner) || !inner.ContainsKey(key2))
                return false;

            inner.Remove(key2);

            if (inner.Count is 0)
                dic.Remove(key1);

            return true;
        }

        /// <summary>
        ///     Adds an element to a List&lt;V&gt; stored in a two-level Dictionary&lt;,&gt;. If the specified key does not
        ///     exist in the current Dictionary, a new List is created.</summary>
        /// <typeparam name="K1">
        ///     Type of the key of the first-level Dictionary.</typeparam>
        /// <typeparam name="K2">
        ///     Type of the key of the second-level Dictionary.</typeparam>
        /// <typeparam name="V">
        ///     Type of the values in the Lists.</typeparam>
        /// <param name="dic">
        ///     Dictionary to operate on.</param>
        /// <param name="key1">
        ///     Key at which the second-level Dictionary is located in the first-level Dictionary.</param>
        /// <param name="key2">
        ///     Key at which the list is located in the second-level Dictionary.</param>
        /// <param name="value">
        ///     Value to add to the List located at the specified Keys.</param>
        public static void AddSafe<K1, K2, V>(this IDictionary<K1, Dictionary<K2, List<V>>> dic, K1 key1, K2 key2, V value)
        {
            if (dic is null)
                throw new ArgumentNullException(nameof(dic));

            if (key1 is null)
                throw new ArgumentNullException(nameof(key1), "Null values cannot be used for keys in dictionaries.");

            if (key2 is null)
                throw new ArgumentNullException(nameof(key2), "Null values cannot be used for keys in dictionaries.");

            if (!dic.ContainsKey(key1))
                dic[key1] = new Dictionary<K2, List<V>>();

            if (!dic[key1].ContainsKey(key2))
                dic[key1][key2] = new List<V>();

            dic[key1][key2].Add(value);
        }

        /// <summary>
        ///     Increments an integer in an <see cref="IDictionary&lt;K, V&gt;"/> by the specified amount. If the specified
        ///     key does not exist in the current dictionary, the value <paramref name="amount"/> is inserted.</summary>
        /// <typeparam name="K">
        ///     Type of the key of the dictionary.</typeparam>
        /// <param name="dic">
        ///     Dictionary to operate on.</param>
        /// <param name="key">
        ///     Key at which the list is located in the dictionary.</param>
        /// <param name="amount">
        ///     The amount by which to increment the integer.</param>
        /// <returns>
        ///     The new value at the specified key.</returns>
        public static int IncSafe<K>(this IDictionary<K, int> dic, K key, int amount = 1) => dic is null ? throw new ArgumentNullException(nameof(dic))
                : key is null ? throw new ArgumentNullException(nameof(key), "Null values cannot be used for keys in dictionaries.")
                : dic.ContainsKey(key) ? (dic[key] = dic[key] + amount) : (dic[key] = amount);

        /// <summary>
        ///     Removes the first occurrence of an element from a List&lt;V&gt; stored in the current IDictionary&lt;K,
        ///     List&lt;V&gt;&gt;. If this leaves the list stored at the specified key empty, the key is removed from the
        ///     IDictionary. If the key is not in the dictionary to begin with, nothing happens.</summary>
        /// <typeparam name="K">
        ///     Type of the key of the IDictionary.</typeparam>
        /// <typeparam name="V">
        ///     Type of the values in the Lists.</typeparam>
        /// <param name="dic">
        ///     IDictionary to operate on.</param>
        /// <param name="key">
        ///     Key at which the list is located in the IDictionary.</param>
        /// <param name="value">
        ///     Value to add to the List located at the specified Key.</param>
        public static void RemoveSafe<K, V>(this IDictionary<K, List<V>> dic, K key, V value)
        {
            if (dic is null)
                throw new ArgumentNullException(nameof(dic));

            if (key is null)
                throw new ArgumentNullException(nameof(key), "Null values cannot be used for keys in dictionaries.");

            if (!dic.ContainsKey(key))
                return;

            dic[key].Remove(value);

            if (dic[key].Count is 0)
                dic.Remove(key);
        }

        /// <summary>
        ///     Returns an enumeration of tuples containing all pairs of elements from the source collection. For example, the
        ///     input sequence 1, 2 yields the pairs [1,1], [1,2], [2,1], and [2,2].</summary>
        public static IEnumerable<Tuple<T, T>> AllPairs<T>(this IEnumerable<T> source)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            IList<T> sourceArr = source as IList<T> ?? source.ToArray();

            return sourceArr.SelectMany(item1 => sourceArr.Select(item2 => item1.ToTuple(item2)));
        }

        /// <summary>Returns an enumeration of objects computed from all pairs of elements from the source collection.</summary>
        public static IEnumerable<TResult> AllPairs<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TSource, TResult> selector)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            IList<TSource> sourceArr = source as IList<TSource> ?? source.ToArray();

            return sourceArr.SelectMany(item1 => sourceArr.Select(item2 => selector(item1, item2)));
        }

        /// <summary>
        ///     Returns an enumeration of tuples containing all unique pairs of distinct elements from the source collection.
        ///     For example, the input sequence 1, 2, 3 yields the pairs [1,2], [1,3] and [2,3] only.</summary>
        public static IEnumerable<Tuple<T, T>> UniquePairs<T>(this IEnumerable<T> source)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            IEnumerable<Tuple<T, T>> uniquePairsIterator()
            {
                IList<T> arr = source as IList<T> ?? source.ToArray();

                for (int i = 0; i < arr.Count - 1; i++)
                    for (int j = i + 1; j < arr.Count; j++)
                        yield return arr[i].ToTuple(arr[j]);
            }

            return uniquePairsIterator();
        }

        /// <summary>
        ///     Returns an enumeration of tuples containing all consecutive pairs of the elements.</summary>
        /// <param name="source">
        ///     The input enumerable.</param>
        /// <param name="closed">
        ///     If true, an additional pair containing the last and first element is included. For example, if the source
        ///     collection contains { 1, 2, 3, 4 } then the enumeration contains { (1, 2), (2, 3), (3, 4) } if <paramref
        ///     name="closed"/> is false, and { (1, 2), (2, 3), (3, 4), (4, 1) } if <paramref name="closed"/> is true.</param>
        public static IEnumerable<Tuple<T, T>> ConsecutivePairs<T>(this IEnumerable<T> source, bool closed) => SelectConsecutivePairs(source, closed, (i1, i2) => i1.ToTuple(i2));

        /// <summary>
        ///     Enumerates all consecutive pairs of the elements.</summary>
        /// <param name="source">
        ///     The input enumerable.</param>
        /// <param name="closed">
        ///     If true, an additional pair containing the last and first element is included. For example, if the source
        ///     collection contains { 1, 2, 3, 4 } then the enumeration contains { (1, 2), (2, 3), (3, 4) } if <paramref
        ///     name="closed"/> is <c>false</c>, and { (1, 2), (2, 3), (3, 4), (4, 1) } if <paramref name="closed"/> is
        ///     <c>true</c>.</param>
        /// <param name="selector">
        ///     The selector function to run each consecutive pair through.</param>
        public static IEnumerable<TResult> SelectConsecutivePairs<T, TResult>(this IEnumerable<T> source, bool closed, Func<T, T, TResult> selector)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            IEnumerable<TResult> SelectConsecutivePairsIterator()
            {
                using (IEnumerator<T> enumer = source.GetEnumerator())
                {
                    bool any = enumer.MoveNext();

                    if (!any)
                        yield break;

                    T first = enumer.Current,
                        last = enumer.Current;

                    while (enumer.MoveNext())
                    {
                        yield return selector(last, enumer.Current);
                        last = enumer.Current;
                    }

                    if (closed)
                        yield return selector(last, first);
                }
            }

            return SelectConsecutivePairsIterator();
        }

        /// <summary>Sorts the elements of a sequence in ascending order.</summary>
        public static IEnumerable<T> Order<T>(this IEnumerable<T> source) => source.OrderBy(k => k);

        /// <summary>Sorts the elements of a sequence in ascending order by using a specified comparer.</summary>
        public static IEnumerable<T> Order<T>(this IEnumerable<T> source, IComparer<T> comparer) => source.OrderBy(k => k, comparer);

        /// <summary>
        ///     Splits the specified IEnumerable at every element that satisfies a specified predicate and returns a
        ///     collection containing each sequence of elements in between each pair of such elements. The elements satisfying
        ///     the predicate are not included.</summary>
        /// <param name="splitWhat">
        ///     The collection to be split.</param>
        /// <param name="splitWhere">
        ///     A predicate that determines which elements constitute the separators.</param>
        /// <returns>
        ///     A collection containing the individual pieces taken from the original collection.</returns>
        public static IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> splitWhat, Func<T, bool> splitWhere)
        {
            if (splitWhat is null)
                throw new ArgumentNullException(nameof(splitWhat));

            if (splitWhere is null)
                throw new ArgumentNullException(nameof(splitWhere));

            IEnumerable<IEnumerable<T>> SplitIterator()
            {
                var items = new List<T>();
                foreach (T item in splitWhat)
                {
                    if (splitWhere(item))
                    {
                        yield return items;
                        items = new List<T>();
                    }
                    else
                        items.Add(item);
                }

                yield return items;
            }

            return SplitIterator();
        }

        /// <summary>
        ///     Adds a single element to the end of an <see cref="IEnumerable{T}"/>.</summary>
        /// <typeparam name="T">
        ///     Type of enumerable to return.</typeparam>
        /// <returns>
        ///     IEnumerable containing all the input elements, followed by the specified additional element.</returns>
        public static IEnumerable<T> Concat<T>(this IEnumerable<T> source, T element)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            IEnumerable<T> ConcatIterator()
            {
                foreach (T e in source)
                    yield return e;

                yield return element;
            }

            return ConcatIterator();
        }

        /// <summary>
        ///     Adds a single element to the start of an <see cref="IEnumerable{T}"/>.</summary>
        /// <typeparam name="T">
        ///     Type of enumerable to return.</typeparam>
        /// <returns>
        ///     IEnumerable containing the specified additional element, followed by all the input elements.</returns>
        public static IEnumerable<T> Concat<T>(this T head, IEnumerable<T> tail)
        {
            if (tail is null)
                throw new ArgumentNullException(nameof(tail));

            IEnumerable<T> ConcatIterator()
            {
                yield return head;

                foreach (T e in tail)
                    yield return e;
            }

            return ConcatIterator();
        }

        /// <summary>
        ///     This does the same as <see cref="Order{T}(IEnumerable{T})"/>, but it is much faster if you intend to extract
        ///     only the first few items using <see cref="Enumerable.Take"/>.</summary>
        /// <param name="source">
        ///     The sequence to be sorted.</param>
        /// <returns>
        ///     The given <see cref="IEnumerable{T}"/> with its elements sorted progressively.</returns>
        public static IEnumerable<T> OrderLazy<T>(this IEnumerable<T> source) => OrderLazy(source, Comparer<T>.Default);

        /// <summary>
        ///     This does the same as <see cref="Order{T}(IEnumerable{T},IComparer{T})"/>, but it is much faster if you intend
        ///     to extract only the first few items using <see cref="Enumerable.Take"/>.</summary>
        /// <param name="source">
        ///     The sequence to be sorted.</param>
        /// <param name="comparer">
        ///     An instance of <see cref="IComparer{T}"/> specifying the comparison to use on the items.</param>
        /// <returns>
        ///     The given IEnumerable&lt;T&gt; with its elements sorted progressively.</returns>
        public static IEnumerable<T> OrderLazy<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (comparer is null)
                throw new ArgumentNullException(nameof(comparer));

            T[] arr = source.ToArray();

            if (arr.Length < 2)
                return arr;

            int[] map = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                map[i] = i;

            IEnumerable<T> QuickSort(T[] items, int left, int right)
            {
                int CompareForStableSort(T elem1, int elem1Index, T elem2, int elem2Index)
                {
                    int r = comparer.Compare(elem1, elem2);
                    return !(r is 0) ? r : elem1Index.CompareTo(elem2Index);
                }

                while (left < right)
                {
                    int curleft = left,
                        curright = right,
                        pivotIndex = map[curleft + ((curright - curleft) >> 1)];

                    T pivot = items[pivotIndex];

                    do
                    {
                        while (curleft < map.Length && CompareForStableSort(pivot, pivotIndex, items[map[curleft]], map[curleft]) > 0)
                            curleft++;

                        while (curright >= 0 && CompareForStableSort(pivot, pivotIndex, items[map[curright]], map[curright]) < 0)
                            curright--;

                        if (curleft > curright)
                            break;

                        if (curleft < curright)
                        {
                            int tmp = map[curleft];
                            map[curleft] = map[curright];
                            map[curright] = tmp;
                        }

                        curleft++;
                        curright--;
                    }
                    while (curleft <= curright);

                    if (left < curright)
                        foreach (T s in QuickSort(items, left, curright))
                            yield return s;

                    else if (left == curright)
                        yield return items[map[curright]];

                    if (curright + 1 < curleft)
                        yield return items[map[curright + 1]];

                    left = curleft;
                }

                yield return items[map[left]];
            }

            return QuickSort(arr, 0, arr.Length - 1);
        }

        /// <summary>
        ///     Returns all permutations of the input <see cref="IEnumerable&lt;T&gt;"/>.</summary>
        /// <param name="source">
        ///     The list of items to permute.</param>
        /// <returns>
        ///     A collection containing all permutations of the input <see cref="IEnumerable&lt;T&gt;"/>.</returns>
        public static IEnumerable<IEnumerable<T>> Permutations<T>(this IEnumerable<T> source) => source is null ? throw new ArgumentNullException(nameof(source)) : PermutationsInner(source as T[] ?? source.ToArray());

        private static IEnumerable<IEnumerable<T>> PermutationsInner<T>(IEnumerable<T> source)
        {
            int c = source.Count();

            if (c < 2)
                yield return source;

            else
                for (int i = 0; i < c; i++)
                    foreach (IEnumerable<T> p in PermutationsInner(source.Take(i).Concat(source.Skip(i + 1))))
                        yield return source.Skip(i).Take(1).Concat(p);
        }

        /// <summary>
        ///     Returns all subsequences of the specified lengths of the input <see cref="IEnumerable&lt;T&gt;"/>.</summary>
        /// <param name="source">
        ///     The sequence of items to generate subsequences of.</param>
        /// <param name="minLength">
        ///     The minimum length of a subsequence to return. Must be between 0 and the length of the input collection.</param>
        /// <param name="maxLength">
        ///     The maximum length of a subsequence to return. Must be between 0 and the length of the input collection. If
        ///     <c>null</c> is specified, the size of the input collection is used.</param>
        /// <returns>
        ///     A collection containing all matching subsequences of the input <see cref="IEnumerable&lt;T&gt;"/>.</returns>
        public static IEnumerable<IEnumerable<T>> Subsequences<T>(this IEnumerable<T> source, int minLength = 0, int? maxLength = null)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            IList<T> input = (source as IList<T>) ?? source.ToArray();

            if (minLength < 0 || minLength > input.Count)
                throw new ArgumentOutOfRangeException(nameof(minLength), "minLength must be between 0 and the size of the collection.");
            if (maxLength < 0 || maxLength > input.Count)
                throw new ArgumentOutOfRangeException(nameof(maxLength), "maxLength must be between 0 and the size of the collection.");

            static IEnumerable<List<int>> Subsequences(int range, int minLen, int maxLen)
            {
                var results = new List<List<int>>();

                if (minLen <= 0 && range is 0)
                    yield return new List<int>();

                else if (range > 0 && maxLen > 0)
                {
                    foreach (List<int> list in Subsequences(range - 1, minLen - 1, maxLen))
                    {
                        if (list.Count >= minLen)
                        {
                            if (list.Count < maxLen)
                            {
                                var list2 = list.ToList();
                                list2.Add(range - 1);
                                yield return list2;
                            }

                            yield return list;
                        }
                        else if (list.Count < maxLen)
                        {
                            list.Add(range - 1);
                            yield return list;
                        }
                    }
                }
            }

            return Subsequences(input.Count, minLength, maxLength ?? input.Count).Select(ssq => ssq.Select(ix => input[ix]));
        }

        /// <summary>
        ///     Returns the first element of a sequence, or <c>null</c> if the sequence contains no elements.</summary>
        /// <typeparam name="T">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">
        ///     The <see cref="IEnumerable&lt;T&gt;"/> to return the first element of.</param>
        /// <returns>
        ///     <c>null</c> if <paramref name="source"/> is empty; otherwise, the first element in <paramref name="source"/>.</returns>
        public static T? FirstOrNull<T>(this IEnumerable<T> source) where T : struct
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            using IEnumerator<T> e = source.GetEnumerator();

            return e.MoveNext() ? (T?)e.Current : null;
        }

        /// <summary>
        ///     Returns the first element of a sequence that satisfies a given predicate, or <c>null</c> if the sequence
        ///     contains no elements.</summary>
        /// <typeparam name="T">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">
        ///     The <see cref="IEnumerable&lt;T&gt;"/> to return the first element of.</param>
        /// <param name="predicate">
        ///     Only consider elements that satisfy this predicate.</param>
        /// <returns>
        ///     <c>null</c> if <paramref name="source"/> is empty; otherwise, the first element in <paramref name="source"/>.</returns>
        public static T? FirstOrNull<T>(this IEnumerable<T> source, Func<T, bool> predicate) where T : struct
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));
            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));
            using (IEnumerator<T> e = source.GetEnumerator())
            {
                while (e.MoveNext())
                    if (predicate(e.Current))
                        return e.Current;
                return null;
            }
        }

        /// <summary>
        ///     Returns the first element of a sequence, or a default value if the sequence contains no elements.</summary>
        /// <typeparam name="T">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">
        ///     The <see cref="IEnumerable&lt;T&gt;"/> to return the first element of.</param>
        /// <param name="default">
        ///     The default value to return if the sequence contains no elements.</param>
        /// <returns>
        ///     <paramref name="default"/> if <paramref name="source"/> is empty; otherwise, the first element in <paramref
        ///     name="source"/>.</returns>
        public static T FirstOrDefault<T>(this IEnumerable<T> source, T @default)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            using IEnumerator<T> e = source.GetEnumerator();

            return e.MoveNext() ? e.Current : @default;
        }

        /// <summary>
        ///     Returns the first element of a sequence, or a default value if the sequence contains no elements.</summary>
        /// <typeparam name="T">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">
        ///     The <see cref="IEnumerable&lt;T&gt;"/> to return the first element of.</param>
        /// <param name="predicate">
        ///     A function to test each element for a condition.</param>
        /// <param name="default">
        ///     The default value to return if the sequence contains no elements.</param>
        /// <returns>
        ///     <paramref name="default"/> if <paramref name="source"/> is empty or if no element passes the test specified by
        ///     <paramref name="predicate"/>; otherwise, the first element in <paramref name="source"/> that passes the test
        ///     specified by <paramref name="predicate"/>.</returns>
        public static T FirstOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate, T @default)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));

            using IEnumerator<T> e = source.GetEnumerator();

            while (e.MoveNext())
                if (predicate(e.Current))
                    return e.Current;

            return @default;

        }

        /// <summary>
        ///     Returns the first element of a sequence, or a default value if the sequence contains no elements.</summary>
        /// <typeparam name="TSource">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TResult">
        ///     The type of the resulting value.</typeparam>
        /// <param name="source">
        ///     The <see cref="IEnumerable&lt;T&gt;"/> to return the first element of.</param>
        /// <param name="predicate">
        ///     A function to test each element for a condition.</param>
        /// <param name="resultSelector">
        ///     A function to transform the first element into the result value. Will only be called if the sequence contains
        ///     an element that passes the test specified by <paramref name="predicate"/>.</param>
        /// <param name="default">
        ///     The default value to return if the sequence contains no elements.</param>
        /// <returns>
        ///     <paramref name="default"/> if <paramref name="source"/> is empty or if no element passes the test specified by
        ///     <paramref name="predicate"/>; otherwise, the transformed first element in <paramref name="source"/> that
        ///     passes the test specified by <paramref name="predicate"/>.</returns>
        public static TResult FirstOrDefault<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> resultSelector, TResult @default)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));

            if (resultSelector is null)
                throw new ArgumentNullException(nameof(resultSelector));

            using IEnumerator<TSource> e = source.GetEnumerator();

            while (e.MoveNext())
                if (predicate(e.Current))
                    return resultSelector(e.Current);

            return @default;
        }

        /// <summary>
        ///     Returns the index of the first element in this <paramref name="source"/> satisfying the specified <paramref
        ///     name="predicate"/>. If no such elements are found, returns <c>-1</c>.</summary>
        public static int IndexOf<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));

            int index = 0;

            foreach (T v in source)
            {
                if (predicate(v))
                    return index;

                index++;
            }

            return -1;
        }

        /// <summary>
        ///     Returns the index of the first element in this <paramref name="source"/> satisfying the specified <paramref
        ///     name="predicate"/>. The second parameter receives the index of each element. If no such elements are found,
        ///     returns <c>-1</c>.</summary>
        public static int IndexOf<T>(this IEnumerable<T> source, Func<T, int, bool> predicate)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));

            int index = 0;

            foreach (T v in source)
            {
                if (predicate(v, index))
                    return index;

                index++;
            }

            return -1;
        }

        /// <summary>
        ///     Returns the index of the first element in this <paramref name="source"/> satisfying the specified <paramref
        ///     name="predicate"/>, starting at the specified <paramref name="startIndex"/>. If no such elements are found,
        ///     returns <c>-1</c>.</summary>
        public static int IndexOf<T>(this IEnumerable<T> source, Func<T, bool> predicate, int startIndex)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));

            if (startIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex cannot be negative.");

            int index = 0;

            foreach (T v in source)
            {
                if (predicate(v) && index >= startIndex)
                    return index;

                index++;
            }

            return -1;
        }

        /// <summary>
        ///     Returns the index of the last element in this <paramref name="source"/> satisfying the specified <paramref
        ///     name="predicate"/>. If no such elements are found, returns <c>-1</c>.</summary>
        /// <remarks>
        ///     This method is optimised for the case in which the input sequence is a list or array. In all other cases, the
        ///     collection is evaluated completely before this method returns.</remarks>
        public static int LastIndexOf<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));

            if (source is IList<T> list)
            {
                int i = list.Count - 1;

                while (i >= 0 && !predicate(list[i]))
                    i--;

                return i;
            }

            int index = 0,
                lastIndex = -1;

            foreach (T v in source)
            {
                if (predicate(v))
                    lastIndex = index;

                index++;
            }

            return lastIndex;
        }

        /// <summary>
        ///     Returns the index of the first element in this <paramref name="source"/> that is equal to the specified
        ///     <paramref name="element"/> as determined by the specified <paramref name="comparer"/>. If no such elements are
        ///     found, returns <c>-1</c>.</summary>
        public static int IndexOf<T>(this IEnumerable<T> source, T element, IEqualityComparer<T>? comparer = null)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (comparer is null)
                comparer = EqualityComparer<T>.Default;

            int index = 0;

            foreach (T v in source)
            {
                if (comparer.Equals(v, element))
                    return index;

                index++;
            }

            return -1;
        }

        /// <summary>
        ///     Returns the minimum resulting value in a sequence, or a default value if the sequence is empty.</summary>
        /// <typeparam name="TSource">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">
        ///     A sequence of values to determine the minimum value of.</param>
        /// <param name="default">
        ///     A default value to return in case the sequence is empty.</param>
        /// <returns>
        ///     The minimum value in the sequence, or the specified default value if the sequence is empty.</returns>
        public static TSource MinOrDefault<TSource>(this IEnumerable<TSource> source, TSource @default = default!)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            MinMax(source, min: true).Destruct(out TSource result, out bool found);

            return found ? result : @default;
        }

        /// <summary>
        ///     Invokes a selector on each element of a collection and returns the minimum resulting value, or a default value
        ///     if the sequence is empty.</summary>
        /// <typeparam name="TSource">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TResult">
        ///     The type of the value returned by <paramref name="selector"/>.</typeparam>
        /// <param name="source">
        ///     A sequence of values to determine the minimum value of.</param>
        /// <param name="selector">
        ///     A transform function to apply to each element.</param>
        /// <param name="default">
        ///     A default value to return in case the sequence is empty.</param>
        /// <returns>
        ///     The minimum value in the sequence, or the specified default value if the sequence is empty.</returns>
        public static TResult MinOrDefault<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector, TResult @default = default!)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            MinMax(source.Select(selector), min: true).Destruct(out TResult result, out bool found);

            return found ? result : @default;
        }

        /// <summary>
        ///     Returns the maximum resulting value in a sequence, or a default value if the sequence is empty.</summary>
        /// <typeparam name="TSource">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">
        ///     A sequence of values to determine the maximum value of.</param>
        /// <param name="default">
        ///     A default value to return in case the sequence is empty.</param>
        /// <returns>
        ///     The maximum value in the sequence, or the specified default value if the sequence is empty.</returns>
        public static TSource MaxOrDefault<TSource>(this IEnumerable<TSource> source, TSource @default = default!)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            MinMax(source, min: false).Destruct(out TSource result, out bool found);

            return found ? result : @default;
        }

        /// <summary>
        ///     Invokes a selector on each element of a collection and returns the maximum resulting value, or a default value
        ///     if the sequence is empty.</summary>
        /// <typeparam name="TSource">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TResult">
        ///     The type of the value returned by <paramref name="selector"/>.</typeparam>
        /// <param name="source">
        ///     A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">
        ///     A transform function to apply to each element.</param>
        /// <param name="default">
        ///     A default value to return in case the sequence is empty.</param>
        /// <returns>
        ///     The maximum value in the sequence, or the specified default value if the sequence is empty.</returns>
        public static TResult MaxOrDefault<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector, TResult @default = default!)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            MinMax(source.Select(selector), min: false).Destruct(out TResult result, out bool found);

            return found ? result : @default;
        }

        /// <summary>
        ///     Returns the minimum resulting value in a sequence, or <c>null</c> if the sequence is empty.</summary>
        /// <typeparam name="TSource">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">
        ///     A sequence of values to determine the minimum value of.</param>
        /// <returns>
        ///     The minimum value in the sequence, or <c>null</c> if the sequence is empty.</returns>
        public static TSource? MinOrNull<TSource>(this IEnumerable<TSource> source) where TSource : struct
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            MinMax(source, min: true).Destruct(out TSource result, out bool found);

            return found ? result : (TSource?)null;
        }

        /// <summary>
        ///     Invokes a selector on each element of a collection and returns the minimum resulting value, or <c>null</c> if
        ///     the sequence is empty.</summary>
        /// <typeparam name="TSource">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TResult">
        ///     The type of the value returned by <paramref name="selector"/>.</typeparam>
        /// <param name="source">
        ///     A sequence of values to determine the minimum value of.</param>
        /// <param name="selector">
        ///     A transform function to apply to each element.</param>
        /// <returns>
        ///     The minimum value in the sequence, or <c>null</c> if the sequence is empty.</returns>
        public static TResult? MinOrNull<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector) where TResult : struct
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            MinMax(source.Select(selector), min: true).Destruct(out TResult result, out bool found);

            return found ? result : (TResult?)null;
        }

        /// <summary>
        ///     Returns the maximum resulting value in a sequence, or <c>null</c> if the sequence is empty.</summary>
        /// <typeparam name="TSource">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">
        ///     A sequence of values to determine the maximum value of.</param>
        /// <returns>
        ///     The maximum value in the sequence, or <c>null</c> if the sequence is empty.</returns>
        public static TSource? MaxOrNull<TSource>(this IEnumerable<TSource> source) where TSource : struct
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            MinMax(source, min: false).Destruct(out TSource result, out bool found);

            return found ? result : (TSource?)null;
        }

        /// <summary>
        ///     Invokes a selector on each element of a collection and returns the maximum resulting value, or <c>null</c> if
        ///     the sequence is empty.</summary>
        /// <typeparam name="TSource">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TResult">
        ///     The type of the value returned by <paramref name="selector"/>.</typeparam>
        /// <param name="source">
        ///     A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">
        ///     A transform function to apply to each element.</param>
        /// <returns>
        ///     The maximum value in the sequence, or <c>null</c> if the sequence is empty.</returns>
        public static TResult? MaxOrNull<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector) where TResult : struct
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            MinMax(source.Select(selector), min: false).Destruct(out TResult result, out bool found);

            return found ? result : (TResult?)null;
        }

        private static Tuple<T, bool> MinMax<T>(IEnumerable<T> source, bool min)
        {
            Comparer<T> cmp = Comparer<T>.Default;

            var curBest = default(T);
            bool haveBest = false;

            foreach (T elem in source)
            {
                if (!haveBest || (min ? cmp.Compare(elem, curBest!) < 0 : cmp.Compare(elem, curBest!) > 0))
                {
                    curBest = elem;
                    haveBest = true;
                }
            }

            return curBest!.ToTuple(haveBest);
        }

        /// <summary>
        ///     Returns the first element from the input sequence for which the value selector returns the smallest value.</summary>
        /// <exception cref="InvalidOperationException">
        ///     The input collection is empty.</exception>
        public static T MinElement<T, TValue>(this IEnumerable<T> source, Func<T, TValue> valueSelector) where TValue : IComparable<TValue> => MinMaxElement(source, valueSelector, min: true, doThrow: true)!.Item2;

        /// <summary>
        ///     Returns the first element from the input sequence for which the value selector returns the smallest value, or
        ///     a default value if the collection is empty.</summary>
        public static T MinElementOrDefault<T, TValue>(this IEnumerable<T> source, Func<T, TValue> valueSelector, T defaultValue = default!) where TValue : IComparable<TValue>
        {
            Tuple<int, T>? tup = MinMaxElement(source, valueSelector, min: true, doThrow: false);
            return tup is null ? defaultValue : tup.Item2;
        }

        /// <summary>
        ///     Returns the first element from the input sequence for which the value selector returns the largest value.</summary>
        /// <exception cref="InvalidOperationException">
        ///     The input collection is empty.</exception>
        public static T MaxElement<T, TValue>(this IEnumerable<T> source, Func<T, TValue> valueSelector) where TValue : IComparable<TValue> => MinMaxElement(source, valueSelector, min: false, doThrow: true)!.Item2;

        /// <summary>
        ///     Returns the first element from the input sequence for which the value selector returns the largest value, or a
        ///     default value if the collection is empty.</summary>
        public static T MaxElementOrDefault<T, TValue>(this IEnumerable<T> source, Func<T, TValue> valueSelector, T defaultValue = default!) where TValue : IComparable<TValue>
        {
            Tuple<int, T>? tup = MinMaxElement(source, valueSelector, min: false, doThrow: false);
            return tup is null ? defaultValue : tup.Item2;
        }

        /// <summary>
        ///     Returns the index of the first element from the input sequence for which the value selector returns the
        ///     smallest value.</summary>
        /// <exception cref="InvalidOperationException">
        ///     The input collection is empty.</exception>
        public static int MinIndex<T, TValue>(this IEnumerable<T> source, Func<T, TValue> valueSelector) where TValue : IComparable<TValue> =>
            MinMaxElement(source, valueSelector, min: true, doThrow: true)!.Item1;

        /// <summary>
        ///     Returns the index of the first element from the input sequence for which the value selector returns the
        ///     smallest value, or <c>null</c> if the collection is empty.</summary>
        public static int? MinIndexOrNull<T, TValue>(this IEnumerable<T> source, Func<T, TValue> valueSelector) where TValue : IComparable<TValue> =>
            MinMaxElement(source, valueSelector, min: true, doThrow: false)?.Item1;

        /// <summary>
        ///     Returns the index of the first element from the input sequence for which the value selector returns the
        ///     largest value.</summary>
        /// <exception cref="InvalidOperationException">
        ///     The input collection is empty.</exception>
        public static int MaxIndex<T, TValue>(this IEnumerable<T> source, Func<T, TValue> valueSelector) where TValue : IComparable<TValue> =>
            MinMaxElement(source, valueSelector, min: false, doThrow: true)!.Item1;

        /// <summary>
        ///     Returns the index of the first element from the input sequence for which the value selector returns the
        ///     largest value, or a default value if the collection is empty.</summary>
        public static int? MaxIndexOrNull<T, TValue>(this IEnumerable<T> source, Func<T, TValue> valueSelector) where TValue : IComparable<TValue> =>
            MinMaxElement(source, valueSelector, min: false, doThrow: false)?.Item1;

        private static Tuple<int, T>? MinMaxElement<T, TValue>(IEnumerable<T> source, Func<T, TValue> valueSelector, bool min, bool doThrow) where TValue : IComparable<TValue>
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (valueSelector is null)
                throw new ArgumentNullException(nameof(valueSelector));

            using (IEnumerator<T> enumerator = source.GetEnumerator())
            {
                if (!enumerator.MoveNext())
                {
                    return doThrow ? throw new InvalidOperationException("source contains no elements.") : (Tuple<int, T>?)null;
                }

                T minMaxElem = enumerator.Current;
                TValue minMaxValue = valueSelector(minMaxElem);

                int minMaxIndex = 0,
                    curIndex = 0;

                while (enumerator.MoveNext())
                {
                    curIndex++;

                    TValue value = valueSelector(enumerator.Current);

                    if (min ? (value.CompareTo(minMaxValue) < 0) : (value.CompareTo(minMaxValue) > 0))
                    {
                        minMaxValue = value;
                        minMaxElem = enumerator.Current;
                        minMaxIndex = curIndex;
                    }
                }

                return minMaxIndex.ToTuple(minMaxElem);
            }
        }

        /// <summary>
        ///     Enumerates the items of this collection, skipping the last <paramref name="count"/> items. Note that the
        ///     memory usage of this method is proportional to <paramref name="count"/>, but the source collection is only
        ///     enumerated once, and in a lazy fashion. Also, enumerating the first item will take longer than enumerating
        ///     subsequent items.</summary>
        /// <param name="source">
        ///     Source collection.</param>
        /// <param name="count">
        ///     Number of items to skip from the end of the collection.</param>
        /// <param name="throwIfNotEnough">
        ///     If <c>true</c>, the enumerator throws at the end of the enumeration if the source collection contained fewer
        ///     than <paramref name="count"/> elements.</param>
        public static IEnumerable<T> SkipLast<T>(this IEnumerable<T> source, int count, bool throwIfNotEnough = false)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), "count cannot be negative.");

            if (count is 0)
                return source;

            if (source is ICollection<T> collection)
            {
                return throwIfNotEnough && collection.Count < count
                    ? throw new InvalidOperationException("The collection does not contain enough elements.")
                    : collection.Take(Math.Max(0, collection.Count - count));
            }

            IEnumerable<T> skipLastIterator()
            {
                var queue = new T[count];
                int headtail = 0;
                int collected = 0;

                foreach (T item in source)
                {
                    if (collected < count)
                    {
                        queue[headtail] = item;
                        headtail++;
                        collected++;
                    }
                    else
                    {
                        if (headtail == count)
                            headtail = 0;

                        yield return queue[headtail];

                        queue[headtail] = item;
                        headtail++;
                    }
                }

                if (throwIfNotEnough && collected < count)
                    throw new InvalidOperationException("The collection does not contain enough elements.");
            }

            return skipLastIterator();
        }

        /// <summary>
        ///     Returns a collection containing only the last <paramref name="count"/> items of the input collection. This
        ///     method enumerates the entire collection to the end once before returning. Note also that the memory usage of
        ///     this method is proportional to <paramref name="count"/>.</summary>
        public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> source, int count)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), "count cannot be negative.");

            if (count is 0)
                return Enumerable.Empty<T>();

            if (source is IList<T> list)
            {
                IEnumerable<T> TakeLastFromList()
                {
                    for (int i = Math.Max(0, list.Count - count); i < list.Count; i++)
                        yield return list[i];
                }

                return TakeLastFromList();
            }
            else if (source is ICollection<T> collection)
            {
                IEnumerable<T> TakeLastFromCollection()
                {
                    foreach (T elem in collection.Skip(Math.Max(0, collection.Count - count)))
                        yield return elem;
                }

                return TakeLastFromCollection();
            }
            else
            {
                IEnumerable<T> TakeLast()
                {
                    var queue = new Queue<T>(count + 1);
                    foreach (T item in source)
                    {
                        if (queue.Count == count)
                            queue.Dequeue();

                        queue.Enqueue(item);
                    }

                    foreach (T item in queue)
                        yield return item;
                }

                return TakeLast();
            }
        }

        /// <summary>Returns true if and only if the input collection begins with the specified collection.</summary>
        public static bool StartsWith<T>(this IEnumerable<T> source, IEnumerable<T> sequence) => StartsWith<T>(source, sequence, EqualityComparer<T>.Default);

        /// <summary>Returns true if and only if the input collection begins with the specified collection.</summary>
        public static bool StartsWith<T>(this IEnumerable<T> source, IEnumerable<T> sequence, IEqualityComparer<T> comparer)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (sequence is null)
                throw new ArgumentNullException(nameof(sequence));

            if (comparer is null)
                throw new ArgumentNullException(nameof(comparer));

            using IEnumerator<T> sourceEnum = source.GetEnumerator(),
                seqEnum = sequence.GetEnumerator();

            while (true)
            {
                if (!seqEnum.MoveNext())
                    return true;

                if (!sourceEnum.MoveNext() || !comparer.Equals(sourceEnum.Current, seqEnum.Current))
                    return false;
            }
        }

        /// <summary>Creates a <see cref="Queue{T}"/> from an enumerable collection.</summary>
        public static Queue<T> ToQueue<T>(this IEnumerable<T> source) => source is null ? throw new ArgumentNullException(nameof(source)) : new Queue<T>(source);

        /// <summary>Creates a <see cref="Stack{T}"/> from an enumerable collection.</summary>
        public static Stack<T> ToStack<T>(this IEnumerable<T> source) => source is null ? throw new ArgumentNullException(nameof(source)) : new Stack<T>(source);

        /// <summary>
        ///     Creates a two-level dictionary from an enumerable collection according to two specified key selector functions
        ///     and optional key comparers.</summary>
        /// <typeparam name="TSource">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TKey1">
        ///     The type of the keys returned by <paramref name="key1Selector"/>.</typeparam>
        /// <typeparam name="TKey2">
        ///     The type of the keys returned by <paramref name="key2Selector"/>.</typeparam>
        /// <param name="source">
        ///     Source collection to create a dictionary from.</param>
        /// <param name="key1Selector">
        ///     A function to extract the first-level key from each element.</param>
        /// <param name="key2Selector">
        ///     A function to extract the second-level key from each element.</param>
        /// <param name="comparer1">
        ///     An equality comparer to compare the first-level keys.</param>
        /// <param name="comparer2">
        ///     An equality comparer to compare the second-level keys.</param>
        public static Dictionary<TKey1, Dictionary<TKey2, TSource>> ToDictionary2<TSource, TKey1, TKey2>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, IEqualityComparer<TKey1>? comparer1 = null, IEqualityComparer<TKey2>? comparer2 = null)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (key1Selector is null)
                throw new ArgumentNullException(nameof(key1Selector));

            if (key2Selector is null)
                throw new ArgumentNullException(nameof(key2Selector));

            var newDic = new Dictionary<TKey1, Dictionary<TKey2, TSource>>(comparer1 ?? EqualityComparer<TKey1>.Default);

            source.ForEach(e => newDic.AddSafe(key1Selector(e), key2Selector(e), e, comparer2));

            return newDic;
        }

        /// <summary>
        ///     Creates a two-level dictionary from an enumerable collection according to two specified key selector functions
        ///     and optional key comparers.</summary>
        /// <typeparam name="TSource">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TKey1">
        ///     The type of the keys returned by <paramref name="key1Selector"/>.</typeparam>
        /// <typeparam name="TKey2">
        ///     The type of the keys returned by <paramref name="key2Selector"/>.</typeparam>
        /// <typeparam name="TValue">
        ///     The type of the value returned by <paramref name="elementSelector"/>.</typeparam>
        /// <param name="source">
        ///     Source collection to create a dictionary from.</param>
        /// <param name="key1Selector">
        ///     A function to extract the first-level key from each element.</param>
        /// <param name="key2Selector">
        ///     A function to extract the second-level key from each element.</param>
        /// <param name="elementSelector">
        ///     A transform function to produce a result element value from each element.</param>
        /// <param name="comparer1">
        ///     An equality comparer to compare the first-level keys.</param>
        /// <param name="comparer2">
        ///     An equality comparer to compare the second-level keys.</param>
        public static Dictionary<TKey1, Dictionary<TKey2, TValue>> ToDictionary2<TSource, TKey1, TKey2, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TValue> elementSelector, IEqualityComparer<TKey1>? comparer1 = null, IEqualityComparer<TKey2>? comparer2 = null)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (key1Selector is null)
                throw new ArgumentNullException(nameof(key1Selector));

            if (key2Selector is null)
                throw new ArgumentNullException(nameof(key2Selector));

            if (elementSelector is null)
                throw new ArgumentNullException(nameof(elementSelector));

            var newDic = new Dictionary<TKey1, Dictionary<TKey2, TValue>>(comparer1 ?? EqualityComparer<TKey1>.Default);

            source.ForEach(e => newDic.AddSafe(key1Selector(e), key2Selector(e), elementSelector(e), comparer2));

            return newDic;
        }

        /// <summary>
        ///     Returns a collection of integers containing the indexes at which the elements of the source collection match
        ///     the given predicate.</summary>
        /// <typeparam name="T">
        ///     The type of elements in the collection.</typeparam>
        /// <param name="source">
        ///     The source collection whose elements are tested using <paramref name="predicate"/>.</param>
        /// <param name="predicate">
        ///     The predicate against which the elements of <paramref name="source"/> are tested.</param>
        /// <returns>
        ///     A collection containing the zero-based indexes of all the matching elements, in increasing order.</returns>
        public static IEnumerable<int> SelectIndexWhere<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));

            IEnumerable<int> SelectIndexWhereIterator()
            {
                int i = 0;

                using (IEnumerator<T> e = source.GetEnumerator())
                {
                    while (e.MoveNext())
                    {
                        if (predicate(e.Current))
                            yield return i;

                        i++;
                    }
                }
            }

            return SelectIndexWhereIterator();
        }

        /// <summary>
        ///     Transforms every element of an input collection using two selector functions and returns a collection
        ///     containing all the results.</summary>
        /// <typeparam name="TSource">
        ///     Type of the elements in the source collection.</typeparam>
        /// <typeparam name="TResult">
        ///     Type of the results of the selector functions.</typeparam>
        /// <param name="source">
        ///     Input collection to transform.</param>
        /// <param name="selector1">
        ///     First selector function.</param>
        /// <param name="selector2">
        ///     Second selector function.</param>
        /// <returns>
        ///     A collection containing the transformed elements from both selectors, thus containing twice as many elements
        ///     as the original collection.</returns>
        public static IEnumerable<TResult> SelectTwo<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector1, Func<TSource, TResult> selector2)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (selector1 is null)
                throw new ArgumentNullException(nameof(selector1));

            if (selector2 is null)
                throw new ArgumentNullException(nameof(selector2));

            IEnumerable<TResult> SelectTwoIterator()
            {
                foreach (TSource elem in source)
                {
                    yield return selector1(elem);
                    yield return selector2(elem);
                }
            }

            return SelectTwoIterator();
        }

        /// <summary>Returns the original collection but with every value cast to their nullable equivalent.</summary>
        public static IEnumerable<TResult?> SelectNullable<TResult>(this IEnumerable<TResult> source) where TResult : struct => source.Select(val => (TResult?)val);

        /// <summary>
        ///     Turns all elements in the enumerable to strings and joins them using the specified <paramref
        ///     name="separator"/> and the specified <paramref name="prefix"/> and <paramref name="suffix"/> for each string.</summary>
        /// <param name="values">
        ///     The sequence of elements to join into a string.</param>
        /// <param name="separator">
        ///     Optionally, a separator to insert between each element and the next.</param>
        /// <param name="prefix">
        ///     Optionally, a string to insert in front of each element.</param>
        /// <param name="suffix">
        ///     Optionally, a string to insert after each element.</param>
        /// <param name="lastSeparator">
        ///     Optionally, a separator to use between the second-to-last and the last element.</param>
        /// <example>
        ///     <code>
        ///         // Returns "[Paris], [London], [Tokyo]"
        ///         (new[] { "Paris", "London", "Tokyo" }).JoinString(", ", "[", "]")
        ///         
        ///         // Returns "[Paris], [London] and [Tokyo]"
        ///         (new[] { "Paris", "London", "Tokyo" }).JoinString(", ", "[", "]", " and ");</code></example>
        public static string JoinString<T>(this IEnumerable<T> values, string? separator = null, string? prefix = null, string? suffix = null, string? lastSeparator = null)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            if (lastSeparator is null)
                lastSeparator = separator;

            using IEnumerator<T> enumerator = values.GetEnumerator();

            if (!enumerator.MoveNext())
                return "";

            T one = enumerator.Current;

            if (!enumerator.MoveNext())
                return prefix + one + suffix;

            T two = enumerator.Current;

            if (!enumerator.MoveNext())
                return prefix is null && suffix is null ? one + lastSeparator + two : prefix + one + suffix + lastSeparator + prefix + two + suffix;

            StringBuilder sb = new StringBuilder().Append(prefix).Append(one).Append(suffix).Append(separator).Append(prefix).Append(two).Append(suffix);

            T prev = enumerator.Current;

            while (enumerator.MoveNext())
            {
                sb.Append(separator).Append(prefix).Append(prev).Append(suffix);
                prev = enumerator.Current;
            }

            sb.Append(lastSeparator).Append(prefix).Append(prev).Append(suffix);

            return sb.ToString();
        }

        /// <summary>
        ///     Inserts the specified item in between each element in the input collection.</summary>
        /// <param name="source">
        ///     The input collection.</param>
        /// <param name="extraElement">
        ///     The element to insert between each consecutive pair of elements in the input collection.</param>
        /// <returns>
        ///     A collection containing the original collection with the extra element inserted. For example, new[] { 1, 2, 3
        ///     }.InsertBetween(0) returns { 1, 0, 2, 0, 3 }.</returns>
        public static IEnumerable<T> InsertBetween<T>(this IEnumerable<T> source, T extraElement) => source is null
                ? throw new ArgumentNullException(nameof(source))
                : source.SelectMany(val => new[] { extraElement, val }).Skip(1);

        /// <summary>
        ///     Inserts the <paramref name="comma"/> item in between each element in the input collection except between the
        ///     second-last and last, where it inserts <paramref name="and"/> instead.</summary>
        /// <param name="source">
        ///     The input collection.</param>
        /// <param name="comma">
        ///     The element to insert between each consecutive pair of elements in the input collection except between the
        ///     second-last and last.</param>
        /// <param name="and">
        ///     The element to insert between the second-last and last element of the input collection.</param>
        /// <returns>
        ///     A collection containing the original collection with the extra element inserted. For example, new[] { "a",
        ///     "b", "c" }.InsertBetweenWithAnd(", ", " and ") returns { "a", ", ", "b", " and ", "c" }.</returns>
        public static IEnumerable<T> InsertBetweenWithAnd<T>(this IEnumerable<T> source, T comma, T and)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            IEnumerable<T> InsertBetweenWithAndIterator()
            {
                using IEnumerator<T> enumerator = source.GetEnumerator();

                if (!enumerator.MoveNext())
                    yield break;

                yield return enumerator.Current;

                if (!enumerator.MoveNext())
                    yield break;

                T prev = enumerator.Current;

                while (enumerator.MoveNext())
                {
                    yield return comma;
                    yield return prev;

                    prev = enumerator.Current;
                }

                yield return and;
                yield return prev;
            }

            return InsertBetweenWithAndIterator();
        }

        /// <summary>Determines whether this sequence comprises the values provided in the specified order.</summary>
        public static bool SequenceEqual<T>(this IEnumerable<T> sequence1, params T[] sequence2) => Enumerable.SequenceEqual(sequence1, sequence2);

        /// <summary>Determines whether all the input sequences are equal according to SequenceEquals.</summary>
        public static bool AllSequencesEqual<T>(this IEnumerable<IEnumerable<T>> sources)
        {
            using IEnumerator<IEnumerable<T>> e = sources.GetEnumerator();

            if (!e.MoveNext())
                return true;

            IEnumerable<T> firstSequence = e.Current;

            while (e.MoveNext())
                if (!firstSequence.SequenceEqual(e.Current))
                    return false;

            return true;
        }

        /// <summary>
        ///     Splits a collection into chunks of equal size. The last chunk may be smaller than <paramref
        ///     name="chunkSize"/>, but all chunks, if any, will contain at least one item.</summary>
        public static IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> source, int chunkSize)
        {
            if (chunkSize <= 0)
                throw new ArgumentException("chunkSize must be greater than zero.", nameof(chunkSize));

            IEnumerable<IEnumerable<T>> SplitIterator()
            {
                var list = new List<T>(chunkSize);

                foreach (T item in source)
                {
                    list.Add(item);

                    if (list.Count == chunkSize)
                    {
                        yield return list;
                        list = new List<T>(chunkSize);
                    }
                }

                if (list.Count > 0)
                    yield return list;
            }

            return SplitIterator();
        }

        /// <summary>
        ///     Accumulates consecutive equal elements.</summary>
        /// <typeparam name="TItem">
        ///     The type of items in the input sequence.</typeparam>
        /// <param name="source">
        ///     The input sequence from which to accumulate groups of consecutive elements.</param>
        /// <param name="itemEquality">
        ///     An optional function to determine equality of items.</param>
        /// <returns>
        ///     A collection containing each sequence of consecutive equal elements.</returns>
        public static IEnumerable<ConsecutiveGroup<TItem, TItem>> GroupConsecutive<TItem>(this IEnumerable<TItem> source, Func<TItem, TItem, bool> itemEquality) => GroupConsecutiveBy(source, x => x, new CustomEqualityComparer<TItem>(itemEquality));

        /// <summary>
        ///     Accumulates consecutive equal elements.</summary>
        /// <typeparam name="TItem">
        ///     The type of items in the input sequence.</typeparam>
        /// <param name="source">
        ///     The input sequence from which to accumulate groups of consecutive elements.</param>
        /// <param name="itemComparer">
        ///     An optional equality comparer to determine item equality by.</param>
        /// <returns>
        ///     A collection containing each sequence of consecutive equal elements.</returns>
        public static IEnumerable<ConsecutiveGroup<TItem, TItem>> GroupConsecutive<TItem>(this IEnumerable<TItem> source, IEqualityComparer<TItem>? itemComparer = null) => GroupConsecutiveBy(source, x => x, itemComparer);

        /// <summary>
        ///     Accumulates consecutive elements that are equal when processed by a selector.</summary>
        /// <typeparam name="TItem">
        ///     The type of items in the input sequence.</typeparam>
        /// <typeparam name="TKey">
        ///     The return type of the <paramref name="selector"/> function.</typeparam>
        /// <param name="source">
        ///     The input sequence from which to accumulate groups of consecutive elements.</param>
        /// <param name="selector">
        ///     A function to transform each item into a key which is compared for equality.</param>
        /// <param name="keyComparer">
        ///     An optional equality comparer for the keys returned by <paramref name="selector"/>.</param>
        /// <returns>
        ///     A collection containing each sequence of consecutive equal elements.</returns>
        public static IEnumerable<ConsecutiveGroup<TItem, TKey>> GroupConsecutiveBy<TItem, TKey>(this IEnumerable<TItem> source, Func<TItem, TKey> selector, IEqualityComparer<TKey>? keyComparer = null)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            IEnumerable<ConsecutiveGroup<TItem, TKey>> GroupConsecutiveIterator()
            {
                bool any = false;
                var prevKey = default(TKey);
                int index = 0;
                var currentList = new List<TItem>();

                foreach (TItem elem in source)
                {
                    TKey key = selector(elem);

                    if (!any)
                        any = true;
                    else if (keyComparer is { } ? !keyComparer.Equals(prevKey!, key) : !Equals(prevKey, key))
                    {
                        yield return new ConsecutiveGroup<TItem, TKey>(index - currentList.Count, currentList, prevKey!);
                        currentList = new List<TItem>();
                    }

                    currentList.Add(elem);

                    prevKey = key;
                    index++;
                }

                if (any)
                    yield return new ConsecutiveGroup<TItem, TKey>(index - currentList.Count, currentList, prevKey!);
            }

            return GroupConsecutiveIterator();
        }

        /// <summary>
        ///     Enumerates a chain of objects where each object refers to the next one. The chain starts with the specified
        ///     object and ends when null is encountered.</summary>
        /// <typeparam name="T">
        ///     Type of object to enumerate.</typeparam>
        /// <param name="obj">
        ///     Initial object.</param>
        /// <param name="next">
        ///     A function that returns the next object given the current one. If null is returned, enumeration will end.</param>
        public static IEnumerable<T> SelectChain<T>(this T obj, Func<T, T> next) where T : class
        {
            while (obj is { })
            {
                yield return obj;
                obj = next(obj);
            }
        }

        /// <summary>
        ///     Determines which element occurs the most often in the specified input sequence.</summary>
        /// <typeparam name="T">
        ///     Type of elements in the input sequence.</typeparam>
        /// <param name="source">
        ///     Sequence to find most common element in.</param>
        /// <param name="comparer">
        ///     Optional equality comparer to compare elements by.</param>
        /// <returns>
        ///     Of all elements that occur the most number of times, the one whose last instance occurs soonest in the
        ///     sequence.</returns>
        public static T MaxCountElement<T>(this IEnumerable<T> source, IEqualityComparer<T>? comparer = null) => MaxCountElement(source, out _, comparer);

        /// <summary>
        ///     Determines which element occurs the most often in the specified input sequence, and how often.</summary>
        /// <typeparam name="T">
        ///     Type of elements in the input sequence.</typeparam>
        /// <param name="source">
        ///     Sequence to find most common element in.</param>
        /// <param name="count">
        ///     Receives the number of times the element occurred.</param>
        /// <param name="comparer">
        ///     Optional equality comparer to compare elements by.</param>
        /// <returns>
        ///     Of all elements that occur the most number of times, the one whose last instance occurs soonest in the
        ///     sequence.</returns>
        public static T MaxCountElement<T>(this IEnumerable<T> source, out int count, IEqualityComparer<T>? comparer = null)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            var counts = new Dictionary<T, int>(comparer);
            var curMaxElement = default(T);

            count = 0;

            foreach (T elem in source)
            {
                int newCount = counts.IncSafe(elem);
                if (newCount > count)
                {
                    count = newCount;
                    curMaxElement = elem;
                }
            }

            return count is 0 ? throw new InvalidOperationException("The specified collection contained no elements.") : curMaxElement!;
        }

        /// <summary>Returns the sum of the values in the specified collection, truncated to a 32-bit integer.</summary>
        public static int SumUnchecked(this IEnumerable<int> source)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            unchecked
            {
                int sum = 0;

                source.ForEach(v => sum += v);

                return sum;
            }
        }

        /// <summary>
        ///     Returns the sum of the values in the specified collection projected by the specified selector function,
        ///     truncated to a 32-bit integer.</summary>
        public static int SumUnchecked<T>(this IEnumerable<T> source, Func<T, int> selector)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            unchecked
            {
                int sum = 0;

                source.ForEach(v => sum += selector(v));

                return sum;
            }
        }

        /// <summary>
        ///     Returns only the non-<c>null</c> elements from the specified collection of nullable values as non-nullable
        ///     values.</summary>
        /// <typeparam name="T">
        ///     The inner value type.</typeparam>
        /// <param name="src">
        ///     A collection of nullable values.</param>
        /// <returns>
        ///     A collection containing only those values that aren’t <c>null</c>.</returns>
        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> src) where T : struct
        {
            if (src is null)
                throw new ArgumentNullException(nameof(src));

            IEnumerable<T> WhereNotNullIterator()
            {
                foreach (T? tq in src)
                    if (tq is { })
                        yield return tq.Value;
            }

            return WhereNotNullIterator();
        }

        /// <summary>
        ///     Determines whether all elements of a sequence satisfy a condition by incorporating the element's index.</summary>
        /// <typeparam name="T">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">
        ///     An <see cref="IEnumerable{T}"/> that contains the elements to apply the predicate to.</param>
        /// <param name="predicate">
        ///     A function to test each element for a condition; the second parameter of the function represents the index of
        ///     the source element.</param>
        /// <returns>
        ///     <c>true</c> if every element of the source sequence passes the test in the specified <paramref
        ///     name="predicate"/>, or if the sequence is empty; otherwise, false.</returns>
        public static bool All<T>(this IEnumerable<T> source, Func<T, int, bool> predicate)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));

            int ix = 0;

            foreach (T elem in source)
            {
                if (!predicate(elem, ix))
                    return false;
                ix++;
            }

            return true;
        }

        /// <summary>
        ///     Determines whether any element of a sequence satisfies a condition by incorporating the element's index.</summary>
        /// <typeparam name="T">
        ///     The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">
        ///     An <see cref="IEnumerable{T}"/> that contains the elements to apply the predicate to.</param>
        /// <param name="predicate">
        ///     A function to test each element for a condition; the second parameter of the function represents the index of
        ///     the source element.</param>
        /// <returns>
        ///     <c>true</c> if any elements in the source sequence pass the test in the specified <paramref
        ///     name="predicate"/>; otherwise, false.</returns>
        public static bool Any<T>(this IEnumerable<T> source, Func<T, int, bool> predicate)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));

            int ix = 0;

            foreach (T elem in source)
            {
                if (predicate(elem, ix))
                    return true;
                ix++;
            }

            return false;
        }

        /// <summary>
        ///     Converts an <c>IEnumerable&lt;KeyValuePair&lt;TKey, TValue&gt;&gt;</c> into a <c>Dictionary&lt;TKey,
        ///     TValue&gt;</c>.</summary>
        /// <param name="source">
        ///     Source collection to convert to a dictionary.</param>
        /// <param name="comparer">
        ///     An optional equality comparer to compare keys.</param>
        /// <param name="ignoreDuplicateKeys">
        ///     If <c>true</c>, duplicate keys are ignored and only their first occurrence added to the dictionary. Otherwise,
        ///     a duplicate key causes an exception.</param>
        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, IEqualityComparer<TKey>? comparer = null, bool ignoreDuplicateKeys = false)
        {
            if (!ignoreDuplicateKeys)
                return source.ToDictionary(kvp => kvp.Key, kvp => kvp.Value, comparer ?? EqualityComparer<TKey>.Default);

            var result = new Dictionary<TKey, TValue>();

            foreach (KeyValuePair<TKey, TValue> entry in source)
                if (!result.ContainsKey(entry.Key))
                    result.Add(entry.Key, entry.Value);

            return result;
        }

        /// <summary>Sorts the elements of a sequence in ascending order by using a specified comparison delegate.</summary>
        public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> source, Comparison<T> comparison) => source is null ? throw new ArgumentNullException(nameof(source))
                : comparison is null ? throw new ArgumentNullException(nameof(comparison))
                : source.OrderBy(x => x, new CustomComparer<T>(comparison));

        /// <summary>
        /// Returns an enumeration of tuples containing all pairs of elements from the source collection.
        /// For example, the input sequence 1, 2 yields the pairs [1,1], [1,2], [2,1], and [2,2].
        /// </summary>
        public static IQueryable<Tuple<T, T>> AllPairs<T>(this IQueryable<T> source) => source.SelectMany(item1 => source.Select(item2 => new Tuple<T, T>(item1, item2)));

        /// <summary>
        /// Returns an enumeration of <see cref="Tuple&lt;T, U&gt;"/>s containing all ordered pairs of elements from the two source collections.
        /// For example, [1, 2].Join(["one", "two"]) results in the tuples [1, "one"], [1, "two"], [2, "one"] and [2, "two"].
        /// </summary>
        public static IQueryable<Tuple<T, U>> Join<T, U>(this IQueryable<T> source, IQueryable<U> with) => source.SelectMany(item1 => with.Select(item2 => new Tuple<T, U>(item1, item2)));

        /// <summary>
        /// Returns an enumeration of tuples containing all unique pairs of distinct elements from the source collection.
        /// For example, the input sequence 1, 2, 3 yields the pairs [1,2], [1,3] and [2,3] only.
        /// </summary>
        /// <remarks>Warning: This method does not work with IQToolkit.</remarks>
        public static IQueryable<Tuple<T, T>> UniquePairs<T>(this IQueryable<T> source) => source.SelectMany((item1, index) => source.Take(index + 1).Select(item2 => new Tuple<T, T>(item1, item2)));

        /// <summary>
        /// Returns an enumeration of tuples containing all consecutive pairs of the elements.
        /// </summary>
        /// <param name="source">The input enumerable.</param>
        /// <param name="closed">If true, an additional pair containing the last and first element is included. For example,
        /// if the source collection contains { 1, 2, 3, 4 } then the enumeration contains { (1, 2), (2, 3), (3, 4) } if <paramref name="closed"/>
        /// is false, and { (1, 2), (2, 3), (3, 4), (4, 1) } if <paramref name="closed"/> is true.</param>
        /// <remarks>Warning: This method does not work with IQToolkit.</remarks>
        public static IQueryable<Tuple<T, T>> ConsecutivePairs<T>(this IQueryable<T> source, bool closed) => closed
                ? source.Select((item, index) => new Tuple<T, T>(item, source.Concat(source.First()).Skip(index + 1).First()))
                : source.Select((item, index) => new Tuple<T, T>(item, source.Skip(index + 1).First()));

        /// <summary>
        /// Returns an enumeration of the specified enumerable in sorted order.
        /// </summary>
        public static IOrderedQueryable<T> Order<T>(this IQueryable<T> source) => source.OrderBy(x => x);

        /// <summary>
        /// Returns an enumeration of the specified enumerable in sorted order.
        /// </summary>
        public static IOrderedQueryable<T> Order<T>(this IQueryable<T> source, IComparer<T> comparison) => source.OrderBy(x => x, comparison);

        /// <summary>
        /// Adds a single element to the end of an IQueryable.
        /// </summary>
        /// <typeparam name="T">Type of enumerable to return.</typeparam>
        /// <returns>IQueryable containing all the input elements, followed by the specified additional element.</returns>
        public static IQueryable<T> Concat<T>(this IQueryable<T> input, T element) => input.Concat(new[] { element });

        /// <summary>
        /// Returns the first element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">The collection to return the first element of.</param>
        /// <param name="default">The default value to return if the sequence contains no elements.</param>
        /// <returns><paramref name="default"/> if <paramref name="source"/> is empty;
        /// otherwise, the first element in <paramref name="source"/>.</returns>
        public static T FirstOrDefault<T>(this IQueryable<T> source, T @default)
        {
            using IEnumerator<T> e = source.Take(1).GetEnumerator();
            return e.MoveNext() ? e.Current : @default;
        }

        /// <summary>
        /// Returns the first element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">The collection to return the first element of.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="default">The default value to return if the sequence contains no elements.</param>
        /// <returns><paramref name="default"/> if <paramref name="source"/> is empty or if no element passes the test specified by <paramref name="predicate"/>;
        /// otherwise, the first element in <paramref name="source"/> that passes the test specified by <paramref name="predicate"/>.</returns>
        public static T FirstOrDefault<T>(this IQueryable<T> source, Expression<Func<T, bool>> predicate, T @default)
        {
            using IEnumerator<T> e = source.Where(predicate).Take(1).GetEnumerator();
            return e.MoveNext() ? e.Current : @default;
        }

        /// <summary>
        /// Returns the first element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TResult">The type of the resulting value.</typeparam>
        /// <param name="source">The collection to return the first element of.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="resultSelector">A function to transform the first element into the result value. Will only be called if the sequence contains an element that passes the test specified by <paramref name="predicate"/>.</param>
        /// <param name="default">The default value to return if the sequence contains no elements.</param>
        /// <returns><paramref name="default"/> if <paramref name="source"/> is empty or if no element passes the test specified by <paramref name="predicate"/>;
        /// otherwise, the transformed first element in <paramref name="source"/> that passes the test specified by <paramref name="predicate"/>.</returns>
        public static TResult FirstOrDefault<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, Func<TSource, TResult> resultSelector, TResult @default)
        {
            using IEnumerator<TResult> e = source.Where(predicate).Select(resultSelector).Take(1).GetEnumerator();
            return e.MoveNext() ? e.Current : @default;
        }

        /// <summary>
        ///     Clips this value to the range defined by <paramref name="minimumValue"/> and <paramref name="maximumValue"/>.
        ///     The returned number will be no less than the minimum value and no greater than the maximum value. Throws an
        ///     exception if min value is greater than the max value.</summary>
        public static int Clip(this int value, int minimumValue, int maximumValue) => minimumValue > maximumValue
                ? throw new ArgumentException("Clip: minimumValue cannot be greater than maximumValue.", nameof(maximumValue))
                : value <= minimumValue ? minimumValue : value >= maximumValue ? maximumValue : value;

        /// <summary>Clips this value so that it is no less than the minimum value specified.</summary>
        public static int ClipMin(this int value, int minimumValue) => value <= minimumValue ? minimumValue : value;

        /// <summary>Clips this value so that it is no greater than the maximum value specified.</summary>
        public static int ClipMax(this int value, int maxnimumValue) => value >= maxnimumValue ? maxnimumValue : value;

        /// <summary>
        ///     Clips this value to the range defined by <paramref name="minimumValue"/> and <paramref name="maximumValue"/>.
        ///     The returned number will be no less than the minimum value and no greater than the maximum value. Throws an
        ///     exception if min value is greater than the max value.</summary>
        public static float Clip(this float value, float minimumValue, float maximumValue) => minimumValue > maximumValue
                ? throw new ArgumentException("Clip: minimumValue cannot be greater than maximumValue.", nameof(maximumValue))
                : value <= minimumValue ? minimumValue : value >= maximumValue ? maximumValue : value;

        /// <summary>Clips this value so that it is no less than the minimum value specified.</summary>
        public static float ClipMin(this float value, float minimumValue) => value <= minimumValue ? minimumValue : value;

        /// <summary>Clips this value so that it is no greater than the maximum value specified.</summary>
        public static float ClipMax(this float value, float maxnimumValue) => value >= maxnimumValue ? maxnimumValue : value;

        /// <summary>
        ///     Clips this value to the range defined by <paramref name="minimumValue"/> and <paramref name="maximumValue"/>.
        ///     The returned number will be no less than the minimum value and no greater than the maximum value. Throws an
        ///     exception if min value is greater than the max value.</summary>
        public static double Clip(this double value, double minimumValue, double maximumValue) => minimumValue > maximumValue
                ? throw new ArgumentException("Clip: minimumValue cannot be greater than maximumValue.", nameof(maximumValue))
                : value <= minimumValue ? minimumValue : value >= maximumValue ? maximumValue : value;

        /// <summary>Clips this value so that it is no less than the minimum value specified.</summary>
        public static double ClipMin(this double value, double minimumValue) => value <= minimumValue ? minimumValue : value;

        /// <summary>Clips this value so that it is no greater than the maximum value specified.</summary>
        public static double ClipMax(this double value, double maxnimumValue) => value >= maxnimumValue ? maxnimumValue : value;

        /// <summary>
        ///     Clips this value to the range defined by <paramref name="minimumValue"/> and <paramref name="maximumValue"/>.
        ///     The returned number will be no less than the minimum value and no greater than the maximum value. Throws an
        ///     exception if min value is greater than the max value.</summary>
        public static decimal Clip(this decimal value, decimal minimumValue, decimal maximumValue) => minimumValue > maximumValue
                ? throw new ArgumentException("Clip: minimumValue cannot be greater than maximumValue.", nameof(maximumValue))
                : value <= minimumValue ? minimumValue : value >= maximumValue ? maximumValue : value;

        /// <summary>Clips this value so that it is no less than the minimum value specified.</summary>
        public static decimal ClipMin(this decimal value, decimal minimumValue) => value <= minimumValue ? minimumValue : value;

        /// <summary>Clips this value so that it is no greater than the maximum value specified.</summary>
        public static decimal ClipMax(this decimal value, decimal maxnimumValue) => value >= maxnimumValue ? maxnimumValue : value;

        /// <summary>Attempts to parse this string as an int, returning null if the parse fails.</summary>
        public static int? TryParseAsInt(this string value) => int.TryParse(value, out int result) ? result : (int?)null;

        /// <summary>
        ///     Converts the integer to a textual representation using English words. For example, 142.ToWords() is "one
        ///     hundred and forty-two".</summary>
        public static string ToWords(this int number)
        {
            if (number is 0)
                return "zero";

            if (number < 0)
                return "minus " + ToWords(-number);

            string words = "";

            if (number / 1000000000 > 0)
            {
                words += " " + ToWords(number / 1000000000) + " billion";
                number %= 1000000000;
            }

            if (number / 1000000 > 0)
            {
                words += " " + ToWords(number / 1000000) + " million";
                number %= 1000000;
            }

            if (number / 1000 > 0)
            {
                words += " " + ToWords(number / 1000) + " thousand";
                number %= 1000;
            }

            if (number / 100 > 0)
            {
                words += " " + ToWords(number / 100) + " hundred";
                number %= 100;
            }

            if (number > 0)
            {
                if (!(words is ""))
                    words += " and";

                string?[] unitsMap = new[] { null, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string?[] tensMap = new[] { null, "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += " " + unitsMap[number];
                else
                {
                    words += " " + tensMap[number / 10];
                    if (number % 10 > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words.Substring(1);
        }

        /// <summary>
        ///     Determines whether the current type is, derives from, or implements the specified generic type, and determines
        ///     that type’s generic type parameters.</summary>
        /// <param name="type">
        ///     The current type.</param>
        /// <param name="typeToFind">
        ///     A generic type definition for a base type of interface, e.g. <c>typeof(ICollection&lt;&gt;)</c> or
        ///     <c>typeof(IDictionary&lt;,&gt;)</c>.</param>
        /// <param name="typeParameters">
        ///     Receives an array containing the generic type parameters of the generic type.</param>
        /// <returns>
        ///     <c>true</c> if the current type is, derives from or implements the specified generic type.</returns>
        public static bool TryGetGenericParameters(this Type type, Type typeToFind, out Type[]? typeParameters)
        {
            typeParameters = null;

            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeToFind)
            {
                typeParameters = type.GetGenericArguments();
                return true;
            }

            if (typeToFind.IsInterface)
            {
                Type implements = type.FindInterfaces((ty, obj) => ty.IsGenericType && ty.GetGenericTypeDefinition() == typeToFind, null).FirstOrDefault();

                if (implements is null)
                    return false;

                typeParameters = implements.GetGenericArguments();

                return true;
            }

            foreach (Type baseType in type.SelectChain(t => t.BaseType))
            {
                if (baseType.IsGenericType && baseType.GetGenericTypeDefinition() == typeToFind)
                {
                    typeParameters = baseType.GetGenericArguments();
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        ///     Returns all fields contained in the specified type, including private fields inherited from base classes.</summary>
        /// <param name="type">
        ///     The type to return all fields of.</param>
        /// <returns>
        ///     An <see cref="IEnumerable&lt;FieldInfo&gt;"/> containing all fields contained in this type, including private
        ///     fields inherited from base classes.</returns>
        public static IEnumerable<FieldInfo> GetAllFields(this Type type)
        {
            IEnumerable<FieldInfo> fields = type.GetFields(Flags);

            Type baseType = type.BaseType;

            return baseType is null ? fields : GetAllFields(baseType).Concat(fields);
        }

        /// <summary>
        ///     Returns all properties contained in the specified type, including private properties inherited from base
        ///     classes.</summary>
        /// <param name="type">
        ///     The type to return all properties of.</param>
        /// <returns>
        ///     An <see cref="IEnumerable&lt;PropertyInfo&gt;"/> containing all properties contained in this type, including
        ///     private properties inherited from base classes.</returns>
        public static IEnumerable<PropertyInfo> GetAllProperties(this Type type)
        {
            IEnumerable<PropertyInfo> properties = type.GetProperties(Flags);

            Type baseType = type.BaseType;

            return baseType is null ? properties : GetAllProperties(baseType).Concat(properties);
        }

        /// <summary>
        ///     Indicates whether one or more instance of the specified attribute type is applied to this member.</summary>
        /// <typeparam name="T">
        ///     The type of attribute to search for.</typeparam>
        /// <param name="member">
        ///     Member whose custom attributes to search.</param>
        /// <param name="inherit">
        ///     Specifies whether to search this member's inheritance chain to find the attributes.</param>
        public static bool IsDefined<T>(this MemberInfo member, bool inherit = false) => member.IsDefined(typeof(T), inherit);

        /// <summary>
        ///     Indicates whether one or more instance of the specified attribute type is applied to this parameter.</summary>
        /// <typeparam name="T">
        ///     The type of attribute to search for.</typeparam>
        /// <param name="parameter">
        ///     Parameter whose custom attributes to search.</param>
        public static bool IsDefined<T>(this ParameterInfo parameter) => parameter.IsDefined(typeof(T), false /* This argument is ignored */);

        /// <summary>Determines whether a property has a public getter.</summary>
        public static bool HasPublicGetter(this PropertyInfo Property)
        {
            MethodInfo meth = Property.GetGetMethod();
            return meth is { } && meth.IsPublic;
        }

        /// <summary>Determines whether a property is static.</summary>
        public static bool IsStatic(this PropertyInfo Property)
        {
            MethodInfo meth = Property.GetGetMethod();
            return meth is null ? Property.GetSetMethod().IsStatic : meth.IsStatic;
        }

        /// <summary>
        ///     Returns the equivalent of <c>default(T)</c> for a <c>Type</c> object. For reference or nullable types, this is
        ///     <c>null</c>, while for value types, it is the default value (e.g. <c>false</c>, <c>0</c>, etc.).</summary>
        /// <param name="type">
        ///     The type to retrieve the default value for.</param>
        public static object? GetDefaultValue(this Type type) => type.IsValueType ? Activator.CreateInstance(type) : null;

        /// <summary>Contains the set of characters that are used in base64-url encoding.</summary>
        public const string CharsBase64Url = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_";

        private static int[]? s_invBase64Url;

        /// <summary>
        ///     Concatenates the specified number of repetitions of the current string.</summary>
        /// <param name="input">
        ///     The string to be repeated.</param>
        /// <param name="numTimes">
        ///     The number of times to repeat the string.</param>
        /// <returns>
        ///     A concatenated string containing the original string the specified number of times.</returns>
        public static string Repeat(this string input, int numTimes)
        {
            switch (numTimes)
            {
                case 0:
                    return "";
                case 1:
                    return input;
                case 2:
                    return input + input;
            }

            var sb = new StringBuilder();

            for (int i = 0; i < numTimes; i++)
                sb.Append(input);

            return sb.ToString();
        }

        /// <summary>
        ///     Escapes all necessary characters in the specified string so as to make it usable safely in an HTML or XML
        ///     context.</summary>
        /// <param name="input">
        ///     The string to apply HTML or XML escaping to.</param>
        /// <param name="leaveSingleQuotesAlone">
        ///     If <c>true</c>, does not escape single quotes (<c>'</c>, U+0027).</param>
        /// <param name="leaveDoubleQuotesAlone">
        ///     If <c>true</c>, does not escape single quotes (<c>"</c>, U+0022).</param>
        /// <returns>
        ///     The specified string with the necessary HTML or XML escaping applied.</returns>
        public static string HtmlEscape(this string input, bool leaveSingleQuotesAlone = false, bool leaveDoubleQuotesAlone = false)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));

            string result = input.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");

            if (!leaveSingleQuotesAlone)
                result = result.Replace("'", "&#39;");

            if (!leaveDoubleQuotesAlone)
                result = result.Replace("\"", "&quot;");

            return result;
        }

        /// <summary>Contains the set of ASCII characters allowed in a URL.</summary>
        private static byte[] UrlAllowedBytes
        {
            get
            {
                if (s_urlAllowedBytesCache is null)
                    s_urlAllowedBytesCache = Encoding.UTF8.GetBytes("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789$-_.!*(),/:;@");
                return s_urlAllowedBytesCache;
            }
        }
        private static byte[]? s_urlAllowedBytesCache;

        /// <summary>
        ///     Escapes all necessary characters in the specified string so as to make it usable safely in a URL.</summary>
        /// <param name="input">
        ///     The string to apply URL escaping to.</param>
        /// <returns>
        ///     The specified string with the necessary URL escaping applied.</returns>
        /// <seealso cref="UrlUnescape(string)"/>
        public static string UrlEscape(this string input)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));

            byte[] utf8 = input.ToUtf8();

            var sb = new StringBuilder();

            utf8.ForEach(b =>
            {
                if (UrlAllowedBytes.Contains(b))
                    sb.Append((char)b);
                else
                    sb.AppendFormat("%{0:X2}", b);
            });

            return sb.ToString();
        }

        /// <summary>
        ///     Reverses the escaping performed by <see cref="UrlEscape"/> by decoding hexadecimal URL escape sequences into
        ///     their original characters.</summary>
        /// <param name="input">
        ///     String containing URL escape sequences to be decoded.</param>
        /// <returns>
        ///     The specified string with all URL escape sequences decoded.</returns>
        /// <seealso cref="UrlEscape(string)"/>
        public static string UrlUnescape(this string input)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));

            if (input.Length < 3)
                return input.Replace('+', ' ');

            byte[] buffer = new byte[input.Length];

            int bufIx = 0,
                inpIx = 0;

            while (inpIx < input.Length)
            {
                if (inpIx <= input.Length - 6 && input[inpIx] is '%' && input[inpIx + 1] is 'u' && int.TryParse(input.Substring(inpIx + 2, 4), NumberStyles.AllowHexSpecifier, null, out int i))
                {
                    bufIx += Encoding.UTF8.GetBytes(char.ConvertFromUtf32(i), 0, 1, buffer, bufIx);
                    inpIx += 6;
                }
                else if (inpIx <= input.Length - 3 && input[inpIx] is '%' && int.TryParse(input.Substring(inpIx + 1, 2), NumberStyles.AllowHexSpecifier, null, out i))
                {
                    buffer[bufIx] = (byte)i;
                    bufIx++;
                    inpIx += 3;
                }
                else if (!(input[inpIx] is '%'))
                {
                    buffer[bufIx] = input[inpIx] is '+' ? (byte)' ' : (byte)input[inpIx];
                    bufIx++;
                    inpIx++;
                }
                else
                    throw new ArgumentException("The input string is not in valid URL-escaped format.", nameof(input));
            }

            return Encoding.UTF8.GetString(buffer, 0, bufIx);
        }

        /// <summary>Contains the set of characters disallowed in file names across all filesystems supported by our software.</summary>
        private static char[] FilenameDisallowedCharacters
        {
            get
            {
                if (s_filenameDisallowedCharactersCache is null)
                    s_filenameDisallowedCharactersCache = @"\/:?*""<>|{}".ToCharArray();
                return s_filenameDisallowedCharactersCache;
            }
        }
        private static char[]? s_filenameDisallowedCharactersCache;

        /// <summary>
        ///     Escapes all characters in this string which cannot form part of a valid filename on at least one supported
        ///     filesystem. The escaping is fully reversible (via <see cref="FilenameCharactersUnescape"/>), but does not
        ///     treat characters at specific positions differently (e.g. the "." at the end of the name is not escaped, even
        ///     though it will disappear on a Win32 system).</summary>
        public static string FilenameCharactersEscape(this string input, bool includeNonAscii = false)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));

            var result = new StringBuilder(input.Length + input.Length / 2);

            foreach (char c in input)
            {
                if (FilenameDisallowedCharacters.Contains(c) || c >= 128 && includeNonAscii)
                {
                    result.Append('{');
                    foreach (byte bt in Encoding.UTF8.GetBytes(c.ToString()))
                        result.AppendFormat("{0:X2}", bt);
                    result.Append('}');
                }
                else
                    result.Append(c);
            }

            return result.ToString();
        }

        /// <summary>
        ///     Reverses the transformation done by <see cref="FilenameCharactersEscape"/>. This routine will also work on
        ///     filenames that cannot have been generated by the above escape procedure; any "invalid" escapes will be
        ///     preserved as-is.</summary>
        public static string FilenameCharactersUnescape(this string input)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));

            var result = new StringBuilder(input.Length);
            byte[] decode = new byte[4];

            int offset = 0;
            while (offset < input.Length)
            {
                if (input[offset] is '{')
                {
                    int decodeCount = 0;
                    int startOffset = offset;
                    offset++;
                    while (offset < input.Length)
                    {
                        char c = char.ToUpperInvariant(input[offset]);
                        if (c is '}')
                        {
                            offset++;
                            if (decodeCount > 0)
                            {
                                try
                                {
                                    result.Append(Encoding.UTF8.GetString(decode, 0, decodeCount));
                                    startOffset = -1;
                                }
                                catch (ArgumentException) { }
                            }

                            break;
                        }
                        else if (c >= '0' && c <= '9' || c >= 'A' && c <= 'F')
                        {
                            offset++;
                            if (offset >= input.Length || decodeCount is 4)
                                break;
                            char c2 = char.ToUpperInvariant(input[offset]);
                            if (c2 >= '0' && c2 <= '9' || c2 >= 'A' && c2 <= 'F')
                            {
                                offset++;
                                decode[decodeCount] = (byte)((c < 'A' ? c - '0' : c - '7') * 16 | (c2 < 'A' ? c2 - '0' : c2 - '7'));
                                decodeCount++;
                            }
                            else
                                break;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (!(startOffset is -1))
                        result.Append(input, startOffset, offset - startOffset);
                }
                else
                {
                    result.Append(input[offset]);
                    offset++;
                }
            }

            return result.ToString();
        }

        /// <summary>
        ///     Converts the specified string to UTF-8.</summary>
        /// <param name="input">
        ///     String to convert to UTF-8.</param>
        /// <returns>
        ///     The specified string, converted to a byte-array containing the UTF-8 encoding of the string.</returns>
        public static byte[] ToUtf8(this string input) => input is null ? throw new ArgumentNullException(nameof(input)) : Encoding.UTF8.GetBytes(input);

        /// <summary>
        ///     Converts the specified string to UTF-16.</summary>
        /// <param name="input">
        ///     String to convert to UTF-16.</param>
        /// <returns>
        ///     The specified string, converted to a byte-array containing the UTF-16 encoding of the string.</returns>
        public static byte[] ToUtf16(this string input) => input is null ? throw new ArgumentNullException(nameof(input)) : Encoding.Unicode.GetBytes(input);

        /// <summary>
        ///     Converts the specified string to UTF-16 (Big Endian).</summary>
        /// <param name="input">
        ///     String to convert to UTF-16 (Big Endian).</param>
        /// <returns>
        ///     The specified string, converted to a byte-array containing the UTF-16 (Big Endian) encoding of the string.</returns>
        public static byte[] ToUtf16BE(this string input) => input is null ? throw new ArgumentNullException(nameof(input)) : Encoding.BigEndianUnicode.GetBytes(input);

        /// <summary>
        ///     Converts the specified raw UTF-8 data to a string.</summary>
        /// <param name="input">
        ///     Data to interpret as UTF-8 text.</param>
        /// <param name="removeBom">
        ///     <c>true</c> to remove the first character if it is a UTF-8 BOM.</param>
        /// <returns>
        ///     A string containing the characters represented by the UTF-8-encoded input.</returns>
        public static string FromUtf8(this byte[] input, bool removeBom = false)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));

            string result = Encoding.UTF8.GetString(input);

            return removeBom && result[0] is '\ufeff' ? result.Substring(1) : result;
        }

        /// <summary>
        ///     Converts the specified raw UTF-16 (little-endian) data to a string.</summary>
        /// <param name="input">
        ///     Data to interpret as UTF-16 text.</param>
        /// <returns>
        ///     A string containing the characters represented by the UTF-16-encoded input.</returns>
        public static string FromUtf16(this byte[] input) => input is null ? throw new ArgumentNullException(nameof(input)) : Encoding.Unicode.GetString(input);

        /// <summary>
        ///     Converts the specified raw UTF-16 (big-endian) data to a string.</summary>
        /// <param name="input">
        ///     Data to interpret as UTF-16BE text.</param>
        /// <returns>
        ///     A string containing the characters represented by the UTF-16BE-encoded input.</returns>
        public static string FromUtf16BE(this byte[] input) => input is null ? throw new ArgumentNullException(nameof(input)) : Encoding.BigEndianUnicode.GetString(input);

        /// <summary>
        ///     Determines the length of the UTF-8 encoding of the specified string.</summary>
        /// <param name="input">
        ///     String to determined UTF-8 length of.</param>
        /// <returns>
        ///     The length of the string in bytes when encoded as UTF-8.</returns>
        public static int Utf8Length(this string input) => input is null ? throw new ArgumentNullException(nameof(input)) : Encoding.UTF8.GetByteCount(input);

        /// <summary>
        ///     Determines the length of the UTF-16 encoding of the specified string.</summary>
        /// <param name="input">
        ///     String to determined UTF-16 length of.</param>
        /// <returns>
        ///     The length of the string in bytes when encoded as UTF-16.</returns>
        public static int Utf16Length(this string input) => input is null ? throw new ArgumentNullException(nameof(input)) : Encoding.Unicode.GetByteCount(input);

        /// <summary>
        ///     Returns a JavaScript- or JSON-compatible representation of the string with the appropriate characters escaped.
        ///     Returns "null" if the input is null.</summary>
        /// <param name="input">
        ///     String to escape.</param>
        /// <param name="quotes">
        ///     Specifies what type of quotes to put around the result, if any.</param>
        /// <returns>
        ///     JavaScript- or JSON-compatible representation of the input string, or the "null" keyword if the input is null.</returns>
        public static string JsEscapeNull(this string input, JsQuotes quotes = JsQuotes.Double) => input?.JsEscape(quotes) ?? "null";

        /// <summary>
        ///     Returns a JavaScript- or JSON-compatible representation of the string with the appropriate characters escaped.</summary>
        /// <param name="input">
        ///     String to escape.</param>
        /// <param name="quotes">
        ///     Specifies what type of quotes to put around the result, if any.</param>
        /// <returns>
        ///     JavaScript- or JSON-compatible representation of the input string.</returns>
        public static string JsEscape(this string input, JsQuotes quotes = JsQuotes.Double)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));

            var sb = new StringBuilder();

            sb.AppendJsEscaped(input, quotes);

            return sb.ToString();
        }

        /// <summary>
        ///     Appends a JavaScript- or JSON-compatible representation of the string with the appropriate characters escaped
        ///     into the specified StringBuilder.</summary>
        /// <param name="sb">
        ///     The StringBuilder to add the result to.</param>
        /// <param name="input">
        ///     String to escape.</param>
        /// <param name="quotes">
        ///     Specifies what type of quotes to put around the result, if any.</param>
        public static void AppendJsEscaped(this StringBuilder sb, string input, JsQuotes quotes = JsQuotes.Double)
        {
            if (sb is null)
                throw new ArgumentNullException(nameof(sb));

            if (input is null)
                throw new ArgumentNullException(nameof(input));

            if (!(quotes is JsQuotes.None))
                sb.Append(quotes is JsQuotes.Double ? '"' : '\'');

            foreach (char c in input)
            {
                switch (c)
                {
                    case '"':
                        sb.Append(quotes is JsQuotes.Single ? c.ToString() : "\\\"");
                        break;

                    case '\'':
                        sb.Append(quotes is JsQuotes.Double ? c.ToString() : quotes is JsQuotes.Single ? "\\'" : "\\u0027");
                        break;

                    case '\\':
                        sb.Append("\\\\");
                        break;

                    case '\b':
                        sb.Append("\\b");
                        break;

                    case '\f':
                        sb.Append("\\f");
                        break;

                    case '\n':
                        sb.Append("\\n");
                        break;

                    case '\r':
                        sb.Append("\\r");
                        break;

                    case '\t':
                        sb.Append("\\t");
                        break;

                    default:
                        if (c <= 31)
                        {
                            sb.Append("\\u");
                            sb.Append(((int)c).ToString("X4"));
                        }
                        else
                            sb.Append(c);
                        break;
                }
            }

            if (!(quotes is JsQuotes.None))
                sb.Append(quotes is JsQuotes.Double ? '"' : '\'');
        }

        /// <summary>
        ///     Returns an SQL-compatible representation of the string in single-quotes with the appropriate characters
        ///     escaped.</summary>
        /// <param name="input">
        ///     String to escape.</param>
        /// <returns>
        ///     SQL-compatible representation of the input string.</returns>
        public static string SqlEscape(this string input) => input is null ? throw new ArgumentNullException(nameof(input)) : "'" + input.Replace("'", "''") + "'";

        /// <summary>
        ///     Encodes this byte array to base-64-url format, which is safe for use in URLs and does not contain the
        ///     unnecessary padding when the number of bytes is not divisible by 3.</summary>
        /// <seealso cref="Base64UrlDecode"/>
        public static string Base64UrlEncode(this byte[] bytes)
        {
            if (bytes is null)
                throw new ArgumentNullException(nameof(bytes));

            var result = new StringBuilder();
            int i = 0;

            while (i < bytes.Length)
            {
                if (bytes.Length - i >= 3)
                {
                    result.Append(CharsBase64Url[bytes[i] >> 2]);
                    result.Append(CharsBase64Url[(bytes[i] & 3) << 4 | bytes[i + 1] >> 4]);
                    result.Append(CharsBase64Url[(bytes[i + 1] & 15) << 2 | bytes[i + 2] >> 6]);
                    result.Append(CharsBase64Url[bytes[i + 2] & 63]);
                    i += 3;
                }
                else if (bytes.Length - i is 2)
                {
                    result.Append(CharsBase64Url[bytes[i] >> 2]);
                    result.Append(CharsBase64Url[(bytes[i] & 3) << 4 | bytes[i + 1] >> 4]);
                    result.Append(CharsBase64Url[(bytes[i + 1] & 15) << 2]);
                    i += 2;
                }
                else
                {
                    result.Append(CharsBase64Url[bytes[i] >> 2]);
                    result.Append(CharsBase64Url[(bytes[i] & 3) << 4]);
                    i += 1;
                }
            }

            return result.ToString();
        }

        /// <summary>
        ///     Decodes this string from base-64-url encoding, which is safe for use in URLs and does not contain the
        ///     unnecessary padding when the number of bytes is not divisible by 3, into a byte array.</summary>
        /// <seealso cref="Base64UrlEncode"/>
        public static byte[] Base64UrlDecode(this string input)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));
            if (input.Any(ch => !CharsBase64Url.Contains(ch)))
                throw new ArgumentException("The input string to Base64UrlDecode is not a valid base-64-url encoded string.", nameof(input));

            if (s_invBase64Url is null)
            {
                s_invBase64Url = new int[256];

                for (int j = 0; j < s_invBase64Url.Length; j++)
                    s_invBase64Url[j] = -1;

                for (int j = 0; j < CharsBase64Url.Length; j++)
                    s_invBase64Url[CharsBase64Url[j]] = j;
            }

            int padding = input.Length % 4;

            if (padding is 1)
                throw new InvalidOperationException("The input string to Base64UrlDecode is not a valid base-64-url encoded string.");

            if (padding > 0)
                padding--;

            byte[] result = new byte[input.Length / 4 * 3 + padding];
            int resultIndex = 0, inputIndex = 0;

            while (inputIndex < input.Length)
            {
                if (input.Length - inputIndex >= 4)
                {
                    uint v0 = checked((uint)s_invBase64Url[input[inputIndex++]]);
                    uint v1 = checked((uint)s_invBase64Url[input[inputIndex++]]);
                    uint v2 = checked((uint)s_invBase64Url[input[inputIndex++]]);
                    uint v3 = checked((uint)s_invBase64Url[input[inputIndex++]]);
                    result[resultIndex++] = (byte)(v0 << 2 | v1 >> 4);
                    result[resultIndex++] = (byte)((v1 & 15) << 4 | v2 >> 2);
                    result[resultIndex++] = (byte)((v2 & 3) << 6 | v3);
                }
                else if (input.Length - inputIndex is 3)
                {
                    uint v0 = checked((uint)s_invBase64Url[input[inputIndex++]]);
                    uint v1 = checked((uint)s_invBase64Url[input[inputIndex++]]);
                    uint v2 = checked((uint)s_invBase64Url[input[inputIndex++]]);
                    result[resultIndex++] = (byte)(v0 << 2 | v1 >> 4);
                    result[resultIndex++] = (byte)((v1 & 15) << 4 | v2 >> 2);
                }
                else if (input.Length - inputIndex is 2)
                {
                    uint v0 = checked((uint)s_invBase64Url[input[inputIndex++]]);
                    uint v1 = checked((uint)s_invBase64Url[input[inputIndex++]]);
                    result[resultIndex++] = (byte)(v0 << 2 | v1 >> 4);
                }
                else
                    throw new Exception("Internal error in Base64UrlDecode");
            }

            return result;
        }

        /// <summary>
        ///     Escapes all characters in this string whose code is less than 32 or form invalid UTF-16 using C/C#-compatible
        ///     backslash escapes.</summary>
        /// <seealso cref="CLiteralUnescape"/>
        public static string CLiteralEscape(this string value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));

            var result = new StringBuilder(value.Length + value.Length / 2);

            for (int i = 0; i < value.Length; i++)
            {
                char c = value[i];
                switch (c)
                {
                    case '\0': result.Append(@"\0"); break;
                    case '\a': result.Append(@"\a"); break;
                    case '\b': result.Append(@"\b"); break;
                    case '\t': result.Append(@"\t"); break;
                    case '\n': result.Append(@"\n"); break;
                    case '\v': result.Append(@"\v"); break;
                    case '\f': result.Append(@"\f"); break;
                    case '\r': result.Append(@"\r"); break;
                    case '\\': result.Append(@"\\"); break;
                    case '"': result.Append(@"\"""); break;

                    default:
                        if (c >= 0xD800 && c < 0xDC00)
                        {
                            if (i == value.Length - 1)
                                result.AppendFormat(@"\u{0:X4}", (int)c);
                            else
                            {
                                char c2 = value[i + 1];
                                if (c2 >= 0xDC00 && c2 <= 0xDFFF)
                                {
                                    i++;
                                    result.Append(c);
                                    result.Append(c2);
                                }
                                else
                                    result.AppendFormat(@"\u{0:X4}", (int)c);
                            }
                        }
                        else if (c >= 0xDC00 && c <= 0xDFFF)
                            result.AppendFormat(@"\u{0:X4}", (int)c);
                        else if (c >= ' ')
                            result.Append(c);
                        else
                            result.AppendFormat(@"\u{0:X4}", (int)c);
                        break;
                }
            }

            return result.ToString();
        }

        /// <summary>
        ///     Reverses the escaping done by <see cref="CLiteralEscape"/>. Note that unescaping is not fully C/C#-compatible
        ///     in the sense that not all strings that are valid string literals in C/C# can be correctly unescaped by this
        ///     procedure.</summary>
        /// <seealso cref="CLiteralEscape"/>
        public static string CLiteralUnescape(this string value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));

            var result = new StringBuilder(value.Length);

            int i = 0;

            while (i < value.Length)
            {
                char c = value[i];

                if (!(c is '\\'))
                    result.Append(c);
                else
                {
                    if (i + 1 >= value.Length)
                        throw new ArgumentException($"String ends before the escape sequence at position {i} is complete", nameof(value));

                    i++;

                    c = value[i];

                    int code;

                    switch (c)
                    {
                        case '0': result.Append('\0'); break;
                        case 'a': result.Append('\a'); break;
                        case 'b': result.Append('\b'); break;
                        case 't': result.Append('\t'); break;
                        case 'n': result.Append('\n'); break;
                        case 'v': result.Append('\v'); break;
                        case 'f': result.Append('\f'); break;
                        case 'r': result.Append('\r'); break;
                        case '\\': result.Append('\\'); break;
                        case '"': result.Append('"'); break;

                        case 'x':
                            int len = 0;

                            i++;

                            while (len <= 4 && i + len < value.Length && (value[i + len] >= '0' && value[i + len] <= '9' || value[i + len] >= 'a' && value[i + len] <= 'f' || value[i + len] >= 'A' && value[i + len] <= 'F'))
                                len++;

                            if (len is 0)
                                throw new ArgumentException($@"Invalid hex escape sequence ""\x"" at position {i - 2}", nameof(value));

                            code = int.Parse(value.Substring(i, len), NumberStyles.AllowHexSpecifier);

                            result.Append((char)code);

                            i += len - 1;
                            break;

                        case 'u':
                            if (i + 4 >= value.Length)
                                throw new ArgumentException($@"Invalid hex escape sequence ""\u"" at position {i}", nameof(value));

                            i++;

                            code = int.Parse(value.Substring(i, 4), NumberStyles.AllowHexSpecifier);

                            result.Append((char)code);

                            i += 3;
                            break;

                        default:
                            throw new ArgumentException($"Unrecognised escape sequence at position {i - 1}: \\{c}", nameof(value));
                    }
                }

                i++;
            }

            return result.ToString();
        }

        /// <summary>Returns the specified collection, but with leading and trailing empty strings and nulls removed.</summary>
        public static IEnumerable<string> Trim(this IEnumerable<string> values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            string[] arr = values.ToArray();

            int begin = 0;

            while (begin < arr.Length && string.IsNullOrEmpty(arr[begin]))
                begin++;

            if (begin == arr.Length)
                return new string[0];

            int end = arr.Length - 1;

            while (end >= 0 && string.IsNullOrEmpty(arr[end]))
                end--;

            return arr.Skip(begin).Take(end - begin + 1);
        }

        /// <summary>
        ///     Word-wraps the current string to a specified width. Supports UNIX-style newlines and indented paragraphs.</summary>
        /// <remarks>
        ///     <para>
        ///         The supplied text will be split into "paragraphs" at the newline characters. Every paragraph will begin on
        ///         a new line in the word-wrapped output, indented by the same number of spaces as in the input. All
        ///         subsequent lines belonging to that paragraph will also be indented by the same amount.</para>
        ///     <para>
        ///         All multiple contiguous spaces will be replaced with a single space (except for the indentation).</para></remarks>
        /// <param name="text">
        ///     Text to be word-wrapped.</param>
        /// <param name="maxWidth">
        ///     The maximum number of characters permitted on a single line, not counting the end-of-line terminator.</param>
        /// <param name="hangingIndent">
        ///     The number of spaces to add to each line except the first of each paragraph, thus creating a hanging
        ///     indentation.</param>
        public static IEnumerable<string> WordWrap(this string text, int maxWidth, int hangingIndent = 0) => text is null ? throw new ArgumentNullException(nameof(text))
                : maxWidth < 1 ? throw new ArgumentOutOfRangeException(nameof(maxWidth), maxWidth, $"{nameof(maxWidth)} cannot be less than 1")
                : hangingIndent < 0 ? throw new ArgumentOutOfRangeException(nameof(hangingIndent), hangingIndent, $"{nameof(hangingIndent)} cannot be negative.")
                : text is null || text.Length is 0 ? Enumerable.Empty<string>()
                : WordWrap(
                text.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None),
                maxWidth,
                hangingIndent,
                (txt, substrIndex) => txt.Substring(substrIndex).Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries),
                str => str.Length,
                txt =>
                {
                    int indentLen = 0;
                    while (indentLen < txt.Length && txt[indentLen] is ' ')
                        indentLen++;
                    return indentLen;
                },
                num => new string(' ', num),
                () => new StringBuilder(),
                sb => sb.Length,
                (sb, str) => sb.Append(str),
                sb => sb.ToString(),
                (str, start, length) => length is null ? str.Substring(start) : str.Substring(start, length.Value),
                (str1, str2) => str1 + str2);

        private static IEnumerable<T> WordWrap<T, TBuilder>(IEnumerable<T> paragraphs, int maxWidth, int hangingIndent, Func<T, int, IEnumerable<T>> splitSubstringIntoWords, Func<T, int> getLength, Func<T, int> getIndent, Func<int, T> spaces, Func<TBuilder> getBuilder, Func<TBuilder, int> getTotalLength, Action<TBuilder, T> add, Func<TBuilder, T> getString, Func<T, int, int?, T> substring, Func<T, T, T> concat)
        {
            foreach (T paragraph in paragraphs)
            {
                int indentLen = getIndent(paragraph);

                T indent = spaces(indentLen + hangingIndent),
                    space = spaces(indentLen);

                int numSpaces = indentLen;

                TBuilder curLine = getBuilder();

                foreach (T wordForeach in splitSubstringIntoWords(paragraph, indentLen))
                {
                    T word = wordForeach;

                    int curLineLength = getTotalLength(curLine);

                    if (curLineLength + numSpaces + getLength(word) > maxWidth)
                    {
                        if (getLength(word) > maxWidth)
                        {
                            if (curLineLength + numSpaces + 2 <= maxWidth || getTotalLength(curLine) is 0)
                            {
                                int length = maxWidth - getTotalLength(curLine) - numSpaces;
                                add(curLine, space);
                                add(curLine, substring(word, 0, length));
                                word = substring(word, length, null);
                            }

                            yield return getString(curLine);

                            while (indentLen + getLength(word) > maxWidth)
                            {
                                yield return concat(indent, substring(word, 0, maxWidth - indentLen));
                                word = substring(word, maxWidth - indentLen, null);
                            }

                            curLine = getBuilder();
                            add(curLine, indent);
                            add(curLine, word);
                        }
                        else
                        {
                            yield return getString(curLine);

                            curLine = getBuilder();
                            add(curLine, indent);
                            add(curLine, word);
                        }
                    }
                    else
                    {
                        add(curLine, space);
                        add(curLine, word);
                    }

                    if (!(numSpaces is 1))
                    {
                        space = spaces(1);
                        numSpaces = 1;
                    }
                }

                yield return getString(curLine);
            }
        }

        /// <summary>Attempts to detect Unix-style and Mac-style line endings and converts them to Windows (\r\n).</summary>
        public static string UnifyLineEndings(this string input)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));

            string[] lines = Regex.Split(input, @"\r\n|\r|\n");

            return string.Join("\r\n", lines);
        }

        /// <summary>
        ///     Determines whether the specified URL starts with the specified URL path. For example, the URL
        ///     "/directory/file" starts with "/directory" but not with "/dir".</summary>
        public static bool UrlStartsWith(this string url, string path) => url is null
                ? throw new ArgumentNullException(nameof(url))
                : url == path || url.StartsWith(path + "/") || url.StartsWith(path + "?");

        /// <summary>
        ///     Same as <see cref="string.Substring(int)"/> but does not throw exceptions when the start index falls outside
        ///     the boundaries of the string. Instead the result is truncated as appropriate.</summary>
        public static string SubstringSafe(this string source, int startIndex) => source is null
                ? throw new ArgumentNullException(nameof(source))
                : startIndex >= source.Length ? "" : startIndex < 0 ? source : source.Substring(startIndex);

        /// <summary>
        ///     Same as <see cref="string.Substring(int, int)"/> but does not throw exceptions when the start index or length
        ///     (or both) fall outside the boundaries of the string. Instead the result is truncated as appropriate.</summary>
        public static string SubstringSafe(this string source, int startIndex, int length)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (startIndex < 0)
            {
                length += startIndex;
                startIndex = 0;
            }

            return startIndex >= source.Length || length <= 0 ? ""
                : startIndex + length > source.Length ? source.Substring(startIndex)
                : source.Substring(startIndex, length);
        }

        /// <summary>
        ///     Determines whether this string is equal to the other string under the ordinal case-insensitive comparison
        ///     (<see cref="StringComparison.OrdinalIgnoreCase"/>).</summary>
        public static bool EqualsNoCase(this string strthis, string str) => strthis is null ? throw new ArgumentNullException(nameof(strthis)) : strthis.Equals(str, StringComparison.OrdinalIgnoreCase);

        /// <summary>
        ///     Determines whether this string contains the other string under the ordinal case-insensitive comparison (<see
        ///     cref="StringComparison.OrdinalIgnoreCase"/>).</summary>
        public static bool ContainsNoCase(this string strthis, string str) => strthis is null
                ? throw new ArgumentNullException(nameof(strthis))
                : str is null ? throw new ArgumentNullException(nameof(str)) : !(strthis.IndexOf(str, StringComparison.OrdinalIgnoreCase) is -1);

        /// <summary>
        ///     Returns true if and only if this string ends with the specified character.</summary>
        /// <seealso cref="StartsWith"/>
        public static bool EndsWith(this string str, char? ch) => str is null
                ? throw new ArgumentNullException(nameof(str))
                : ch is null || str is { } && str.Length > 0 && str[str.Length - 1] == ch.Value;

        /// <summary>
        ///     Returns true if and only if this string starts with the specified character.ToDictionary</summary>
        /// <seealso cref="EndsWith"/>
        public static bool StartsWith(this string str, char? ch) => str is null
                ? throw new ArgumentNullException(nameof(str))
                : ch is null || str is { } && str.Length > 0 && str[0] == ch.Value;

        /// <summary>Reconstructs a byte array from its hexadecimal representation (“hexdump”).</summary>
        public static byte[] FromHex(this string input)
        {
            if (input is null || input.Length % 2 is 1)
                throw new ArgumentOutOfRangeException(input, "The input string must be non-null and of even length.");

            byte[] result = new byte[input.Length / 2];
            int j = 0;

            for (int i = 0; i < result.Length; i++)
            {
                int upperNibble, lowerNibble;

                upperNibble = input[j] >= '0' && input[j] <= '9'
                    ? input[j] - '0'
                    : input[j] >= 'a' && input[j] <= 'f'
                    ? input[j] - 'a' + 10
                    : input[j] >= 'A' && input[j] <= 'F'
                    ? input[j] - 'A' + 10
                    : throw new InvalidOperationException($"The character '{input[j]}' is not a valid hexadecimal digit.");

                j++;

                lowerNibble = input[j] >= '0' && input[j] <= '9' ? input[j] - '0'
                    : input[j] >= 'a' && input[j] <= 'f' ? input[j] - 'a' + 10
                    : input[j] >= 'A' && input[j] <= 'F' ? input[j] - 'A' + 10
                    : throw new InvalidOperationException($"The character '{input[j]}' is not a valid hexadecimal digit.");

                j++;

                result[i] = (byte)((upperNibble << 4) + lowerNibble);
            }

            return result;
        }

        /// <summary>
        ///     Removes the overall indentation of the specified string while maintaining the relative indentation of each
        ///     line.</summary>
        /// <param name="str">
        ///     String to remove indentation from.</param>
        /// <returns>
        ///     A string in which every line that isn’t all whitespace has had spaces removed from the beginning equal to the
        ///     least amount of spaces at the beginning of any line.</returns>
        public static string Unindent(this string str)
        {
            int least = Regex.Matches(str, @"^( *)(?![\r\n ]|\z)", RegexOptions.Multiline).Cast<Match>().MinOrDefault(m => m.Groups[1].Length, 0);
            return least is 0 ? str : Regex.Replace(str, "^" + new string(' ', least), "", RegexOptions.Multiline);
        }

        /// <summary>
        ///     Inserts spaces at the beginning of every line contained within the specified string.</summary>
        /// <param name="str">
        ///     String to add indentation to.</param>
        /// <param name="by">
        ///     Number of spaces to add.</param>
        /// <param name="indentFirstLine">
        ///     If true (default), all lines are indented; otherwise, all lines except the first.</param>
        /// <returns>
        ///     The indented string.</returns>
        public static string Indent(this string str, int by, bool indentFirstLine = true) => indentFirstLine
                ? Regex.Replace(str, "^", new string(' ', by), RegexOptions.Multiline)
                : Regex.Replace(str, "(?<=\n)", new string(' ', by));

        /// <summary>
        ///     Removes spaces from the beginning of every line in such a way that the smallest indentation is reduced to
        ///     zero. Lines which contain only whitespace are not considered in the calculation and may therefore become
        ///     empty.</summary>
        /// <param name="str">
        ///     The string to transform.</param>
        public static string RemoveCommonIndentation(this string str)
        {
            int minLen = Regex.Matches(str, @"^(?> *)(?!\r|$| )", RegexOptions.Multiline)
                        .Cast<Match>()
                        .Min(m => m.Length);

            return Regex.Replace(
                str,
                $"^(?> {{{minLen}}})|^(?> {{0,{minLen}}}(\r|$))",
                "",
                RegexOptions.Multiline);
        }

        /// <summary>
        ///     Splits a string into chunks of equal size. The last chunk may be smaller than <paramref name="chunkSize"/>,
        ///     but all chunks, if any, will contain at least 1 character.</summary>
        /// <param name="str">
        ///     String to split into chunks.</param>
        /// <param name="chunkSize">
        ///     Size of each chunk. Must be greater than zero.</param>
        /// <returns>
        ///     A lazy-evaluated collection containing the chunks from the string.</returns>
        public static IEnumerable<string> Split(this string str, int chunkSize) => str is null ? throw new ArgumentNullException(nameof(str))
                : chunkSize <= 0 ? throw new ArgumentException("chunkSize must be greater than zero.", nameof(chunkSize))
                : str.Length is 0 ? Enumerable.Empty<string>() : SplitIterator(str, chunkSize);

        private static IEnumerable<string> SplitIterator(this string str, int chunkSize)
        {
            for (int offset = 0; offset < str.Length; offset += chunkSize)
                yield return str.Substring(offset, Math.Min(chunkSize, str.Length - offset));
        }

        /// <summary>
        ///     Returns a new string in which all occurrences of <paramref name="oldValue"/> in the current instance,
        ///     identified using the specified string comparison, are replaced with <paramref name="newValue"/>.</summary>
        public static string Replace(this string str, string oldValue, string newValue, StringComparison comparison)
        {
            if (str is null)
                throw new ArgumentNullException(nameof(str));

            if (oldValue is null)
                throw new ArgumentNullException(nameof(oldValue));

            if (oldValue.Length is 0)
                throw new ArgumentException("oldValue cannot be the empty string.", nameof(oldValue));

            if (newValue is null)
                throw new ArgumentNullException(nameof(newValue));

            string output = "";

            while (true)
            {
                int p = str.IndexOf(oldValue, comparison);

                if (p is -1)
                    return output + str;

                output += str.Substring(0, p) + newValue;
                str = str.Substring(p + oldValue.Length);
            }
        }

        /// <summary>
        ///     Returns a string array that contains the substrings in this string that are delimited by elements of a
        ///     specified string array.</summary>
        /// <param name="str">
        ///     String to be split.</param>
        /// <param name="separator">
        ///     Strings that delimit the substrings in this string.</param>
        /// <returns>
        ///     An array whose elements contain the substrings in this string that are delimited by one or more strings in
        ///     separator. For more information, see the Remarks section.</returns>
        public static string[] Split(this string str, params string[] separator) => str.Split(separator, StringSplitOptions.None);

        /// <summary>
        ///     Returns a string array that contains the substrings in this string that are delimited by elements of a
        ///     specified string array. Empty items (zero-length strings) are filtered out.</summary>
        /// <param name="str">
        ///     String to be split.</param>
        /// <param name="separator">
        ///     Strings that delimit the substrings in this string.</param>
        /// <returns>
        ///     An array whose elements contain the substrings in this string that are delimited by one or more strings in
        ///     separator. For more information, see the Remarks section.</returns>
        public static string[] SplitNoEmpty(this string str, params string[] separator) => str.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        /// <summary>Determines whether the string contains only the characters 0-9.</summary>
        public static bool IsNumeric(this string str) => !str.Any(c => c < '0' || c > '9');

        /// <summary>Adds the specified line to the end of the current string. Returns the line if the current string is null.</summary>
        public static string AddLine(this string str, string line) => str is null ? line : str + Environment.NewLine + line;

        /// <summary>
        ///     Enumerates all (remaining) lines from this text reader, reading lines only when needed, and
        ///     hence compatible with potentially blocking or infinite streams.</summary>
        public static IEnumerable<string> ReadLines(this TextReader reader)
        {
            while (true)
            {
                string line = reader.ReadLine();

                if (line is null)
                    yield break;

                yield return line;
            }
        }

        /// <summary>
        ///     Returns the path to this element. The path consists of the names of all parents of this element up to the root
        ///     node, separated with forward slashes.</summary>
        public static string Path(this XContainer element)
        {
            var list = new List<string>();

            while (element is { } && element is XElement x)
            {
                list.Add(x.Name.ToString());
                element = element.Parent;
            }

            list.Reverse();

            return list.JoinString("/");
        }

        /// <summary>
        ///     Returns the path of this attribute. The path consists of the <see fref="XElement.Path()"/> of this attribute's
        ///     element, followed by attribute name in square brackets.</summary>
        public static string Path(this XAttribute attribute) => attribute.Parent.Path() + "[" + attribute.Name + "]";

        /// <summary>
        ///     Returns the first element matching "name", or if none, throws an exception to say which element was missing
        ///     which sub-element. This is a counterpart to <see cref="XContainer.Element"/>.</summary>
        public static XElement ChkElement(this XContainer element, XName name) => element.Element(name) ?? throw new InvalidOperationException("Element \"{0}\" is expected contain an element named \"{1}\".".Form(element.Path(), name));

        /// <summary>
        ///     Returns the first attribute matching "name", or if none, throws an exception to say which element was missing
        ///     which attribute. This is a counterpart to <see cref="XElement.Attribute"/>.</summary>
        public static XAttribute ChkAttribute(this XElement element, XName name) => element.Attribute(name) ?? throw new InvalidOperationException("Element \"{0}\" is expected contain an attribute named \"{1}\".".Form(element.Path(), name));

        /// <summary>
        ///     Returns the value of this attribute, converted to a double. If the conversion cannot succeed, throws an
        ///     exception describing which attribute was expected to be a double.</summary>
        public static double AsDouble(this XAttribute attribute)
        {
            string value = attribute.Value;

            return double.TryParse(value, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out double result)
                ? result
                : throw new InvalidOperationException("Attribute \"{0}\" is expected to contain a number (convertible to \"double\")".Form(attribute.Path()));
        }

        /// <summary>
        ///     Gets the first (in document order) child element with the specified local name (ignoring the namespace).</summary>
        /// <param name="element">
        ///     XML element to search.</param>
        /// <param name="name">
        ///     The name to match.</param>
        /// <returns>
        ///     The first element found or <c>null</c> if no such element exists.</returns>
        public static XElement ElementI(this XElement element, string name) => element.Elements().FirstOrDefault(elem => elem.Name.LocalName == name);

        /// <summary>
        ///     Returns a filtered collection of the child elements of this element or document, in document order. Only
        ///     elements that have the specified local name (ignoring the namespace) are included in the collection.</summary>
        /// <param name="element">
        ///     XML element to search.</param>
        /// <param name="name">
        ///     The name to match.</param>
        /// <returns>
        ///     The first element found or <c>null</c> if no such element exists.</returns>
        public static IEnumerable<XElement> ElementsI(this XContainer element, string name) => element.Elements().Where(elem => elem.Name.LocalName == name);

        /// <summary>
        ///     Returns the first attribute of this element that has the specified local name (ignoring the namespace).</summary>
        /// <param name="element">
        ///     XML element to search.</param>
        /// <param name="name">
        ///     The name to match.</param>
        /// <returns>
        ///     The first attribute if found or <c>null</c> if no such attribute exists.</returns>
        public static XAttribute AttributeI(this XElement element, string name) => element.Attributes().FirstOrDefault(attr => attr.Name.LocalName == name);

        /// <summary>
        ///     Returns a filtered collection of attributes of this element. Only elements that have the specified local name
        ///     (ignoring the namespace) are included in the collection.</summary>
        /// <param name="element">
        ///     XML element to search.</param>
        /// <param name="name">
        ///     The name to match.</param>
        /// <returns>
        ///     The filtered collection of attributes..</returns>
        public static IEnumerable<XAttribute> AttributesI(this XElement element, string name) => element.Attributes().Where(attr => attr.Name.LocalName == name);
    }
}
