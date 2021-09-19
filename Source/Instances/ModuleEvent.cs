using System;
using System.Collections.Generic;
using System.Reflection;
using static System.Delegate;

namespace KeepCoding.Internal
{
    /// <summary>
    /// A class that encapsulates an adder, getter, and setter, similar to a property.
    /// </summary>
    /// <typeparam name="T">The type of the inner variable on the getter.</typeparam>
    public sealed class ModuleEvent<T> : StrictRecord<Tuple<ModuleEvent<T>.Adder, ModuleEvent<T>.Getter, ModuleEvent<T>.Setter, ModuleEvent<T>.Signature, ModuleEvent<T>.Remover, ModuleEvent<T>.ModuleEventDictionary, ModuleEvent<T>.Converter>, ModuleEvent<T>> where T : Delegate
    {
        /// <summary>
        /// A class that stores a dictionary, restricting what you are able to do.
        /// </summary>
        public sealed class ModuleEventDictionary : StrictRecord<Dictionary<T, object>, ModuleEventDictionary>
        {
            /// <summary>
            /// Clears the dictionary.
            /// </summary>
            public void Clear() => Value.Clear();

            /// <summary>
            /// Gets the value from the specified key. If the key doesn't exist, <see langword="null"/> is returned.
            /// </summary>
            /// <param name="key">The key to use.</param>
            /// <returns>The value from the key, or <see langword="null"/>.</returns>
            public object Get(T key) => Value.Get(key, null);

            /// <summary>
            /// Removes a key from the dictionary. If the key doesn't exist, nothing happens.
            /// </summary>
            /// <param name="key">The key to use.</param>
            public void Remove(T key) => Value.Remove(key);

            /// <summary>
            /// Adds a key with a value to the dictionary.
            /// </summary>
            /// <param name="key">The key to add.</param>
            /// <param name="value">The value to add.</param>
            public void Add(T key, object value) => Value.Add(key, value);
        }

        /// <summary>
        /// Represents the remover operator.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public delegate void Remover(object value);

        /// <summary>
        /// Represents an adder operator.
        /// </summary>
        public delegate void Adder(object value);

        /// <summary>
        /// Represents a setter operator.
        /// </summary>
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
            Assert(value);

            object method = Create(value);

            Value.Item6.Add(value, method);
            Value.Item1(method);
        }

        /// <summary>
        /// Sets the event to the inner value.
        /// </summary>
        public void Set(T value)
        {
            Assert(value);
            Value.Item6.Clear();

            object method = Create(value);

            Value.Item6.Add(value, method);
            Value.Item3(method);
        }

        /// <summary>
        /// Gets the value of the inner value.
        /// </summary>
        /// <returns></returns>
        public T Get() => Value.Item2();

        /// <summary>
        /// The remover operator.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public void Remove(T value)
        {
            Value.Item6.Remove(Assert(value));
            Value.Item5(Create(value));
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
        /// <returns>A <see langword="new"/> instance of this type, with the inner value based on the parameters passed in.</returns>
        public static ModuleEvent<T> New(Adder adder, Getter getter, Setter setter, Signature signature, Remover remover, Converter converter = null) => From(adder.ToTuple(getter, setter, signature, remover, new ModuleEventDictionary(), converter));

        /// <summary>
        /// Implicitly uses the getter.
        /// </summary>
        /// <param name="addGetSet">The instance of this type to convert.</param>
        public static implicit operator T(ModuleEvent<T> addGetSet) => addGetSet.Value.Item2();

        /// <summary>
        /// Performs a null check on each entry in the tuple.
        /// </summary>
        protected override void Validate() => Value.Items.ForEach(o => o.NullCheck("None of the methods can be null."));

        private object Create(T value)
        {
            Delegate dele = Value.Item7 is null ? value : Value.Item7(value);
            return CreateDelegate(Value.Item4(), dele.Target, dele.Method);
        }

        private static T Assert(T value) => value is null ? throw new NullReferenceException("The value cannot be null.") : value;
        private MissingMethodException Missing => new MissingMethodException($"The current type of the component (\"{Module.GetType().Name}\") lacks this method.");

    }
}
