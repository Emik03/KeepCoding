using System;

namespace KeepCoding
{
    /// <summary>
    /// An exception thrown for when the wrong datatype is used. Written by Emik.
    /// </summary>
    [Serializable]
    public sealed class WrongDatatypeException : Exception
    {
        /// <summary>
        /// An exception thrown for when the wrong datatype is used.
        /// </summary>
        public WrongDatatypeException() { }

        /// <summary>
        /// An exception thrown for when the wrong datatype is used.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public WrongDatatypeException(string message) : base(message) { }

        /// <summary>
        /// An exception thrown for when the wrong datatype is used.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        /// <param name="innerException">An <see cref="Exception"/> within this exception.</param>
        public WrongDatatypeException(string message, Exception innerException) : base(message, innerException) { }
    }
}
