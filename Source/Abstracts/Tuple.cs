using System;

namespace KeepCoding
{
    /// <summary>
    /// An abstract type meant for the tuple data type for C# 4. Written by Emik.
    /// </summary>
    public abstract class Tuple
    {
        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="WrongDatatypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public object this[byte i] { get => throw IndexOutOfRange(i); set => throw IndexOutOfRange(i); }

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

        private protected IndexOutOfRangeException IndexOutOfRange(int i) => new($"The index {i} was out of range from the tuple of length {ToArray.Length}.");

        private protected TOutput Cast<TInput, TOutput>(in TInput value, int index) => value is TOutput t ? t : throw WrongDatatype(value, typeof(TOutput), index);

        private WrongDatatypeException WrongDatatype<T>(in T received, in Type expected, int index) => new($"The {(index + 1).ToOrdinal()} element in the tuple cannot be assigned because the value {received.UnwrapToString()} is type {received.GetType().Name} which doesn't match the expected type {expected.Name}.");
    }
}
