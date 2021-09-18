using System;

namespace KeepCoding.Internal
{
    /// <summary>
    /// An exception thrown when a mutable action is performed on an immutable member.
    /// </summary>
    [Serializable]
    public sealed class ImmutableException : KeepCodingException
    {
        /// <summary>
        /// An exception thrown when a mutable action is performed on an immutable member.
        /// </summary>
        public ImmutableException() { }

        /// <summary>
        /// An exception thrown when a mutable action is performed on an immutable member.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public ImmutableException(string message) : base(message) { }

        /// <summary>
        /// An exception thrown when a mutable action is performed on an immutable member.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        /// <param name="innerException">An <see cref="Exception"/> within this exception.</param>
        public ImmutableException(string message, Exception innerException) : base(message, innerException) { }
    }
}
