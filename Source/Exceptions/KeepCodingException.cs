using System;

namespace KeepCoding.Internal
{
    /// <summary>
    /// An exception that is declared from the Keep Coding library.
    /// </summary>
    public class KeepCodingException : Exception
    {
        /// <summary>
        /// An exception that is declared from the Keep Coding library.
        /// </summary>
        public KeepCodingException() { }

        /// <summary>
        /// An exception that is declared from the Keep Coding library.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public KeepCodingException(string message) : base(message) { }

        /// <summary>
        /// An exception that is declared from the Keep Coding library.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        /// <param name="innerException">An <see cref="Exception"/> within this exception.</param>
        public KeepCodingException(string message, Exception innerException) : base(message, innerException) { }
    }
}
