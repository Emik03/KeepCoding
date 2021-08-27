using System;
using System.Collections.Generic;

namespace KeepCoding
{
    /// <summary>
    /// Encapsulates an <see cref="IComparer{T}"/> that uses a comparison function provided as a delegate.
    /// </summary>
    /// <typeparam name="T">The type of elements to be compared.</typeparam>
    public sealed class CustomComparer<T> : IComparer<T>
    {
        private readonly Comparison<T> _comparison;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="comparison">Provides the comparison function for this comparer.</param>
        public CustomComparer(Comparison<T> comparison) => _comparison = comparison;

        /// <summary>
        /// Compares two elements.
        /// </summary>
        /// <remarks>
        /// This method implements <see cref="IComparer&lt;T&gt;.Compare(T,T)"/>.
        /// </remarks>
        public int Compare(T x, T y) => _comparison(x, y);

        /// <summary>
        /// Creates and returns a CustomComparer which compares items by comparing the results of a selector function.
        /// </summary>
        /// <param name="selector">Function selecting the actual value to be compared.</param>
        /// <param name="comparer">Comparer to use for comparing the results of the selector function. If null, the default comparer is used; this comparer will use the IComparable interface if implemented.</param>
        public static CustomComparer<T> By<TBy>(Func<T, TBy> selector, IComparer<TBy> comparer = null)
        {
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            if (comparer is null)
                comparer = Comparer<TBy>.Default;

            return new CustomComparer<T>((a, b) => comparer.Compare(selector(a), selector(b)));
        }

        /// <summary>
        /// Creates and returns a CustomComparer which compares items by comparing the results of a selector function.
        /// </summary>
        /// <param name="selector">Function selecting the actual value to be compared.</param>
        /// <param name="comparison">Comparison to use for comparing the results of the selector function.</param>
        public static CustomComparer<T> By<TBy>(Func<T, TBy> selector, Comparison<TBy> comparison) => selector is null ? throw new ArgumentNullException(nameof(selector))
                : comparison is null ? throw new ArgumentNullException(nameof(comparison))
                : new CustomComparer<T>((a, b) => comparison(selector(a), selector(b)));

        /// <summary>
        /// Creates and returns a CustomComparer which compares items by comparing the results of a selector function.
        /// </summary>
        /// <param name="selector">Function selecting the string value to be compared.</param>
        /// <param name="ignoreCase">If false, an invariant culture string comparison is used. Otherwise, an ordinal no-case comparison (suitable for filenames etc).</param>
        public static CustomComparer<T> By(Func<T, string> selector, bool ignoreCase)
        {
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            StringComparer comparer = ignoreCase ? StringComparer.OrdinalIgnoreCase : StringComparer.InvariantCulture;

            return new CustomComparer<T>((a, b) => comparer.Compare(selector(a), selector(b)));
        }

        /// <summary>
        /// Creates and returns a CustomComparer which uses the current comparer first, and if the current comparer says the items are equal, further compares items by comparing the results of a selector function.
        /// </summary>
        /// <param name="selector">Function selecting the actual value to be compared.</param>
        /// <param name="comparer">Comparer to use for comparing the results of the selector function. If null, the default comparer is used; this comparer will use the IComparable interface if implemented.</param>
        public CustomComparer<T> ThenBy<TBy>(Func<T, TBy> selector, IComparer<TBy> comparer = null)
        {
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            if (comparer is null)
                comparer = Comparer<TBy>.Default;

            return new CustomComparer<T>((a, b) =>
            {
                int result = Compare(a, b);
                return result != 0 ? result : comparer.Compare(selector(a), selector(b));
            });
        }

        /// <summary>
        /// Creates and returns a CustomComparer which uses the current comparer first, and if the current comparer says the items are equal, further compares items by comparing the results of a selector function.
        /// </summary>
        /// <param name="selector">Function selecting the actual value to be compared.</param>
        /// <param name="comparison">Comparison to use for comparing the results of the selector function.</param>
        public CustomComparer<T> ThenBy<TBy>(Func<T, TBy> selector, Comparison<TBy> comparison) => selector is null ? throw new ArgumentNullException(nameof(selector)) : new CustomComparer<T>((a, b) =>
        {
            int result = Compare(a, b);
            return !(result is 0) ? result : comparison(selector(a), selector(b));
        });

        /// <summary>
        /// Creates and returns a CustomComparer which uses the current comparer first, and if the current comparer says the items are equal, further compares items by comparing the results of a string selector function.
        /// </summary>
        /// <param name="selector">Function selecting the actual value to be compared.</param>
        /// <param name="ignoreCase">If false, an invariant culture string comparison is used. Otherwise, an ordinal no-case comparison (suitable for filenames etc).</param>
        public CustomComparer<T> ThenBy(Func<T, string> selector, bool ignoreCase)
        {
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            StringComparer comparer = ignoreCase ? StringComparer.OrdinalIgnoreCase : StringComparer.InvariantCulture;

            return new CustomComparer<T>((a, b) =>
            {
                int result = Compare(a, b);
                return result != 0 ? result : comparer.Compare(selector(a), selector(b));
            });
        }
    }
}
