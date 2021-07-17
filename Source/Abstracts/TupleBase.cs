using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.String;

namespace KeepCoding
{
    /// <summary>
    /// Provides the base <see langword="class"/> for the multiple tuple types.
    /// </summary>
    /// <remarks>
    /// <see cref="TupleBase"/> provides the general functionality that different types of tuples share in common with. As each different type of tuple gives different amounts of generics, this base <see langword="class"/> is therefore non-generic and provides every method that doesn't require it. This can therefore be used as a way of passing in an ambiguous type of tuple.
    /// </remarks>
    /// <example>
    /// The following example illustrates a method for returning the last item of any tuple that uses <see cref="TupleBase"/>.
    /// <code>using KeepCoding;
    /// 
    /// public static class Extensions
    /// {
    ///     public static object Last(TupleBase tuple)
    ///     {
    ///         return tuple[tuple.UpperBound];
    ///     }
    /// }
    /// </code>
    /// This can then used on any kind of tuple. A constructor can be used, but in this example the extension method <see cref="TypeHelper.ToTuple{T1, T2}(T1, T2)"/> is used instead.
    /// <code>using KeepCoding;
    /// 
    /// public sealed class FooModule : ModuleScript
    /// {
    ///     private void Start()
    ///     {
    ///         Tuple&lt;int, string&gt; tuple = 0.ToTuple("bar");
    ///         
    ///         object o = Extensions.Last(tuple);
    ///         
    ///         Log(o);
    ///     }
    /// }
    /// </code>
    /// This is the output from the console.
    /// <code>[Foo #1] bar
    /// </code>
    /// </example>
    /// <seealso cref="TypeHelper.ToTuple{T1, T2}(T1, T2)"/>
    public abstract class TupleBase : ITuple, IEquatable<TupleBase>
    {
        /// <summary>
        /// Passes an index into the tuple, where items are considered ordered and part of an array.
        /// </summary>
        /// <value>
        /// <see cref="ToArray"/> with the index specified.
        /// </value>
        /// <remarks>
        /// A <see cref="TupleBase"/> will always throw an <see cref="IndexOutOfRangeException"/> regardless if the getter or setter is called as it contains no items to index into. The purpose of this indexer is to provide all derived classes the same <see cref="IndexOutOfRangeException"/> message. As there is type ambiguity between multiple generics, the <see langword="return"/> type has to be <see cref="object"/> as any value is passed into each item.
        /// </remarks>
        /// <example>
        /// The following example illustrates how an <see cref="IndexOutOfRangeException"/> will always be thrown no matter what index is passed in.
        /// </example>
        /// <code>using KeepCoding;
        /// 
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         TupleBase tuple = new TupleBase();
        ///         
        ///         // This uses the getter.
        ///         Try(() => Log(tuple[i]);
        ///         
        ///         // This uses the setter.
        ///         Try(() => tuple[i] = 0);
        ///     }
        ///     
        ///     private void Try(Action act)
        ///     {
        ///         for (int i = int.MinValue; i &lt; int.MaxValue; i++)
        ///         {
        ///             try
        ///             {
        ///                 object o = tuple[i];
        ///                 
        ///                 throw new ArgumentException("This exception will never be thrown because the above operation will always fail!");
        ///             }
        ///             catch (IndexOutOfRangeException)
        ///             {
        ///                 continue;
        ///             }
        ///         }
        ///     }
        /// }
        /// </code>
        /// <seealso cref="ToArray"/>
        /// <param name="index">The index to pass into <see cref="ToArray"/>.</param>
        /// <exception cref="IndexOutOfRangeException">The index parameter is out of range because there are no items in this tuple type.</exception>
        /// <returns><see cref="IndexOutOfRangeException"/>, ignoring the value.</returns>
        public object this[byte index] { get => throw IndexOutOfRange(index); set => throw IndexOutOfRange(index); }

        /// <summary>
        /// undefined
        /// </summary>
        public static bool operator ==(TupleBase left, TupleBase right) => left.Equals(right);

        /// <summary>
        /// undefined
        /// </summary>
        public static bool operator !=(TupleBase left, TupleBase right) => !(left == right);

        /// <summary>
        /// undefined
        /// </summary>
        public bool IsEmpty => Length == 0;

        /// <summary>
        /// undefined
        /// </summary>
        public byte Length => (byte)GetType().GetGenericArguments().Length;

        /// <summary>
        /// undefined
        /// </summary>
        public byte UpperBound => IsEmpty ? throw new InvalidOperationException("The tuple is empty, meaning that the upper bound doesn't exist.") : (byte)(Length - 1);

        /// <summary>
        /// undefined
        /// </summary>
        public abstract object[] ToArray { get; }

        /// <summary>
        /// undefined
        /// </summary>
        public override bool Equals(object obj) => Equals(obj as ITuple);

        /// <summary>
        /// undefined
        /// </summary>
        public bool Equals(ITuple other) => other is null ? this is null : ToArray.SequenceEqual(other.ToArray);

        /// <summary>
        /// undefined
        /// </summary>
        public bool Equals(TupleBase other) => Equals(other as ITuple);

        /// <summary>
        /// undefined
        /// </summary>
        public override int GetHashCode() => 1108013089 + EqualityComparer<object[]>.Default.GetHashCode(ToArray);

        /// <summary>
        /// undefined
        /// </summary>
        public override string ToString() => Join(" ", ToArray.ConvertAll(o => o.ToString()));

        /// <summary>
        /// undefined
        /// </summary>
        public IEnumerator GetEnumerator() => ToArray.GetEnumerator();

        private protected static T Cast<T>(in object value, in int index) => value is T t ? t : throw UnrecognizedType(value, typeof(T), index);

        private IndexOutOfRangeException IndexOutOfRange(in int i) => new IndexOutOfRangeException($"The index {i} was out of range from the tuple of length {ToArray.Length}.");

        private static UnrecognizedTypeException UnrecognizedType<T>(in T received, in Type expected, in int index) => new UnrecognizedTypeException($"The {(index + 1).ToOrdinal()} element in the tuple cannot be assigned because the value {received.UnwrapToString()} is type {received.GetType().Name} which doesn't match the expected type {expected.Name}.");
    }
}
