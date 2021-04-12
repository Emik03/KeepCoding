using System;
using System.Collections.Generic;
using System.Linq;

namespace KeepCodingAndNobodyExplodes
{
    /// <summary>
    /// An abstract type meant for the tuple datatype for C# 4. Written by Emik.
    /// </summary>
    public abstract class Tuple
    {
        /// <summary>
        /// Indexable tuple, uses <see cref="ToArray"/> to use the appropriate index.
        /// </summary>
        /// <param name="i">The index to use.</param>
        /// <returns><see cref="ToArray"/>'s <paramref name="i"/>th element.</returns>
        public abstract object this[int i] { get; set; }

        /// <value>
        /// All of the tuple's items as an array, ordered by item number.
        /// </value>
        public abstract object[] ToArray { get; }

        private protected T Cast<T>(object value, int index) => value is T t ? t : throw WrongDatatype(value, typeof(T), index);

        private protected IndexOutOfRangeException IndexOutOfRange(int i) => new IndexOutOfRangeException($"The index {i} was out of range from the tuple of length {ToArray.Length}.");

        private protected WrongDatatypeException WrongDatatype(object received, Type expected, int index) => new WrongDatatypeException($"The {(index + 1).ToOrdinal()} element in the tuple cannot be assigned because the value {received.UnwrapToString()} is type {received.GetType().Name} which doesn't match the expected type {expected.Name}.");
    }

    /// <summary>
    /// A basic tuple datatype for C# 4. Written by Emik.
    /// </summary>
    public class Tuple<T> : Tuple
    {
        /// <summary>
        /// Creates a singleton tuple.
        /// </summary>
        /// <param name="item1">The item to pass into the first property.</param>
        public Tuple(T item1) => Item1 = item1;

        /// <summary>
        /// Creates a singleton tuple of default values.
        /// </summary>
        public Tuple() : this(default) { }

        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="WrongDatatypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public override object this[int i]
        {
            get => i switch
            {
                0 => Item1,
                _ => throw IndexOutOfRange(i)
            };
            set => Item1 = i switch
            {
                0 => Item1 = Cast<T>(value, i),
                _ => throw IndexOutOfRange(i)
            };
        }

        /// <value>
        /// The first item of the tuple.
        /// </value>
        public T Item1 { get; set; }

        /// <value>
        /// All of the tuple's items as an array, ordered by item number.
        /// </value>
        public override object[] ToArray => new object[] { Item1 };

        /// <summary>
        /// Determines whether the tuple is equal.
        /// </summary>
        /// <param name="obj">The <see cref="Tuple{T}"/> as <see cref="object"/>.</param>
        /// <returns>True if itself and the parameter are equal.</returns>
        public override bool Equals(object obj) => Item1.Equals(((Tuple<T>)obj).Item1);

        /// <summary>
        /// Gets the hash code of <see cref="Item1"/>.
        /// </summary>
        /// <returns>The hash code of <see cref="Item1"/>.</returns>
        public override int GetHashCode() => 592959197 + EqualityComparer<T>.Default.GetHashCode(Item1);

        /// <summary>
        /// Gets the item, and returns it as a string.
        /// </summary>
        /// <returns><see cref="Item1"/> as <see cref="string"/>.</returns>
        public override string ToString() => Item1.ToString();

        /// <summary>
        /// Evaluates whether the item in the tuple is the same.
        /// </summary>
        /// <param name="tupleA">The left-hand side comparison.</param>
        /// <param name="tupleB">The right-hand side comparison.</param>
        /// <returns>True if <paramref name="tupleA.Item1"/> and <paramref name="tupleB.Item1"/> are equal.</returns>
        public static bool operator ==(Tuple<T> tupleA, Tuple<T> tupleB) => tupleA == null ? tupleB == null : tupleA.Equals(tupleB);

        /// <summary>
        /// Evaluates whether the item in the tuple is not the same.
        /// </summary>
        /// <param name="tupleA">The left-hand side comparison.</param>
        /// <param name="tupleB">The right-hand side comparison.</param>
        /// <returns>True if <paramref name="tupleA.Item1"/> and <paramref name="tupleB.Item1"/> are not equal.</returns>
        public static bool operator !=(Tuple<T> tupleA, Tuple<T> tupleB) => !(tupleA == tupleB);
    }

