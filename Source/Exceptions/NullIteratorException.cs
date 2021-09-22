#if !SIMPLIFIED
using System;

namespace KeepCoding.Internal
{
    /// <summary>
    /// An exception thrown when the iterator is null.
    /// </summary>
    [Serializable]
    public sealed class NullIteratorException : KeepCodingException
    {
        /// <summary>
        /// An exception thrown when the iterator is null.
        /// </summary>
        public NullIteratorException() { }

        /// <summary>
        /// An exception thrown when the iterator is null.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public NullIteratorException(string message) : base(message) { }

        /// <summary>
        /// An exception thrown when the iterator is null.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        /// <param name="innerException">An <see cref="Exception"/> within this exception.</param>
        public NullIteratorException(string message, Exception innerException) : base(message, innerException) { }
    }
}
#endif
