using System;

namespace KeepCoding.v14
{
    /// <summary>
    /// An abstract type meant for the tuple data type for C# 4. Written by Emik.
    /// </summary>
    public abstract class Tuple
    {
        /// <summary>
        /// Indexable tuple, uses <see cref="ToArray"/> to use the appropriate index.
        /// </summary>
        /// <param name="i">The index to use.</param>
        /// <returns><see cref="ToArray"/>'s <paramref name="i"/>th element.</returns>
        public abstract object this[int i] { get; set; }

        /// <value>
        /// All of the tuple's items as an array, ordered by item number.
        /// </value>
        public abstract object[] ToArray { get; }

        private protected T Cast<T>(object value, int index) => value is T t ? t : throw WrongDatatype(value, typeof(T), index);

        private protected IndexOutOfRangeException IndexOutOfRange(int i) => new($"The index {i} was out of range from the tuple of length {ToArray.Length}.");

        private protected WrongDatatypeException WrongDatatype(object received, Type expected, int index) => new($"The {(index + 1).ToOrdinal()} element in the tuple cannot be assigned because the value {received.UnwrapToString()} is type {received.GetType().Name} which doesn't match the expected type {expected.Name}.");
    }
}
