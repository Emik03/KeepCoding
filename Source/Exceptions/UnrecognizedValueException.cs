using System;

namespace KeepCoding.v14
{
    /// <summary>
    /// An exception thrown for when the value isn't handled. Written by Emik.
    /// </summary>
    [Serializable]
    public sealed class UnrecognizedValueException : Exception
    {
        /// <summary>
        /// An exception thrown for when the type isn't handled.
        /// </summary>
        public UnrecognizedValueException() { }

        /// <summary>
        /// An exception thrown for when the value isn't handled.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public UnrecognizedValueException(string message) : base(message) { }

        /// <summary>
        /// An exception thrown for when the value isn't handled.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        /// <param name="innerException">An <see cref="Exception"/> within this exception.</param>
        public UnrecognizedValueException(string message, Exception innerException) : base(message, innerException) { }
    }
}
