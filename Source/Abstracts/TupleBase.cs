using System;
using System.Collections;
using System.Linq;

namespace KeepCoding
{
    /// <summary>
    /// An abstract type meant for the tuple data type for C# 4. Written by Emik.
    /// </summary>
    public abstract class TupleBase : ITuple
    {
        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="WrongDatatypeException"></exception>
        /// <param name="index">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public object this[byte index] { get => throw IndexOutOfRange(index); set => throw IndexOutOfRange(index); }

        /// <value>
        /// Determines if the tuple data type is empty.
        /// </value>
        public bool IsEmpty => Length == 0;

        /// <value>
        /// Gets the length of the tuple, describing the amount of elements there are.
        /// </value>
        public byte Length => (byte)GetType().GetGenericArguments().Length;

        /// <value>
        /// Gets the upper bound of the tuple, which is the last index.
        /// </value>
        /// <exception cref="InvalidOperationException"></exception>
        public byte UpperBound => IsEmpty ? throw new InvalidOperationException("The tuple is empty, meaning that the upper bound doesn't exist.") : (byte)(Length - 1);

        /// <value>
        /// All of the tuple's items as an array, ordered by item number.
        /// </value>
        public abstract object[] ToArray { get; }

        /// <summary>
        /// Gets the enumerator of the <see cref="TupleBase"/>, using <see cref="ToArray"/>.
        /// </summary>
        /// <returns>All of the items in <see cref="TupleBase"/>.</returns>
        public IEnumerator GetEnumerator() => ToArray.GetEnumerator();

        private protected static TOutput Cast<TInput, TOutput>(in TInput value, int index) => value is TOutput t ? t : throw WrongDatatype(value, typeof(TOutput), index);

        private IndexOutOfRangeException IndexOutOfRange(int i) => new IndexOutOfRangeException($"The index {i} was out of range from the tuple of length {ToArray.Length}.");

        private static WrongDatatypeException WrongDatatype<T>(in T received, in Type expected, int index) => new WrongDatatypeException($"The {(index + 1).ToOrdinal()} element in the tuple cannot be assigned because the value {received.UnwrapToString()} is type {received.GetType().Name} which doesn't match the expected type {expected.Name}.");
    }
}
