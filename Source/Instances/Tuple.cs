using System;
using System.Collections.Generic;
using System.Linq;

namespace KeepCoding.v151
{
    /// <summary>
    /// A basic tuple data type for C# 4. Written by Emik.
    /// </summary>
    public class Tuple<T> : Tuple, IEquatable<Tuple<T>>
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
        public new object this[byte i]
        {
            get => i == 0 ? Item1 : base[i];
            set
            {
                if (i == 0)
                    Item1 = Cast<T>(in value, i);
                else
                    base[i] = value;
            }
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
        public override bool Equals(object obj) => Equals((Tuple<T>)obj);

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
        public static bool operator ==(Tuple<T> tupleA, Tuple<T> tupleB) => tupleA is null ? tupleB is null : tupleA.Equals(tupleB);

        /// <summary>
        /// Evaluates whether the item in the tuple is not the same.
        /// </summary>
        /// <param name="tupleA">The left-hand side comparison.</param>
        /// <param name="tupleB">The right-hand side comparison.</param>
        /// <returns>True if <paramref name="tupleA.Item1"/> and <paramref name="tupleB.Item1"/> are not equal.</returns>
        public static bool operator !=(Tuple<T> tupleA, Tuple<T> tupleB) => !(tupleA == tupleB);

        /// <summary>
        /// Destructs the tuple.
        /// </summary>
        /// <param name="item">The variable to assign the first element of the tuple.</param>
        public void Destruct(out T item) => item = Item1;

        /// <summary>
        /// Determines whether the tuple is equal.
        /// </summary>
        /// <param name="other">The <see cref="Tuple{T}"/> to compare to.</param>
        /// <returns>True if itself and the parameter are equal.</returns>
        public bool Equals(Tuple<T> other) => Item1.Equals(other.Item1);
    }

    /// <summary>
    /// A basic tuple data type for C# 4. Written by Emik.
    /// </summary>
    public class Tuple<T1, T2> : Tuple<T1>, IEquatable<Tuple<T1, T2>>
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
        public new object this[byte i]
        {
            get => i == 1 ? Item2 : base[i];
            set
            {
                if (i == 1)
                    Item2 = Cast<T2>(in value, i);
                else
                    base[i] = value;
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
        public override bool Equals(object obj) => Equals((Tuple<T1, T2>)obj);

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

        /// <summary>
        /// Destructs the tuple.
        /// </summary>
        /// <param name="item1">The variable to assign the first element of the tuple.</param>
        /// <param name="item2">The variable to assign the second element of the tuple.</param>
        public void Destruct(out T1 item1, out T2 item2) 
        { 
            item1 = Item1;
            item2 = Item2;
        }

        /// <summary>
        /// Determines whether the tuple is equal.
        /// </summary>
        /// <param name="other">The <see cref="Tuple{T1, T2}"/> to compare to.</param>
        /// <returns>True if itself and the parameter are equal.</returns>
        public bool Equals(Tuple<T1, T2> other) => ToArray.SequenceEqual(other.ToArray);
    }

    /// <summary>
    /// A basic tuple data type for C# 4. Written by Emik.
    /// </summary>
    public class Tuple<T1, T2, T3> : Tuple<T1, T2>, IEquatable<Tuple<T1, T2, T3>>
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
        public new object this[byte i]
        {
            get => i == 2 ? Item3 : base[i];
            set
            {
                if (i == 2)
                    Item3 = Cast<T3>(in value, i);
                else
                    base[i] = value;
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
        public override bool Equals(object obj) => Equals((Tuple<T1, T2, T3>)obj);

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

        /// <summary>
        /// Destructs the tuple.
        /// </summary>
        /// <param name="item1">The variable to assign the first element of the tuple.</param>
        /// <param name="item2">The variable to assign the second element of the tuple.</param>
        /// <param name="item3">The variable to assign the third element of the tuple.</param>
        public void Destruct(out T1 item1, out T2 item2, out T3 item3)
        {
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
        }

        /// <summary>
        /// Determines whether the tuple is equal.
        /// </summary>
        /// <param name="other">The <see cref="Tuple{T1, T2, T3}"/> to compare to.</param>
        /// <returns>True if itself and the parameter are equal.</returns>
        public bool Equals(Tuple<T1, T2, T3> other) => ToArray.SequenceEqual(other.ToArray);
    }

    /// <summary>
    /// A basic tuple data type for C# 4. Written by Emik.
    /// </summary>
    public class Tuple<T1, T2, T3, T4> : Tuple<T1, T2, T3>, IEquatable<Tuple<T1, T2, T3, T4>>
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
        public new object this[byte i]
        {
            get => i == 3 ? Item4 : base[i];
            set
            {
                if (i == 3)
                    Item4 = Cast<T4>(in value, i);
                else
                    base[i] = value;
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
        public override bool Equals(object obj) => Equals((Tuple<T1, T2, T3, T4>)obj);

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

        /// <summary>
        /// Destructs the tuple.
        /// </summary>
        /// <param name="item1">The variable to assign the first element of the tuple.</param>
        /// <param name="item2">The variable to assign the second element of the tuple.</param>
        /// <param name="item3">The variable to assign the third element of the tuple.</param>
        /// <param name="item4">The variable to assign the fourth element of the tuple.</param>
        public void Destruct(out T1 item1, out T2 item2, out T3 item3, out T4 item4)
        {
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
        }

        /// <summary>
        /// Determines whether the tuple is equal.
        /// </summary>
        /// <param name="other">The <see cref="Tuple{T1, T2, T3, T4}"/> to compare to.</param>
        /// <returns>True if itself and the parameter are equal.</returns>
        public bool Equals(Tuple<T1, T2, T3, T4> other) => ToArray.SequenceEqual(other.ToArray);
    }
}
