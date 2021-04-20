using System;

namespace KeepCoding.v14
{
    /// <summary>
    /// An exception thrown when the iterator is empty. Written by Emik.
    /// </summary>
    [Serializable]
    public sealed class EmptyIteratorException : Exception
    {
        /// <summary>
        /// An exception thrown when the iterator is empty.
        /// </summary>
        public EmptyIteratorException() { }

        /// <summary>
        /// An exception thrown when the iterator is empty.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public EmptyIteratorException(string message) : base(message) { }

        /// <summary>
        /// An exception thrown when the iterator is empty.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        /// <param name="innerException">An <see cref="Exception"/> within this exception.</param>
        public EmptyIteratorException(string message, Exception innerException) : base(message, innerException) { }
    }
}
