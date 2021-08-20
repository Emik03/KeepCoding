using System;
using System.Linq;
using System.Text;
using static System.Math;

namespace KeepCoding
{
    /// <summary>
    /// Encapsulates an arbitrary-size integer.
    /// </summary>
    /// <remarks>
    /// This struct has been written by Timwi. <see href="https://github.com/Timwi/"/>
    /// </remarks>
    public struct BigInt : IComparable<BigInt>, IEquatable<BigInt>
    {
        // If the number fits into a single Int32, this is the actual value.
        // Otherwise, 0 = positive; -1 = negative.
        private int _sign;

        // If the number fits into a single Int32, this is null.
        private readonly uint[] _values;

        private static readonly int[] s_powersOfTen = { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000 };

        /// <summary>
        /// Constructs a <see cref="BigInt"/> from a 32-bit signed integer.
        /// </summary>
        public BigInt(int value) : this(null, value) { }

        /// <summary>
        /// Constructs a <see cref="BigInt"/> from a 32-bit signed integer.
        /// </summary>
        public BigInt(uint value)
        {
            if (value <= int.MaxValue)
            {
                _values = null;
                _sign = (int)value;
                return;
            }

            _values = new uint[] { value };
            _sign = 0;
        }

        /// <summary>
        /// Constructs a <see cref="BigInt"/> from a 64-bit signed integer.
        /// </summary>
        public BigInt(long value)
        {
            if (value.IsBetween(int.MinValue, int.MaxValue))
            {
                _values = null;
                _sign = (int)value;
                return;
            }

            _values = new uint[] { unchecked((uint)value), unchecked((uint)(value >> 32)) };
            _sign = unchecked((int)(value >> 63));
        }

        /// <summary>
        /// Constructs a <see cref="BigInt"/> from a 64-bit unsigned integer.
        /// </summary>
        public BigInt(ulong value)
        {
            if (value <= int.MaxValue)
            {
                _values = null;
                _sign = (int)value;
                return;
            }

            _values = new uint[] { unchecked((uint)value), (uint)(value >> 32) };
            _sign = 0;
        }

        private BigInt(uint[] value, int sign)
        {
            if (value is null)
                goto defaultCase;

            if (!sign.IsBetween(-1, 0))
                throw new ArgumentException("sign must be 0 (positive) or -1 (negative).", nameof(sign));

            // Check if we can reduce the array to a single value.
            if (value.Length is 0)
            {
                _values = null;
                _sign = 0;
                return;
            }

            if (value.Length is 1 && sign is 0 ^ value[0] >= 0x80000000U)
            {
                _values = null;
                _sign = unchecked((int)value[0]);
                return;
            }

            // Check if we can halve the size of the array.
            int ix = value.Length / 2;

            for (; ix < value.Length; ix++)
                if (value[ix] != unchecked((uint)sign))
                    goto defaultCase;

            ix = value.Length / 2;

            while (ix > 0 && value[ix - 1] == unchecked((uint)sign))
                ix--;

            // Check if we can reduce the array to a single value.
            if (ix <= 1 && sign is 0 ^ value[0] >= 0x80000000U)
            {
                _values = null;
                _sign = unchecked((int)value[0]);
                return;
            }

            // Avoid re-allocating new arrays when they’re already pretty small.
            if (value.Length < 8)
                goto defaultCase;

            _values = new uint[ix];
            Array.Copy(value, 0, _values, 0, ix);
            _sign = sign;
            return;

        defaultCase:
            _values = value;
            _sign = sign;
        }

        /// <summary>
        /// Determines whether the integer is 0.
        /// </summary>
        public bool IsZero => _values is null && _sign is 0;

