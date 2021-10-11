#if !LITE
using System;
using KeepCoding.Internal;

namespace KeepCoding
{
    /// <summary>
    /// A basic tuple type that encapsulates members as properties.
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
        /// All of the tuple's items as an array, ordered by item number, lowest to highest.
        /// </summary>
        public override object[] Items => new object[] { Item1 };

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
    /// A basic tuple type that encapsulates members as properties.
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
        /// Creates a tuple of size 2 of default values.
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
        /// All of the tuple's items as an array, ordered by item number, lowest to highest.
        /// </summary>
        public override object[] Items => new object[] { Item1, Item2 };

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
    /// A basic tuple type that encapsulates members as properties.
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
        /// Creates a tuple of size 3 of default values.
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
        /// All of the tuple's items as an array, ordered by item number, lowest to highest.
        /// </summary>
        public override object[] Items => new object[] { Item1, Item2, Item3 };

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
    /// A basic tuple type that encapsulates members as properties.
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
        /// Creates a tuple of size 4 of default values.
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
        /// All of the tuple's items as an array, ordered by item number, lowest to highest.
        /// </summary>
        public override object[] Items => new object[] { Item1, Item2, Item3, Item4 };

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

    /// <summary>
    /// A basic tuple type that encapsulates members as properties.
    /// </summary>
    public class Tuple<T1, T2, T3, T4, T5> : Tuple<T1, T2, T3, T4>
    {
        /// <summary>
        /// Creates a tuple of size 5.
        /// </summary>
        /// <param name="item1">The item to pass into the first property.</param>
        /// <param name="item2">The item to pass into the second property.</param>
        /// <param name="item3">The item to pass into the third property.</param>
        /// <param name="item4">The item to pass into the fourth property.</param>
        /// <param name="item5">The item to pass into the fifth property.</param>
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) : base(item1, item2, item3, item4) => Item5 = item5;

        /// <summary>
        /// Creates a tuple of size 5 of default values.
        /// </summary>
        public Tuple() : this(default, default, default, default, default) { }

        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public new object this[byte i]
        {
            get => i == UpperBound ? Item5 : base[i];
            set
            {
                if (i == UpperBound)
                    Item5 = Cast<T5>(value, i);
                else
                    base[i] = value;
            }
        }

        /// <summary>
        /// All of the tuple's items as an array, ordered by item number, lowest to highest.
        /// </summary>
        public override object[] Items => new object[] { Item1, Item2, Item3, Item4, Item5 };

        /// <summary>
        /// The fifth item of the tuple.
        /// </summary>
        public T5 Item5 { get; set; }

