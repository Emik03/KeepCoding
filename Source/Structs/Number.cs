using System;
using System.Globalization;
using KeepCoding.Internal;
using static System.Convert;
using static System.Globalization.NumberFormatInfo;
using static System.Math;

namespace KeepCoding
{
    /// <summary>
    /// Class meant to encapsulate a primitive numeric value.
    /// </summary>
    public struct Number : IComparable, IFormattable, IComparable<Number>, IEquatable<Number>, IComparable<ValueType>, IEquatable<ValueType>
    {
        /// <summary>
        /// Creates a <see cref="Number"/> with the inner type <see cref="sbyte"/>.
        /// </summary>
        /// <param name="value">The inner value stored.</param>
        public Number(sbyte value) => _value = value;

        /// <summary>
        /// Creates a <see cref="Number"/> with the inner type <see cref="byte"/>.
        /// </summary>
        /// <param name="value">The inner value stored.</param>
        public Number(byte value) => _value = value;

        /// <summary>
        /// Creates a <see cref="Number"/> with the inner type <see cref="short"/>.
        /// </summary>
        /// <param name="value">The inner value stored.</param>
        public Number(short value) => _value = value;

        /// <summary>
        /// Creates a <see cref="Number"/> with the inner type <see cref="ushort"/>.
        /// </summary>
        /// <param name="value">The inner value stored.</param>
        public Number(ushort value) => _value = value;

        /// <summary>
        /// Creates a <see cref="Number"/> with the inner type <see cref="int"/>.
        /// </summary>
        /// <param name="value">The inner value stored.</param>
        public Number(int value) => _value = value;

        /// <summary>
        /// Creates a <see cref="Number"/> with the inner type <see cref="uint"/>.
        /// </summary>
        /// <param name="value">The inner value stored.</param>
        public Number(uint value) => _value = value;

        /// <summary>
        /// Creates a <see cref="Number"/> with the inner type <see cref="long"/>.
        /// </summary>
        /// <param name="value">The inner value stored.</param>
        public Number(long value) => _value = value;

        /// <summary>
        /// Creates a <see cref="Number"/> with the inner type <see cref="ulong"/>.
        /// </summary>
        /// <param name="value">The inner value stored.</param>
        public Number(ulong value) => _value = value;

        /// <summary>
        /// Creates a <see cref="Number"/> with the inner type <see cref="float"/>.
        /// </summary>
        /// <param name="value">The inner value stored.</param>
        public Number(float value) => _value = value;

        /// <summary>
        /// Creates a <see cref="Number"/> with the inner type <see cref="double"/>.
        /// </summary>
        /// <param name="value">The inner value stored.</param>
        public Number(double value) => _value = value;

        /// <summary>
        /// Creates a <see cref="Number"/> with the inner type <see cref="decimal"/>.
        /// </summary>
        /// <param name="value">The inner value stored.</param>
        public Number(decimal value) => _value = value;

        /// <summary>
        /// Returns the epsilon constant with precision based on the current type of the value.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is either <see cref="float"/>, <see cref="double"/>, or <see cref="decimal"/>. An exception is thrown otherwise.
        /// </remarks>
        public Number Epsilon => Do<Number>(
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            _ => float.Epsilon,
            _ => double.Epsilon,
            _ => (decimal)double.Epsilon);

        /// <summary>
        /// Returns the biggest value of the current type of the value.
        /// </summary>
        public Number MaxValue => Do<Number>(
            _ => sbyte.MaxValue,
            _ => byte.MaxValue,
            _ => short.MaxValue,
            _ => ushort.MaxValue,
            _ => int.MaxValue,
            _ => uint.MaxValue,
            _ => long.MaxValue,
            _ => ulong.MaxValue,
            _ => float.MaxValue,
            _ => double.MaxValue,
            _ => decimal.MaxValue);

        /// <summary>
        /// Returns the smallest value of the current type of the value.
        /// </summary>
        public Number MinValue => Do<Number>(
            _ => sbyte.MinValue,
            _ => byte.MinValue,
            _ => short.MinValue,
            _ => ushort.MinValue,
            _ => int.MinValue,
            _ => uint.MinValue,
            _ => long.MinValue,
            _ => ulong.MinValue,
            _ => float.MinValue,
            _ => double.MinValue,
            _ => decimal.MinValue);

        /// <summary>
        /// Returns the "not-a-number" constant.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is either <see cref="float"/> or <see cref="double"/>. An exception is thrown otherwise.
        /// </remarks>
        public Number NaN => Do<Number>(
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            _ => float.NaN,
            _ => double.NaN,
            null);

        /// <summary>
        /// Returns the negative infinity constant.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is either <see cref="float"/> or <see cref="double"/>. An exception is thrown otherwise.
        /// </remarks>
        public Number NegativeInfinity => Do<Number>(
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            _ => float.NegativeInfinity,
            _ => double.NegativeInfinity,
            null);