        /// <summary>
        /// Returns the bit-index of the most significant bit in this number. If the number is positive, this is the index of the most significant ‘1’ bit. If the number is negative, it is the index of the most significant ‘0’ bit. If the number is zero, the result is <c>-1</c>.
        /// </summary>
        public int MostSignificantBit
        {
            get
            {
                uint examine;
                int ix;

                if (_values is null)
                {
                    examine = unchecked((uint)_sign);
                    ix = 0;
                }

                else
                {
                    ix = _values.Length - 1;

                    while (ix > 0 && _values[ix] == _sign)
                        ix--;

                    examine = _values[ix];
                }

                bool signBit = _sign < 0;
                int bitIx = 31;

                while (bitIx >= 0 && !((examine & (1u << bitIx)) is 0) == signBit)
                    bitIx--;

                return bitIx + 32 * ix;
            }
        }

        /// <summary>
        /// Returns the sign of the number: −1 for negative numbers, 0 for zero, and 1 for positive numbers.
        /// </summary>
        public int Sign => _sign < 0 ? -1 : IsZero ? 0 : 1;

        /// <summary>
        /// Returns the absolute value.
        /// </summary>
        public BigInt AbsoluteValue => _sign < 0 ? Negative : this;

        /// <summary>
        /// Returns the bitwise inverse (bitwise NOT).
        /// </summary>
        public BigInt Inverse
        {
            get
            {
                if (_values is null)
                    return new BigInt(null, ~_sign);

                uint[] val = (uint[])_values.Clone();

                for (int i = 0; i < val.Length; i++)
                    val[i] = ~val[i];

                return new BigInt(val, ~_sign);
            }
        }

        /// <summary>
        /// Returns the negative value.
        /// </summary>
        public BigInt Negative
        {
            get
            {
                if (_values is null)
                {
                    long negL = -_sign;
                    int negI = unchecked((int)negL);

                    return negL == negI
                        ? new BigInt(null, negI)
                        : new BigInt(new uint[] { unchecked((uint)negL), (uint)(negL >> 32) }, negL > 0 ? 0 : -1);
                }

                BigInt neg = Add(this, new BigInt(null, -1), subtract: false);

                if (neg._values is null)
                    return new BigInt(null, ~neg._sign);

                for (int i = 0; i < neg._values.Length; i++)
                    neg._values[i] = ~neg._values[i];

                neg._sign = ~neg._sign;

                return neg;
            }
        }

        /// <summary>
        /// Parses a numerical string (consisting only of digits <c>0</c> to <c>9</c>, optionally prepended with a <c>-</c>) into a <see cref="BigInt"/>.
        /// </summary>
        public static BigInt Parse(string str) => TryParse(str, out BigInt result)
                ? result
                : throw new ArgumentException($"Only digits 0–9, optionally prepended with a '-', are allowed in {nameof(BigInt.Parse)}.", nameof(str));

        /// <summary>
        /// Parses a numerical string (consisting only of digits <c>0</c> to <c>9</c>, optionally prepended with a <c>-</c>) into a <see cref="BigInt"/>.
        /// </summary>
        public static bool TryParse(string str, out BigInt value)
        {
            value = new BigInt(0);

            if (!str[0].IsBetween('0', '9') && !(str[0] is '-') ||
                str.Skip(1).Any(ch => !ch.IsBetween('0', '9')))
                return false;

            bool neg = str[0] is '-';
            int ix = neg ? 1 : 0;

            while (str.Length - ix >= 9)
            {
                // This should never happen.
                if (!int.TryParse(str.Substring(ix, 9), out int intVal))
                    return false;

                value = value * 1000000000 + intVal;
                ix += 9;
            }

            if (str.Length == ix)
                return true;

            value = value * s_powersOfTen[str.Length - ix] + int.Parse(str.Substring(ix));

            if (neg)
                value = -value;

            return true;
        }

        /// <summary>
        /// Constructs a <see cref="BigInt"/> from an 8-bit signed integer.
        /// </summary>
        public static implicit operator BigInt(sbyte value) => new BigInt(null, value);

