using System;

namespace KeepCoding.v15
{
    /// <summary>
    /// An exception for when Unity searches for a component but is unable to find said component. Written by Emik.
    /// </summary>
    [Serializable]
    public sealed class UnityComponentNotFoundException : Exception
    {
        /// <summary>
        /// An exception for when Unity searches for a component but is unable to find said component.
        /// </summary>
        public UnityComponentNotFoundException() { }

        /// <summary>
        /// An exception for when Unity searches for a component but is unable to find said component.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public UnityComponentNotFoundException(string message) : base(message) { }

        /// <summary>
        /// An exception for when Unity searches for a component but is unable to find said component.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        /// <param name="innerException">An <see cref="Exception"/> within this exception.</param>
        public UnityComponentNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