        /// <summary>
        /// Returns the positive infinity constant.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is either <see cref="float"/> or <see cref="double"/>. An exception is thrown otherwise.
        /// </remarks>
        public Number PositiveInfinity => Do<Number>(
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            _ => float.PositiveInfinity,
            _ => double.PositiveInfinity,
            null);

        private readonly ValueType _value;

        /// <summary>
        /// Plus operator.
        /// </summary>
        /// <remarks>
        /// <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/> implicitly converts to <see cref="int"/>.
        /// </remarks>
        /// <param name="number">The number to apply the operator to.</param>
        /// <returns>The number with the operator applied to it.</returns>
        public static Number operator +(Number number) => number.Do<Number>(
            n => +n,
            n => +n,
            n => +n,
            n => +n,
            n => +n,
            n => +n,
            n => +n,
            n => +n,
            n => +n,
            n => +n,
            n => +n);

        /// <summary>
        /// Minus operator.
        /// </summary>
        /// <remarks>
        /// <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/> implicitly converts to <see cref="int"/>. <see cref="uint"/> implicitly converts to <see cref="long"/>. Calling this will assume that the value is not <see cref="ulong"/>. An exception is thrown otherwise.
        /// </remarks>
        /// <param name="number">The number to apply the operator to.</param>
        /// <returns>The number with the operator applied to it.</returns>
        public static Number operator -(Number number) => number.Do<Number>(
            n => -n,
            n => -n,
            n => -n,
            n => -n,
            n => -n,
            n => -n,
            n => -n,
            null,
            n => -n,
            n => -n,
            n => -n);

        /// <summary>
        /// Tilde operator.
        /// </summary>
        /// <remarks>
        /// <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/> implicitly converts to <see cref="int"/>. <see cref="uint"/> implicitly converts to <see cref="long"/>. Calling this will assume that the value is not <see cref="float"/>, <see cref="double"/>, or <see cref="decimal"/>. An exception is thrown otherwise.
        /// </remarks>
        /// <param name="number">The number to apply the operator to.</param>
        /// <returns>The number with the operator applied to it.</returns>
        public static Number operator ~(Number number) => number.Do<Number>(
            n => ~n,
            n => ~n,
            n => ~n,
            n => ~n,
            n => ~n,
            n => ~n,
            n => ~n,
            n => ~n,
            null,
            null,
            null);

        /// <summary>
        /// Increment operator.
        /// </summary>
        /// <param name="number">The number to apply the operator to.</param>
        /// <returns>The number with the operator applied to it.</returns>
        public static Number operator ++(Number number) => number.Do<Number>(
            n => n++,
            n => n++,
            n => n++,
            n => n++,
            n => n++,
            n => n++,
            n => n++,
            n => n++,
            n => n++,
            n => n++,
            n => n++);

        /// <summary>
        /// Decrement operator.
        /// </summary>
        /// <param name="number">The number to apply the operator to.</param>
        /// <returns>The number with the operator applied to it.</returns>
        public static Number operator --(Number number) => number.Do<Number>(
            n => n--,
            n => n--,
            n => n--,
            n => n--,
            n => n--,
            n => n--,
            n => n--,
            n => n--,
            n => n--,
            n => n--,
            n => n--);

        /// <summary>
        /// True operator.
        /// </summary>
        /// <remarks>
        /// True if the number is strictly larger than zero.
        /// </remarks>
        /// <param name="number">The number to apply the operator to.</param>
        /// <returns>The number with the operator applied to it.</returns>
        public static bool operator true(Number number) => (bool)number;

        /// <summary>
        /// False operator.
        /// </summary>
        /// <remarks>
        /// False if the operator is zero or less.
        /// </remarks>
        /// <param name="number">The number to apply the operator to.</param>
        /// <returns>The number with the operator applied to it.</returns>
        public static bool operator false(Number number) => !(bool)number;

        /// <summary>
        /// Add operator.
        /// </summary>
        /// <remarks>
        /// <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/> implicitly converts to <see cref="int"/>.
        /// </remarks>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static Number operator +(Number number, Number other) => number.Do<Number>(other,
            (n, m) => n + m,
            (n, m) => n + m,
            (n, m) => n + m,
            (n, m) => n + m,
            (n, m) => n + m,
            (n, m) => n + m,
            (n, m) => n + m,
            (n, m) => n + m,
            (n, m) => n + m,
            (n, m) => n + m,
            (n, m) => n + m);

