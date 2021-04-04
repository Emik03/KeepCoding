using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KeepCodingAndNobodyExplodes
{
    /// <summary>
    /// Extension methods surrounding <see cref="Array"/> static methods to make code a bit shorter. Written by Emik.
    /// </summary>
    public static class ArrayHelper
    {
        /// <summary>
        /// Returns a read-only wrapper for the specified array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.asreadonly?view=net-5.0"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based array to wrap in a read-only <see cref="ReadOnlyCollection{T}"/> wrapper.</param>
        /// <returns>A read-only <see cref="ReadOnlyCollection{T}"/> wrapper for the specified array.</returns>
        public static ReadOnlyCollection<T> AsReadOnly<T>(this T[] array) => Array.AsReadOnly(array);

        /// <summary>
        /// Searches an entire one-dimensional sorted array for a specific element, using the <see cref="IComparable"/> interface implemented by each element of the array and by the specified object.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch_System_Array_System_Object_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <param name="array">The sorted one-dimensional Array to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <returns>The index of the specified <paramref name="value"/> in the specified <paramref name="array"/>, if <paramref name="value"/> is found; otherwise, a negative number. If <paramref name="value"/> is not found and <paramref name="value"/> is less than one or more elements in <paramref name="array"/>, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value"/>. If <paramref name="value"/> is not found and <paramref name="value"/> is greater than all elements in <paramref name="array"/>, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array"/>, the return <paramref name="value"/> can be incorrect and a negative number could be returned, even if <paramref name="value"/> is present in <paramref name="array"/>.</returns>
        public static int BinarySearch(this Array array, object value) => Array.BinarySearch(array, value);

        /// <summary>
        /// Searches an entire one-dimensional sorted array for a value using the specified <see cref="IComparer"/> interface.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch_System_Array_System_Object_System_Collections_IComparer_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <param name="array">The sorted one-dimensional <see cref="Array"/> to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <param name="comparer">The <see cref="IComparer"/> implementation to use when comparing elements.</param>
        /// <returns>The index of the specified <paramref name="value"/> in the specified <paramref name="array"/>, if <paramref name="value"/> is found; otherwise, a negative number. If <paramref name="value"/> is not found and <paramref name="value"/> is less than one or more elements in <paramref name="array"/>, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value"/>. If <paramref name="value"/> is not found and <paramref name="value"/> is greater than all elements in <paramref name="array"/>, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array"/>, the return <paramref name="value"/> can be incorrect and a negative number could be returned, even if <paramref name="value"/> is present in <paramref name="array"/>.</returns>
        public static int BinarySearch(this Array array, object value, IComparer comparer) => Array.BinarySearch(array, value, comparer);

        /// <summary>
        /// Searches a range of elements in a one-dimensional sorted array for a value, using the <see cref="IComparable"/> interface implemented by each element of the array and by the specified value.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch_System_Array_System_Int32_System_Int32_System_Object_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <param name="array">The sorted one-dimensional <see cref="Array"/> to search.</param>
        /// <param name="index">The starting index of the range to search.</param>
        /// <param name="length">The length of the range to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <returns>The index of the specified <paramref name="value"/> in the specified <paramref name="array"/>, if <paramref name="value"/> is found; otherwise, a negative number. If <paramref name="value"/> is not found and <paramref name="value"/> is less than one or more elements in <paramref name="array"/>, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value"/>. If <paramref name="value"/> is not found and <paramref name="value"/> is greater than all elements in <paramref name="array"/>, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array"/>, the return <paramref name="value"/> can be incorrect and a negative number could be returned, even if <paramref name="value"/> is present in <paramref name="array"/>.</returns>
        public static int BinarySearch(this Array array, int index, int length, object value) => Array.BinarySearch(array, index, length, value);

        /// <summary>
        /// Searches a range of elements in a one-dimensional sorted array for a value, using the specified <see cref="IComparer"/> interface.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch_System_Array_System_Int32_System_Int32_System_Object_System_Collections_IComparer_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <param name="array">The sorted one-dimensional <see cref="Array"/> to search.</param>
        /// <param name="index">The starting index of the range to search.</param>
        /// <param name="length">The length of the range to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <param name="comparer">The <see cref="IComparer"/> implementation to use when comparing elements or <c>null</c> to use the <see cref="IComparable"/> implementation of each element..</param>
        /// <returns>The index of the specified <paramref name="value"/> in the specified <paramref name="array"/>, if <paramref name="value"/> is found; otherwise, a negative number. If <paramref name="value"/> is not found and <paramref name="value"/> is less than one or more elements in <paramref name="array"/>, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value"/>. If <paramref name="value"/> is not found and <paramref name="value"/> is greater than all elements in <paramref name="array"/>, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array"/>, the return <paramref name="value"/> can be incorrect and a negative number could be returned, even if <paramref name="value"/> is present in <paramref name="array"/>.</returns>
        public static int BinarySearch(this Array array, int index, int length, object value, IComparer comparer) => Array.BinarySearch(array, index, length, value, comparer);

        /// <summary>
        /// Searches an entire one-dimensional sorted array for a specific element, using the <see cref="IComparable{T}"/> generic interface implemented by each element of the <see cref="Array"/> and by the specified object.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch__1___0_____0_"/></remarks>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The sorted one-dimensional, zero-based <see cref="Array"/> to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <returns>The index of the specified <paramref name="value"/> in the specified <paramref name="array"/>, if <paramref name="value"/> is found; otherwise, a negative number. If <paramref name="value"/> is not found and <paramref name="value"/> is less than one or more elements in <paramref name="array"/>, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value"/>. If <paramref name="value"/> is not found and <paramref name="value"/> is greater than all elements in <paramref name="array"/>, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array"/>, the return <paramref name="value"/> can be incorrect and a negative number could be returned, even if <paramref name="value"/> is present in <paramref name="array"/>.</returns>
        public static int BinarySearch<T>(this T[] array, T value) => Array.BinarySearch(array, value);

        /// <summary>
        /// Searches an entire one-dimensional sorted array for a value using the specified <see cref="IComparer{T}"/> generic interface.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch__1___0_____0_System_Collections_Generic_IComparer___0__"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The sorted one-dimensional, zero-based <see cref="Array"/> to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <param name="comparer">The <see cref="IComparer{T}"/> implementation to use when comparing elements or <c>null</c> to use the <see cref="IComparable{T}"/> implementation of each element.</param>
        /// <returns>The index of the specified <paramref name="value"/> in the specified <paramref name="array"/>, if <paramref name="value"/> is found; otherwise, a negative number. If <paramref name="value"/> is not found and <paramref name="value"/> is less than one or more elements in <paramref name="array"/>, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value"/>. If <paramref name="value"/> is not found and <paramref name="value"/> is greater than all elements in <paramref name="array"/>, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array"/>, the return <paramref name="value"/> can be incorrect and a negative number could be returned, even if <paramref name="value"/> is present in <paramref name="array"/>.</returns>
        public static int BinarySearch<T>(this T[] array, T value, IComparer<T> comparer) => Array.BinarySearch(array, value, comparer);

        /// <summary>
        /// Searches a range of elements in a one-dimensional sorted array for a value, using the <see cref="IComparable{T}"/> generic interface implemented by each element of the <see cref="Array"/> and by the specified value.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch__1___0___System_Int32_System_Int32___0_"/></remarks>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The sorted one-dimensional, zero-based <see cref="Array"/> to search.</param>
        /// <param name="index">The starting index of the range to search.</param>
        /// <param name="length">The length of the range to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <returns>The index of the specified <paramref name="value"/> in the specified <paramref name="array"/>, if <paramref name="value"/> is found; otherwise, a negative number. If <paramref name="value"/> is not found and <paramref name="value"/> is less than one or more elements in <paramref name="array"/>, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value"/>. If <paramref name="value"/> is not found and <paramref name="value"/> is greater than all elements in <paramref name="array"/>, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array"/>, the return <paramref name="value"/> can be incorrect and a negative number could be returned, even if <paramref name="value"/> is present in <paramref name="array"/>.</returns>
        public static int BinarySearch<T>(this T[] array, int index, int length, T value) => Array.BinarySearch(array, index, length, value);

        /// <summary>
        /// Searches a range of elements in a one-dimensional sorted array for a value, using the specified <see cref="IComparer{T}"/> generic interface.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch__1___0___System_Int32_System_Int32___0_System_Collections_Generic_IComparer___0__"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The sorted one-dimensional, zero-based <see cref="Array"/> to search.</param>
        /// <param name="index">The starting index of the range to search.</param>
        /// <param name="length">The length of the range to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <param name="comparer">The <see cref="IComparer{T}"/> implementation to use when comparing elements or <c>null</c> to use the <see cref="IComparable{T}"/> implementation of each element.</param>
        /// <returns>The index of the specified <paramref name="value"/> in the specified <paramref name="array"/>, if <paramref name="value"/> is found; otherwise, a negative number. If <paramref name="value"/> is not found and <paramref name="value"/> is less than one or more elements in <paramref name="array"/>, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value"/>. If <paramref name="value"/> is not found and <paramref name="value"/> is greater than all elements in <paramref name="array"/>, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array"/>, the return <paramref name="value"/> can be incorrect and a negative number could be returned, even if <paramref name="value"/> is present in <paramref name="array"/>.</returns>
        public static int BinarySearch<T>(this T[] array, int index, int length, T value, IComparer<T> comparer) => Array.BinarySearch(array, index, length, value, comparer);

        /// <summary>
        /// Sets a range of elements in an array to the default value of each element type.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.clear?view=net-5.0"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <param name="array">The array whose elements need to be cleared.</param>
        /// <param name="index">The starting index of the range of elements to clear.</param>
        /// <param name="length">The number of elements to clear.</param>
        /// <returns><paramref name="array"/></returns>
        public static Array Clear(this Array array, int index, int length) { Array.Clear(array, index, length); return array; }

        /// <summary>
        /// Copies a range of elements from an <see cref="Array"/> starting at the specified source index and pastes them to another <see cref="Array"/> starting at the specified destination index. Guarantees that all changes are undone if the copy does not succeed completely.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.constrainedcopy?view=net-5.0"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArrayTypeMismatchException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <param name="sourceArray">The <see cref="Array"/> that contains the data to copy.</param>
        /// <param name="sourceIndex">A 32-bit integer that represents the index in the <paramref name="sourceArray"/> at which copying begins.</param>
        /// <param name="destinationArray">The <see cref="Array"/> that receives the data.</param>
        /// <param name="destinationIndex">A 32-bit integer that represents the index in the <paramref name="destinationArray"/> at which storing begins.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        /// <returns><paramref name="destinationArray"/></returns>
        public static Array ConstrainedCopy(this Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) { Array.ConstrainedCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length); return destinationArray; }

        /// <summary>
        /// Converts an array of one type to an array of another type.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.convertall?view=net-5.0"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <typeparam name="TInput">The type of the elements of the source array.</typeparam>
        /// <typeparam name="TOutput">The type of the elements of the target array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to convert to a target type.</param>
        /// <param name="converter">A <see cref="Converter{TInput, TOutput}"/> that converts each element from one type to another type.</param>
        /// <returns>An array of the target type containing the converted elements from the source array.</returns>
        public static TOutput[] ConvertAll<TInput, TOutput>(this TInput[] array, Converter<TInput, TOutput> converter) => Array.ConvertAll(array, converter);

        /// <summary>
        /// Copies a range of elements from an <see cref="Array"/> starting at the specified source index and pastes them to another <see cref="Array"/> starting at the specified destination index. The length and the indexes are specified as 64-bit integers.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Int64_System_Array_System_Int64_System_Int64_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArrayTypeMismatchException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <param name="sourceArray">The <see cref="Array"/> that contains the data to copy.</param>
        /// <param name="sourceIndex">A 64-bit integer that represents the index in the <paramref name="sourceArray"/> at which copying begins.</param>
        /// <param name="destinationArray">The <see cref="Array"/> that receives the data.</param>
        /// <param name="destinationIndex">A 64-bit integer that represents the index in the <paramref name="destinationIndex"/> at which storing begins.</param>
        /// <param name="length">A 64-bit integer that represents the number of elements to copy. The integer must be between zero and <see cref="int.MaxValue"/>, inclusive.</param>
        /// <returns><paramref name="destinationArray"/></returns>
        public static Array Copy(this Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length) { Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length); return destinationArray; }

        /// <summary>
        /// Copies a range of elements from an <see cref="Array"/> starting at the specified source index and pastes them to another <see cref="Array"/> starting at the specified destination index. The length and the indexes are specified as 32-bit integers.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Int32_System_Array_System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArrayTypeMismatchException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <param name="sourceArray">The <see cref="Array"/> that contains the data to copy.</param>
        /// <param name="sourceIndex">A 32-bit integer that represents the index in the <paramref name="sourceArray"/> at which copying begins.</param>
        /// <param name="destinationArray">The <see cref="Array"/> that receives the data.</param>
        /// <param name="destinationIndex">A 32-bit integer that represents the index in the <paramref name="destinationIndex"/> at which storing begins.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        /// <returns><paramref name="destinationArray"/></returns>
        public static Array Copy(this Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) { Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length); return destinationArray; }

        /// <summary>
        /// Copies a range of elements from an Array starting at the first element and pastes them into another Array starting at the first element. The length is specified as a 64-bit integer.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Array_System_Int64_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArrayTypeMismatchException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <param name="sourceArray">The <see cref="Array"/> that contains the data to copy.</param>
        /// <param name="destinationArray">The <see cref="Array"/> that receives the data.</param>
        /// <param name="length">A 64-bit integer that represents the number of elements to copy. The integer must be between zero and <see cref="int.MaxValue"/>, inclusive.</param>
        /// <returns><paramref name="destinationArray"/></returns>
        public static Array Copy(this Array sourceArray, Array destinationArray, long length) { Array.Copy(sourceArray, destinationArray, length); return destinationArray; }

        /// <summary>
        /// Copies a range of elements from an <see cref="Array"/> starting at the first element and pastes them into another <see cref="Array"/> starting at the first element. The length is specified as a 32-bit integer.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Array_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArrayTypeMismatchException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <param name="sourceArray">The <see cref="Array"/> that contains the data to copy.</param>
        /// <param name="destinationArray">The <see cref="Array"/> that receives the data.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        /// <returns><paramref name="destinationArray"/></returns>
        public static Array Copy(this Array sourceArray, Array destinationArray, int length) { Array.Copy(sourceArray, destinationArray, length); return destinationArray; }

        /// <summary>
        /// Creates a one-dimensional <see cref="Array"/> of the specified <see cref="Type"/> and length, with zero-based indexing.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="elementType">The <see cref="Type"/> of the <see cref="Array"/> to create.</param>
        /// <param name="length">The size of the <see cref="Array"/> to create.</param>
        /// <returns>A new one-dimensional <see cref="Array"/> of the specified <see cref="Type"/> with the specified length, using zero-based indexing.</returns>
        public static Array CreateInstance(this Type elementType, int length) => Array.CreateInstance(elementType, length);

        /// <summary>
        /// Creates a multidimensional <see cref="Array"/> of the specified <see cref="Type"/> and dimension lengths, with zero-based indexing. The dimension lengths are specified in an array of 32-bit integers.
        /// </summary>
        /// <param name="elementType">The <see cref="Type"/> of the <see cref="Array"/> to create.</param>
        /// <param name="lengths">An array of 32-bit integers that represent the size of each dimension of the <see cref="Array"/> to create.</param>
        /// <returns>A new multidimensional <see cref="Array"/> of the specified <see cref="Type"/> with the specified length for each dimension, using zero-based indexing.</returns>
        public static Array CreateInstance(this Type elementType, params int[] lengths) => Array.CreateInstance(elementType, lengths);

        /// <summary>
        /// Creates a multidimensional <see cref="Array"/> of the specified <see cref="Type"/> and dimension lengths, with zero-based indexing. The dimension lengths are specified in an array of 64-bit integers.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int64___"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="elementType">The <see cref="Type"/> of the <see cref="Array"/> to create.</param>
        /// <param name="lengths">An array of 64-bit integers that represent the size of each dimension of the <see cref="Array"/> to create. Each integer in the array must be between zero and <see cref="int.MaxValue"/>, inclusive.</param>
        /// <returns>A new multidimensional <see cref="Array"/> of the specified <see cref="Type"/> with the specified length for each dimension, using zero-based indexing.</returns>
        public static Array CreateInstance(this Type elementType, params long[] lengths) => Array.CreateInstance(elementType, lengths);

        /// <summary>
        /// Creates a two-dimensional Array of the specified Type and dimension lengths, with zero-based indexing.
        /// </summary>
        /// <remarks><see href="https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="elementType">The <see cref="Type"/> of the <see cref="Array"/> to create.</param>
        /// <param name="length1">The size of the first dimension of the <see cref="Array"/> to create.</param>
        /// <param name="length2">The size of the second dimension of the <see cref="Array"/> to create.</param>
        /// <returns>A new two-dimensional <see cref="Array"/> of the specified <see cref="Type"/> with the specified length for each dimension, using zero-based indexing.</returns>
        public static Array CreateInstance(this Type elementType, int length1, int length2) => Array.CreateInstance(elementType, length1, length2);

        /// <summary>
        /// Creates a multidimensional <see cref="Array"/> of the specified <see cref="Type"/> and dimension lengths, with the specified lower bounds.
        /// </summary>
        /// <remarks><see href="https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int32___System_Int32___"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="elementType">The <see cref="Type"/> of the <see cref="Array"/> to create.</param>
        /// <param name="lengths">A one-dimensional array that contains the size of each dimension of the <see cref="Array"/> to create.</param>
        /// <param name="lowerBounds">A one-dimensional array that contains the lower bound (starting index) of each dimension of the <see cref="Array"/> to create.</param>
        /// <returns>A new multidimensional <see cref="Array"/> of the specified <see cref="Type"/> with the specified length and lower bound for each dimension.</returns>
        public static Array CreateInstance(this Type elementType, int[] lengths, int[] lowerBounds) => Array.CreateInstance(elementType, lengths, lowerBounds);

        /// <summary>
        /// Creates a three-dimensional <see cref="Array"/> of the specified <see cref="Type"/> and dimension lengths, with zero-based indexing.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int32_System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="elementType">The <see cref="Type"/> of the <see cref="Array"/> to create.</param>
        /// <param name="length1">The size of the first dimension of the <see cref="Array"/> to create.</param>
        /// <param name="length2">The size of the second dimension of the <see cref="Array"/> to create.</param>
        /// <param name="length3">The size of the third dimension of the <see cref="Array"/> to create.</param>
        /// <returns>A new three-dimensional <see cref="Array"/> of the specified <see cref="Type"/> with the specified length for each dimension, using zero-based indexing.</returns>
        public static Array CreateInstance(this Type elementType, int length1, int length2, int length3) => Array.CreateInstance(elementType, length1, length2, length3);

        /// <summary>
        /// Determines whether the specified array contains elements that match the conditions defined by the specified predicate.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.exists?view=net-5.0"/></remarks>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to search.</param>
        /// <param name="match">The <see cref="Predicate{T}"/> that defines the conditions of the elements to search for.</param>
        /// <returns><c>true</c> if <paramref name="array"/> contains one or more elements that match the conditions defined by the specified predicate; otherwise, <c>false</c>.</returns>
        public static bool Exists<T>(this T[] array, Predicate<T> match) => Array.Exists(array, match);

        /// <summary>
        /// Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire <see cref="Array"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.find?view=net-5.0"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based array to search.</param>
        /// <param name="match">The predicate that defines the conditions of the element to search for.</param>
        /// <returns>The first element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type <typeparamref name="T"/>.</returns>
        public static T Find<T>(this T[] array, Predicate<T> match) => Array.Find(array, match);

        /// <summary>
        /// Retrieves all the elements that match the conditions defined by the specified predicate.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.findall?view=net-5.0"/></remarks>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to search.</param>
        /// <param name="match">The <see cref="Predicate{T}"/> that defines the conditions of the elements to search for.</param>
        /// <returns>An <see cref="Array"/> containing all the elements that match the conditions defined by the specified predicate, if found; otherwise, an empty <see cref="Array"/>.</returns>
        public static T[] FindAll<T>(this T[] array, Predicate<T> match) => Array.FindAll(array, match);

        /// <summary>
        /// Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the entire <see cref="Array"/>.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to search.</param>
        /// <param name="match">The <see cref="Predicate{T}"/> that defines the conditions of the element to search for.</param>
        /// <returns>The zero-based index of the first occurrence of an element that matches the conditions defined by <paramref name="match"/>, if found; otherwise, -1.</returns>
        public static int FindIndex<T>(this T[] array, Predicate<T> match) => Array.FindIndex(array, match);

        /// <summary>
        /// Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the range of elements in the <see cref="Array"/> that extends from the specified index to the last element.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.findindex?view=net-5.0#System_Array_FindIndex__1___0___System_Int32_System_Predicate___0__"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to search.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="match">The <see cref="Predicate{T}"/> that defines the conditions of the element to search for.</param>
        /// <returns>The zero-based index of the first occurrence of an element that matches the conditions defined by <paramref name="match"/>, if found; otherwise, -1.</returns>
        public static int FindIndex<T>(this T[] array, int startIndex, Predicate<T> match) => Array.FindIndex(array, startIndex, match);

        /// <summary>
        /// Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the range of elements in the <see cref="Array"/> that starts at the specified index and contains the specified number of elements.
        /// </summary>
        /// <remarks>https://docs.microsoft.com/en-us/dotnet/api/system.array.findindex?view=net-5.0#System_Array_FindIndex__1___0___System_Int32_System_Int32_System_Predicate___0__</remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to search.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <param name="match">The <see cref="Predicate{T}"/> that defines the conditions of the element to search for.</param>
        /// <returns>The zero-based index of the first occurrence of an element that matches the conditions defined by <see cref="Predicate{T}"/>, if found; otherwise, -1.</returns>
        public static int FindIndex<T>(this T[] array, int startIndex, int count, Predicate<T> match) => Array.FindIndex(array, startIndex, count, match);

        /// <summary>
        /// Searches for an element that matches the conditions defined by the specified predicate, and returns the last occurrence within the entire <see cref="Array"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.findlast?view=net-5.0"/></remarks>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to search.</param>
        /// <param name="match">The <see cref="Predicate{T}"/> that defines the conditions of the element to search for.</param>
        /// <returns>The last element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type <typeparamref name="T"/>.</returns>
        public static T FindLast<T>(this T[] array, Predicate<T> match) => Array.FindLast(array, match);

        /// <summary>
        /// Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the entire <see cref="Array"/>.
        /// </summary>
        /// <remarks><see href="https://docs.microsoft.com/en-us/dotnet/api/system.array.findlastindex?view=net-5.0#System_Array_FindLastIndex__1___0___System_Predicate___0__"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to search.</param>
        /// <param name="match">The <see cref="Predicate{T}"/> that defines the conditions of the element to search for.</param>
        /// <returns>The zero-based index of the last occurrence of an element that matches the conditions defined by <paramref name="match"/>, if found; otherwise, -1.</returns>
        public static int FindLastIndex<T>(this T[] array, Predicate<T> match) => Array.FindLastIndex(array, match);

        /// <summary>
        /// Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the range of elements in the <see cref="Array"/> that extends from the specified index to the last element.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.findlastindex?view=net-5.0#System_Array_FindLastIndex__1___0___System_Int32_System_Predicate___0__"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to search.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="match">The <see cref="Predicate{T}"/> that defines the conditions of the element to search for.</param>
        /// <returns>The zero-based index of the last occurrence of an element that matches the conditions defined by <paramref name="match"/>, if found; otherwise, -1.</returns>
        public static int FindLastIndex<T>(this T[] array, int startIndex, Predicate<T> match) => Array.FindLastIndex(array, startIndex, match);

        /// <summary>
        /// Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the range of elements in the <see cref="Array"/> that starts at the specified index and contains the specified number of elements.
        /// </summary>
        /// <remarks>https://docs.microsoft.com/en-us/dotnet/api/system.array.findlastindex?view=net-5.0#System_Array_FindLastIndex__1___0___System_Int32_System_Int32_System_Predicate___0__</remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to search.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <param name="match">The <see cref="Predicate{T}"/> that defines the conditions of the element to search for.</param>
        /// <returns>The zero-based index of the last occurrence of an element that matches the conditions defined by <see cref="Predicate{T}"/>, if found; otherwise, -1.</returns>
        public static int FindLastIndex<T>(this T[] array, int startIndex, int count, Predicate<T> match) => Array.FindLastIndex(array, startIndex, count, match);

        /// <summary>
        /// Performs the specified action on each element of the specified array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.foreach?view=net-5.0"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> on whose elements the action is to be performed.</param>
        /// <param name="action">The <see cref="Action{T}"/> to perform on each element of <paramref name="array"/>.</param>
        /// <returns><paramref name="array"/></returns>
        public static T[] ForEach<T>(this T[] array, Action<T> action) { Array.ForEach(array, action); return array; }

        /// <summary>
        /// Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <param name="array">The one-dimensional array to search.</param>
        /// <param name="value">The object to locate in <paramref name="array"/>.</param>
        /// <returns>The index of the first occurrence of <paramref name="value"/> in <paramref name="array"/>, if found; otherwise, the lower bound of the array minus 1.</returns>
        public static int IndexOf(this Array array, object value) => Array.IndexOf(array, value);

        /// <summary>
        /// Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its first occurrence. The range extends from a specified index to the end of the array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="RankException"></exception>
        /// <param name="array">The one-dimensional array to search.</param>
        /// <param name="value">The object to locate in <paramref name="array"/>.</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <returns>The index of the first occurrence of <paramref name="value"/>, if it's found, within the range of elements in <paramref name="array"/> that extends from <paramref name="startIndex"/> to the last element; otherwise, the lower bound of the array minus 1.</returns>
        public static int IndexOf(this Array array, object value, int startIndex) => Array.IndexOf(array, value, startIndex);

        /// <summary>
        /// Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of ifs first occurrence. The range extends from a specified index for a specified number of elements.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="RankException"></exception>
        /// <param name="array">The one-dimensional array to search.</param>
        /// <param name="value">The object to locate in <paramref name="array"/>.</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <param name="count">The number of elements to search.</param>
        /// <returns>The index of the first occurrence of <paramref name="value"/>, if it's found in the <paramref name="array"/> from index <paramref name="startIndex"/> to <paramref name="startIndex"/> + <paramref name="count"/> - 1; otherwise, the lower bound of the array minus 1.</returns>
        public static int IndexOf(this Array array, object value, int startIndex, int count) => Array.IndexOf(array, value, startIndex, count);

        /// <summary>
        /// Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its first occurrence. The range extends from a specified index for a specified number of elements.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf__1___0_____0_System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based array to search.</param>
        /// <param name="value">The object to locate in <paramref name="array"/>.</param>
        /// <param name="startIndex">The zero-based starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The zero-based index of the first occurrence of <paramref name="value"/> within the range of elements in <paramref name="array"/> that starts at <paramref name="startIndex"/> and contains the number of elements specified in <paramref name="count"/>, if found; otherwise, -1.</returns>
        public static int IndexOf<T>(this T[] array, T value, int startIndex, int count) => Array.IndexOf(array, value, startIndex, count);

        /// <summary>
        /// Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf__1___0_____0_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based array to search.</param>
        /// <param name="value">The object to locate in <paramref name="array"/>.</param>
        /// <returns>The zero-based index of the first occurrence of <paramref name="value"/> in the entire <paramref name="array"/>, if found; otherwise, -1.</returns>
        public static int IndexOf<T>(this T[] array, T value) => Array.IndexOf(array, value);

        /// <summary>
        /// Searches for the specified object in a range of elements of a one dimensional array, and returns the index of its first occurrence. The range extends from a specified index to the end of the array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf__1___0_____0_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based array to search.</param>
        /// <param name="value">The object to locate in <paramref name="array"/>.</param>
        /// <param name="startIndex">The zero-based starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <returns>The zero-based index of the first occurrence of <paramref name="value"/> within the range of elements in <paramref name="array"/> that extends from <paramref name="startIndex"/> to the last element, if found; otherwise, -1.</returns>
        public static int IndexOf<T>(this T[] array, T value, int startIndex) => Array.IndexOf(array, value, startIndex);

        /// <summary>
        /// Searches for the specified object and returns the index of its last occurrence in a one-dimensional array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <param name="array">The one-dimensional array to search.</param>
        /// <param name="value">The object to locate in <paramref name="array"/>.</param>
        /// <returns>The index of the last occurrence of <paramref name="value"/> in <paramref name="array"/>, if found; otherwise, the lower bound of the array minus 1.</returns>
        public static int LastIndexOf(this Array array, object value) => Array.LastIndexOf(array, value);

        /// <summary>
        /// Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its last occurrence. The range extends from a specified index to the end of the array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="RankException"></exception>
        /// <param name="array">The one-dimensional array to search.</param>
        /// <param name="value">The object to locate in <paramref name="array"/>.</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <returns>The index of the last occurrence of <paramref name="value"/>, if it's found, within the range of elements in <paramref name="array"/> that extends from <paramref name="startIndex"/> to the last element; otherwise, the lower bound of the array minus 1.</returns>
        public static int LastIndexOf(this Array array, object value, int startIndex) => Array.LastIndexOf(array, value, startIndex);

        /// <summary>
        /// Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of ifs last occurrence. The range extends from a specified index for a specified number of elements.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="RankException"></exception>
        /// <param name="array">The one-dimensional array to search.</param>
        /// <param name="value">The object to locate in <paramref name="array"/>.</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <param name="count">The number of elements to search.</param>
        /// <returns>The index of the last occurrence of <paramref name="value"/>, if it's found in the <paramref name="array"/> from index <paramref name="startIndex"/> to <paramref name="startIndex"/> + <paramref name="count"/> - 1; otherwise, the lower bound of the array minus 1.</returns>
        public static int LastIndexOf(this Array array, object value, int startIndex, int count) => Array.LastIndexOf(array, value, startIndex, count);

        /// <summary>
        /// Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its last occurrence. The range extends from a specified index for a specified number of elements.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf__1___0_____0_System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based array to search.</param>
        /// <param name="value">The object to locate in <paramref name="array"/>.</param>
        /// <param name="startIndex">The zero-based starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The zero-based index of the last occurrence of <paramref name="value"/> within the range of elements in <paramref name="array"/> that starts at <paramref name="startIndex"/> and contains the number of elements specified in <paramref name="count"/>, if found; otherwise, -1.</returns>
        public static int LastIndexOf<T>(this T[] array, T value, int startIndex, int count) => Array.LastIndexOf(array, value, startIndex, count);

        /// <summary>
        /// Searches for the specified object and returns the index of its last occurrence in a one-dimensional array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf__1___0_____0_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based array to search.</param>
        /// <param name="value">The object to locate in <paramref name="array"/>.</param>
        /// <returns>The zero-based index of the last occurrence of <paramref name="value"/> in the entire <paramref name="array"/>, if found; otherwise, -1.</returns>
        public static int LastIndexOf<T>(this T[] array, T value) => Array.LastIndexOf(array, value);

        /// <summary>
        /// Searches for the specified object in a range of elements of a one dimensional array, and returns the index of its last occurrence. The range extends from a specified index to the end of the array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf__1___0_____0_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based array to search.</param>
        /// <param name="value">The object to locate in <paramref name="array"/>.</param>
        /// <param name="startIndex">The zero-based starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <returns>The zero-based index of the last occurrence of <paramref name="value"/> within the range of elements in <paramref name="array"/> that extends from <paramref name="startIndex"/> to the last element, if found; otherwise, -1.</returns>
        public static int LastIndexOf<T>(this T[] array, T value, int startIndex) => Array.LastIndexOf(array, value, startIndex);

        /// <summary>
        /// Changes the number of elements of a one-dimensional array to the specified new size.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.resize?view=net-5.0"/></remarks>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based array to resize, or <c>null</c> to create a new array with the specified size.</param>
        /// <param name="newSize">The size of the new array.</param>
        /// <returns><paramref name="array"/></returns>
        public static T[] Resize<T>(this T[] array, int newSize) { Array.Resize(ref array, newSize); return array; }

        /// <summary>
        /// Reverses the sequence of a subset of the elements in the one-dimensional <see cref="Array"/>.
        /// </summary>
        /// <remarks>https://docs.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-5.0#System_Array_Reverse_System_Array_System_Int32_System_Int32_</remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <param name="array">The one-dimensional <see cref="Array"/> to reverse.</param>
        /// <param name="index">The starting index of the section to reverse.</param>
        /// <param name="length">The number of elements in the section to reverse.</param>
        /// <returns><paramref name="array"/></returns>
        internal static Array Reverse(this Array array, int index, int length) { Array.Reverse(array, index, length); return array; }

        /// <summary>
        /// Reverses the sequence of the elements in the entire one-dimensional <see cref="Array"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-5.0#System_Array_Reverse_System_Array_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <param name="array">The one-dimensional <see cref="Array"/> to reverse.</param>
        /// <returns><paramref name="array"/></returns>
        internal static Array Reverse(this Array array) { Array.Reverse(array); return array; }

        /// <summary>
        /// Reverses the sequence of the elements in the one-dimensional generic array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-5.0#System_Array_Reverse__1___0___"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <typeparam name="T">The type of the elements in <paramref name="array"/>.</typeparam>
        /// <param name="array">The one-dimensional array of elements to reverse.</param>
        /// <returns><paramref name="array"/></returns>
        internal static T[] Reverse<T>(this T[] array) { Array.Reverse(array); return array; }

        /// <summary>
        /// Reverses the sequence of a subset of the elements in the one-dimensional generic array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-5.0#System_Array_Reverse__1___0___System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <typeparam name="T">The type of the elements in <paramref name="array"/>.</typeparam>
        /// <param name="array">The one-dimensional array of elements to reverse.</param>
        /// <param name="index">The starting index of the section to reverse.</param>
        /// <param name="length">The number of elements in the section to reverse.</param>
        /// <returns><paramref name="array"/></returns>
        internal static T[] Reverse<T>(this T[] array, int index, int length) { Array.Reverse(array, index, length); return array; }

        /// <summary>
        /// Sorts the elements in a range of elements in a one-dimensional <see cref="Array"/> using the specified <see cref="IComparer"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Int32_System_Int32_System_Collections_IComparer_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <param name="array">The one-dimensional <see cref="Array"/> to sort.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort</param>
        /// <param name="comparer">The <see cref="IComparer"/> implementation to use when comparing elements.</param>
        /// <returns><paramref name="array"/></returns>
        public static Array Sort(this Array array, int index, int length, IComparer comparer) { Array.Sort(array, index, length, comparer); return array; }

        /// <summary>
        /// Sorts a range of elements in a pair of one-dimensional <see cref="Array"/> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="Array"/> using the specified <see cref="IComparer"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Array_System_Int32_System_Int32_System_Collections_IComparer_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <param name="keys">The one-dimensional <see cref="Array"/> that contains the keys to sort.</param>
        /// <param name="items">The one-dimensional <see cref="Array"/> that contains the items that correspond to each of the keys in the <paramref name="keys"/><see cref="Array"/> or <c>null</c> to sort only the <paramref name="keys"/><see cref="Array"/>.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// <param name="comparer">The <see cref="IComparer"/> implementation to use when comparing elements or <c>null</c> to use the <see cref="IComparable"/> implementation of each element.</param>
        /// <returns><paramref name="keys"/> and <paramref name="items"/></returns>
        public static Tuple<Array, Array> Sort(this Array keys, Array items, int index, int length, IComparer comparer) { Array.Sort(keys, items, index, length, comparer); return new Tuple<Array, Array>(keys, items); }

        /// <summary>
        /// Sorts the elements in a range of elements in a one-dimensional <see cref="Array"/> using the <see cref="IComparable"/> implementation of each element of the <see cref="Array"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <param name="array">The one-dimensional <see cref="Array"/> to sort.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// <returns><paramref name="array"/></returns>
        public static Array Sort(this Array array, int index, int length) { Array.Sort(array, index, length); return array; }

        /// <summary>
        /// Sorts a range of elements in a pair of one-dimensional <see cref="Array"/> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="Array"/> using the <see cref="IComparable"/> implementation of each key.
        /// </summary>
        /// <remarks><seealso href=""/>https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Array_System_Int32_System_Int32_</remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <param name="keys">The one-dimensional <see cref="Array"/> that contains the keys to sort.</param>
        /// <param name="items">The one-dimensional <see cref="Array"/> that contains the items that correspond to each of the keys in the <paramref name="keys"/><see cref="Array"/> or <c>null</c> to sort only the <paramref name="keys"/><see cref="Array"/>.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// <returns><paramref name="keys"/> and <paramref name="items"/></returns>
        public static Tuple<Array, Array> Sort(this Array keys, Array items, int index, int length) { Array.Sort(keys, items, index, length); return new Tuple<Array, Array>(keys, items); }

        /// <summary>
        /// Sorts the elements in a one-dimensional <see cref="Array"/> using the specified <see cref="IComparer"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Collections_IComparer_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <param name="array">The one-dimensional array to sort.</param>
        /// <param name="comparer">The implementation to use when comparing elements or <c>null</c> to use the <see cref="IComparable"/> implementation of each element.</param>
        /// <returns><paramref name="array"/></returns>
        public static Array Sort(this Array array, IComparer comparer) { Array.Sort(array, comparer); return array; }

        /// <summary>
        /// Sorts a pair of one-dimensional <see cref="Array"/> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="Array"/> using the specified <see cref="IComparer"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Array_System_Collections_IComparer_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <param name="keys">The one-dimensional <see cref="Array"/> that contains the keys to sort.</param>
        /// <param name="items">The one-dimensional <see cref="Array"/> that contains the items that correspond to each of the keys in the <paramref name="keys"/><see cref="Array"/> or <c>null</c> to sort only the <paramref name="keys"/><see cref="Array"/>.</param>
        /// <param name="comparer">The implementation to use when comparing elements or <c>null</c> to use the <see cref="IComparable"/> implementation of each element.</param>
        /// <returns><paramref name="keys"/> and <paramref name="items"/></returns>
        public static Tuple<Array, Array> Sort(this Array keys, Array items, IComparer comparer) { Array.Sort(keys, items, comparer); return new Tuple<Array, Array>(keys, items); }

        /// <summary>
        /// Sorts a pair of one-dimensional <see cref="Array"/> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="Array"/> using the <see cref="IComparable"/> implementation of each key.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Array_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <param name="keys">The one-dimensional <see cref="Array"/> that contains the keys to sort.</param>
        /// <param name="items">The one-dimensional <see cref="Array"/> that contains the items that correspond to each of the keys in the <paramref name="keys"/><see cref="Array"/> or <c>null</c> to sort only the <paramref name="keys"/><see cref="Array"/>.</param>
        /// <returns><paramref name="keys"/> and <paramref name="items"/></returns>
        public static Tuple<Array, Array> Sort(this Array keys, Array items) { Array.Sort(keys, items); return new Tuple<Array, Array>(keys, items); }

        /// <summary>
        /// Sorts the elements in an entire one-dimensional <see cref="Array"/> using the <see cref="IComparable"/> implementation of each element of the <see cref="Array"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <param name="array">The one-dimensional <see cref="Array"/> to sort.</param>
        /// <returns><paramref name="array"/></returns>
        public static Array Sort(this Array array) { Array.Sort(array); return array; }

        /// <summary>
        /// Sorts the elements in an entire <see cref="Array"/> using the <see cref="IComparable{T}"/> generic interface implementation of each element of the <see cref="Array"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based Array to sort.</param>
        /// <returns><paramref name="array"/></returns>
        public static T[] Sort<T>(this T[] array) { Array.Sort(array); return array; }

        /// <summary>
        /// Sorts the elements in an <see cref="Array"/> using the specified <see cref="IComparer{T}"/> generic interface.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Collections_Generic_IComparer___0__"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-base <see cref="Array"/> to sort.</param>
        /// <param name="comparer">The <see cref="IComparable{T}"/> generic interface implementation to use when comparing elements, or <c>null</c> to use the <see cref="IComparable{T}"/> generic interface implementation of each element.</param>
        /// <returns><paramref name="array"/></returns>
        public static T[] Sort<T>(this T[] array, IComparer<T> comparer) { Array.Sort(array, comparer); return array; }

        /// <summary>
        /// Sorts the elements in an <see cref="Array"/> using the specified <see cref="Comparison{T}"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Comparison___0__"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to sort.</param>
        /// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
        /// <returns><paramref name="array"/></returns>
        public static T[] Sort<T>(this T[] array, Comparison<T> comparison) { Array.Sort(array, comparison); return array; }

        /// <summary>
        /// Sorts the elements in a range of elements in an <see cref="Array"/> using the <see cref="IComparable{T}"/> generic interface implementation of each element of the <see cref="Array"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to sort.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// <returns><paramref name="array"/></returns>
        public static T[] Sort<T>(this T[] array, int index, int length) { Array.Sort(array, index, length); return array; }

        /// <summary>
        /// Sorts the elements in a range of elements in an <see cref="Array"/> using the specified <see cref="IComparer{T}"/> generic interface.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Int32_System_Int32_System_Collections_Generic_IComparer___0__"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to sort.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// <param name="comparer">The implementation to use when comparing elements or <c>null</c> to use the <see cref="IComparable"/> implementation of each element.</param>
        /// <returns><paramref name="array"/></returns>
        public static T[] Sort<T>(this T[] array, int index, int length, IComparer<T> comparer) { Array.Sort(array, index, length, comparer); return array; }

        /// <summary>
        /// Sorts a pair of <see cref="Array"/> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="Array"/> using the <see cref="IComparable{T}"/> generic interface implementation of each key.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Collections_Generic_IComparer___0__"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <typeparam name="TKey">The type of the elements of the key array.</typeparam>
        /// <typeparam name="TValue">The type of the elements of the items array.</typeparam>
        /// <param name="keys">The one-dimensional, zero-based <see cref="Array"/> that contains the keys to sort.</param>
        /// <param name="items">The one-dimensional, zero-based <see cref="Array"/> that contains the items that correspond to the keys in <paramref name="keys"/>, or <c>null</c> to sort only <paramref name="keys"/>.</param>
        /// <returns><paramref name="keys"/> and <paramref name="items"/></returns>
        public static Tuple<TKey[], TValue[]> Sort<TKey, TValue>(this TKey[] keys, TValue[] items) { Array.Sort(keys, items); return new Tuple<TKey[], TValue[]>(keys, items); }

        /// <summary>
        /// Sorts a pair of <see cref="Array"/> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="Array"/> using the specified <see cref="IComparer{T}"/> generic interface.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Collections_Generic_IComparer___0__"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <typeparam name="TKey">The type of the elements of the key array.</typeparam>
        /// <typeparam name="TValue">The type of the elements of the items array.</typeparam>
        /// <param name="keys">The one-dimensional, zero-based <see cref="Array"/> that contains the keys to sort.</param>
        /// <param name="items">The one-dimensional, zero-based <see cref="Array"/> that contains the items that correspond to the keys in <paramref name="keys"/>, or <c>null</c> to sort only <paramref name="keys"/>.</param>
        /// <param name="comparer">The <see cref="IComparable{T}"/> generic interface implementation to use when comparing elements, or <c>null</c> to use the <see cref="IComparable{T}"/> generic interface implementation of each element.</param>
        /// <returns><paramref name="keys"/> and <paramref name="items"/></returns>
        public static Tuple<TKey[], TValue[]> Sort<TKey, TValue>(this TKey[] keys, TValue[] items, IComparer<TKey> comparer) { Array.Sort(keys, items, comparer); return new Tuple<TKey[], TValue[]>(keys, items); }

        /// <summary>
        /// Sorts a range of elements in a pair of <see cref="Array"/> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="Array"/> using the <see cref="IComparable{T}"/> generic interface implementation of each key.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <typeparam name="TKey">The type of the elements of the key array.</typeparam>
        /// <typeparam name="TValue">The type of the elements of the items array.</typeparam>
        /// <param name="keys">The one-dimensional, zero-based <see cref="Array"/> that contains the keys to sort.</param>
        /// <param name="items">The one-dimensional, zero-based <see cref="Array"/> that contains the items that correspond to the keys in <paramref name="keys"/>, or <c>null</c> to sort only <paramref name="keys"/>.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// <returns><paramref name="keys"/> and <paramref name="items"/></returns>
        public static Tuple<TKey[], TValue[]> Sort<TKey, TValue>(this TKey[] keys, TValue[] items, int index, int length) { Array.Sort(keys, items, index, length); return new Tuple<TKey[], TValue[]>(keys, items); }

        /// <summary>
        /// Sorts a range of elements in a pair of <see cref="Array"/> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="Array"/> using the specified <see cref="IComparer{T}"/> generic interface.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Int32_System_Int32_System_Collections_Generic_IComparer___0__"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <typeparam name="TKey">The type of the elements of the key array.</typeparam>
        /// <typeparam name="TValue">The type of the elements of the items array.</typeparam>
        /// <param name="keys">The one-dimensional, zero-based <see cref="Array"/> that contains the keys to sort.</param>
        /// <param name="items">The one-dimensional, zero-based <see cref="Array"/> that contains the items that correspond to the keys in <paramref name="keys"/>, or <c>null</c> to sort only <paramref name="keys"/>.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// <param name="comparer">The implementation to use when comparing elements or <c>null</c> to use the <see cref="IComparable"/> implementation of each element.</param>
        /// <returns><paramref name="keys"/> and <paramref name="items"/></returns>
        public static Tuple<TKey[], TValue[]> Sort<TKey, TValue>(this TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer) { Array.Sort(keys, items, index, length, comparer); return new Tuple<TKey[], TValue[]>(keys, items); }

        /// <summary>
        /// Determines whether every element in the array matches the conditions defined by the specified predicate.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.trueforall?view=net-5.0"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to check against the conditions.</param>
        /// <param name="match">The predicate that defines the conditions to check against the elements.</param>
        /// <returns><c>true</c> if every element in <paramref name="array"/> matches the conditions defined by the specified predicate; otherwise, <c>false</c>. If there are no elements in the array, the return value is <c>true</c>.</returns>
        public static bool TrueForAll<T>(this T[] array, Predicate<T> match) => Array.TrueForAll(array, match);

        /// <summary>
        /// Creates a shallow copy of the <see cref="Array"/>
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.clone?view=net-5.0"/></remarks>
        /// <param name="this"><c>this</c></param>
        /// <returns>A shallow copy of the <paramref name="this"/>.</returns>
        public static object Clone(this Array @this) => @this.Clone();

        /// <summary>
        /// Copies all the elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index. The index is specified as a 64-bit integer.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.copyto?view=net-5.0#System_Array_CopyTo_System_Array_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="array">The one-dimensional array that is the destination of the elements copied from the current array.</param>
        /// <param name="index">A 32-bit integer that represents the index in <paramref name="array"/> at which copying begins.</param>
        /// <returns><paramref name="array"/></returns>
        public static Array CopyTo(this Array @this, Array array, int index) { @this.CopyTo(array, index); return array; }

        /// <summary>
        /// Copies all the elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index. The index is specified as a 64-bit integer.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.copyto?view=net-5.0#System_Array_CopyTo_System_Array_System_Int32_"/></remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="array">The one-dimensional array that is the destination of the elements copied from the current array.</param>
        /// <param name="index">A 64-bit integer that represents the index in <paramref name="array"/> at which copying begins.</param>
        /// <returns><paramref name="array"/></returns>
        public static Array CopyTo(this Array @this, Array array, long index) { @this.CopyTo(array, index); return array; }

        /// <summary>
        /// Returns an <see cref="IEnumerator"/> for the <see cref="Array"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.getenumerator?view=net-5.0"/></remarks>
        /// <param name="this"><c>this</c></param>
        /// <returns>An <see cref="IEnumerator"/> for the Array.</returns>
        public static IEnumerator GetEnumerator(this Array @this) => @this.GetEnumerator();

        /// <summary>
        /// Gets a 32-bit integer that represents the number of elements in the specified dimension of the <see cref="Array"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.getlength?view=net-5.0"/></remarks>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="dimension">A zero-based dimension of the <see cref="Array"/> whose length needs to be determined.</param>
        /// <returns>A 32-bit integer that represents the number of elements in the specified dimension.</returns>
        public static int GetLength(this Array @this, int dimension) => @this.GetLength(dimension);

        /// <summary>
        /// Gets a 64-bit integer that represents the number of elements in the specified dimension of the <see cref="Array"/>.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.getlonglength?view=net-5.0"/></remarks>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="dimension">A zero-based dimension of the <see cref="Array"/> whose length needs to be determined.</param>
        /// <returns>A 64-bit integer that represents the number of elements in the specified dimension.</returns>
        public static long GetLongLength(this Array @this, int dimension) => @this.GetLongLength(dimension);

        /// <summary>
        /// Gets the index of the first element of the specified dimension in the array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.getlowerbound?view=net-5.0"/></remarks>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="dimension">A zero-based dimension of the array whose starting index needs to be determined.</param>
        /// <returns>The index of the first element of the specified dimension in the array.</returns>
        public static int GetLowerBound(this Array @this, int dimension) => @this.GetLowerBound(dimension);

        /// <summary>
        /// Gets the index of the last element of the specified dimension in the array.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.getupperbound?view=net-5.0"/></remarks>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="dimension">A zero-based dimension of the array whose starting index needs to be determined.</param>
        /// <returns>The index of the first element of the specified dimension in the array.</returns>
        public static int GetUpperBound(this Array @this, int dimension) => @this.GetUpperBound(dimension);

        /// <summary>
        /// Gets the value at the specified position in the three-dimensional <see cref="Array"/>. The indexes are specified as 64-bit integers.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int64_System_Int64_System_Int64_"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="index1">A 64-bit integer that represents the first-dimension index of the <see cref="Array"/> element to get.</param>
        /// <param name="index2">A 64-bit integer that represents the second-dimension index of the <see cref="Array"/> element to get.</param>
        /// <param name="index3">A 64-bit integer that represents the third-dimension index of the <see cref="Array"/> element to get.</param>
        /// <returns>The value at the specified position in the three-dimensional <see cref="Array"/>.</returns>
        public static object Get(this Array @this, long index1, long index2, long index3) => @this.GetValue(index1, index2, index3);

        /// <summary>
        /// Gets the value at the specified position in the three-dimensional <see cref="Array"/>. The indexes are specified as 32-bit integers.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int32_System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="index1">A 32-bit integer that represents the first-dimension index of the <see cref="Array"/> element to get.</param>
        /// <param name="index2">A 32-bit integer that represents the second-dimension index of the <see cref="Array"/> element to get.</param>
        /// <param name="index3">A 32-bit integer that represents the third-dimension index of the <see cref="Array"/> element to get.</param>
        /// <returns>The value at the specified position in the three-dimensional <see cref="Array"/>.</returns>
        public static object Get(this Array @this, int index1, int index2, int index3) => @this.GetValue(index1, index2, index3);

        /// <summary>
        /// Gets the value at the specified position in the two-dimensional <see cref="Array"/>. The indexes are specified as 64-bit integers.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int64_System_Int64_"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="index1">A 64-bit integer that represents the first-dimension index of the <see cref="Array"/> element to get.</param>
        /// <param name="index2">A 64-bit integer that represents the second-dimension index of the <see cref="Array"/> element to get.</param>
        /// <returns>The value at the specified position in the two-dimensional <see cref="Array"/>.</returns>
        public static object GetValue(this Array @this, long index1, long index2) => @this.GetValue(index1, index2);

        /// <summary>
        /// Gets the value at the specified position in the two-dimensional <see cref="Array"/>. The indexes are specified as 32-bit integers.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="index1">A 32-bit integer that represents the first-dimension index of the <see cref="Array"/> element to get.</param>
        /// <param name="index2">A 32-bit integer that represents the second-dimension index of the <see cref="Array"/> element to get.</param>
        /// <returns>The value at the specified position in the two-dimensional <see cref="Array"/>.</returns>
        public static object Get(this Array @this, int index1, int index2) => @this.GetValue(index1, index2);

        /// <summary>
        /// Gets the value at the specified position in the one-dimensional <see cref="Array"/>. The indexes are specified as 32-bit integers.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int32_"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="index">A 32-bit integer that represents the first-dimension index of the <see cref="Array"/> element to get.</param>
        /// <returns>The value at the specified position in the one-dimensional <see cref="Array"/>.</returns>
        public static object Get(this Array @this, int index) => @this.GetValue(index);

        /// <summary>
        /// Gets the value at the specified position in the one-dimensional <see cref="Array"/>. The indexes are specified as 64-bit integers.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int64_"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="index">A 64-bit integer that represents the first-dimension index of the <see cref="Array"/> element to get.</param>
        /// <returns>The value at the specified position in the one-dimensional <see cref="Array"/>.</returns>
        public static object Get(this Array @this, long index) => @this.GetValue(index);

        /// <summary>
        /// Gets the value at the specified position in the multidimensional <see cref="Array"/>. The indexes are specified as an array of 32-bit integers.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int32___"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="indices">A one-dimensional array of 32-bit integers that represent the indexes specifying the position of the Array element to get.</param>
        /// <returns>The value at the specified position in the multidimensional <see cref="Array"/>.</returns>
        public static object Get(this Array @this, params int[] indices) => @this.GetValue(indices);

        /// <summary>
        /// Gets the value at the specified position in the multidimensional <see cref="Array"/>. The indexes are specified as an array of 64-bit integers.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int64___"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="indices">A one-dimensional array of 64-bit integers that represent the indexes specifying the position of the Array element to get.</param>
        /// <returns>The value at the specified position in the multidimensional <see cref="Array"/>.</returns>
        public static object Get(this Array @this, params long[] indices) => @this.GetValue(indices);

        /// <summary>
        /// Initializes every element of the value-type <see cref="Array"/> by calling the parameterless constructor of the value type.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.initialize?view=net-5.0"/></remarks>
        /// <param name="this"><c>this</c></param>
        /// <returns><paramref name="this"/></returns>
        public static Array Initialize(this Array @this) { @this.Initialize(); return @this; }

        /// <summary>
        /// Sets a value to the element at the specified position in the one-dimensional Array. The index is specified as a 32-bit integer.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.setvalue?view=net-5.0#System_Array_SetValue_System_Object_System_Int32_"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="value">The new value for the specified element.</param>
        /// <param name="index">A 32-bit integer that represents the position of the <see cref="Array"/> element to set.</param>
        /// <returns><paramref name="this"/></returns>
        public static Array Set(this Array @this, object value, int index) { @this.SetValue(value, index); return @this; }

        /// <summary>
        /// Sets a value to the element at the specified position in the multi-dimensional Array. The index is specified as a 32-bit integer.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.setvalue?view=net-5.0#System_Array_SetValue_System_Object_System_Int32___"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="value">The new value for the specified element.</param>
        /// <param name="indices">A one-dimensional array of 32-bit integers that represent the indexes specifying the position of the element to set.</param>
        /// <returns><paramref name="this"/></returns>
        public static Array Set(this Array @this, object value, params int[] indices) { @this.SetValue(value, indices); return @this; }

        /// <summary>
        /// Sets a value to the element at the specified position in the one-dimensional Array. The index is specified as a 64-bit integer.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.setvalue?view=net-5.0#System_Array_SetValue_System_Object_System_Int64_"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="value">The new value for the specified element.</param>
        /// <param name="index">A 64-bit integer that represents the position of the <see cref="Array"/> element to set.</param>
        /// <returns><paramref name="this"/></returns>
        public static Array Set(this Array @this, object value, long index) { @this.SetValue(value, index); return @this; }

        /// <summary>
        /// Sets a value to the element at the specified position in the multi-dimensional Array. The index is specified as a 64-bit integer.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.setvalue?view=net-5.0#System_Array_SetValue_System_Object_System_Int64___"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="value">The new value for the specified element.</param>
        /// <param name="indices">A one-dimensional array of 64-bit integers that represent the indexes specifying the position of the element to set.</param>
        /// <returns><paramref name="this"/></returns>
        public static Array Set(this Array @this, object value, params long[] indices) { @this.SetValue(value, indices); return @this; }

        /// <summary>
        /// Sets a value to the element at the specified position in the two-dimensional Array. The index is specified as a 32-bit integer.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.setvalue?view=net-5.0#System_Array_SetValue_System_Object_System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="value">The new value for the specified element.</param>
        /// <param name="index1">A 32-bit integer that represents the first-dimension index of the <see cref="Array"/> element to set.</param>
        /// <param name="index2">A 32-bit integer that represents the second-dimension index of the <see cref="Array"/> element to set.</param>
        /// <returns><paramref name="this"/></returns>
        public static Array Set(this Array @this, object value, int index1, int index2) { @this.SetValue(value, index1, index2); return @this; }

        /// <summary>
        /// Sets a value to the element at the specified position in the two-dimensional Array. The index is specified as a 64-bit integer.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.setvalue?view=net-5.0#System_Array_SetValue_System_Object_System_Int64_System_Int64_"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="value">The new value for the specified element.</param>
        /// <param name="index1">A 64-bit integer that represents the first-dimension index of the <see cref="Array"/> element to set.</param>
        /// <param name="index2">A 64-bit integer that represents the second-dimension index of the <see cref="Array"/> element to set.</param>
        /// <returns><paramref name="this"/></returns>
        public static Array Set(this Array @this, object value, long index1, long index2) { @this.SetValue(value, index1, index2); return @this; }

        /// <summary>
        /// Sets a value to the element at the specified position in the three-dimensional Array. The index is specified as a 32-bit integer.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.setvalue?view=net-5.0#System_Array_SetValue_System_Object_System_Int32_System_Int32_System_Int32_"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="value">The new value for the specified element.</param>
        /// <param name="index1">A 32-bit integer that represents the first-dimension index of the <see cref="Array"/> element to set.</param>
        /// <param name="index2">A 32-bit integer that represents the second-dimension index of the <see cref="Array"/> element to set.</param>
        /// <param name="index3">A 32-bit integer that represents the third-dimension index of the <see cref="Array"/> element to set.</param>
        /// <returns><paramref name="this"/></returns>
        public static Array Set(this Array @this, object value, int index1, int index2, int index3) { @this.SetValue(value, index1, index2, index3); return @this; }

        /// <summary>
        /// Sets a value to the element at the specified position in the three-dimensional Array. The index is specified as a 64-bit integer.
        /// </summary>
        /// <remarks><seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.array.setvalue?view=net-5.0#System_Array_SetValue_System_Object_System_Int64_System_Int64_System_Int64_"/></remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <param name="this"><c>this</c></param>
        /// <param name="value">The new value for the specified element.</param>
        /// <param name="index1">A 64-bit integer that represents the first-dimension index of the <see cref="Array"/> element to set.</param>
        /// <param name="index2">A 64-bit integer that represents the second-dimension index of the <see cref="Array"/> element to set.</param>
        /// <param name="index3">A 64-bit integer that represents the third-dimension index of the <see cref="Array"/> element to set.</param>
        /// <returns><paramref name="this"/></returns>
        public static Array Set(this Array @this, object value, long index1, long index2, long index3) { @this.SetValue(value, index1, index2, index3); return @this; }
    }
}