        /// <summary>
        /// Constructs a <see cref="BigInt"/> from an 8-bit unsigned integer.
        /// </summary>
        public static implicit operator BigInt(byte value) => new BigInt(null, value);

        /// <summary>
        /// Constructs a <see cref="BigInt"/> from a 16-bit signed integer.
        /// </summary>
        public static implicit operator BigInt(ushort value) => new BigInt(null, value);

        /// <summary>
        /// Constructs a <see cref="BigInt"/> from a 16-bit unsigned integer.
        /// </summary>
        public static implicit operator BigInt(short value) => new BigInt(null, value);

        /// <summary>
        /// Constructs a <see cref="BigInt"/> from a 32-bit signed integer.
        /// </summary>
        public static implicit operator BigInt(int value) => new BigInt(null, value);

        /// <summary>
        /// Constructs a <see cref="BigInt"/> from a 32-bit unsigned integer.
        /// </summary>
        public static implicit operator BigInt(uint value) => new BigInt(value);

        /// <summary>
        /// Constructs a <see cref="BigInt"/> from a 64-bit signed integer.
        /// </summary>
        public static implicit operator BigInt(long value) => new BigInt(value);

        /// <summary>
        /// Constructs a <see cref="BigInt"/> from a 64-bit unsigned integer.
        /// </summary>
        public static implicit operator BigInt(ulong value) => new BigInt(value);

        /// <summary>
        /// Less-than comparison operator.
        /// </summary>
        public static bool operator <(BigInt one, BigInt two) => one.CompareTo(two) < 0;

        /// <summary>
        /// Greater-than comparison operator.
        /// </summary>
        public static bool operator >(BigInt one, BigInt two) => one.CompareTo(two) > 0;

        /// <summary>
        /// Less-than-or-equal-to comparison operator.
        /// </summary>
        public static bool operator <=(BigInt one, BigInt two) => one.CompareTo(two) <= 0;

        /// <summary>
        /// Greater-than-or-equal-to comparison operator.
        /// </summary>
        public static bool operator >=(BigInt one, BigInt two) => one.CompareTo(two) >= 0;

        /// <summary>
        /// Equality comparison operator.
        /// </summary>
        public static bool operator ==(BigInt one, BigInt two) => one.CompareTo(two) is 0;

        /// <summary>
        /// Inequality comparison operator.
        /// </summary>
        public static bool operator !=(BigInt one, BigInt two) => !(one.CompareTo(two) is 0);

        /// <summary>
        /// Returns the operand.
        /// </summary>
        public static BigInt operator +(BigInt operand) => operand;

        /// <summary>
        /// Returns the negative value.
        /// </summary>
        public static BigInt operator -(BigInt op) => op.Negative;

        /// <summary>
        /// Returns the bitwise inverse (bitwise NOT).
        /// </summary>
        public static BigInt operator ~(BigInt op) => op.Inverse;

        /// <summary>
        /// Increment operator.
        /// </summary>
        public static BigInt operator ++(BigInt operand) => Add(operand, 1, subtract: false);

        /// <summary>
        /// Decrement operator.
        /// </summary>
        public static BigInt operator --(BigInt operand) => Add(operand, 1, subtract: true);

        /// <summary>
        /// Returns the sum of <paramref name="one"/> plus <paramref name="two"/>.
        /// </summary>
        public static BigInt operator +(BigInt one, BigInt two) => Add(one, two, subtract: false);

        /// <summary>
        /// Returns the difference of <paramref name="one"/> minus <paramref name="two"/>.
        /// </summary>
        public static BigInt operator -(BigInt one, BigInt two) => Add(one, two, subtract: true);

        /// <summary>
        /// Returns the product of <paramref name="one"/> times <paramref name="two"/>.
        /// </summary>
        public static BigInt operator *(BigInt one, BigInt two) => Multiply(one, two);

