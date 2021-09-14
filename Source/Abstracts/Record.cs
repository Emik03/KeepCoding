using System.Collections.Generic;

namespace KeepCoding
{
    /// <summary>
    /// Defines a reference type that provides built-in functionality for encapsulating data.
    /// </summary>
    /// <remarks>
    /// This class has been mostly taken from mcintyre321's ValueOf type. <see href="https://github.com/mcintyre321/ValueOf"/>
    /// </remarks>
    /// <typeparam name="T">The type of data to encapsulate.</typeparam>
    /// <typeparam name="TThis">The type that is encapsulating <typeparamref name="T"/>.</typeparam>
    public abstract class Record<T, TThis> where TThis : Record<T, TThis>, new()
    {
        /// <summary>
        /// The value to store.
        /// </summary>
        public T Value { get; protected set; }

        /// <summary>
        /// Determines whether two records contain the same <see cref="Value"/>.
        /// </summary>
        /// <param name="a">The left-hand side record to compare.</param>
        /// <param name="b">The right-hand side record to compare.</param>
        /// <returns><see langword="true"/> if <paramref name="a"/> and <paramref name="b"/> are both <see langword="null"/>, or <see cref="Equals(Record{T, TThis})"/> returns <see langword="true"/>. Otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Record<T, TThis> a, Record<T, TThis> b) => a is null && b is null || !(a is null) && !(b is null) && a.Equals(b);

        /// <summary>
        /// Determines whether two records don't contain the same <see cref="Value"/>.
        /// </summary>
        /// <param name="a">The left-hand side record to compare.</param>
        /// <param name="b">The right-hand side record to compare.</param>
        /// <returns><see langword="false"/> if <paramref name="a"/> and <paramref name="b"/> are both <see langword="null"/>, or <see cref="Equals(Record{T, TThis})"/> returns <see langword="true"/>. Otherwise, <see langword="true"/>.</returns>
        public static bool operator !=(Record<T, TThis> a, Record<T, TThis> b) => !(a == b);

        /// <summary>
        /// Encapsulates <paramref name="a"/> into a <see langword="new"/> instance of <see cref="Record{TValue, TThis}"/>.
        /// </summary>
        /// <param name="a">The <typeparamref name="T"/> to pass into the <see cref="Record{TValue, TThis}"/>.</param>
        public static implicit operator Record<T, TThis>(T a) => From(a);

        /// <summary>
        /// Takes <paramref name="a"/>'s inner <see cref="Value"/>.
        /// </summary>
        /// <param name="a">The <see cref="Record{TValue, TThis}"/> to take <see cref="Value"/> from.</param>
        public static implicit operator T(Record<T, TThis> a) => a.Value;

        /// <summary>
        /// Determines whether two records don't contain the same <see cref="Value"/>.
        /// </summary>
        /// <param name="obj">The other instance to compare.</param>
        /// <returns><see langword="false"/> if itself and <paramref name="obj"/> are both <see langword="null"/>, or <see cref="Equals(Record{T, TThis})"/> returns <see langword="true"/>. Otherwise, <see langword="true"/>.</returns>
        public override bool Equals(object obj) => !(obj is null) && (ReferenceEquals(this, obj) || obj.GetType() == GetType() && Equals((Record<T, TThis>)obj));

        /// <summary>
        /// Gets the hash code.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode() => EqualityComparer<T>.Default.GetHashCode(Value);

        /// <summary>
        /// Uses <see cref="Helper.Stringify{T}(T, StringifyFormat)"/> for the inner <see cref="Value"/>.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Value.Stringify();

        /// <summary>
        /// Creates a <see langword="new"/> instance of <see cref="Record{TValue, TThis}"/> from the specified <typeparamref name="TThis"/>.
        /// </summary>
        /// <param name="item">The item to make a <see langword="new"/> instance of <see cref="Record{TValue, TThis}"/> from.</param>
        /// <returns>A new instance of <see cref="Record{TValue, TThis}"/> with the inner <see cref="Value"/> set to <paramref name="item"/>.</returns>
        public static TThis From(T item)
        {
            var x = new TThis
            {
                Value = item
            };

            x.Validate();

            return x;
        }

        /// <summary>
        /// Called whenever <see cref="From(T)"/> is used. This method can be used to <see langword="throw"/> invalid values.
        /// </summary>
        protected virtual void Validate() { }

        /// <summary>
        /// Determines whether two records don't contain the same <see cref="Value"/>.
        /// </summary>
        /// <param name="other">The other instance to compare.</param>
        /// <returns><see langword="false"/> if itself and <paramref name="other"/> are both <see langword="null"/>, or <see cref="Equals(Record{T, TThis})"/> returns <see langword="true"/>. Otherwise, <see langword="true"/>.</returns>
        protected virtual bool Equals(Record<T, TThis> other) => EqualityComparer<T>.Default.Equals(Value, other.Value);
    }
}