        /// <summary>
        /// Destructs the tuple.
        /// </summary>
        /// <param name="item1">The variable to assign the first element of the tuple.</param>
        /// <param name="item2">The variable to assign the second element of the tuple.</param>
        /// <param name="item3">The variable to assign the third element of the tuple.</param>
        /// <param name="item4">The variable to assign the fourth element of the tuple.</param>
        /// <param name="item5">The variable to assign the fifth element of the tuple.</param>
        public void Destruct(out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5)
        {
            Destruct(out item1, out item2, out item3, out item4);
            item5 = Item5;
        }
    }

    /// <summary>
    /// A basic tuple type that encapsulates members as properties.
    /// </summary>
    public class Tuple<T1, T2, T3, T4, T5, T6> : Tuple<T1, T2, T3, T4, T5>
    {
        /// <summary>
        /// Creates a tuple of size 6.
        /// </summary>
        /// <param name="item1">The item to pass into the first property.</param>
        /// <param name="item2">The item to pass into the second property.</param>
        /// <param name="item3">The item to pass into the third property.</param>
        /// <param name="item4">The item to pass into the fourth property.</param>
        /// <param name="item5">The item to pass into the fifth property.</param>
        /// <param name="item6">The item to pass into the sixth property.</param>
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) : base(item1, item2, item3, item4, item5) => Item6 = item6;

        /// <summary>
        /// Creates a tuple of size 6 of default values.
        /// </summary>
        public Tuple() : this(default, default, default, default, default, default) { }

        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public new object this[byte i]
        {
            get => i == UpperBound ? Item6 : base[i];
            set
            {
                if (i == UpperBound)
                    Item6 = Cast<T6>(value, i);
                else
                    base[i] = value;
            }
        }

        /// <summary>
        /// All of the tuple's items as an array, ordered by item number, lowest to highest.
        /// </summary>
        public override object[] Items => new object[] { Item1, Item2, Item3, Item4, Item5, Item6 };

        /// <summary>
        /// The sixth item of the tuple.
        /// </summary>
        public T6 Item6 { get; set; }

        /// <summary>
        /// Destructs the tuple.
        /// </summary>
        /// <param name="item1">The variable to assign the first element of the tuple.</param>
        /// <param name="item2">The variable to assign the second element of the tuple.</param>
        /// <param name="item3">The variable to assign the third element of the tuple.</param>
        /// <param name="item4">The variable to assign the fourth element of the tuple.</param>
        /// <param name="item5">The variable to assign the fifth element of the tuple.</param>
        /// <param name="item6">The variable to assign the sixth element of the tuple.</param>
        public void Destruct(out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6)
        {
            Destruct(out item1, out item2, out item3, out item4, out item5);
            item6 = Item6;
        }
    }

    /// <summary>
    /// A basic tuple type that encapsulates members as properties.
    /// </summary>
    public class Tuple<T1, T2, T3, T4, T5, T6, T7> : Tuple<T1, T2, T3, T4, T5, T6>
    {
        /// <summary>
        /// Creates a tuple of size 7.
        /// </summary>
        /// <param name="item1">The item to pass into the first property.</param>
        /// <param name="item2">The item to pass into the second property.</param>
        /// <param name="item3">The item to pass into the third property.</param>
        /// <param name="item4">The item to pass into the fourth property.</param>
        /// <param name="item5">The item to pass into the fifth property.</param>
        /// <param name="item6">The item to pass into the sixth property.</param>
        /// <param name="item7">The item to pass into the seventh property.</param>
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) : base(item1, item2, item3, item4, item5, item6) => Item7 = item7;

        /// <summary>
        /// Creates a tuple of size 7 of default values.
        /// </summary>
        public Tuple() : this(default, default, default, default, default, default, default) { }

        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public new object this[byte i]
        {
            get => i == UpperBound ? Item7 : base[i];
            set
            {
                if (i == UpperBound)
                    Item7 = Cast<T7>(value, i);
                else
                    base[i] = value;
            }
        }

        /// <summary>
        /// All of the tuple's items as an array, ordered by item number, lowest to highest.
        /// </summary>
        public override object[] Items => new object[] { Item1, Item2, Item3, Item4, Item5, Item6, Item7 };

        /// <summary>
        /// The seventh item of the tuple.
        /// </summary>
        public T7 Item7 { get; set; }

        /// <summary>
        /// Destructs the tuple.
        /// </summary>
        /// <param name="item1">The variable to assign the first element of the tuple.</param>
        /// <param name="item2">The variable to assign the second element of the tuple.</param>
        /// <param name="item3">The variable to assign the third element of the tuple.</param>
        /// <param name="item4">The variable to assign the fourth element of the tuple.</param>
        /// <param name="item5">The variable to assign the fifth element of the tuple.</param>
        /// <param name="item6">The variable to assign the sixth element of the tuple.</param>
        /// <param name="item7">The variable to assign the seventh element of the tuple.</param>
        public void Destruct(out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7)
        {
            Destruct(out item1, out item2, out item3, out item4, out item5, out item6);
            item7 = Item7;
        }
    }

    /// <summary>
    /// A basic tuple type that encapsulates members as properties.
    /// </summary>
    public class Tuple<T1, T2, T3, T4, T5, T6, T7, T8> : Tuple<T1, T2, T3, T4, T5, T6, T7>
    {
        /// <summary>
        /// Creates a tuple of size 8.
        /// </summary>
        /// <param name="item1">The item to pass into the first property.</param>
        /// <param name="item2">The item to pass into the second property.</param>
        /// <param name="item3">The item to pass into the third property.</param>
        /// <param name="item4">The item to pass into the fourth property.</param>
        /// <param name="item5">The item to pass into the fifth property.</param>
        /// <param name="item6">The item to pass into the sixth property.</param>
        /// <param name="item7">The item to pass into the seventh property.</param>
        /// <param name="item8">The item to pass into the eighth property.</param>
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8) : base(item1, item2, item3, item4, item5, item6, item7) => Item8 = item8;

        /// <summary>
        /// Creates a tuple of size 8 of default values.
        /// </summary>
        public Tuple() : this(default, default, default, default, default, default, default, default) { }

        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public new object this[byte i]
        {
            get => i == UpperBound ? Item8 : base[i];
            set
            {
                if (i == UpperBound)
                    Item8 = Cast<T8>(value, i);
                else
                    base[i] = value;
            }
        }

        /// <summary>
        /// All of the tuple's items as an array, ordered by item number, lowest to highest.
        /// </summary>
        public override object[] Items => new object[] { Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8 };

        /// <summary>
        /// The eighth item of the tuple.
        /// </summary>
        public T8 Item8 { get; set; }

        /// <summary>
        /// Destructs the tuple.
        /// </summary>
        /// <param name="item1">The variable to assign the first element of the tuple.</param>
        /// <param name="item2">The variable to assign the second element of the tuple.</param>
        /// <param name="item3">The variable to assign the third element of the tuple.</param>
        /// <param name="item4">The variable to assign the fourth element of the tuple.</param>
        /// <param name="item5">The variable to assign the fifth element of the tuple.</param>
        /// <param name="item6">The variable to assign the sixth element of the tuple.</param>
        /// <param name="item7">The variable to assign the seventh element of the tuple.</param>
        /// <param name="item8">The variable to assign the eighth element of the tuple.</param>
        public void Destruct(out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8)
        {
            Destruct(out item1, out item2, out item3, out item4, out item5, out item6, out item7);
            item8 = Item8;
        }
    }

    /// <summary>
    /// A basic tuple type that encapsulates members as properties.
    /// </summary>
    public class Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9> : Tuple<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        /// <summary>
        /// Creates a tuple of size 9.
        /// </summary>
        /// <param name="item1">The item to pass into the first property.</param>
        /// <param name="item2">The item to pass into the second property.</param>
        /// <param name="item3">The item to pass into the third property.</param>
        /// <param name="item4">The item to pass into the fourth property.</param>
        /// <param name="item5">The item to pass into the fifth property.</param>
        /// <param name="item6">The item to pass into the sixth property.</param>
        /// <param name="item7">The item to pass into the seventh property.</param>
        /// <param name="item8">The item to pass into the eighth property.</param>
        /// <param name="item9">The item to pass into the ninth property.</param>
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9) : base(item1, item2, item3, item4, item5, item6, item7, item8) => Item9 = item9;

        /// <summary>
        /// Creates a tuple of size 9 of default values.
        /// </summary>
        public Tuple() : this(default, default, default, default, default, default, default, default, default) { }

        /// <summary>
        /// Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="i">The index to use.</param>
        /// <returns>The item indexed into.</returns>
        public new object this[byte i]
        {
            get => i == UpperBound ? Item9 : base[i];
            set
            {
                if (i == UpperBound)
                    Item9 = Cast<T9>(value, i);
                else
                    base[i] = value;
            }
        }

        /// <summary>
        /// All of the tuple's items as an array, ordered by item number, lowest to highest.
        /// </summary>
        public override object[] Items => new object[] { Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9 };

        /// <summary>
        /// The ninth item of the tuple.
        /// </summary>
        public T9 Item9 { get; set; }

        /// <summary>
        /// Destructs the tuple.
        /// </summary>
        /// <param name="item1">The variable to assign the first element of the tuple.</param>
        /// <param name="item2">The variable to assign the second element of the tuple.</param>
        /// <param name="item3">The variable to assign the third element of the tuple.</param>
        /// <param name="item4">The variable to assign the fourth element of the tuple.</param>
        /// <param name="item5">The variable to assign the fifth element of the tuple.</param>
        /// <param name="item6">The variable to assign the sixth element of the tuple.</param>
        /// <param name="item7">The variable to assign the seventh element of the tuple.</param>
        /// <param name="item8">The variable to assign the eighth element of the tuple.</param>
        /// <param name="item9">The variable to assign the ninth element of the tuple.</param>
        public void Destruct(out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9)
        {
            Destruct(out item1, out item2, out item3, out item4, out item5, out item6, out item7, out item8);
            item9 = Item9;
        }
    }
}
#endif