        /// <summary>
        /// Returns the quotient obtained by dividing <paramref name="one"/> by <paramref name="two"/>.
        /// </summary>
        public static BigInt operator /(BigInt one, BigInt two) => DivideModulo(one, two).Quotient;

        /// <summary>
        /// Returns the remainder obtained when dividing <paramref name="one"/> by <paramref name="two"/>.
        /// </summary>
        public static BigInt operator %(BigInt one, BigInt two) => DivideModulo(one, two).Remainder;

        /// <summary>
        /// Bitwise or operator.
        /// </summary>
        public static BigInt operator |(BigInt one, BigInt two)
        {
            uint[] nv, oth;

            if (one._values is null)
            {
                if (two._values is null)
                    return new BigInt(null, one._sign | two._sign);

                if (one._sign < 0)
                    return new BigInt(null, one._sign | unchecked((int)two._values[0]));

                nv = (uint[])two._values.Clone();
                nv[0] |= unchecked((uint)one._sign);

                return new BigInt(nv, two._sign | (one._sign >> 31));
            }
            else if (two._values is null)
            {
                if (two._sign < 0)
                    return new BigInt(null, two._sign | unchecked((int)one._values[0]));

                nv = (uint[])one._values.Clone();
                nv[0] |= unchecked((uint)two._sign);

                return new BigInt(nv, one._sign | (two._sign >> 31));
            }

            BigInt longer, shorter;

            if (one._values.Length > two._values.Length)
            {
                longer = one;
                shorter = two;
            }
            else
            {
                longer = two;
                shorter = one;
            }

            if (shorter._sign < 0)
            {
                nv = (uint[])shorter._values.Clone();
                oth = longer._values;
            }
            else
            {
                nv = (uint[])longer._values.Clone();
                oth = shorter._values;
            }

            for (int i = shorter._values.Length - 1; i >= 0; i--)
                nv[i] |= oth[i];

            return new BigInt(nv, shorter._sign | longer._sign);
        }

        /// <summary>
        /// Bitwise and operator.
        /// </summary>
        public static BigInt operator &(BigInt one, BigInt two)
        {
            uint[] nv, oth;

            if (one._values is null)
            {
                if (two._values is null)
                    return new BigInt(null, one._sign & two._sign);

                if (one._sign >= 0)
                    return new BigInt(null, one._sign & unchecked((int)two._values[0]));

                nv = (uint[])two._values.Clone();
                nv[0] &= unchecked((uint)one._sign);

                return new BigInt(nv, two._sign & (one._sign >> 31));
            }
            else if (two._values is null)
            {
                if (two._sign >= 0)
                    return new BigInt(null, two._sign & unchecked((int)one._values[0]));

                nv = (uint[])one._values.Clone();
                nv[0] &= unchecked((uint)two._sign);

                return new BigInt(nv, one._sign & (two._sign >> 31));
            }

            BigInt longer, shorter;

            if (one._values.Length > two._values.Length)
            {
                longer = one;
                shorter = two;
            }
            else
            {
                longer = two;
                shorter = one;
            }

            if (shorter._sign < 0)
            {
                nv = (uint[])longer._values.Clone();
                oth = shorter._values;
            }
            else
            {
                nv = (uint[])shorter._values.Clone();
                oth = longer._values;
            }

            for (int i = shorter._values.Length - 1; i >= 0; i--)
                nv[i] &= oth[i];

            return new BigInt(nv, shorter._sign & longer._sign);
        }

