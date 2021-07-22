using System;

namespace KeepCoding.Internal
{
    /// <summary>
    /// An exception thrown when the number is unexpectedly negative.
    /// </summary>
    [Serializable]
    public sealed class NegativeNumberException : Exception
    {
        /// <summary>
        /// An exception thrown when the number is unexpectedly negative.
        /// </summary>
        public NegativeNumberException() { }

        /// <summary>
        /// An exception thrown when the number is unexpectedly negative.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public NegativeNumberException(string message) : base(message) { }

        /// <summary>
        /// An exception thrown when the number is unexpectedly negative.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        /// <param name="innerException">An <see cref="Exception"/> within this exception.</param>
        public NegativeNumberException(string message, Exception innerException) : base(message, innerException) { }
    }
}
