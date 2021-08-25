using System;
using System.Collections.Generic;

namespace KeepCoding
{
    /// <summary>
    /// Encapsulates an <see cref="IEqualityComparer{T}"/> that uses an equality comparison function provided as a delegate.
    /// </summary>
    /// <typeparam name="T">The type of elements to be compared for equality.</typeparam>
    public sealed class CustomEqualityComparer<T> : IEqualityComparer<T> where T : notnull
    {
        private readonly Func<T, T, bool> _comparison;

        private readonly Func<T, int>? _getHashCode;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="comparison">Provides the comparison function for this equality comparer.</param>
        /// <param name="getHashCode">Provides the hash function for this equality comparer.</param>
        public CustomEqualityComparer(Func<T, T, bool> comparison, Func<T, int>? getHashCode)
        {
            _comparison = comparison;
            _getHashCode = getHashCode;
        }

        /// <summary>
        /// Constructor which re-uses the default hash function. Use this overload only if using the objects’ original hash function is appropriate for this equality comparison.</summary>
        /// <param name="comparison">Provides the comparison function for this equality comparer.</param>
        public CustomEqualityComparer(Func<T, T, bool> comparison) : this(comparison, null) { }

        /// <summary>
        /// Compares two elements for equality.
        /// </summary>
        /// <remarks>
        /// This method implements <see cref="IEqualityComparer&lt;T&gt;.Equals(T,T)"/>.
        /// </remarks>
        public bool Equals(T x, T y) => _comparison(x, y);

        /// <summary>
        /// Returns a hash code for an element.
        /// </summary>
        /// <remarks>
        /// This method implements <see cref="IEqualityComparer&lt;T&gt;.GetHashCode(T)"/>.
        /// </remarks>
        public int GetHashCode(T obj) => _getHashCode is null ? obj.GetHashCode() : _getHashCode(obj);

        /// <summary>
        /// Creates and returns an equality comparer that compares the equality of objects by comparing the equality of
        /// the result of a selector function.</summary>
        /// <param name="selector">Function selecting the actual value to be compared.</param>
        /// <param name="comparer">Comparer to use for comparing the results of the selector function.</param>
        public static CustomEqualityComparer<T> By<TBy>(Func<T, TBy> selector, IEqualityComparer<TBy> comparer) => selector is null ? throw new ArgumentNullException(nameof(selector))
                : comparer is null ? throw new ArgumentNullException(nameof(comparer))
                : new CustomEqualityComparer<T>((a, b) => comparer.Equals(selector(a), selector(b)), a => comparer.GetHashCode(selector(a)));

        /// <summary>
        /// Creates and returns an equality comparer that compares the equality of objects by comparing the equality of
        /// the result of a selector function.
        /// </summary>
        /// <param name="selector">Function selecting the actual value to be compared.</param>
        /// <param name="comparison">Function used to compare values for equality. If null, will use IEquatable if implemented, or the object's Equals override.</param>
        /// <param name="getHashCode">Function used to compute hash codes. If null, will use IEquatable if implemented, or the object's GetHashCode override.</param>
        public static CustomEqualityComparer<T> By<TBy>(Func<T, TBy> selector, Func<TBy, TBy, bool>? comparison = null, Func<TBy, int>? getHashCode = null)
        {
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            EqualityComparer<TBy> default_ = EqualityComparer<TBy>.Default;

            Func<T, T, bool> cmp = comparison is null
                ? new Func<T, T, bool>((T a, T b) => default_.Equals(selector(a), selector(b)))
                : new Func<T, T, bool>((T a, T b) => comparison(selector(a), selector(b)));

            Func<T, int> ghc = getHashCode is null
                ? new Func<T, int>((T a) => default_.GetHashCode(selector(a)))
                : new Func<T, int>((T a) => getHashCode(selector(a)));

            return new CustomEqualityComparer<T>(cmp, ghc);
        }

        /// <summary>
        /// Creates and returns an equality comparer that compares the equality of objects by comparing the equality of
        /// the result of a string selector function.
        /// </summary>
        /// <param name="selector">Function selecting the actual string value to be compared.</param>
        /// <param name="ignoreCase">If false, an invariant culture string comparison is used. Otherwise, an ordinal no-case comparison (suitable for filenames etc).</param>
        public static CustomEqualityComparer<T> By(Func<T, string> selector, bool ignoreCase) => selector is null ? throw new ArgumentNullException(nameof(selector)) : By(selector, ignoreCase ? StringComparer.OrdinalIgnoreCase : StringComparer.InvariantCulture);
    }
}