        /// <summary>
        /// Bitwise xor operator.
        /// </summary>
        public static BigInt operator ^(BigInt one, BigInt two)
        {
            if (one._values is null && two._values is null)
                return new BigInt(null, one._sign ^ two._sign);

            int len = Max(one._values is null ? 1 : one._values.Length, two._values is null ? 1 : two._values.Length),
                sign = (one._sign >> 31) ^ (two._sign >> 31);

            uint[] nv = null;
            uint v;

            for (int i = len - 1; i >= 1; i--)
            {
                v = (one._values is null || i >= one._values.Length ? unchecked((uint)(one._sign >> 31)) : one._values[i])
                  ^ (two._values is null || i >= two._values.Length ? unchecked((uint)(two._sign >> 31)) : two._values[i]);

                if (v != sign)
                {
                    if (nv is null)
                        nv = new uint[i + 1];

                    nv[i] = v;
                }
            }

            v = (one._values is null ? unchecked((uint)one._sign) : one._values[0]) ^ (two._values is null ? unchecked((uint)two._sign) : two._values[0]);

            if (nv is null)
            {
                if (v >> 31 == sign)
                    return new BigInt(null, unchecked((int)v));

                nv = new uint[1];
            }

            nv[0] = v;

            return new BigInt(nv, sign);
        }

        /// <summary>
        /// Returns the result of a bit-shift-right by the specified <paramref name="amount"/>. This is equivalent to dividing by 2 to the power of <paramref name="amount"/> and rounding down.
        /// </summary>
        /// <remarks>
        /// If <paramref name="amount"/> is negative, the number is shifted left instead.
        /// </remarks>
        public static BigInt operator >>(BigInt operand, int amount)
        {
            if (amount is 0)
                return operand;

            if (amount < 0)
                return operand << (-amount);

            if (operand._values is null)
                return new BigInt(null, operand._sign >> Min(31, amount));

            int hb = operand.MostSignificantBit - amount;

            if (hb < 0)
                return new BigInt(null, operand._sign);

            int amount32 = amount >> 5;
            int amountRest = amount & 0x1f;

            uint[] nv;

            if (amountRest is 0)
            {
                nv = new uint[operand._values.Length - amount32];
                Array.Copy(operand._values, amount32, nv, 0, operand._values.Length - amount32);
                return new BigInt(nv, operand._sign);
            }

            int hb32 = hb >> 5;

            nv = new uint[hb32 + 1];

            nv[hb32] = (hb32 + amount32 + 1 >= operand._values.Length)
                ? (operand._values[hb32 + amount32] >> amountRest)
                : (operand._values[hb32 + amount32] >> amountRest) | (operand._values[hb32 + amount32 + 1] << (32 - amountRest));

            for (int i = hb32 - 1; i >= 0; i--)
                nv[i] = (operand._values[i + amount32] >> amountRest) | (operand._values[i + amount32 + 1] << (32 - amountRest));

            return new BigInt(nv, operand._sign);
        }

        /// <summary>
        /// Returns the result of a bit-shift-left by the specified <paramref name="amount"/>. This is equivalent to multiply by 2 to the power of <paramref name="amount"/>.
        /// </summary>
        /// <remarks>
        /// If <paramref name="amount"/> is negative, the number is shifted right instead.
        /// </remarks>
        public static BigInt operator <<(BigInt operand, int amount)
        {
            if (amount is 0 || operand._values is null && (operand._sign is 0 || operand._sign is -1))
                return operand;

            if (amount < 0)
                return operand >> (-amount);

            if (operand._values is null && amount < 32)
            {
                int shI = operand._sign << amount;

                if (((long)operand._sign) << amount == shI)
                    return new BigInt(null, shI);
            }

            int hb = operand.MostSignificantBit + amount;

            uint[] nv = new uint[(hb >> 5) + 1];

            int amount32 = amount >> 5,
                amountRest = amount & 0x1f;

            if (amountRest is 0)
            {
                if (operand._values is null)
                    nv[amount32] = unchecked((uint)operand._sign);

                else
                    for (int j = Math.Min(operand._values.Length - 1, nv.Length - amount32 - 1); j >= 0; j--)
                        nv[j + amount32] = operand._values[j];

                return new BigInt(nv, operand._sign >> 31);
            }

            uint last;

            if (operand._values is null)
            {
                nv[amount32] = unchecked((uint)operand._sign << amountRest);

                last = unchecked((uint)operand._sign >> (32 - amountRest));

                if (!(last is 0))
                    nv[amount32 + 1] = last;

                return new BigInt(nv, operand._sign >> 31);
            }

            nv[amount32] = operand._values[0] << amountRest;

            int i = 1;

            for (; i < operand._values.Length; i++)
                nv[i + amount32] = (operand._values[i] << amountRest) | (operand._values[i - 1] >> (32 - amountRest));

            last = operand._values[i - 1] >> (32 - amountRest);

            if (!(last is 0))
                nv[i + amount32] = last;
            return new BigInt(nv, operand._sign);
        }

