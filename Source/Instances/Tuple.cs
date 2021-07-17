using System;
using System.Collections.Generic;
using System.Linq;

namespace KeepCoding
{
    /// <summary>
    /// A basic tuple data type for C# 4.
    /// </summary>
    public class Tuple<T> : TupleBase
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
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public new object this[byte i]
        {
            get => i == UpperBound ? Item1 : base[i];
            set
            {
                if (i == UpperBound)
                    Item1 = Cast<T>(value, i);
                else
                    base[i] = value;
            }
        }

        /// <summary>
        /// All of the tuple's items as an array, ordered by item number.
        /// </summary>
        public override object[] ToArray => new object[] { Item1 };

        /// <summary>
        /// The first item of the tuple.
        /// </summary>
        public T Item1 { get; set; }

        /// <summary>
        /// Destructs the tuple.
        /// </summary>
        /// <param name="item">The variable to assign the first element of the tuple.</param>
        public void Destruct(out T item) => item = Item1;
    }

    /// <summary>
    /// A basic tuple data type for C# 4. 
    /// </summary>
    public class Tuple<T1, T2> : Tuple<T1>
    {
        /// <summary>
        /// Creates a tuple of size 2.
        /// </summary>
        /// <param name="item1">The item to pass into the first property.</param>
        /// <param name="item2">The item to pass into the second property.</param>
        public Tuple(T1 item1, T2 item2) : base(item1) => Item2 = item2;

        /// <summary>
        /// Creates a singleton tuple of default values.
        /// </summary>
        public Tuple() : this(default, default) { }

        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public new object this[byte i]
        {
            get => i == UpperBound ? Item2 : base[i];
            set
            {
                if (i == UpperBound)
                    Item2 = Cast<T2>(value, i);
                else
                    base[i] = value;
            }
        }

        /// <summary>
        /// All of the tuple's items as an array, ordered by item number.
        /// </summary>
        public override object[] ToArray => new object[] { Item1, Item2 };

        /// <summary>
        /// The second item of the tuple.
        /// </summary>
        public T2 Item2 { get; set; }

        /// <summary>
        /// Destructs the tuple.
        /// </summary>
        /// <param name="item1">The variable to assign the first element of the tuple.</param>
        /// <param name="item2">The variable to assign the second element of the tuple.</param>
        public void Destruct(out T1 item1, out T2 item2)
        {
            Destruct(out item1);
            item2 = Item2;
        }
    }

    /// <summary>
    /// A basic tuple data type for C# 4. 
    /// </summary>
    public class Tuple<T1, T2, T3> : Tuple<T1, T2>
    {
        /// <summary>
        /// Creates a tuple of size 3.
        /// </summary>
        /// <param name="item1">The item to pass into the first property.</param>
        /// <param name="item2">The item to pass into the second property.</param>
        /// <param name="item3">The item to pass into the third property.</param>
        public Tuple(T1 item1, T2 item2, T3 item3) : base(item1, item2) => Item3 = item3;

        /// <summary>
        /// Creates a singleton tuple of default values.
        /// </summary>
        public Tuple() : this(default, default, default) { }

        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public new object this[byte i]
        {
            get => i == UpperBound ? Item3 : base[i];
            set
            {
                if (i == UpperBound)
                    Item3 = Cast<T3>(value, i);
                else
                    base[i] = value;
            }
        }

        /// <summary>
        /// All of the tuple's items as an array, ordered by item number.
        /// </summary>
        public override object[] ToArray => new object[] { Item1, Item2, Item3 };

        /// <summary>
        /// The third item of the tuple.
        /// </summary>
        public T3 Item3 { get; set; }

        /// <summary>
        /// Destructs the tuple.
        /// </summary>
        /// <param name="item1">The variable to assign the first element of the tuple.</param>
        /// <param name="item2">The variable to assign the second element of the tuple.</param>
        /// <param name="item3">The variable to assign the third element of the tuple.</param>
        public void Destruct(out T1 item1, out T2 item2, out T3 item3)
        {
            Destruct(out item1, out item2);
            item3 = Item3;
        }
    }

    /// <summary>
    /// A basic tuple data type for C# 4. 
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
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4) : base(item1, item2, item3) => Item4 = item4;

        /// <summary>
        /// Creates a singleton tuple of default values.
        /// </summary>
        public Tuple() : this(default, default, default, default) { }

        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public new object this[byte i]
        {
            get => i == UpperBound ? Item4 : base[i];
            set
            {
                if (i == UpperBound)
                    Item4 = Cast<T4>(value, i);
                else
                    base[i] = value;
            }
        }

        /// <summary>
        /// All of the tuple's items as an array, ordered by item number.
        /// </summary>
        public override object[] ToArray => new object[] { Item1, Item2, Item3, Item4 };

        /// <summary>
        /// The fourth item of the tuple.
        /// </summary>
        public T4 Item4 { get; set; }

        /// <summary>
        /// Destructs the tuple.
        /// </summary>
        /// <param name="item1">The variable to assign the first element of the tuple.</param>
        /// <param name="item2">The variable to assign the second element of the tuple.</param>
        /// <param name="item3">The variable to assign the third element of the tuple.</param>
        /// <param name="item4">The variable to assign the fourth element of the tuple.</param>
        public void Destruct(out T1 item1, out T2 item2, out T3 item3, out T4 item4)
        {
            Destruct(out item1, out item2, out item3);
            item4 = Item4;
        }
    }
}
