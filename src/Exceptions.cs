using System;

namespace KeepCoding.v14
{
    /// <summary>
    /// An exception thrown when the constructor throws an exception due to a bad argument. Written by Emik.
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

    /// <summary>
    /// An exception thrown when the number is unexpectedly negative. Written by Emik.
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

    /// <summary>
    /// An exception thrown when the iterator is null. Written by Emik.
    /// </summary>
    [Serializable]
    public sealed class NullIteratorException : Exception
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

    /// <summary>
    /// An exception thrown for when the type isn't handled. Written by Emik.
    /// </summary>
    [Serializable]
    public sealed class UnrecognizedTypeException : Exception
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
