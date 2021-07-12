using System;

namespace KeepCoding
{
    /// <summary>
    /// An exception thrown when the constructor throws an exception due to a bad argument.
    /// </summary>
    [Serializable]
    public sealed class ConstructorArgumentException : Exception
    {
        /// <summary>
        /// An exception thrown when the constructor throws an exception due to a bad argument.
        /// </summary>
        public ConstructorArgumentException() { }

        /// <summary>
        /// An exception thrown when the constructor throws an exception due to a bad argument.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public ConstructorArgumentException(string message) : base(message) { }

        /// <summary>
        /// An exception thrown when the constructor throws an exception due to a bad argument.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        /// <param name="innerException">An <see cref="Exception"/> within this exception.</param>
        public ConstructorArgumentException(string message, Exception innerException) : base(message, innerException) { }
    }
}
