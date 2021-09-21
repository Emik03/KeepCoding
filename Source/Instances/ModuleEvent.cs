using System;
using System.Collections.Generic;
using System.Linq;
using static System.Delegate;

namespace KeepCoding.Internal
{
    /// <summary>
    /// A class that encapsulates an adder, getter, remover, and setter, similar to a property.
    /// </summary>
    /// <typeparam name="T">The type of the inner variable on the getter.</typeparam>
    public sealed class ModuleEvent<T> where T : Delegate
    {
        private readonly Adder _add;

        private readonly Converter _convert;

        private readonly EventDictionary _events;

        private readonly Getter _get;

        private readonly Remover _remove;

        private readonly Setter _set;

        private readonly Signature _signature;

        /// <summary>
        /// A class that stores a dictionary, restricting what you are able to do.
        /// </summary>
        public sealed class EventDictionary
        {
            private readonly Dictionary<T, object> _dictionary;

            /// <summary>
            /// Creates a new instance of <see cref="EventDictionary"/>, setting the inner dictionary to a new instance.
            /// </summary>
            public EventDictionary() => _dictionary = new Dictionary<T, object>();

            /// <summary>
            /// Adds a key with a value to the dictionary.
            /// </summary>
            /// <param name="key">The key to add.</param>
            /// <param name="value">The value to add.</param>
            public void Add(T key, object value) => _dictionary.Add(key, value);

            /// <summary>
            /// Clears the dictionary.
            /// </summary>
            public void Clear() => _dictionary.Clear();

            /// <summary>
            /// Gets the value from the specified key. If the key doesn't exist, <see langword="null"/> is returned.
            /// </summary>
            /// <param name="key">The key to use.</param>
            /// <returns>The value from the key, or <see langword="null"/>.</returns>
            public object Get(T key) => _dictionary.Get(key, null);

            /// <summary>
            /// Removes a key from the dictionary. If the key doesn't exist, nothing happens.
            /// </summary>
            /// <param name="key">The key to use.</param>
            public void Remove(T key) => _dictionary.Remove(key);
        }

        /// <summary>
        /// Creates a <see langword="new"/> instance of <see cref="ModuleEvent{T}"/> with the underlying type passed in.
        /// </summary>
        /// <param name="adder">The encapsulated method that will add an event.</param>
        /// <param name="getter">The encapsulated method that will get the value.</param>
        /// <param name="setter">The encapsulated method that will set the value.</param>
        /// <param name="signature">The encapsulated method that will get the <see cref="Type"/> of the target.</param>
        /// <param name="remover">The encapsulated method that will remove the value.</param>
        /// <param name="converter">The encapsulated method that changes the value before used in converting types.</param>
        public ModuleEvent(Adder adder, Getter getter, Remover remover, Setter setter, Signature signature, Converter converter = null)
        {
            const string Reason = "Required parameters cannot be null.";

            _add = adder.NullCheck(Reason);
            _get = getter.NullCheck(Reason);
            _remove = remover.NullCheck(Reason);
            _set = setter.NullCheck(Reason);
            _signature = signature.NullCheck(Reason);
            _convert = converter;
            _events = new EventDictionary();
        }

        /// <summary>
        /// Represents an adder operator.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public delegate void Adder(object value);

        /// <summary>
        /// Represents the remover operator.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public delegate void Remover(object value);

        /// <summary>
        /// Represents a setter operator.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public delegate void Setter(object value);

        /// <summary>
        /// Converts the delegate to a different type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The value converted to something else from <typeparamref name="T"/>.</returns>
        public delegate Delegate Converter(T value);

        /// <summary>
        /// Gets the <see cref="Type"/> of the target.
        /// </summary>
        /// <returns>The <see cref="Type"/> of the target.</returns>
        public delegate Type Signature();

        /// <summary>
        /// Represents a getter operator.
        /// </summary>
        /// <returns>The value from the operation.</returns>
        public delegate T Getter();

        /// <summary>
        /// Subscribes an event to the inner value.
        /// </summary>
        public void Add(T value)
        {
            if (value is null)
                return;

            object method = Create(value);

            _events.Add(value, method);
            _add(method);
        }

        /// <summary>
        /// Sets the event to the inner value.
        /// </summary>
        public void Set(T value)
        {
            _events.Clear();

            object method = Create(value);

            _events.Add(value, method);
            _set(method);
        }

        /// <summary>
        /// Gets the value of the inner value.
        /// </summary>
        /// <returns>The returned value of the <see cref="Getter"/>.</returns>
        public T Get() => _get();

        /// <summary>
        /// The remover operator.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public void Remove(T value)
        {
            if (value is null)
                return;

            _remove(_events.Get(value));
            _events.Remove(value);
        }

        /// <summary>
        /// Implicitly uses the getter.
        /// </summary>
        /// <param name="moduleEvent">The instance of this type to convert.</param>
        public static implicit operator T(ModuleEvent<T> moduleEvent) => moduleEvent._get();

        private object Create(T value)
        {
            if (value is null)
                return null;

            Delegate dele = _convert is null ? value : _convert(value);

            return CreateDelegate(_signature(), dele.Target, dele.Method);
        }
    }
}
