using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KeepCoding
{
    /// <summary>
    /// Stores an arbitrarily large number. Written by Emik.
    /// </summary>
    public sealed class BigInteger : IEnumerable, IEquatable<BigInteger>
    {
        /// <summary>
        /// Creates a big integer containing the number specified.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="value">The value to store. <see cref="Array"/>, <see cref="string"/>, and any number-type are compatible.</param>
        public BigInteger(object value) => _value = ObjectToBytes(in value);

        /// <summary>
        /// Creates a big integer with the default value. (0)
        /// </summary>
        public BigInteger() : this(0) { }

        /// <summary>
        /// Indexable number. Allows you to treat the value as an array.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="index">The <paramref name="index"/>th digit to look from.</param>
        /// <param name="isLeftToRight">Determines if the index goes from left-to-right (<see langword="true"/>), or right-to-left (<see langword="false"/>).</param>
        /// <returns>The current value's <paramref name="index"/>th digit.</returns>
        public int this[int index, bool isLeftToRight = true] { get => _value[isLeftToRight ? index : GetUpperBound - index]; set => _value[isLeftToRight ? index : GetUpperBound - index] = Math.Abs(value) <= 9 ? CastToCurrentNegative(value) : throw new ArgumentOutOfRangeException($"You are assigning a 1-digit number, yet your value {value} is {value.ToString().Replace("-", "").Length} digits long."); }

        /// <value>
        /// Whether or not the number is negative.
        /// </value>
        public bool IsNegative => _value[0] < 0;

        /// <value>
        /// The amount of digits of the value.
        /// </value>
        public int Length => _value.Length;

        /// <value>
        /// The first digit's index.
        /// </value>
        public int GetLowerBound => _value.GetLowerBound(0);

        /// <value>
        /// The last digit's index.
        /// </value>
        public int GetUpperBound => _value.GetUpperBound(0);

        /// <summary>
        /// The number itself. The instance is duplicated so that the original BigInteger's value may not be modified directly.
        /// </summary>
        public sbyte[] Value => _value.ToArray();

        /// <value>
        /// BigInteger with value zero. (Default value)
        /// </value>
        public static BigInteger Zero => new BigInteger(0);

        /// <value>
        /// BigInteger with value one.
        /// </value>
        public static BigInteger One => new BigInteger(1);

        /// <summary>
        /// Equals operator; determines if both integers contain the same value.
        /// </summary>
        /// <param name="bigIntegerA">The left-hand side operator</param>
        /// <param name="bigIntegerB">The right-hand side operator.</param>
        /// <returns>True if both are the same number.</returns>
        public static bool operator ==(BigInteger bigIntegerA, BigInteger bigIntegerB) => bigIntegerA._value.SequenceEqual(bigIntegerB._value);

        /// <summary>
        /// Equals operator; determines if both integers contain the same value. The <see cref="object"/> is casted as a <see cref="BigInteger"/>.
        /// </summary>
        /// <param name="bigInteger">The left-hand side operator</param>
        /// <param name="value">The right-hand side operator.</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if both are the same number.</returns>
        public static bool operator ==(BigInteger bigInteger, object value) => bigInteger._value.SequenceEqual(ObjectToBytes(in value));

        /// <summary>
        /// Equals operator; determines if both integers contain the same value. The <see cref="object"/> is casted as a <see cref="BigInteger"/>.
        /// </summary>
        /// <param name="value">The left-hand side operator.</param>
        /// <param name="bigInteger">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if both are the same number.</returns>
        public static bool operator ==(object value, BigInteger bigInteger) => bigInteger == value;

        /// <summary>
        /// Not equals operator; determines if both integers do not contain the same value.
        /// </summary>
        /// <param name="bigIntegerA">The left-hand side operator</param>
        /// <param name="bigIntegerB">The right-hand side operator.</param>
        /// <returns>True if both are not the same number.</returns>
        public static bool operator !=(BigInteger bigIntegerA, BigInteger bigIntegerB) => !(bigIntegerA == bigIntegerB);

        /// <summary>
        /// Not equals operator; determines if both integers do not contain the same value. The <see cref="object"/> is casted as a <see cref="BigInteger"/>.
        /// </summary>
        /// <param name="bigInteger">The left-hand side operator</param>
        /// <param name="value">The right-hand side operator.</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if both are not the same number.</returns>
        public static bool operator !=(BigInteger bigInteger, object value) => !(bigInteger == value);

        /// <summary>
        /// Not equals operator; determines if both integers do not contain the same value. The <see cref="object"/> is casted as a <see cref="BigInteger"/>.
        /// </summary>
        /// <param name="value">The left-hand side operator</param>
        /// <param name="bigInteger">The right-hand side operator.</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if both are not the same number.</returns>
        public static bool operator !=(object value, BigInteger bigInteger) => !(bigInteger == value);

        /// <summary>
        /// More than operator; determines if left-hand side has a greater value than right-hand side.
        /// </summary>
        /// <param name="bigIntegerA">The left-hand side operator.</param>
        /// <param name="bigIntegerB">The right-hand side operator</param>
        /// <returns>True if <paramref name="bigIntegerA"/> is more than <paramref name="bigIntegerB"/>.</returns>
        public static bool operator >(BigInteger bigIntegerA, BigInteger bigIntegerB) => EqualityTernary(in bigIntegerA, in bigIntegerB) ?? false;

        /// <summary>
        /// More than operator; determines if left-hand side has a greater value than right-hand side.
        /// </summary>
        /// <param name="bigInteger">The left-hand side operator.</param>
        /// <param name="value">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if <paramref name="bigInteger"/> is more than <paramref name="value"/>.</returns>
        public static bool operator >(BigInteger bigInteger, object value) => bigInteger > new BigInteger(value);

        /// <summary>
        /// More than operator; determines if left-hand side has a greater value than right-hand side.
        /// </summary>
        /// <param name="value">The left-hand side operator.</param>
        /// <param name="bigInteger">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if <paramref name="value"/> is more than <paramref name="bigInteger"/>.</returns>
        public static bool operator >(object value, BigInteger bigInteger) => new BigInteger(value) > bigInteger;

        /// <summary>
        /// Less than operator; determines if left-hand side has a lesser value than right-hand side.
        /// </summary>
        /// <param name="bigIntegerA">The left-hand side operator.</param>
        /// <param name="bigIntegerB">The right-hand side operator</param>
        /// <returns>True if <paramref name="bigIntegerA"/> is less than <paramref name="bigIntegerB"/>.</returns>
        public static bool operator <(BigInteger bigIntegerA, BigInteger bigIntegerB) => bigIntegerB > bigIntegerA;

        /// <summary>
        /// Less than operator; determines if left-hand side has a lesser value than right-hand side.
        /// </summary>
        /// <param name="bigInteger">The left-hand side operator.</param>
        /// <param name="value">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if <paramref name="bigInteger"/> is less than <paramref name="value"/>.</returns>
        public static bool operator <(BigInteger bigInteger, object value) => bigInteger < new BigInteger(value);

        /// <summary>
        /// Less than operator; determines if left-hand side has a lesser value than right-hand side.
        /// </summary>
        /// <param name="value">The left-hand side operator.</param>
        /// <param name="bigInteger">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if <paramref name="value"/> is less than <paramref name="bigInteger"/>.</returns>
        public static bool operator <(object value, BigInteger bigInteger) => new BigInteger(value) < bigInteger;

        /// <summary>
        /// More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.
        /// </summary>
        /// <param name="bigIntegerA">The left-hand side operator.</param>
        /// <param name="bigIntegerB">The right-hand side operator</param>
        /// <returns>True if <paramref name="bigIntegerA"/> is more than or equal <paramref name="bigIntegerB"/>.</returns>
        public static bool operator >=(BigInteger bigIntegerA, BigInteger bigIntegerB) => bigIntegerA == bigIntegerB || bigIntegerA > bigIntegerB;

        /// <summary>
        /// More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.
        /// </summary>
        /// <param name="bigInteger">The left-hand side operator.</param>
        /// <param name="value">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if <paramref name="bigInteger"/> is more than or equal <paramref name="value"/>.</returns>
        public static bool operator >=(BigInteger bigInteger, object value) => bigInteger == value || bigInteger > value;

        /// <summary>
        /// More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.
        /// </summary>
        /// <param name="value">The left-hand side operator.</param>
        /// <param name="bigInteger">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if <paramref name="value"/> is more than or equal <paramref name="bigInteger"/>.</returns>
        public static bool operator >=(object value, BigInteger bigInteger) => value == bigInteger || value > bigInteger;

        /// <summary>
        /// Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.
        /// </summary>
        /// <param name="bigIntegerA">The left-hand side operator.</param>
        /// <param name="bigIntegerB">The right-hand side operator</param>
        /// <returns>True if <paramref name="bigIntegerA"/> is less than or equal <paramref name="bigIntegerB"/>.</returns>
        public static bool operator <=(BigInteger bigIntegerA, BigInteger bigIntegerB) => bigIntegerA == bigIntegerB || bigIntegerA < bigIntegerB;

        /// <summary>
        /// Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.
        /// </summary>
        /// <param name="bigInteger">The left-hand side operator.</param>
        /// <param name="value">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if <paramref name="bigInteger"/> is less than or equal <paramref name="value"/>.</returns>
        public static bool operator <=(BigInteger bigInteger, object value) => bigInteger == value || bigInteger < value;

        /// <summary>
        /// Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.
        /// </summary>
        /// <param name="value">The left-hand side operator.</param>
        /// <param name="bigInteger">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if <paramref name="value"/> is less than or equal <paramref name="bigInteger"/>.</returns>
        public static bool operator <=(object value, BigInteger bigInteger) => value == bigInteger || value < bigInteger;

        /// <summary>
        /// Positive operator; returns itself.
        /// </summary>
        /// <param name="bigInteger">The number.</param>
        /// <returns>The number.</returns>
        public static BigInteger operator +(BigInteger bigInteger) => bigInteger;

        /// <summary>
        /// Negative operator; inverts <see cref="IsNegative"/>.
        /// </summary>
        /// <param name="bigInteger">The number.</param>
        /// <returns>The number, inverting <see cref="IsNegative"/>.</returns>
        public static BigInteger operator -(BigInteger bigInteger) => new BigInteger(InvertConditional(bigInteger.Value, true));

        /// <summary>
        /// Addition operator; adds 1.
        /// </summary>
        /// <param name="bigInteger">The number.</param>
        /// <returns>The number + 1.</returns>
        public static BigInteger operator ++(BigInteger bigInteger) => bigInteger += 1;

        /// <summary>
        /// Subtraction operator; subtracts 1.
        /// </summary>
        /// <param name="bigInteger">The number.</param>
        /// <returns>The number - 1.</returns>
        public static BigInteger operator --(BigInteger bigInteger) => bigInteger -= 1;

        /// <summary>
        /// Add operator; gets the sum of 2 numbers.
        /// </summary>
        /// <param name="bigIntegerA">The left-hand side operator.</param>
        /// <param name="bigIntegerB">The right-hand side operator</param>
        /// <returns>The sum of both sides.</returns>
        public static BigInteger operator +(BigInteger bigIntegerA, BigInteger bigIntegerB) => Operate(in bigIntegerA, in bigIntegerB, Operator.Add);

        /// <summary>
        /// Add operator; gets the sum of 2 numbers.
        /// </summary>
        /// <param name="bigInteger">The left-hand side operator.</param>
        /// <param name="value">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>The sum of both sides.</returns>
        public static BigInteger operator +(BigInteger bigInteger, object value) => bigInteger + new BigInteger(value);

        /// <summary>
        /// Addition operator; gets the sum of 2 numbers.
        /// </summary>
        /// <param name="value">The left-hand side operator.</param>
        /// <param name="bigInteger">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>The sum of both sides.</returns>
        public static BigInteger operator +(object value, BigInteger bigInteger) => new BigInteger(value) + bigInteger;

        /// <summary>
        /// Subtraction operator; gets the difference of 2 numbers.
        /// </summary>
        /// <param name="bigIntegerA">The left-hand side operator.</param>
        /// <param name="bigIntegerB">The right-hand side operator</param>
        /// <returns>The difference of both sides.</returns>
        public static BigInteger operator -(BigInteger bigIntegerA, BigInteger bigIntegerB) => Operate(in bigIntegerA, in bigIntegerB, Operator.Subtract);

        /// <summary>
        /// Subtraction operator; gets the difference of 2 numbers.
        /// </summary>
        /// <param name="bigInteger">The left-hand side operator.</param>
        /// <param name="value">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>The difference of both sides.</returns>
        public static BigInteger operator -(BigInteger bigInteger, object value) => bigInteger - new BigInteger(value);

        /// <summary>
        /// Subtraction operator; gets the difference of 2 numbers.
        /// </summary>
        /// <param name="value">The left-hand side operator.</param>
        /// <param name="bigInteger">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>The difference of both sides.</returns>
        public static BigInteger operator -(object value, BigInteger bigInteger) => new BigInteger(value) - bigInteger;

        /// <summary>
        /// Multiplication operator; gets the product of 2 numbers.
        /// </summary>
        /// <param name="bigIntegerA">The left-hand side operator.</param>
        /// <param name="bigIntegerB">The right-hand side operator</param>
        /// <returns>The product of both sides.</returns>
        public static BigInteger operator *(BigInteger bigIntegerA, BigInteger bigIntegerB) => Operate(in bigIntegerA, in bigIntegerB, Operator.Multiply);

        /// <summary>
        /// Multiplication operator; gets the product of 2 numbers.
        /// </summary>
        /// <param name="bigInteger">The left-hand side operator.</param>
        /// <param name="value">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>The product of both sides.</returns>
        public static BigInteger operator *(BigInteger bigInteger, object value) => bigInteger * new BigInteger(value);

        /// <summary>
        /// Multiplication operator; gets the product of 2 numbers.
        /// </summary>
        /// <param name="value">The left-hand side operator.</param>
        /// <param name="bigInteger">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>The product of both sides.</returns>
        public static BigInteger operator *(object value, BigInteger bigInteger) => new BigInteger(value) * bigInteger;

        /// <summary>
        /// Division operator; gets the quotient of 2 numbers.
        /// </summary>
        /// <param name="bigIntegerA">The left-hand side operator.</param>
        /// <param name="bigIntegerB">The right-hand side operator</param>
        /// <returns>The quotient of both sides.</returns>
        public static BigInteger operator /(BigInteger bigIntegerA, BigInteger bigIntegerB) => Operate(in bigIntegerA, in bigIntegerB, Operator.Divide);

        /// <summary>
        /// Division operator; gets the quotient of 2 numbers.
        /// </summary>
        /// <param name="bigInteger">The left-hand side operator.</param>
        /// <param name="value">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>The quotient of both sides.</returns>
        public static BigInteger operator /(BigInteger bigInteger, object value) => bigInteger / new BigInteger(value);

        /// <summary>
        /// Division operator; gets the quotient of 2 numbers.
        /// </summary>
        /// <param name="value">The left-hand side operator.</param>
        /// <param name="bigInteger">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>The quotient of both sides.</returns>
        public static BigInteger operator /(object value, BigInteger bigInteger) => new BigInteger(value) / bigInteger;

        /// <summary>
        /// Modulo operator; gets the modulo of 2 numbers.
        /// </summary>
        /// <param name="bigIntegerA">The left-hand side operator.</param>
        /// <param name="bigIntegerB">The right-hand side operator</param>
        /// <returns>The modulo of both sides.</returns>
        public static BigInteger operator %(BigInteger bigIntegerA, BigInteger bigIntegerB) => Operate(in bigIntegerA, in bigIntegerB, Operator.Modulo);

        /// <summary>
        /// Modulo operator; gets the modulo of 2 numbers.
        /// </summary>
        /// <param name="bigInteger">The left-hand side operator.</param>
        /// <param name="value">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>The modulo of both sides.</returns>
        public static BigInteger operator %(BigInteger bigInteger, object value) => bigInteger % new BigInteger(value);

        /// <summary>
        /// Modulo operator; gets the modulo of 2 numbers.
        /// </summary>
        /// <param name="value">The left-hand side operator.</param>
        /// <param name="bigInteger">The right-hand side operator</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>The modulo of both sides.</returns>
        public static BigInteger operator %(object value, BigInteger bigInteger) => new BigInteger(value) % bigInteger;

        /// <summary>
        /// Converts the <see cref="BigInteger"/> to a <see cref="int"/>.
        /// </summary>
        /// <exception cref="InvalidCastException"></exception>
        /// <param name="bigInteger">The instance of <see cref="BigInteger"/> to convert.</param>
        /// <returns>Itself as <see cref="int"/>.</returns>
        public static explicit operator int(BigInteger bigInteger) => bigInteger.ToInt();

        /// <summary>
        /// Converts the <see cref="int"/> to a <see cref="BigInteger"/>.
        /// </summary>
        /// <param name="value">The value to convert into <see cref="BigInteger"/>.</param>
        /// <returns><see cref="BigInteger"/> with value <paramref name="value"/>.</returns>
        public static implicit operator BigInteger(int value) => new BigInteger(value);

        /// <summary>
        /// Converts the <see cref="BigInteger"/> to a <see cref="long"/>.
        /// </summary>
        /// <exception cref="InvalidCastException"></exception>
        /// <param name="bigInteger">The instance of <see cref="BigInteger"/> to convert.</param>
        /// <returns>Itself as <see cref="long"/>.</returns>
        public static explicit operator long(BigInteger bigInteger) => bigInteger.ToLong();

        /// <summary>
        /// Converts the <see cref="long"/> to a <see cref="BigInteger"/>.
        /// </summary>
        /// <param name="value">The value to convert into <see cref="BigInteger"/>.</param>
        /// <returns><see cref="BigInteger"/> with value <paramref name="value"/>.</returns>
        public static implicit operator BigInteger(long value) => new BigInteger(value);

        /// <summary>
        /// Converts the <see cref="BigInteger"/> to a <see cref="uint"/>.
        /// </summary>
        /// <exception cref="InvalidCastException"></exception>
        /// <param name="bigInteger">The instance of <see cref="BigInteger"/> to convert.</param>
        /// <returns>Itself as <see cref="uint"/>.</returns>
        public static explicit operator uint(BigInteger bigInteger) => bigInteger.ToUInt();

        /// <summary>
        /// Converts the <see cref="uint"/> to a <see cref="BigInteger"/>.
        /// </summary>
        /// <param name="value">The value to convert into <see cref="BigInteger"/>.</param>
        /// <returns><see cref="BigInteger"/> with value <paramref name="value"/>.</returns>
        public static implicit operator BigInteger(uint value) => new BigInteger(value);

        /// <summary>
        /// Converts the <see cref="BigInteger"/> to a <see cref="ulong"/>.
        /// </summary>
        /// <exception cref="InvalidCastException"></exception>
        /// <param name="bigInteger">The instance of <see cref="BigInteger"/> to convert.</param>
        /// <returns>Itself as <see cref="ulong"/>.</returns>
        public static explicit operator ulong(BigInteger bigInteger) => bigInteger.ToULong();

        /// <summary>
        /// Converts the <see cref="ulong"/> to a <see cref="BigInteger"/>.
        /// </summary>
        /// <param name="value">The value to convert into <see cref="BigInteger"/>.</param>
        /// <returns><see cref="BigInteger"/> with value <paramref name="value"/>.</returns>
        public static implicit operator BigInteger(ulong value) => new BigInteger(value);

        /// <summary>
        /// Determins if both values are equal.
        /// </summary>
        /// <param name="obj">The comparison.</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if both values are equal.</returns>
        public override bool Equals(object obj) => Equals(new BigInteger(obj));

        /// <summary>
        /// Gets the hash code of the current values.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            int hashCode = 26699601;
            hashCode = (hashCode * -1521134295) + IsNegative.GetHashCode();
            hashCode = (hashCode * -1521134295) + Length.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<sbyte[]>.Default.GetHashCode(_value);
            return hashCode;
        }

        /// <summary>
        /// Converts the current array it stores as a string.
        /// </summary>
        /// <returns>The value of itself.</returns>
        public override string ToString() => string.Join("", _value.Select((c, i) => c.ToString().Replace(i == 0 ? "--" : "-", "")).ToArray());

        /// <summary>
        /// Determins if both values are equal.
        /// </summary>
        /// <param name="other">The comparison.</param>
        /// <returns>True if both values are equal.</returns>
        public bool Equals(BigInteger other) => other != null && EqualityComparer<sbyte[]>.Default.Equals(_value, other._value);

        /// <summary>
        /// Determines if it is between 2 other <see cref="BigInteger"/> variables. Equality will count as true.
        /// </summary>
        /// <param name="min">The minimum value accepted.</param>
        /// <param name="max">The maximum value accepted.</param>
        /// <returns>True if <paramref name="min"/> is smaller or equal itself and <paramref name="max"/> is greater or equal itself.</returns>
        public bool IsInRange(BigInteger min, BigInteger max) => this >= min && this < max;

        /// <summary>
        /// Determines if it is between 2 other variables. Equality will count as true.
        /// </summary>
        /// <param name="min">The minimum value accepted.</param>
        /// <param name="max">The maximum value accepted.</param>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <returns>True if <paramref name="min"/> is smaller or equal itself and <paramref name="max"/> is greater or equal itself.</returns>
        public bool IsInRange<T>(T min, T max) => this >= min && this < max;

        /// <summary>
        /// Converts the BigInteger to a <see cref="int"/>.
        /// </summary>
        /// <exception cref="InvalidCastException"></exception>
        /// <returns>Itself as <see cref="int"/>.</returns>
        public int ToInt() => IsInRange(int.MinValue, int.MaxValue) ? int.Parse(ToString()) : throw InvalidCast<int>();

        /// <summary>
        /// Converts the BigInteger to a <see cref="long"/>.
        /// </summary>
        /// <exception cref="InvalidCastException"></exception>
        /// <returns>Itself as <see cref="long"/>.</returns>
        public long ToLong() => IsInRange(long.MinValue, long.MaxValue) ? long.Parse(ToString()) : throw InvalidCast<long>();

        /// <summary>
        /// Converts the BigInteger to a <see cref="uint"/>.
        /// </summary>
        /// <exception cref="InvalidCastException"></exception>
        /// <returns>Itself as <see cref="uint"/>.</returns>
        public uint ToUInt() => IsInRange(uint.MinValue, uint.MaxValue) ? uint.Parse(ToString()) : throw InvalidCast<uint>();

        /// <summary>
        /// Converts the BigInteger to a <see cref="ulong"/>.
        /// </summary>
        /// <exception cref="InvalidCastException"></exception>
        /// <returns>Itself as <see cref="ulong"/>.</returns>
        public ulong ToULong() => IsInRange(ulong.MinValue, ulong.MaxValue) ? ulong.Parse(ToString()) : throw InvalidCast<long>();

        /// <summary>
        /// Makes a new instance/deep clone of <see cref="BigInteger"/> with the same value.
        /// </summary>
        /// <returns>A deep clone of itself.</returns>
        public BigInteger Clone() => new BigInteger(_value);

        /// <summary>
        /// Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.
        /// </summary>
        /// <param name="bigInteger">The right-hand side operator.</param>
        /// <returns>Itself mod <paramref name="bigInteger"/>.</returns>
        public BigInteger Modulo(BigInteger bigInteger) => ((this % bigInteger) + bigInteger) % bigInteger;

        /// <summary>
        /// Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.
        /// </summary>
        /// <exception cref="DivideByZeroException"></exception>
        /// <exception cref="NegativeNumberException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="obj">The right-hand side operator.</param>
        /// <returns>Itself mod <paramref name="obj"/>.</returns>
        public BigInteger Modulo<T>(T obj) => ((this % obj) + obj) % obj;

        /// <summary>
        /// Gets the enumerator of the <see cref="BigInteger"/>, using <see cref="Value"/>.
        /// </summary>
        /// <returns>The current number of this <see cref="BigInteger"/>.</returns>
        public IEnumerator GetEnumerator() => Value.GetEnumerator();

        private enum Operator { Add, Subtract, Multiply, Divide, Modulo }

        private static readonly Dictionary<Operator, Func<sbyte[], sbyte[], sbyte[]>> _operations = new Dictionary<Operator, Func<sbyte[], sbyte[], sbyte[]>>()
        {
            { Operator.Add, Addition },
            { Operator.Subtract, Addition },
            { Operator.Multiply, Multiplication },
            { Operator.Divide, Division },
            { Operator.Modulo, Modulation },
        };

        private readonly sbyte[] _value;

        private static readonly sbyte[] _zero = new sbyte[0], _one = new sbyte[] { 1 };

        private static bool IsArrayNegative(in sbyte[] vs) => vs[0] < 0;

        private static bool? EqualityTernary(in BigInteger bigIntegerA, in BigInteger bigIntegerB)
        {
            sbyte[] a = bigIntegerA._value,
                b = bigIntegerB._value;

            if (IsArrayNegative(in a) != IsArrayNegative(in b))
                return IsArrayNegative(in b);

            if (a.Length != b.Length)
                return a.Length > b.Length;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return a[i] > b[i];
            }

            return null;
        }

        private sbyte CastToCurrentNegative(int s) => (sbyte)(s * (s < 0 ^ IsNegative ? -1 : 1));

        private static sbyte[] Addition(sbyte[] left, sbyte[] right)
        {
            bool isNegative = (IsArrayNegative(in left) && IsArrayNegative(in right)) || (IsArrayNegative(in left) && new BigInteger(InvertConditional(in left, IsArrayNegative(in left))) > new BigInteger(right)) || (IsArrayNegative(in right) && new BigInteger(InvertConditional(in right, IsArrayNegative(in right))) > new BigInteger(left));

            left = InvertConditional(left.Reverse(), isNegative);
            right = InvertConditional(right.Reverse(), isNegative);

            var output = new List<sbyte>();

            int carry = 0,
                length = Math.Max(left.Length, right.Length);

            for (int i = 0; i < length; i++)
            {
                int value = left.ElementAtOrDefault(i) + right.ElementAtOrDefault(i);

                output.Add((sbyte)((value + carry) % 10));
                carry = (carry + value) / 10;
            }

            if (carry != 0)
                output = output.Concat(carry.ToString().Select(c => (sbyte)char.GetNumericValue(c))).ToList();

            for (int i = output.Count - 1; i >= 0; i--)
            {
                if (output[i] < 0)
                {
                    output[i] += 10;
                    
                    for (int j = i + 1; j < output.Count; j++)
                    {
                        output[j]--;

                        if (output[j] < 0)
                            output[j] += 10;
                        else
                            break;
                    }
                }
            }

            return InvertConditional(output.ToArray().Reverse(), isNegative);
        }

        private static sbyte[] Division(sbyte[] left, sbyte[] right)
        {
            if (right.SequenceEqual(_zero))
                throw new DivideByZeroException("BigInteger was sent a right-hand operator that evaluated into zero on a division operation.");

            if (left.SequenceEqual(_zero))
                return _zero;

            if (right.SequenceEqual(_one))
                return left;

            if (left.SequenceEqual(right))
                return _one;

            bool isNegative = IsArrayNegative(in left) ^ IsArrayNegative(in right);

            left = InvertConditional(in left, IsArrayNegative(in left));
            right = InvertConditional(in right, IsArrayNegative(in right));

            var output = Enumerable.Repeat((sbyte)0, left.Length).ToList();
            var mutator = new BigInteger(left);

            for (int i = 1; i <= left.Length; i++)
            {
                var comparison = new BigInteger(right) * Math.Pow(10, left.Length - i);

                if (mutator >= comparison)
                {
                    mutator -= comparison;
                    output[--i]++;
                }
            }

            return InvertConditional(output.ToArray(), isNegative);
        }

        private static sbyte[] Modulation(sbyte[] left, sbyte[] right)
        {
            if (right.SequenceEqual(_zero))
                throw new DivideByZeroException("BigInteger was sent a right-hand operator that evaluated into zero on a modulo operation.");

            if (IsArrayNegative(in right))
                throw new NegativeNumberException("BigInteger was sent a right-hand operator that evaluated into the negatives on a modulo operation.");

            if (left.SequenceEqual(_zero) || right.SequenceEqual(_zero) || left.SequenceEqual(right))
                return _zero;

            bool isNegative = IsArrayNegative(in left);

            left = InvertConditional(in left, isNegative);

            var output = Enumerable.Repeat((sbyte)0, left.Length).ToList();
            var mutated = new BigInteger(left);

            for (int i = 1; i <= left.Length; i++)
            {
                var comparison = new BigInteger(right) * Math.Pow(10, left.Length - i);

                if (mutated >= comparison)
                {
                    mutated -= comparison;
                    output[--i]++;
                }
            }

            return InvertConditional(in mutated._value, isNegative);
        }

        private static sbyte[] Multiplication(sbyte[] left, sbyte[] right)
        {
            if (left.SequenceEqual(_zero) || right.SequenceEqual(_zero))
                return _zero;

            if (left.SequenceEqual(_one))
                return right;

            if (right.SequenceEqual(_one))
                return left;

            bool isNegative = IsArrayNegative(in left) ^ IsArrayNegative(in right);

            left = InvertConditional(left.Reverse(), IsArrayNegative(in left));
            right = InvertConditional(right.Reverse(), IsArrayNegative(in right));

            var output = new List<sbyte>[left.Length];

            for (int i = 0; i < left.Length; i++)
            {
                int carry = 0;
                output[i] = Enumerable.Repeat((sbyte)0, i).ToList();

                for (int j = 0; j < right.Length; j++)
                {
                    int value = left.ElementAt(i) * right.ElementAt(j);

                    output[i].Add((sbyte)((value + carry) % 10));
                    carry = (carry + value) / 10;
                }

                if (carry != 0)
                    output[i] = output[i].Concat(carry.ToString().Select(c => (sbyte)c.ToNumber())).ToList();

                output[i] = output[i].Rev();
            }

            for (int i = 0; i < output.Length - 1; i++)
                output[i + 1] = (new BigInteger(output[i]) + new BigInteger(output[i + 1]))._value.ToList();

            return InvertConditional(output.Last().ToArray(), isNegative);
        }

        private static sbyte[] InvertConditional(in sbyte[] vs, bool b) => b ? vs.Select(s => (sbyte)(-1 * s)).ToArray() : vs;

        private static sbyte[] ObjectToBytes<T>(in T obj)
        {
            obj.NullCheck("You cannot construct a BigInteger out of null.");

            if (obj is BigInteger big)
                return big._value.ToArray();

            var values = obj.Unwrap().Select(o => o.ToString());

            if (values.Count() == 1)
                values = values.First().Select(c => c.ToString());

            if (values.First().First() == '-' && values.ElementAtOrDefault(1).FirstOrDefault() != '-')
                values = values.Select((s, i) => "-" + s.Replace("-", "")).Where(s => !s.Replace("-", "").IsNullOrEmpty());

            try
            {
                return values.Select(o => sbyte.Parse(o)).SkipWhile((o, i) => o == 0 && i != values.Count() - 1).ToArray();
            }
            catch (InvalidCastException e)
            {
                throw new ConstructorArgumentException($"Cannot create a big integer because the argument \"{obj.UnwrapToString()}\" supplied with the constructor is bad: {e.Message}");
            }
        }

        private static BigInteger Operate(in BigInteger bigIntegerA, in BigInteger bigIntegerB, Operator op)
            => _operations.ContainsKey(op)
                ? new BigInteger(_operations[op](bigIntegerA._value.ToArray(), InvertConditional(bigIntegerB._value.ToArray(), op == Operator.Subtract)))
                : throw new UnrecognizedValueException($"Unhandled operator: {op}.");

        private InvalidCastException InvalidCast<T>() => new InvalidCastException($"This BigInteger has the value {ToString()} which is outside the range of {typeof(T).Name} and therefore cannot be casted!");
    }
}