    /// <summary>
    /// A basic tuple datatype for C# 4. Written by Emik.
    /// </summary>
    public class Tuple<T1, T2> : Tuple<T1>
    {
        /// <summary>
        /// Creates a tuple of size 2.
        /// </summary>
        /// <param name="item1">The item to pass into the first property.</param>
        /// <param name="item2">The item to pass into the second property.</param>
        public Tuple(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        /// <summary>
        /// Creates a singleton tuple of default values.
        /// </summary>
        public Tuple() : this(default, default) { }

        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="WrongDatatypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public override object this[int i]
        {
            get => i switch
            {
                0 => Item1,
                1 => Item2,
                _ => throw IndexOutOfRange(i)
            };
            set
            {
                switch (i)
                {
                    case 0: Item1 = Cast<T1>(value, i); break;
                    case 1: Item2 = Cast<T2>(value, i); break;
                    default: throw IndexOutOfRange(i);
                }
            }
        }

        /// <value>
        /// The second item of the tuple.
        /// </value>
        public T2 Item2 { get; set; }

        /// <value>
        /// All of the tuple's items as an array, ordered by item number.
        /// </value>
        public override object[] ToArray => new object[] { Item1, Item2 };

        /// <summary>
        /// Determines whether the tuple is equal.
        /// </summary>
        /// <param name="obj">The <see cref="Tuple{T1, T2}"/> as <see cref="object"/>.</param>
        /// <returns>True if itself and the parameter are equal.</returns>
        public override bool Equals(object obj) => ToArray.SequenceEqual(((Tuple<T1, T2>)obj).ToArray);

        /// <summary>
        /// Gets the hash code of all items.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            int hashCode = -1030903623;
            hashCode = (hashCode * -1521134295) + EqualityComparer<T1>.Default.GetHashCode(Item1);
            hashCode = (hashCode * -1521134295) + EqualityComparer<T2>.Default.GetHashCode(Item2);
            return hashCode;
        }

        /// <summary>
        /// Gets all items as an array, and returns it as a string.
        /// </summary>
        /// <returns>All tuples as <see cref="string"/>.</returns>
        public override string ToString() => string.Join(" ", ToArray.ConvertAll(o => o.ToString()));

        /// <summary>
        /// Evaluates whether the item in the tuple is the same.
        /// </summary>
        /// <param name="tupleA">The left-hand side comparison.</param>
        /// <param name="tupleB">The right-hand side comparison.</param>
        /// <returns>True if <paramref name="tupleA.ToArray"/> and all of <paramref name="tupleB.ToArray"/> are equal in sequence.</returns>
        public static bool operator ==(Tuple<T1, T2> tupleA, Tuple<T1, T2> tupleB) => tupleA is null ? tupleB is null : tupleA.Equals(tupleB);

        /// <summary>
        /// Evaluates whether the item in the tuple is not the same.
        /// </summary>
        /// <param name="tupleA">The left-hand side comparison.</param>
        /// <param name="tupleB">The right-hand side comparison.</param>
        /// <returns>True if <paramref name="tupleA.ToArray"/> and all of <paramref name="tupleB.ToArray"/> are not equal in sequence.</returns>
        public static bool operator !=(Tuple<T1, T2> tupleA, Tuple<T1, T2> tupleB) => !(tupleA == tupleB);
    }

    /// <summary>
    /// A basic tuple datatype for C# 4. Written by Emik.
    /// </summary>
    public class Tuple<T1, T2, T3> : Tuple<T1, T2>
    {
        /// <summary>
        /// Creates a tuple of size 3.
        /// </summary>
        /// <param name="item1">The item to pass into the first property.</param>
        /// <param name="item2">The item to pass into the second property.</param>
        /// <param name="item3">The item to pass into the third property.</param>
        public Tuple(T1 item1, T2 item2, T3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }

        /// <summary>
        /// Creates a singleton tuple of default values.
        /// </summary>
        public Tuple() : this(default, default, default) { }

        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="WrongDatatypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public override object this[int i]
        {
            get => i switch
            {
                0 => Item1,
                1 => Item2,
                2 => Item3,
                _ => throw IndexOutOfRange(i)
            };
            set
            {
                switch (i)
                {
                    case 0: Item1 = Cast<T1>(value, i); break;
                    case 1: Item2 = Cast<T2>(value, i); break;
                    case 2: Item3 = Cast<T3>(value, i); break;
                    default: throw IndexOutOfRange(i);
                }
            }
        }

        /// <value>
        /// The third item of the tuple.
        /// </value>
        public T3 Item3 { get; set; }

        /// <value>
        /// All of the tuple's items as an array, ordered by item number.
        /// </value>
        public override object[] ToArray => new object[] { Item1, Item2, Item3 };

        /// <summary>
        /// Determines whether the tuple is equal.
        /// </summary>
        /// <param name="obj">The <see cref="Tuple{T1, T2, T3}"/> as <see cref="object"/>.</param>
        /// <returns>True if itself and the parameter are equal.</returns>
        public override bool Equals(object obj) => ToArray.SequenceEqual(((Tuple<T1, T2, T3>)obj).ToArray);

        /// <summary>
        /// Gets the hash code of all items.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            int hashCode = 341329424;
            hashCode = (hashCode * -1521134295) + EqualityComparer<T1>.Default.GetHashCode(Item1);
            hashCode = (hashCode * -1521134295) + EqualityComparer<T2>.Default.GetHashCode(Item2);
            hashCode = (hashCode * -1521134295) + EqualityComparer<T3>.Default.GetHashCode(Item3);
            return hashCode;
        }

        /// <summary>
        /// Gets all items as an array, and returns it as a string.
        /// </summary>
        /// <returns>All tuples as <see cref="string"/>.</returns>
        public override string ToString() => string.Join(" ", ToArray.ConvertAll(o => o.ToString()));