        /// <summary>
        /// Equality comparison.
        /// </summary>
        public override bool Equals(object obj) => obj is BigInt bi && CompareTo(bi) is 0;

        /// <summary>
        /// Equality comparison.
        /// </summary>
        public bool Equals(BigInt other) => CompareTo(other) is 0;

        /// <summary>
        /// Returns whether the bit at <paramref name="index"/> is 1 (regardless of the integer’s sign).
        /// </summary>
        public bool GetBit(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index), "index cannot be negative.");

            if (_values is null)
                return index >= 31 ? (_sign < 0) : !((_sign & (1 << index)) is 0);

            // = index / 32 (optimized)
            int pos = index >> 5;

            return pos >= _values.Length ? (_sign < 0) : !((_values[pos] & (1 << (index & 0x1f))) is 0);
        }

        /// <summary>
        /// Compares this integer to <paramref name="other"/>.
        /// </summary>
        public int CompareTo(BigInt other)
        {
            if (_sign != other._sign)
                return _sign < other._sign ? -1 : 1;

            if (_values is null && other._values is null)
                return _sign.CompareTo(other._sign);

            for (int i = Max(_values is null ? 0 : _values.Length - 1, other._values is null ? 0 : other._values.Length - 1); i >= 1; i--)
            {
                uint v1 = _values is null || i >= _values.Length ? 0u : _values[i],
                    v2 = other._values is null || i >= other._values.Length ? 0u : other._values[i];

                if (v1 != v2)
                    return v1 < v2 ? -1 : 1;
            }

            uint vv1 = _values is null ? unchecked((uint)_sign) : _values[0],
                vv2 = other._values is null ? unchecked((uint)other._sign) : other._values[0];

            return vv1.CompareTo(vv2);
        }

        /// <summary>
        /// Hash code function.
        /// </summary>
        public override int GetHashCode() => _values is null ? _sign : unchecked((int)_values[0] + MostSignificantBit);

        /// <summary>
        /// Override; see base.
        /// </summary>
        public override string ToString()
        {
            if (IsZero)
                return "0";

            var sb = new StringBuilder();
            BigInt val = _sign < 0 ? -this : this;

            while (!val.IsZero)
            {
                QuotientRemainder qr = val.DivideModulo(1000000000);

                if (qr.Remainder._values is { })
                    throw new InvalidOperationException($"An internal error occurred in {nameof(ToString)}.");

                string str = qr.Remainder._sign.ToString();

                sb.Insert(0, str);

                val = qr.Quotient;

                if (!val.IsZero && str.Length < 9)
                    sb.Insert(0, new string('0', 9 - str.Length));
            }

            if (_sign < 0)
                sb.Insert(0, "-");

            return sb.ToString();
        }

        /// <summary>
        /// Returns the sum of this integer plus <paramref name="other"/>.
        /// </summary>
        public BigInt Add(BigInt other) => Add(this, other, subtract: false);

        /// <summary>
        /// Returns the quotient obtained by dividing this integer by <paramref name="other"/>.
        /// </summary>
        public BigInt Divide(BigInt other) => DivideModulo(this, other).Quotient;

        /// <summary>
        /// Returns the remainder obtained when dividing this integer by <paramref name="other"/>.
        /// </summary>
        public BigInt Modulo(BigInt other) => DivideModulo(this, other).Remainder;

        /// <summary>
        /// Returns the product of this integer times <paramref name="other"/>.
        /// </summary>
        public BigInt Multiply(BigInt other) => Multiply(this, other);

        /// <summary>
        /// Calculates a quotient and remainder by dividing this integer by <paramref name="other"/>.
        /// </summary>
        public QuotientRemainder DivideModulo(BigInt other) => DivideModulo(this, other);

        private static BigInt Add(BigInt one, BigInt two, bool subtract)
        {
            if (one._values is null && two._values is null)
            {
                long sumL = subtract ? (long)one._sign - two._sign : (long)one._sign + two._sign;
                int sumI = unchecked((int)sumL);

                return sumL == sumI
                    ? new BigInt(null, sumI)
                    : new BigInt(new[] { unchecked((uint)sumI), unchecked((uint)((ulong)sumL >> 32)) }, unchecked((int)(sumL >> 63)));
            }

            uint subtractor = subtract ? 0xffffffffu : 0u,
                th = (two._sign < 0) ^ subtract ? 0xffffffffu : 0u;

            int l1 = one._values is null ? 1 : one._values.Length,
                l2 = two._values is null ? 1 : two._values.Length,
                len = Max(l1, l2);

            long lastVal1 = one._values is null ? one._sign : unchecked((long)(one._values[one._values.Length - 1] | ((ulong)one._sign << 32))),
                lastVal2 = two._values is null ? two._sign : unchecked((long)(two._values[two._values.Length - 1] | ((ulong)two._sign << 32))),
                test = subtract ? (lastVal1 - lastVal2 - 1) : (lastVal1 + lastVal2 + 1);

            if (test != unchecked((int)test))
                len++;

            uint[] nv = new uint[len];

            ulong sum =
                (ulong)(one._values is null ? unchecked((uint)one._sign) : one._values[0]) +
                ((two._values is null ? unchecked((uint)two._sign) : two._values[0]) ^ subtractor) +
                (subtract ? 1ul : 0ul);

            nv[0] = unchecked((uint)sum);

            uint carry = unchecked((uint)(sum >> 32));

            for (int i = 1; i < len; i++)
            {
                sum = (ulong)(one._values is null ? 0u : i >= one._values.Length ? unchecked((uint)one._sign) : one._values[i]) +
                    (two._values is null ? th : (i >= two._values.Length ? unchecked((uint)two._sign) : two._values[i]) ^ subtractor) + carry;

                nv[i] = unchecked((uint)sum);

                carry = unchecked((uint)(sum >> 32));
            }

            return new BigInt(nv, (one._sign < 0) ^ (two._sign < 0) ^ subtract ^ !(carry is 0) ? -1 : 0);
        }

        private static BigInt Multiply(BigInt one, BigInt two)
        {
            if (one.IsZero || two.IsZero)
                return new BigInt(null, 0);

            if (one._values is null && one._sign is 1)
                return two;

            if (two._values is null && two._sign is 1)
                return one;

            if (one._values is null && two._values is null)
            {
                long prL = (long)one._sign * two._sign;
                int prI = unchecked((int)prL);

                if (prI == prL)
                    return new BigInt(null, prI);
            }

            uint[] nv = new uint[(one.MostSignificantBit + two.MostSignificantBit + 33) / 32];

            for (int i = 0; i < nv.Length; i++)
            {
                ulong vL = i is 0
                    ? one._values is null ? (uint)one._sign : one._values[0]
                    : one._values is null || i >= one._values.Length ? (uint)(one._sign >> 31) : one._values[i];

                ulong mL = vL * unchecked(two._values is null ? unchecked((uint)two._sign) : two._values[0]) + nv[i];

                nv[i] = unchecked((uint)mL);

                uint carry = unchecked((uint)(mL >> 32));

                for (int j = i + 1; j < nv.Length; j++)
                {
                    mL = vL * unchecked(two._values is null || j - i >= two._values.Length ? unchecked((uint)(two._sign >> 31)) : two._values[j - i]) + carry + nv[j];
                    nv[j] = unchecked((uint)mL);
                    carry = unchecked((uint)(mL >> 32));
                }
            }

            return new BigInt(nv, (one._sign >> 31) ^ (two._sign >> 31));
        }

        private static QuotientRemainder DivideModulo(BigInt one, BigInt two)
        {
            if (two.IsZero)
                throw new DivideByZeroException();

            if (one._values is null && two._values is null)
                return new QuotientRemainder(new BigInt(null, one._sign / two._sign), new BigInt(null, one._sign % two._sign));

            bool neg1 = false, neg2 = false;

            if (one._sign < 0)
            {
                one = -one;
                neg1 = true;
            }

            if (two._sign < 0)
            {
                two = -two;
                neg2 = true;
            }

            // This array starts out with the value of ‘one’ (the dividend). We will successively subtract left-shifted ‘two’s
            // from it until it is smaller than ‘two’, at which point it will contain the remainder.
            uint[] rem = one._values is null ? new[] { unchecked((uint)one._sign) } : neg1 ? one._values : (uint[])one._values.Clone();

            // Divisor.
            uint[] div = two._values ?? new[] { unchecked((uint)two._sign) };

            int msb1 = one.MostSignificantBit + 1,
                msb2 = two.MostSignificantBit + 1;

            // How far left-shifted ‘two’ starts out.
            int curShift = msb1 - msb2;

            // Will contain the quotient at the end.
            uint[] quo = null;

            while (curShift >= 0)
            {
                // Find out whether the part of ‘rem’ that is aligned with ‘div’ is smaller than ‘div’ or not.
                int remBi = curShift % 32;

                for (int i = div.Length - 1; i >= 0; i--)
                {
                    int remBy = curShift / 32 + i;
                    uint v = (rem[remBy] >> remBi) | (remBi is 0 || remBy + 1 >= rem.Length ? 0u : rem[remBy + 1] << (32 - remBi));

                    // If our ‘rem’ part is bigger than ‘div’, we want to place a bit in ‘quo’ and then subtract ‘div’ from ‘rem’.
                    if (v > div[i])
                        goto placeBit;

                    // If our ‘rem’ part is smaller than ‘div’, we want to shift over one bit and continue.
                    if (v < div[i])
                        goto nextShift;
                }

            // If we get here, the ‘rem’ part is equal to ‘div’, so we still want to place a bit and subtract
            placeBit:
                if (quo is null)
                    quo = new uint[curShift / 32 + 1];

                quo[curShift / 32] |= 1u << (curShift % 32);

                long carry = 0L;

                for (int i = 0; i < div.Length; i++)
                {
                    int remBy = curShift / 32 + i;

                    bool more = remBi > 0 && remBy + 1 < rem.Length;

                    uint valA = rem[remBy] >> remBi,
                        valB = more ? rem[remBy + 1] << (32 - remBi) : 0u,
                        valC = valA | valB;

                    long val = valC + carry - div[i];

                    if (more)
                        rem[remBy + 1] = (rem[remBy + 1] >> remBi << remBi) | unchecked((uint)val >> (32 - remBi));

                    rem[remBy] = unchecked((uint)((rem[remBy] & ((1u << remBi) - 1)) | (val << remBi)));

                    carry = val >> 32;
                }

            nextShift:
                curShift--;
            }

            // If quo is null, the quotient is actually 0, so this works out nicely.
            BigInt r = new BigInt(rem, 0),
                q = new BigInt(quo, 0),
                finalQ = (neg1 ^ neg2) ? -q : q,
                finalR = neg1 ? -r : r;

            return new QuotientRemainder(finalQ, finalR);
        }
    }
}
