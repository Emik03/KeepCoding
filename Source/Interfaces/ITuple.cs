using System;
using System.Collections;

namespace KeepCoding
{
    /// <summary>
    /// Interface for tuple type. 
    /// </summary>
    public interface ITuple : IEnumerable, IEquatable<ITuple>
    {
        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="index">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public object this[byte index] { get; set; }

        /// <summary>
        /// Gets the length of the tuple, describing the amount of elements there are.
        /// </summary>
        public byte Length { get; }

        /// <summary>
        /// Gets the upper bound of the tuple, which is the last index.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public byte UpperBound { get; }

        /// <summary>
        /// All of the tuple's items as an array, ordered by item number.
        /// </summary>
        public object[] ToArray { get; }
    }
}
