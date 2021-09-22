#if !SIMPLIFIED
using System;

namespace KeepCoding.Internal
{
    /// <summary>
    /// An exception thrown for when the type isn't handled.
    /// </summary>
    [Serializable]
    public sealed class UnrecognizedTypeException : KeepCodingException
    {
        /// <summary>
        /// An exception thrown for when the type isn't handled.
        /// </summary>
        public UnrecognizedTypeException() { }

        /// <summary>
        /// An exception thrown for when the type isn't handled.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public UnrecognizedTypeException(string message) : base(message) { }

        /// <summary>
        /// An exception thrown for when the type isn't handled.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        /// <param name="innerException">An <see cref="Exception"/> within this exception.</param>
        public UnrecognizedTypeException(string message, Exception innerException) : base(message, innerException) { }
    }
}
#endif
