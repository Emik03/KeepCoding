﻿#if !LITE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KeepCoding.Internal
{
    /// <summary>
    /// Provides the base <see langword="class"/> for the multiple tuple types.
    /// </summary>
    /// <remarks>
    /// <see cref="Tuple"/> provides the general functionality that different types of tuples share in common with. As each different type of tuple gives different amounts of generics, this base <see langword="class"/> is therefore non-generic and provides every method that doesn't require it. This can therefore be used as a way of passing in an ambiguous type of tuple.
    /// </remarks>
    /// <example>
    /// The following example illustrates a method for returning the last item of any tuple that uses <see cref="Tuple"/>.
    /// <code>using KeepCoding.Internal;
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
    public abstract class Tuple : IEnumerable, IEquatable<Tuple>
    {
        /// <summary>
        /// Passes an index into the tuple, where items are considered ordered and part of an array.
        /// </summary>
        /// <value>
        /// <see cref="Items"/> with the index specified.
        /// </value>
        /// <remarks>
        /// A <see cref="Tuple"/> will always throw an <see cref="IndexOutOfRangeException"/> regardless if the getter or setter is called as it contains no items to index into. The purpose of this indexer is to provide all derived classes the same <see cref="IndexOutOfRangeException"/> message. As there is type ambiguity between multiple generics, the <see langword="return"/> type has to be <see cref="object"/> as any value is passed into each item.
        /// </remarks>
        /// <example>
        /// The following example illustrates how an <see cref="IndexOutOfRangeException"/> will always be thrown no matter what index is passed in.
        /// <code>using KeepCoding;
        /// using KeepCoding.Internal;
        /// 
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         TupleBase tuple = new TupleBase();
        ///         
        ///         // This uses the getter.
        ///         Try(b => Log(tuple[b]));
        ///         
        ///         // This uses the setter.
        ///         Try(b => tuple[b] = 0);
        ///     }
        ///     
        ///     private void Try(Action&lt;byte&gt; act)
        ///     {
        ///         for (byte b = byte.MinValue; i &lt; byte.MaxValue; i++)
        ///         {
        ///             try
        ///             {
        ///                 act(b);
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
        /// </example>
        /// <seealso cref="Items"/>
        /// <param name="index">The index to pass into <see cref="Items"/>.</param>
        /// <exception cref="IndexOutOfRangeException">The parameter <paramref name="index"/> is out of range because there are no items in this tuple type.</exception>
        /// <returns><see cref="IndexOutOfRangeException"/>, ignoring <paramref name="index"/>.</returns>
        public object this[byte index] { get => throw IndexOutOfRange(index); set => throw IndexOutOfRange(index); }

        /// <summary>
        /// Determines the amount of items in the tuple type.
        /// </summary>
        /// <value>
        /// The number of generics in the current type.
        /// </value>
        /// <remarks>
        /// The length is the amount of items in the tuple, which can be used to index <see cref="Items"/> or the indexer <see cref="this[byte]"/>.
        /// </remarks>
        /// <example>
        /// The following example illustrates how a method can use the <see cref="Length"/> parameter as a way of determining the tuple item count being odd. <see cref="ArrayHelper.ConvertAll{TInput, TOutput}(TInput[], Converter{TInput, TOutput})"/> is used to convert all tuples to <see cref="bool"/>.
        /// <code>using KeepCoding;
        /// using KeepCoding.Internal;
        /// 
        /// public static class Extensions
        /// {
        ///     public static bool[] IsOdds(params[] TupleBase tuples)
        ///     {
        ///         return tuples.ConvertAll(t => t.Length % 2 == 1);
        ///     }
        /// }
        /// </code>
        /// Next is five variables of all different lengths are now being tested.
        /// <code>using KeepCoding;
        /// 
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         Log(Extensions.IsOdds(0.ToTuple(), // 1 item
        ///             0.ToTuple(0), // 2 items
        ///             0.ToTuple(0, 0), // 3 items
        ///             0.ToTuple(0, 0, 0))); // 4 items
        ///     }
        /// }
        /// </code>
        /// This is the output from the console.
        /// <code>[Foo #1] False, True, False, True, False
        /// </code>
        /// </example>
        /// <seealso cref="this[byte]"/>
        /// <seealso cref="Items"/>
        /// <seealso cref="ArrayHelper.ConvertAll{TInput, TOutput}(TInput[], Converter{TInput, TOutput})"/>
        public byte Length => (byte)GetType().GetGenericArguments().Length;

        /// <summary>
        /// Determines the upperbound of the amount of the length.
        /// </summary>
        /// <value>
        /// <see cref="Length"/> - 1.
        /// </value>
        /// <remarks>
        /// This can be used for indexing <see cref="Items"/> or the indexer <see cref="this[byte]"/>, getting the last item of the tuple. Calling <see cref="UpperBound"/> assumes that there is at least 1 generic in this type.
        /// </remarks>
        /// <example>
        /// The following example illusrates a method that retrieves the last item of the tuple.
        /// <code>using KeepCoding.Internal;
        /// 
        /// public static class Extensions
        /// {
        ///     public static object Last(TupleBase tuple)
        ///     {
        ///         return tuple[tuple.UpperBound];
        ///     }
        /// }
        /// </code>
        /// Now the method will be tested.
        /// <code>using KeepCoding;
        /// 
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         Log(Extensions.Last(0.ToTuple()));
        ///         Log(Extensions.Last(1.ToTuple(2)));
        ///         Log(Extensions.Last(3.ToTuple(4, 5)));
        ///         Log(Extensions.Last(6.ToTuple(7, 8, 9)));
        ///     }
        /// }
        /// </code>
        /// This is the output from the console.
        /// <code>[Foo #1] 0
        /// [Foo #1] 2
        /// [Foo #1] 5
        /// [Foo #1] 9
        /// </code>
        /// </example>
        /// <exception cref="InvalidOperationException">The length is 0, and therefore the upper bound doesn't exist.</exception>
        /// <seealso cref="this[byte]"/>
        /// <seealso cref="Length"/>
        /// <seealso cref="Items"/>
        public byte UpperBound => Length is 0 ? throw new InvalidOperationException("The tuple is empty, meaning that the upper bound doesn't exist.") : (byte)(Length - 1);

        /// <summary>
        /// Converts all items to an array.
        /// </summary>
        /// <value>
        /// All items.
        /// </value>
        /// <remarks>
        /// As the types are not determined, they have to be boxed in <see cref="object"/>.
        /// </remarks>
        /// <example>
        /// The following example illustrates how an entire tuple can be printed using <see cref="Items"/>, since <see cref="Logger.Log{T}(T, object[])"/> can print arrays.
        /// <code>using KeepCoding;
        /// 
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         Log(4.ToTuple(3, 2, 1).ToArray);
        ///     }
        /// }
        /// </code>
        /// This is the output from the console.
        /// <code>[Foo #1] 4, 3, 2, 1
        /// </code>
        /// </example>
        /// <seealso cref="Logger.Log{T}(T, object[])"/>
        public abstract object[] Items { get; }

        /// <summary>
        /// Overrides comparison by checking for individual item equality rather than itself.
        /// </summary>
        /// <remarks>
        /// For more details about comparison, look at <see cref="Equals(Tuple)"/>.
        /// </remarks>
        /// <param name="left">The left-hand side <see cref="Tuple"/> comparison to compare to.</param>
        /// <param name="right">The right-hand side <see cref="Tuple"/> comparison to compare to.</param>
        /// <returns><see langword="true"/> if all items in the tuple equal the other items of the same index.</returns>
        public static bool operator ==(Tuple left, Tuple right) => left.Equals(right);

        /// <summary>
        /// Overrides comparison by checking for individual item equality rather than itself.
        /// </summary>
        /// <remarks>
        /// For more details about comparison, look at <see cref="Equals(Tuple)"/>.
        /// </remarks>
        /// <param name="left">The left-hand side <see cref="Tuple"/> comparison to compare to.</param>
        /// <param name="right">The right-hand side <see cref="Tuple"/> comparison to compare to.</param>
        /// <returns><see langword="true"/> if any item in the tuple does not equal the other item of the same index.</returns>
        public static bool operator !=(Tuple left, Tuple right) => !(left == right);

        /// <summary>
        /// Compares itself and another object attempted to casted as <see cref="Tuple"/> to determine if they contain the same values.
        /// </summary>
        /// <remarks>
        /// For more details about comparison, look at <see cref="Equals(Tuple)"/>.
        /// </remarks>
        /// <param name="obj">The <see cref="object"/> to compare to.</param>
        /// <returns><see langword="true"/> if all items in the tuple equal the other items of the same index.</returns>
        public override bool Equals(object obj) => Equals(obj as Tuple);

        /// <summary>
        /// Compares itself and another <see cref="Tuple"/> to determine if they contain the same values.
        /// </summary>
        /// <remarks>
        /// The comparison is done by taking both of their <see cref="Items"/> values and comparing them with <see cref="Enumerable.SequenceEqual{TSource}(IEnumerable{TSource}, IEnumerable{TSource})"/>. Note that if the tuples are different sizes, this will automatically return <see langword="true"/>. For more information, <see cref="object.Equals(object)"/>.
        /// </remarks>
        /// <example>
        /// The following example illustrates the different ways this method can return true or false.
        /// <code>using KeepCoding;
        /// 
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         Tuple&lt;int&gt; first = 2.ToTuple(),
        ///             second = first,
        ///             third = 2.ToTuple(),
        ///             fourth = 4.ToTuple();
        ///             
        ///         Tuple&lt;int, int&gt; fifth = 2.ToTuple(2);
        ///         
        ///         Log(first.Equals(second));
        ///         Log(first.Equals(third));
        ///         Log(first.Equals(fourth));
        ///         Log(first.Equals(fifth));
        ///     }
        /// }
        /// </code>
        /// This is the output from the console.
        /// <code>[Foo #1] True
        /// [Foo #1] True
        /// [Foo #1] False
        /// [Foo #1] False
        /// </code>
        /// </example>
        /// <param name="other">The <see cref="Tuple"/> to compare itself to.</param>
        /// <returns><see langword="true"/> if both of them have the same items, or are both <see langword="null"/>.</returns>
        public bool Equals(Tuple other) => other is { } && Items.SequenceEqual(other.Items);

        /// <summary>
        /// Gets the hash code of <see cref="Items"/>.
        /// </summary>
        /// <remarks>
        /// Hash codes are a way of quickly asserting equality. It converts all of the given relevant variables into hash codes and combines into a number that makes it unlikely for two different types to have the same hash code. That being said, it is still possible for the hash codes to be identical but not for the same values to have different hash codes, which is why it only should be used as the first step in determining equality and confirming by making the final comparisons to those with equal hash codes. For more information, see <see cref="object.GetHashCode"/>.
        /// </remarks>
        /// <example>
        /// The following example illustrates how two of the same values will result in the same hash code.
        /// <code>using KeepCoding;
        /// 
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         Tuple&lt;int&gt; first = 2.ToTuple(),
        ///             second = 2.ToTuple();
        ///             
        ///         Log(first.GetHashCode() == second.GetHashCode());
        ///     }
        /// }
        /// </code>
        /// This is the output from the console.
        /// <code>[Foo #1] True
        /// </code>
        /// </example>
        /// <seealso cref="Items"/>
        /// <returns>The hash code of this instance.</returns>
        public override int GetHashCode() => 1108013089 + Items.Sum(o => o?.GetHashCode() ?? 0);

        /// <summary>
        /// Joins <see cref="Items"/> to a string, with a space as a delimiter.
        /// </summary>
        /// <remarks>
        /// Each element of <see cref="Items"/> is passed into <see cref="Helper.Stringify{T}(T, StringifyFormat)"/> to unpack iterators and allow each element to be seen. For more details about stringification, refer to <see cref="object.ToString"/>.
        /// </remarks>
        /// <example>
        /// The following example illustrates how a tuple gets converted to a <see cref="string"/>.
        /// <code>using KeepCoding;
        ///
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         Tuple&lt;int, string[], bool&gt; tuple = 0.ToTuple(new[] { "test1", "test2", "test3" }, false);
        ///             
        ///         Log(first.ToString());
        ///     }
        /// }
        /// </code>
        /// This is the output from the console.
        /// <code>[Foo #1] 0, test1, test2, test3, False
        /// </code>
        /// </example>
        /// <seealso cref="Items"/>
        /// <seealso cref="Helper.Stringify{T}(T, StringifyFormat)"/>
        /// <returns><see cref="Items"/> from <see cref="Helper.Stringify{T}(T, StringifyFormat)"/>.</returns>
        public override string ToString() => this.Stringify();

        /// <summary>
        /// Gets the <see cref="IEnumerator"/> of <see cref="Items"/>.
        /// </summary>
        /// <remarks>
        /// This method is needed to implement <see cref="IEnumerator"/> interface. It takes <see cref="Items"/> and performs <see cref="Array.GetEnumerator"/>.
        /// </remarks>
        /// <example>
        /// The following example illustrates how items in <see cref="Items"/> get converted into an <see cref="IEnumerator"/>, and using that <see cref="IEnumerator"/> to print every value.
        /// <code>using System.Collections;
        /// using KeepCoding;
        ///
        /// public sealed class FooModule : ModuleScript
        /// {
        ///     private void Start()
        ///     {
        ///         Tuple&lt;int, string[], bool&gt; tuple = 0.ToTuple(new[] { "test1", "test2", "test3" }, false);
        ///             
        ///         IEnumerator ienumerator = tuple.GetEnumerator();
        ///
        ///         while (ienumerator.MoveNext())
        ///             Log(ienumerator.Current);
        ///     }
        /// }
        /// </code>
        /// This is the output from the console.
        /// <code>[Foo #1] 0
        /// [Foo #1] test1
        /// [Foo #1] test2
        /// [Foo #1] test3
        /// [Foo #1] False
        /// </code>
        /// </example>
        public IEnumerator GetEnumerator() => Items.GetEnumerator();

        private protected static T Cast<T>(in object value, in int index) => value is T t ? t : throw UnrecognizedType(value, typeof(T), index);

        private IndexOutOfRangeException IndexOutOfRange(in int i) => new IndexOutOfRangeException($"The index {i} was out of range from the tuple of length {Items.Length}.");

        private static UnrecognizedTypeException UnrecognizedType<T>(in T received, in Type expected, in int index) => new UnrecognizedTypeException($"The {(index + 1).ToOrdinal()} element in the tuple cannot be assigned because the value {received.Stringify()} is type {received?.GetType().Name ?? "null"} which doesn't match the expected type {expected.Name}.");
    }
}
#endif
