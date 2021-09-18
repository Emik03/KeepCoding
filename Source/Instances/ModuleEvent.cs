namespace KeepCoding
{
    /// <summary>
    /// A class that encapsulates an adder, getter, and setter, similar to a property.
    /// </summary>
    /// <typeparam name="T">The type of the inner variable on the getter.</typeparam>
    public sealed class ModuleEvent<T> : StrictRecord<Tuple<ModuleEvent<T>.Adder, ModuleEvent<T>.Getter, ModuleEvent<T>.Setter>, ModuleEvent<T>>
    {
        /// <summary>
        /// Represents an adder operator.
        /// </summary>
        public delegate void Adder(T value);

        /// <summary>
        /// Represents a getter operator.
        /// </summary>
        /// <returns>The value from the operation.</returns>
        public delegate T Getter();

        /// <summary>
        /// Represents a setter operator.
        /// </summary>
        public delegate void Setter(T value);

        /// <summary>
        /// Subscribes an event to the inner <see langword="delegate"/>.
        /// </summary>
        public void Add(T value) => Value.Item1(value);

        /// <summary>
        /// Sets the event to the inner <see langword="delegate"/>.
        /// </summary>
        public void Set(T value) => Value.Item3(value);

        /// <summary>
        /// Gets the value of the inner <see langword="delegate"/>.
        /// </summary>
        /// <returns></returns>
        public T Get() => Value.Item2();

        /// <summary>
        /// Creates a new instance of <see cref="ModuleEvent{T}"/> with the underlying type passed in.
        /// </summary>
        /// <param name="adder">The encapsulated method that will add an event.</param>
        /// <param name="getter">The encapsulated method that will get the value.</param>
        /// <param name="setter">The encapsulated method that will set the value.</param>
        /// <returns>A new instance of this type, with the inner value based on the parameters passed in.</returns>
        public static ModuleEvent<T> New(Adder adder, Getter getter, Setter setter) => From(adder.ToTuple(getter, setter));

        /// <summary>
        /// Implicitly uses the getter.
        /// </summary>
        /// <param name="addGetSet">The instance of this type to convert.</param>
        public static implicit operator T(ModuleEvent<T> addGetSet) => addGetSet.Value.Item2();

        /// <summary>
        /// Implicitly uses the constructor.
        /// </summary>
        /// <param name="value">The methods to store.</param>
        public static implicit operator ModuleEvent<T>(Tuple<Adder, Getter, Setter> value) => From(value);

        /// <summary>
        /// Performs a null check on each entry in the tuple.
        /// </summary>
        protected override void Validate() => Value.Items.ForEach(o => o.NullCheck("None of the methods can be null."));
    }
}
