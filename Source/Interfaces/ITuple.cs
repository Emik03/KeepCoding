using System;
using System.Collections;

namespace KeepCoding
{
    /// <summary>
    /// Interface for tuple type. 
    /// </summary>
    public interface ITuple : IEnumerable
    {
        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="WrongDatatypeException"></exception>
        /// <param name="index">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public object this[byte index] { get; set; }

        /// <value>
        /// Determines if the tuple data type is empty.
        /// </value>
        public bool IsEmpty { get; }

        /// <value>
        /// Gets the length of the tuple, describing the amount of elements there are.
        /// </value>
        public byte Length { get; }

        /// <value>
        /// Gets the upper bound of the tuple, which is the last index.
        /// </value>
        /// <exception cref="InvalidOperationException"></exception>
        public byte UpperBound { get; }

        /// <value>
        /// All of the tuple's items as an array, ordered by item number.
        /// </value>
        public object[] ToArray { get; }
    }
}