        /// <summary>
        /// Evaluates whether the item in the tuple is the same.
        /// </summary>
        /// <param name="tupleA">The left-hand side comparison.</param>
        /// <param name="tupleB">The right-hand side comparison.</param>
        /// <returns>True if <paramref name="tupleA.ToArray"/> and all of <paramref name="tupleB.ToArray"/> are equal in sequence.</returns>
        public static bool operator ==(Tuple<T1, T2, T3> tupleA, Tuple<T1, T2, T3> tupleB) => tupleA is null ? tupleB is null : tupleA.Equals(tupleB);

        /// <summary>
        /// Evaluates whether the item in the tuple is not the same.
        /// </summary>
        /// <param name="tupleA">The left-hand side comparison.</param>
        /// <param name="tupleB">The right-hand side comparison.</param>
        /// <returns>True if <paramref name="tupleA.ToArray"/> and all of <paramref name="tupleB.ToArray"/> are not equal in sequence.</returns>
        public static bool operator !=(Tuple<T1, T2, T3> tupleA, Tuple<T1, T2, T3> tupleB) => !(tupleA == tupleB);
    }

    /// <summary>
    /// A basic tuple datatype for C# 4. Written by Emik.
    /// </summary>
    public class Tuple<T1, T2, T3, T4> : Tuple<T1, T2, T3>
    {
        /// <summary>
        /// Creates a tuple of size 4.
        /// </summary>
        /// <param name="item1">The item to pass into the first property.</param>
        /// <param name="item2">The item to pass into the second property.</param>
        /// <param name="item3">The item to pass into the third property.</param>
        /// <param name="item4">The item to pass into the fourth property.</param>
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
        }

        /// <summary>
        /// Creates a singleton tuple of default values.
        /// </summary>
        public Tuple() : this(default, default, default, default) { }

        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="WrongDatatypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public override object this[int i]
        {
            get => i switch
            {
                0 => Item1,
                1 => Item2,
                2 => Item3,
                3 => Item4,
                _ => throw IndexOutOfRange(i)
            };
            set
            {
                switch (i)
                {
                    case 0: Item1 = Cast<T1>(value, i); break;
                    case 1: Item2 = Cast<T2>(value, i); break;
                    case 2: Item3 = Cast<T3>(value, i); break;
                    case 3: Item4 = Cast<T4>(value, i); break;
                    default: throw IndexOutOfRange(i);
                }
            }
        }

        /// <value>
        /// The fourth item of the tuple.
        /// </value>
        public T4 Item4 { get; set; }

        /// <value>
        /// All of the tuple's items as an array, ordered by item number.
        /// </value>
        public override object[] ToArray => new object[] { Item1, Item2, Item3, Item4 };

        /// <summary>
        /// Determines whether the tuple is equal.
        /// </summary>
        /// <param name="obj">The <see cref="Tuple{T1, T2, T3, T4}"/> as <see cref="object"/>.</param>
        /// <returns>True if itself and the parameter are equal.</returns>
        public override bool Equals(object obj) => ToArray.SequenceEqual(((Tuple<T1, T2, T3, T4>)obj).ToArray);

        /// <summary>
        /// Gets the hash code of all items.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            int hashCode = -1041475770;
            hashCode = (hashCode * -1521134295) + EqualityComparer<T1>.Default.GetHashCode(Item1);
            hashCode = (hashCode * -1521134295) + EqualityComparer<T2>.Default.GetHashCode(Item2);
            hashCode = (hashCode * -1521134295) + EqualityComparer<T3>.Default.GetHashCode(Item3);
            hashCode = (hashCode * -1521134295) + EqualityComparer<T4>.Default.GetHashCode(Item4);
            return hashCode;
        }

        /// <summary>
        /// Gets all items as an array, and returns it as a string.
        /// </summary>
        /// <returns>All tuples as <see cref="string"/>.</returns>
        public override string ToString() => string.Join(" ", ToArray.ConvertAll(o => o.ToString()));

        /// <summary>
        /// Evaluates whether the item in the tuple is the same.
        /// </summary>
        /// <param name="tupleA">The left-hand side comparison.</param>
        /// <param name="tupleB">The right-hand side comparison.</param>
        /// <returns>True if <paramref name="tupleA.ToArray"/> and all of <paramref name="tupleB.ToArray"/> are equal in sequence.</returns>
        public static bool operator ==(Tuple<T1, T2, T3, T4> tupleA, Tuple<T1, T2, T3, T4> tupleB) => tupleA is null ? tupleB is null : tupleA.Equals(tupleB);

        /// <summary>
        /// Evaluates whether the item in the tuple is not the same.
        /// </summary>
        /// <param name="tupleA">The left-hand side comparison.</param>
        /// <param name="tupleB">The right-hand side comparison.</param>
        /// <returns>True if <paramref name="tupleA.ToArray"/> and all of <paramref name="tupleB.ToArray"/> are not equal in sequence.</returns>
        public static bool operator !=(Tuple<T1, T2, T3, T4> tupleA, Tuple<T1, T2, T3, T4> tupleB) => !(tupleA == tupleB);
    }
}