        /// <summary>
        /// Subtract operator.
        /// </summary>
        /// <remarks>
        /// <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/> implicitly converts to <see cref="int"/>.
        /// </remarks>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static Number operator -(Number number, Number other) => number.Do<Number>(other,
            (n, m) => n - m,
            (n, m) => n - m,
            (n, m) => n - m,
            (n, m) => n - m,
            (n, m) => n - m,
            (n, m) => n - m,
            (n, m) => n - m,
            (n, m) => n - m,
            (n, m) => n - m,
            (n, m) => n - m,
            (n, m) => n - m);

        /// <summary>
        /// Multiply operator.
        /// </summary>
        /// <remarks>
        /// <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/> implicitly converts to <see cref="int"/>.
        /// </remarks>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static Number operator *(Number number, Number other) => number.Do<Number>(other,
            (n, m) => n * m,
            (n, m) => n * m,
            (n, m) => n * m,
            (n, m) => n * m,
            (n, m) => n * m,
            (n, m) => n * m,
            (n, m) => n * m,
            (n, m) => n * m,
            (n, m) => n * m,
            (n, m) => n * m,
            (n, m) => n * m);

        /// <summary>
        /// Divide operator.
        /// </summary>
        /// <remarks>
        /// <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/> implicitly converts to <see cref="int"/>.
        /// </remarks>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static Number operator /(Number number, Number other) => number.Do<Number>(other,
            (n, m) => n / m,
            (n, m) => n / m,
            (n, m) => n / m,
            (n, m) => n / m,
            (n, m) => n / m,
            (n, m) => n / m,
            (n, m) => n / m,
            (n, m) => n / m,
            (n, m) => n / m,
            (n, m) => n / m,
            (n, m) => n / m);

        /// <summary>
        /// Modulo operator.
        /// </summary>
        /// <remarks>
        /// <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/> implicitly converts to <see cref="int"/>.
        /// </remarks>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static Number operator %(Number number, Number other) => number.Do<Number>(other,
            (n, m) => n % m,
            (n, m) => n % m,
            (n, m) => n % m,
            (n, m) => n % m,
            (n, m) => n % m,
            (n, m) => n % m,
            (n, m) => n % m,
            (n, m) => n % m,
            (n, m) => n % m,
            (n, m) => n % m,
            (n, m) => n % m);

        /// <summary>
        /// And operator.
        /// </summary>
        /// <remarks>
        /// <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/> implicitly converts to <see cref="int"/>. Calling this will assume that the value is not <see cref="float"/>, <see cref="double"/>, or <see cref="decimal"/>. An exception is thrown otherwise.
        /// </remarks>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static Number operator &(Number number, Number other) => number.Do<Number>(other,
            (n, m) => n & m,
            (n, m) => n & m,
            (n, m) => n & m,
            (n, m) => n & m,
            (n, m) => n & m,
            (n, m) => n & m,
            (n, m) => n & m,
            (n, m) => n & m,
            null,
            null,
            null);

        /// <summary>
        /// Or operator.
        /// </summary>
        /// <remarks>
        /// <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/> implicitly converts to <see cref="int"/>. Calling this will assume that the value is not <see cref="float"/>, <see cref="double"/>, or <see cref="decimal"/>. An exception is thrown otherwise.
        /// </remarks>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static Number operator |(Number number, Number other) => number.Do<Number>(other,
            (n, m) => n | m,
            (n, m) => n | m,
            (n, m) => n | m,
            (n, m) => n | m,
            (n, m) => n | m,
            (n, m) => n | m,
            (n, m) => n | m,
            (n, m) => n | m,
            null,
            null,
            null);

        /// <summary>
        /// Xor operator.
        /// </summary>
        /// <remarks>
        /// <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/> implicitly converts to <see cref="int"/>. Calling this will assume that the value is not <see cref="float"/>, <see cref="double"/>, or <see cref="decimal"/>. An exception is thrown otherwise.
        /// </remarks>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static Number operator ^(Number number, Number other) => number.Do<Number>(other,
            (n, m) => n ^ m,
            (n, m) => n ^ m,
            (n, m) => n ^ m,
            (n, m) => n ^ m,
            (n, m) => n ^ m,
            (n, m) => n ^ m,
            (n, m) => n ^ m,
            (n, m) => n ^ m,
            null,
            null,
            null);

        /// <summary>
        /// Left shift operator.
        /// </summary>
        /// <remarks>
        /// <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/> implicitly converts to <see cref="int"/>. Calling this will assume that the value is <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, <see cref="ushort"/>, or <see cref="int"/>. An exception is thrown otherwise.
        /// </remarks>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static Number operator <<(Number number, int other) => number.Do<Number>(other,
            (n, m) => n << m,
            (n, m) => n << m,
            (n, m) => n << m,
            (n, m) => n << m,
            (n, m) => n << m,
            null,
            null,
            null,
            null,
            null,
            null);

        /// <summary>
        /// Right shift operator.
        /// </summary>
        /// <remarks>
        /// <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/> implicitly converts to <see cref="int"/>. Calling this will assume that the value is <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, <see cref="ushort"/>, or <see cref="int"/>. An exception is thrown otherwise.
        /// </remarks>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static Number operator >>(Number number, int other) => number.Do<Number>(other,
            (n, m) => n >> m,
            (n, m) => n >> m,
            (n, m) => n >> m,
            (n, m) => n >> m,
            (n, m) => n >> m,
            null,
            null,
            null,
            null,
            null,
            null);

        /// <summary>
        /// Equals operator.
        /// </summary>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static bool operator ==(Number number, Number other) => number.Equals(other);

        /// <summary>
        /// Equals operator.
        /// </summary>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static bool operator !=(Number number, Number other) => !number.Equals(other);

        /// <summary>
        /// Less than operator.
        /// </summary>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static bool operator <(Number number, Number other) => number.CompareTo(other) < 0;

        /// <summary>
        /// Less than or equal operator.
        /// </summary>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static bool operator <=(Number number, Number other) => number.CompareTo(other) <= 0;

        /// <summary>
        /// More than operator.
        /// </summary>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static bool operator >(Number number, Number other) => number.CompareTo(other) > 0;

        /// <summary>
        /// More than or equal operator.
        /// </summary>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static bool operator >=(Number number, Number other) => number.CompareTo(other) >= 0;

        /// <summary>
        /// Equals operator.
        /// </summary>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static bool operator ==(Number number, ValueType other) => ((ValueType)number).Equals(other);

        /// <summary>
        /// Equals operator.
        /// </summary>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static bool operator !=(Number number, ValueType other) => !((ValueType)number).Equals(other);

        /// <summary>
        /// Less than operator.
        /// </summary>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static bool operator <(Number number, ValueType other) => number.CompareTo(other) < 0;

        /// <summary>
        /// Less than or equal operator.
        /// </summary>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static bool operator <=(Number number, ValueType other) => number.CompareTo(other) <= 0;

        /// <summary>
        /// More than operator.
        /// </summary>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static bool operator >(Number number, ValueType other) => number.CompareTo(other) > 0;

        /// <summary>
        /// More than or equals operator.
        /// </summary>
        /// <param name="number">The left-hand side of the operator.</param>
        /// <param name="other">The right-hand side of the operator.</param>
        /// <returns>A number representing the result of the two numbers applied with the operator.</returns>
        public static bool operator >=(Number number, ValueType other) => number.CompareTo(other) >= 0;

        /// <summary>
        /// Explicitly converts the value to a <see cref="bool"/>.
        /// </summary>
        /// <remarks>
        /// True if the number is strictly larger than zero, otherwise false.
        /// </remarks>
        /// <param name="number">The number to cast.</param>
        public static explicit operator bool(Number number) => number > 0;

        /// <summary>
        /// Implicitly converts the value to a <see cref="sbyte"/>.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is in inclusively between <see cref="sbyte.MinValue"/> and <see cref="sbyte.MaxValue"/>.
        /// </remarks>
        /// <param name="number">The number to cast.</param>
        public static implicit operator sbyte(Number number) => ToSByte(number._value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="byte"/>.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is in inclusively between <see cref="byte.MinValue"/> and <see cref="byte.MaxValue"/>.
        /// </remarks>
        /// <param name="number">The number to cast.</param>
        public static implicit operator byte(Number number) => ToByte(number._value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="short"/>.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is in inclusively between <see cref="short.MinValue"/> and <see cref="short.MaxValue"/>.
        /// </remarks>
        /// <param name="number">The number to cast.</param>
        public static implicit operator short(Number number) => ToInt16(number._value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="ushort"/>.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is in inclusively between <see cref="ushort.MinValue"/> and <see cref="ushort.MaxValue"/>.
        /// </remarks>
        /// <param name="number">The number to cast.</param>
        public static implicit operator ushort(Number number) => ToUInt16(number._value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="int"/>.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is in inclusively between <see cref="int.MinValue"/> and <see cref="int.MaxValue"/>.
        /// </remarks>
        /// <param name="number">The number to cast.</param>
        public static implicit operator int(Number number) => ToInt32(number._value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="uint"/>.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is in inclusively between <see cref="uint.MinValue"/> and <see cref="uint.MaxValue"/>.
        /// </remarks>
        /// <param name="number">The number to cast.</param>
        public static implicit operator uint(Number number) => ToUInt32(number._value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="long"/>.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is in inclusively between <see cref="long.MinValue"/> and <see cref="long.MaxValue"/>.
        /// </remarks>
        /// <param name="number">The number to cast.</param>
        public static implicit operator long(Number number) => ToInt64(number._value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="ulong"/>.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is in inclusively between <see cref="ulong.MinValue"/> and <see cref="ulong.MaxValue"/>.
        /// </remarks>
        /// <param name="number">The number to cast.</param>
        public static implicit operator ulong(Number number) => ToUInt64(number._value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="float"/>.
        /// </summary>
        /// <param name="number">The number to cast.</param>
        public static implicit operator float(Number number) => ToSingle(number._value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="double"/>.
        /// </summary>
        /// <param name="number">The number to cast.</param>
        public static implicit operator double(Number number) => ToDouble(number._value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="decimal"/>.
        /// </summary>
        /// <param name="number">The number to cast.</param>
        public static implicit operator decimal(Number number) => ToDecimal(number._value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="Number"/>.
        /// </summary>
        /// <param name="value">The value to use in the constructor.</param>
        public static implicit operator Number(sbyte value) => new Number(value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="Number"/>.
        /// </summary>
        /// <param name="value">The value to use in the constructor.</param>
        public static implicit operator Number(byte value) => new Number(value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="Number"/>.
        /// </summary>
        /// <param name="value">The value to use in the constructor.</param>
        public static implicit operator Number(short value) => new Number(value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="Number"/>.
        /// </summary>
        /// <param name="value">The value to use in the constructor.</param>
        public static implicit operator Number(ushort value) => new Number(value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="Number"/>.
        /// </summary>
        /// <param name="value">The value to use in the constructor.</param>
        public static implicit operator Number(int value) => new Number(value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="Number"/>.
        /// </summary>
        /// <param name="value">The value to use in the constructor.</param>
        public static implicit operator Number(uint value) => new Number(value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="Number"/>.
        /// </summary>
        /// <param name="value">The value to use in the constructor.</param>
        public static implicit operator Number(long value) => new Number(value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="Number"/>.
        /// </summary>
        /// <param name="value">The value to use in the constructor.</param>
        public static implicit operator Number(ulong value) => new Number(value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="Number"/>.
        /// </summary>
        /// <param name="value">The value to use in the constructor.</param>
        public static implicit operator Number(float value) => new Number(value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="Number"/>.
        /// </summary>
        /// <param name="value">The value to use in the constructor.</param>
        public static implicit operator Number(double value) => new Number(value);

        /// <summary>
        /// Implicitly converts the value to a <see cref="Number"/>.
        /// </summary>
        /// <param name="value">The value to use in the constructor.</param>
        public static implicit operator Number(decimal value) => new Number(value);

        /// <summary>
        /// Determines if both items are equal in value.
        /// </summary>
        /// <param name="obj">The comparison.</param>
        /// <returns>True if both items share the same value.</returns>
        public override bool Equals(object obj) => Do(
            n => n.Equals(obj),
            n => n.Equals(obj),
            n => n.Equals(obj),
            n => n.Equals(obj),
            n => n.Equals(obj),
            n => n.Equals(obj),
            n => n.Equals(obj),
            n => n.Equals(obj),
            n => n.Equals(obj),
            n => n.Equals(obj),
            n => n.Equals(obj));

        /// <summary>
        /// Determines if both items are equal in value.
        /// </summary>
        /// <param name="other">The comparison.</param>
        /// <returns>True if both items share the same value.</returns>
        public bool Equals(Number other) => Equals((object)other._value);

        /// <summary>
        /// Determines if both items are equal in value.
        /// </summary>
        /// <param name="other">The comparison.</param>
        /// <returns>True if both items share the same value.</returns>
        public bool Equals(ValueType other) => Equals((object)other);

        /// <summary>
        /// Determines if the value is not a number.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is either <see cref="float"/> or <see cref="double"/>. An exception is thrown otherwise.
        /// </remarks>
        /// <returns>True if the value is not a number.</returns>
        public bool IsNaN() => Do(
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            n => float.IsNaN(n),
            n => double.IsNaN(n),
            null);

        /// <summary>
        /// Attempts to parse a <see cref="string"/> as <see cref="Number"/>.
        /// </summary>
        /// <remarks>
        /// The smallest possible type is used. The order of types from first-to-last are: <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, <see cref="ushort"/>, <see cref="int"/>, <see cref="uint"/>, <see cref="long"/>, <see cref="ulong"/>, <see cref="float"/>, <see cref="double"/>, <see cref="decimal"/>.
        /// </remarks>
        /// <param name="s">The <see cref="string"/> to parse.</param>
        /// <param name="number">The number to store the result in. An instance is returned if it is able to be casted successfully, and <see langword="null"/> otherwise.</param>
        /// <returns>True if it was able to successfully parse the string as a <see cref="Number"/>.</returns>
        public static bool TryParse(string s, out Number number) => TryParse(s, NumberStyles.Float, CurrentInfo, out number);

        /// <summary>
        /// Attempts to parse a <see cref="string"/> as <see cref="Number"/>.
        /// </summary>
        /// <remarks>
        /// The smallest possible type is used. The order of types from first-to-last are: <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, <see cref="ushort"/>, <see cref="int"/>, <see cref="uint"/>, <see cref="long"/>, <see cref="ulong"/>, <see cref="float"/>, <see cref="double"/>, <see cref="decimal"/>.
        /// </remarks>
        /// <param name="s">The <see cref="string"/> to parse.</param>
        /// <param name="style">The <see cref="NumberStyles"/> used for parsing.</param>
        /// <param name="provider">The <see cref="IFormatProvider"/> used for parsing.</param>
        /// <param name="number">The number to store the result in. An instance is returned if it is able to be casted successfully, and <see langword="null"/> otherwise.</param>
        /// <returns>True if it was able to successfully parse the string as a <see cref="Number"/>.</returns>
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Number number) => TryParse(s, style, GetInstance(provider), out number);

        /// <summary>
        /// Attempts to parse a <see cref="string"/> as <see cref="Number"/>.
        /// </summary>
        /// <remarks>
        /// The smallest possible type is used. The order of types from first-to-last are: <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, <see cref="ushort"/>, <see cref="int"/>, <see cref="uint"/>, <see cref="long"/>, <see cref="ulong"/>, <see cref="float"/>, <see cref="double"/>, <see cref="decimal"/>.
        /// </remarks>
        /// <param name="s">The <see cref="string"/> to parse.</param>
        /// <param name="style">The <see cref="NumberStyles"/> used for parsing.</param>
        /// <param name="info">The <see cref="NumberFormatInfo"/> used for parsing.</param>
        /// <param name="number">The number to store the result in. An instance is returned if it is able to be casted successfully, and <see langword="null"/> otherwise.</param>
        /// <returns>True if it was able to successfully parse the string as a <see cref="Number"/>.</returns>
        public static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out Number number)
        {
            if (EarliestParse(s, style, info) is Number result)
            {
                number = result;
                return true;
            }

            number = default;
            return false;
        }

        /// <summary>
        /// Compares and determines the difference between both items.
        /// </summary>
        /// <param name="obj">The comparison.</param>
        /// <returns>The difference between both items.</returns>
        public int CompareTo(object obj) => Do(
            n => n.CompareTo(obj),
            n => n.CompareTo(obj),
            n => n.CompareTo(obj),
            n => n.CompareTo(obj),
            n => n.CompareTo(obj),
            n => n.CompareTo(obj),
            n => n.CompareTo(obj),
            n => n.CompareTo(obj),
            n => n.CompareTo(obj),
            n => n.CompareTo(obj),
            n => n.CompareTo(obj));

        /// <summary>
        /// Compares and determines the difference between both items.
        /// </summary>
        /// <param name="other">The comparison.</param>
        /// <returns>The difference between both items.</returns>
        public int CompareTo(Number other) => CompareTo((object)other);

        /// <summary>
        /// Compares and determines the difference between both items.
        /// </summary>
        /// <param name="other">The comparison.</param>
        /// <returns>The difference between both items.</returns>
        public int CompareTo(ValueType other) => CompareTo((object)other);

        /// <summary>
        /// Determines the hash code of the item, based on the value.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode() => Do(
            n => n.GetHashCode(),
            n => n.GetHashCode(),
            n => n.GetHashCode(),
            n => n.GetHashCode(),
            n => n.GetHashCode(),
            n => n.GetHashCode(),
            n => n.GetHashCode(),
            n => n.GetHashCode(),
            n => n.GetHashCode(),
            n => n.GetHashCode(),
            n => n.GetHashCode());

        /// <summary>
        /// Converts the value to a <see cref="string"/>.
        /// </summary>
        /// <returns>The value as <see cref="string"/>.</returns>
        public override string ToString() => Do(
            n => n.ToString(),
            n => n.ToString(),
            n => n.ToString(),
            n => n.ToString(),
            n => n.ToString(),
            n => n.ToString(),
            n => n.ToString(),
            n => n.ToString(),
            n => n.ToString(),
            n => n.ToString(),
            n => n.ToString());

        /// <summary>
        /// Converts the value to a <see cref="string"/>.
        /// </summary>
        /// <param name="format">The <see cref="string"/> format of the <see cref="string"/>.</param>
        /// <returns>The value as <see cref="string"/>.</returns>
        public string ToString(string format) => ToString(format, CurrentInfo);

        /// <summary>
        /// Converts the value to a <see cref="string"/>.
        /// </summary>
        /// <param name="provider">The <see cref="IFormatProvider"/> format of the <see cref="string"/>.</param>
        /// <returns>The value as <see cref="string"/>.</returns>
        public string ToString(IFormatProvider provider) => ToString(null, provider);

        /// <summary>
        /// Converts the value to a <see cref="string"/>.
        /// </summary>
        /// <param name="format">The <see cref="string"/> format of the <see cref="string"/>.</param>
        /// <param name="provider">The <see cref="IFormatProvider"/> format of the <see cref="string"/>.</param>
        /// <returns>The value as <see cref="string"/>.</returns>
        public string ToString(string format, IFormatProvider provider) => ToString(format, GetInstance(provider));

        /// <summary>
        /// Converts the value to a <see cref="string"/>.
        /// </summary>
        /// <param name="format">The <see cref="string"/> format of the <see cref="string"/>.</param>
        /// <param name="info">The <see cref="NumberFormatInfo"/> format of the <see cref="string"/>.</param>
        /// <returns>The value as <see cref="string"/>.</returns>
        public string ToString(string format, NumberFormatInfo info) => Do(
            sb => sb.ToString(format, info),
            b => b.ToString(format, info),
            s => s.ToString(format, info),
            us => us.ToString(format, info),
            i => i.ToString(format, info),
            ui => ui.ToString(format, info),
            l => l.ToString(format, info),
            ul => ul.ToString(format, info),
            f => f.ToString(format, info),
            d => d.ToString(format, info),
            de => de.ToString(format, info));

        /// <summary>
        /// Determines the type of value it currently is within the <see cref="TypeCode"/> enum.
        /// </summary>
        /// <returns>The current type.</returns>
        public TypeCode GetTypeCode() => Do(
            _ => TypeCode.SByte,
            _ => TypeCode.Byte,
            _ => TypeCode.Int16,
            _ => TypeCode.UInt16,
            _ => TypeCode.Int32,
            _ => TypeCode.UInt32,
            _ => TypeCode.Int64,
            _ => TypeCode.UInt64,
            _ => TypeCode.Single,
            _ => TypeCode.Double,
            _ => TypeCode.Decimal);

        /// <summary>
        /// Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.
        /// </summary>
        /// <param name="other">The right-hand side operator.</param>
        /// <returns>Itself mod <paramref name="other"/>.</returns>
        public Number Modulo(Number other) => (this % other + other) % other;

        /// <summary>
        /// Creates a new <see cref="Number"/> with the inner type being the type specified.
        /// </summary>
        /// <remarks>
        /// Calling this will assume that the value is <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, and <see cref="ushort"/>, <see cref="int"/>, <see cref="uint"/>, <see cref="long"/>, <see cref="ulong"/>, <see cref="float"/>, <see cref="double"/>, or <see cref="decimal"/>. An exception is thrown outherwise.
        /// </remarks>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <typeparam name="T">The inner type of the <see cref="Number"/>.</typeparam>
        /// <returns>A <see cref="Number"/> with inner <typeparamref name="T"/>.</returns>
        public static Number New<T>(T _ = default) => Type.GetTypeCode(typeof(T)) switch
        {
            TypeCode.SByte => new Number(new sbyte()),
            TypeCode.Byte => new Number(new byte()),
            TypeCode.Int16 => new Number(new short()),
            TypeCode.UInt16 => new Number(new ushort()),
            TypeCode.Int32 => new Number(new int()),
            TypeCode.UInt32 => new Number(new uint()),
            TypeCode.Int64 => new Number(new long()),
            TypeCode.UInt64 => new Number(new ulong()),
            TypeCode.Single => new Number(new float()),
            TypeCode.Double => new Number(new double()),
            TypeCode.Decimal => new Number(new decimal()),
            _ => throw WrongType<T>()
        };

        /// <summary>
        /// Parses a <see cref="string"/> as <see cref="Number"/>. An exception is thrown if it fails.
        /// </summary>
        /// <remarks>
        /// The smallest possible type is used. The order of types from first-to-last are: <see cref="sbyte"/>, <see cref="byte"/>, <see cref="short"/>, <see cref="ushort"/>, <see cref="int"/>, <see cref="uint"/>, <see cref="long"/>, <see cref="ulong"/>, <see cref="float"/>, <see cref="double"/>, <see cref="decimal"/>.
        /// </remarks>
        /// <param name="s">The <see cref="string"/> to parse.</param>
        /// <returns>The <see cref="string"/> as <see cref="Number"/>.</returns>
        public static Number Parse(string s) => Parse(s, NumberStyles.Float, CurrentInfo);

        /// <summary>
        /// Parses a <see cref="string"/> as <see cref="Number"/>. An exception is thrown if it fails.
        /// </summary>
        /// <param name="s">The <see cref="string"/> to parse.</param>
        /// <param name="style">The <see cref="NumberStyles"/> used for parsing.</param>
        /// <returns>The <see cref="string"/> as <see cref="Number"/>.</returns>
        public static Number Parse(string s, NumberStyles style) => Parse(s, style, CurrentInfo);

        /// <summary>
        /// Parses a <see cref="string"/> as <see cref="Number"/>. An exception is thrown if it fails.
        /// </summary>
        /// <param name="s">The <see cref="string"/> to parse.</param>
        /// <param name="provider">The <see cref="IFormatProvider"/> used for parsing.</param>
        /// <returns>The <see cref="string"/> as <see cref="Number"/>.</returns>
        public static Number Parse(string s, IFormatProvider provider) => Parse(s, NumberStyles.Float, GetInstance(provider));

        /// <summary>
        /// Parses a <see cref="string"/> as <see cref="Number"/>. An exception is thrown if it fails.
        /// </summary>
        /// <param name="s">The <see cref="string"/> to parse.</param>
        /// <param name="style">The <see cref="NumberStyles"/> used for parsing.</param>
        /// <param name="provider">The <see cref="IFormatProvider"/> used for parsing.</param>
        /// <returns>The <see cref="string"/> as <see cref="Number"/>.</returns>
        public static Number Parse(string s, NumberStyles style, IFormatProvider provider) => Parse(s, style, GetInstance(provider));

        /// <summary>
        /// Parses a <see cref="string"/> as <see cref="Number"/>. An exception is thrown if it fails.
        /// </summary>
        /// <param name="s">The <see cref="string"/> to parse.</param>
        /// <param name="style">The <see cref="NumberStyles"/> used for parsing.</param>
        /// <param name="info">The <see cref="NumberFormatInfo"/> used for parsing.</param>
        /// <returns>The <see cref="string"/> as <see cref="Number"/>.</returns>
        public static Number Parse(string s, NumberStyles style, NumberFormatInfo info) => EarliestParse(s, style, info) ?? throw WrongFormat(s);

        /// <summary>
        /// Casts the <see cref="Number"/> into the numeric type. Unlike implicit casting, the value will trim the bytes that cannot occupy the new datatype, such as a number being too large or decimals.
        /// </summary>
        /// <returns>Itself as <typeparamref name="T"/>.</returns>
        public T Cast<T>()
        {
            Number number = this;

            return (T)New<T>().Do<object>(
                _ => (sbyte)(number.Trunc() % sbyte.MaxValue),
                _ => (byte)(number.TruncAbs() % byte.MaxValue),
                _ => (short)(number.Trunc() % short.MaxValue),
                _ => (ushort)(number.TruncAbs() % ushort.MaxValue),
                _ => (int)(number.Trunc() % int.MaxValue),
                _ => (uint)(number.TruncAbs() % uint.MaxValue),
                _ => (long)(number.Trunc() % long.MaxValue),
                _ => (ulong)(number.TruncAbs() % ulong.MaxValue),
                _ => (float)number,
                _ => (double)number,
                _ => (decimal)number);
        }

        private static FormatException WrongFormat(in string value) => throw new FormatException($"The value {value} is not formatted correctly.");

        private Number Trunc() => Truncate((double)this);

        private Number TruncAbs() => Abs(Truncate((double)this));

        private static Number? EarliestParse(in string s, in NumberStyles style, in NumberFormatInfo info) => sbyte.TryParse(s, out sbyte sb) ? sb :
                byte.TryParse(s, style, info, out byte b) ? b :
                short.TryParse(s, style, info, out short sh) ? sh :
                ushort.TryParse(s, style, info, out ushort us) ? us :
                int.TryParse(s, style, info, out int i) ? i :
                uint.TryParse(s, style, info, out uint ui) ? ui :
                long.TryParse(s, style, info, out long l) ? l :
                ulong.TryParse(s, style, info, out ulong ul) ? ul :
                float.TryParse(s, style, info, out float f) ? f :
                double.TryParse(s, style, info, out double d) ? d :
                decimal.TryParse(s, style, info, out decimal de) ? (Number?)de : null;

        private static UnrecognizedTypeException WrongType<T>() => throw new UnrecognizedTypeException($"The type {typeof(T)} in this case is not valid.");

        private static UnrecognizedTypeException WrongType<T>(T value) => throw new UnrecognizedTypeException($"The value {value} has the type {typeof(T)} which in this case is not valid.");

        private T Do<T>(in Func<sbyte, T> doSb, in Func<byte, T> doB, in Func<short, T> doS, in Func<ushort, T> doUs, in Func<int, T> doI, in Func<uint, T> doUi, in Func<long, T> doL, in Func<ulong, T> doUl, in Func<float, T> doF, in Func<double, T> doD, in Func<decimal, T> doDe) => _value switch
        {
            sbyte sb => Run(sb, doSb),
            byte b => Run(b, doB),
            short s => Run(s, doS),
            ushort us => Run(us, doUs),
            int i => Run(i, doI),
            uint ui => Run(ui, doUi),
            long l => Run(l, doL),
            ulong ul => Run(ul, doUl),
            float f => Run(f, doF),
            double d => Run(d, doD),
            decimal de => Run(de, doDe),
            _ => throw WrongType(_value)
        };

        private T Do<T>(in Number other, in Func<sbyte, sbyte, T> doSb, in Func<byte, byte, T> doB, in Func<short, short, T> doS, in Func<ushort, ushort, T> doUs, in Func<int, int, T> doI, in Func<uint, uint, T> doUi, in Func<long, long, T> doL, in Func<ulong, ulong, T> doUl, in Func<float, float, T> doF, in Func<double, double, T> doD, in Func<decimal, decimal, T> doDe) => (TypeCode)Max((int)GetTypeCode(), (int)other.GetTypeCode()) switch
        {
            TypeCode.SByte => doSb(this, other),
            TypeCode.Byte => doB(this, other),
            TypeCode.Int16 => doS(this, other),
            TypeCode.UInt16 => doUs(this, other),
            TypeCode.Int32 => doI(this, other),
            TypeCode.UInt32 => doUi(this, other),
            TypeCode.Int64 => doL(this, other),
            TypeCode.UInt64 => doUl(this, other),
            TypeCode.Single => doF(this, other),
            TypeCode.Double => doD(this, other),
            TypeCode.Decimal => doDe(this, other),
            _ => throw WrongType(GetTypeCode() < other.GetTypeCode() ? this : other)
        };

        private static TResult Run<T, TResult>(in T value, in Func<T, TResult> func) => func is { } ? func(value) : throw WrongType(value);
    }
}
