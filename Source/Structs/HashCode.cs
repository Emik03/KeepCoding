/*

The xxHash32 implementation is based on the code published by Yann Collet:
https://raw.githubusercontent.com/Cyan4973/xxHash/5c174cfa4e45a42f94082dc0d4539b39696afea1/xxhash.c

  xxHash - Fast Hash algorithm
  Copyright (C) 2012-2016, Yann Collet

  BSD 2-Clause License (http://www.opensource.org/licenses/bsd-license.php)

  Redistribution and use in source and binary forms, with or without
  modification, are permitted provided that the following conditions are
  met:

  * Redistributions of source code must retain the above copyright
  notice, this list of conditions and the following disclaimer.
  * Redistributions in binary form must reproduce the above
  copyright notice, this list of conditions and the following disclaimer
  in the documentation and/or other materials provided with the
  distribution.

  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
  "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
  LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
  A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
  OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
  SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
  LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
  DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
  THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
  (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
  OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

  You can contact the author at :
  - xxHash homepage: http://www.xxhash.com
  - xxHash source repository : https://github.com/Cyan4973/xxHash

*/

using System;
using System.Collections.Generic;

namespace KeepCoding
{
    /// <summary>
    /// Combines the hash code for multiple values into a single hash code. xxHash32 is used for the hash code. <see href="https://github.com/Cyan4973/xxHash"/>
    /// </summary>
    /// <remarks>
    /// You can use HashCode to combine multiple values (for example, fields on a structure or class) into a single hash code. This structure operates in one of two ways, static methods that accept a set of up to eight values to combine, and two instance methods that operate in a streaming fashion, accepting values one at a time.
    /// </remarks>
    public struct HashCode
    {
        private static readonly uint s_seed = GenerateGlobalSeed();

        private uint _length, _v1, _v2, _v3, _v4, _queue1, _queue2, _queue3;

        private const uint Prime1 = 2654435761U, Prime2 = 2246822519U, Prime3 = 3266489917U, Prime4 = 668265263U, Prime5 = 374761393U;

        /// <summary>
        /// Adds a single value to the hash code.
        /// </summary>
        /// <typeparam name="T">The type of the value to add to the hash code.</typeparam>
        /// <param name="value">The value to add to the hash code.</param>
        public void Add<T>(T value) => Add(value?.GetHashCode() ?? 0);

        /// <summary>
        /// Adds a single value to the hash code, specifying the type that provides the hash code function.
        /// </summary>
        /// <typeparam name="T">The type of the value to add to the hash code.</typeparam>
        /// <param name="value">The value to add to the hash code.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer{T}"/> to use to calculate the hash code. This value can be a null reference (Nothing in Visual Basic), which will use the default equality comparer for <typeparamref name="T"/>.</param>
        public void Add<T>(T value, IEqualityComparer<T> comparer) => Add(comparer?.GetHashCode(value) ?? value?.GetHashCode() ?? 0);

        /// <summary>
        /// Diffuses the hash code returned by the specified value.
        /// </summary>
        /// <remarks>
        /// Some data structures assume that hash codes are diffused across a large range. This method improves the quality of the hash code returned by the value and is useful when the underlying data type is simple, for example, an integer value.
        /// </remarks>
        /// <typeparam name="T1">The type of the value to add the hash code.</typeparam>
        /// <param name="value1">The value to add to the hash code.</param>
        /// <returns>The hash code that represents the single value.</returns>
        public static int Combine<T1>(T1 value1)
        {
            uint hc1 = (uint)(value1?.GetHashCode() ?? 0),
                hash = MixEmptyState();

            hash += 4;

            hash = QueueRound(hash, hc1);

            hash = MixFinal(hash);

            return (int)hash;
        }

        /// <summary>
        /// Combines two values into a hash code.
        /// </summary>
        /// <typeparam name="T1">The type of the first value to combine into the hash code.</typeparam>
        /// <typeparam name="T2">The type of the second value to combine into the hash code.</typeparam>
        /// <param name="value1">The first value to combine into the hash code.</param>
        /// <param name="value2">The second value to combine into the hash code.</param>
        /// <returns>The hash code that represents the two values.</returns>
        public static int Combine<T1, T2>(T1 value1, T2 value2)
        {
            uint hc1 = (uint)(value1?.GetHashCode() ?? 0),
                hc2 = (uint)(value2?.GetHashCode() ?? 0),
                hash = MixEmptyState();

            hash += 8;

            hash = QueueRound(hash, hc1);
            hash = QueueRound(hash, hc2);

            hash = MixFinal(hash);

            return (int)hash;
        }

        /// <summary>
        /// Combines three values into a hash code.
        /// </summary>
        /// <typeparam name="T1">The type of the first value to combine into the hash code.</typeparam>
        /// <typeparam name="T2">The type of the second value to combine into the hash code.</typeparam>
        /// <typeparam name="T3">The type of the third value to combine into the hash code.</typeparam>
        /// <param name="value1">The first value to combine into the hash code.</param>
        /// <param name="value2">The second value to combine into the hash code.</param>
        /// <param name="value3">The third value to combine into the hash code.</param>
        /// <returns>The hash code that represents the three values.</returns>
        public static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3)
        {
            uint hc1 = (uint)(value1?.GetHashCode() ?? 0),
                hc2 = (uint)(value2?.GetHashCode() ?? 0),
                hc3 = (uint)(value3?.GetHashCode() ?? 0),
                hash = MixEmptyState();

            hash += 12;

            hash = QueueRound(hash, hc1);
            hash = QueueRound(hash, hc2);
            hash = QueueRound(hash, hc3);

            hash = MixFinal(hash);

            return (int)hash;
        }

        /// <summary>
        /// Combines four values into a hash code.
        /// </summary>
        /// <typeparam name="T1">The type of the first value to combine into the hash code.</typeparam>
        /// <typeparam name="T2">The type of the second value to combine into the hash code.</typeparam>
        /// <typeparam name="T3">The type of the third value to combine into the hash code.</typeparam>
        /// <typeparam name="T4">The type of the fourth value to combine into the hash code.</typeparam>
        /// <param name="value1">The first value to combine into the hash code.</param>
        /// <param name="value2">The second value to combine into the hash code.</param>
        /// <param name="value3">The third value to combine into the hash code.</param>
        /// <param name="value4">The fourth value to combine into the hash code.</param>
        /// <returns>The hash code that represents the four values.</returns>
        public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4)
        {
            uint hc1 = (uint)(value1?.GetHashCode() ?? 0),
                hc2 = (uint)(value2?.GetHashCode() ?? 0),
                hc3 = (uint)(value3?.GetHashCode() ?? 0),
                hc4 = (uint)(value4?.GetHashCode() ?? 0);

            Initialize(out uint v1, out uint v2, out uint v3, out uint v4);

            v1 = Round(v1, hc1);
            v2 = Round(v2, hc2);
            v3 = Round(v3, hc3);
            v4 = Round(v4, hc4);

            uint hash = MixState(v1, v2, v3, v4);
            hash += 16;

            hash = MixFinal(hash);
            return (int)hash;
        }

        /// <summary>
        /// Combines five values into a hash code.
        /// </summary>
        /// <typeparam name="T1">The type of the first value to combine into the hash code.</typeparam>
        /// <typeparam name="T2">The type of the second value to combine into the hash code.</typeparam>
        /// <typeparam name="T3">The type of the third value to combine into the hash code.</typeparam>
        /// <typeparam name="T4">The type of the fourth value to combine into the hash code.</typeparam>
        /// <typeparam name="T5">The type of the fifth value to combine into the hash code.</typeparam>
        /// <param name="value1">The first value to combine into the hash code.</param>
        /// <param name="value2">The second value to combine into the hash code.</param>
        /// <param name="value3">The third value to combine into the hash code.</param>
        /// <param name="value4">The fourth value to combine into the hash code.</param>
        /// <param name="value5">The fifth value to combine into the hash code.</param>
        /// <returns>The hash code that represents the five values.</returns>
        public static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5)
        {
            uint hc1 = (uint)(value1?.GetHashCode() ?? 0),
                hc2 = (uint)(value2?.GetHashCode() ?? 0),
                hc3 = (uint)(value3?.GetHashCode() ?? 0),
                hc4 = (uint)(value4?.GetHashCode() ?? 0),
                hc5 = (uint)(value5?.GetHashCode() ?? 0);

            Initialize(out uint v1, out uint v2, out uint v3, out uint v4);

            v1 = Round(v1, hc1);
            v2 = Round(v2, hc2);
            v3 = Round(v3, hc3);
            v4 = Round(v4, hc4);

            uint hash = MixState(v1, v2, v3, v4);

            hash += 20;

            hash = QueueRound(hash, hc5);

            hash = MixFinal(hash);

            return (int)hash;
        }

        /// <summary>
        /// Combines six values into a hash code.
        /// </summary>
        /// <typeparam name="T1">The type of the first value to combine into the hash code.</typeparam>
        /// <typeparam name="T2">The type of the second value to combine into the hash code.</typeparam>
        /// <typeparam name="T3">The type of the third value to combine into the hash code.</typeparam>
        /// <typeparam name="T4">The type of the fourth value to combine into the hash code.</typeparam>
        /// <typeparam name="T5">The type of the fifth value to combine into the hash code.</typeparam>
        /// <typeparam name="T6">The type of the sixth value to combine into the hash code.</typeparam>
        /// <param name="value1">The first value to combine into the hash code.</param>
        /// <param name="value2">The second value to combine into the hash code.</param>
        /// <param name="value3">The third value to combine into the hash code.</param>
        /// <param name="value4">The fourth value to combine into the hash code.</param>
        /// <param name="value5">The fifth value to combine into the hash code.</param>
        /// <param name="value6">The sixth value to combine into the hash code.</param>
        /// <returns>The hash code that represents the six values.</returns>
        public static int Combine<T1, T2, T3, T4, T5, T6>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6)
        {
            uint hc1 = (uint)(value1?.GetHashCode() ?? 0),
                hc2 = (uint)(value2?.GetHashCode() ?? 0),
                hc3 = (uint)(value3?.GetHashCode() ?? 0),
                hc4 = (uint)(value4?.GetHashCode() ?? 0),
                hc5 = (uint)(value5?.GetHashCode() ?? 0),
                hc6 = (uint)(value6?.GetHashCode() ?? 0);

            Initialize(out uint v1, out uint v2, out uint v3, out uint v4);

            v1 = Round(v1, hc1);
            v2 = Round(v2, hc2);
            v3 = Round(v3, hc3);
            v4 = Round(v4, hc4);

            uint hash = MixState(v1, v2, v3, v4);

            hash += 24;

            hash = QueueRound(hash, hc5);
            hash = QueueRound(hash, hc6);

            hash = MixFinal(hash);

            return (int)hash;
        }

        /// <summary>
        /// Combines seven values into a hash code.
        /// </summary>
        /// <typeparam name="T1">The type of the first value to combine into the hash code.</typeparam>
        /// <typeparam name="T2">The type of the second value to combine into the hash code.</typeparam>
        /// <typeparam name="T3">The type of the third value to combine into the hash code.</typeparam>
        /// <typeparam name="T4">The type of the fourth value to combine into the hash code.</typeparam>
        /// <typeparam name="T5">The type of the fifth value to combine into the hash code.</typeparam>
        /// <typeparam name="T6">The type of the sixth value to combine into the hash code.</typeparam>
        /// <typeparam name="T7">The type of the seventh value to combine into the hash code.</typeparam>
        /// <param name="value1">The first value to combine into the hash code.</param>
        /// <param name="value2">The second value to combine into the hash code.</param>
        /// <param name="value3">The third value to combine into the hash code.</param>
        /// <param name="value4">The fourth value to combine into the hash code.</param>
        /// <param name="value5">The fifth value to combine into the hash code.</param>
        /// <param name="value6">The sixth value to combine into the hash code.</param>
        /// <param name="value7">The seventh value to combine into the hash code.</param>
        /// <returns>The hash code that represents the seven values.</returns>
        public static int Combine<T1, T2, T3, T4, T5, T6, T7>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7)
        {
            uint hc1 = (uint)(value1?.GetHashCode() ?? 0),
                hc2 = (uint)(value2?.GetHashCode() ?? 0),
                hc3 = (uint)(value3?.GetHashCode() ?? 0),
                hc4 = (uint)(value4?.GetHashCode() ?? 0),
                hc5 = (uint)(value5?.GetHashCode() ?? 0),
                hc6 = (uint)(value6?.GetHashCode() ?? 0),
                hc7 = (uint)(value7?.GetHashCode() ?? 0);

            Initialize(out uint v1, out uint v2, out uint v3, out uint v4);

            v1 = Round(v1, hc1);
            v2 = Round(v2, hc2);
            v3 = Round(v3, hc3);
            v4 = Round(v4, hc4);

            uint hash = MixState(v1, v2, v3, v4);

            hash += 28;

            hash = QueueRound(hash, hc5);
            hash = QueueRound(hash, hc6);
            hash = QueueRound(hash, hc7);

            hash = MixFinal(hash);

            return (int)hash;
        }

        /// <summary>
        /// Combines eight values into a hash code.
        /// </summary>
        /// <typeparam name="T1">The type of the first value to combine into the hash code.</typeparam>
        /// <typeparam name="T2">The type of the second value to combine into the hash code.</typeparam>
        /// <typeparam name="T3">The type of the third value to combine into the hash code.</typeparam>
        /// <typeparam name="T4">The type of the fourth value to combine into the hash code.</typeparam>
        /// <typeparam name="T5">The type of the fifth value to combine into the hash code.</typeparam>
        /// <typeparam name="T6">The type of the sixth value to combine into the hash code.</typeparam>
        /// <typeparam name="T7">The type of the seventh value to combine into the hash code.</typeparam>
        /// <typeparam name="T8">The type of the eighth value to combine into the hash code.</typeparam>
        /// <param name="value1">The first value to combine into the hash code.</param>
        /// <param name="value2">The second value to combine into the hash code.</param>
        /// <param name="value3">The third value to combine into the hash code.</param>
        /// <param name="value4">The fourth value to combine into the hash code.</param>
        /// <param name="value5">The fifth value to combine into the hash code.</param>
        /// <param name="value6">The sixth value to combine into the hash code.</param>
        /// <param name="value7">The seventh value to combine into the hash code.</param>
        /// <param name="value8">The eighth value to combine into the hash code.</param>
        /// <returns>The hash code that represents the eight values.</returns>
        public static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8)
        {
            uint hc1 = (uint)(value1?.GetHashCode() ?? 0),
                hc2 = (uint)(value2?.GetHashCode() ?? 0),
                hc3 = (uint)(value3?.GetHashCode() ?? 0),
                hc4 = (uint)(value4?.GetHashCode() ?? 0),
                hc5 = (uint)(value5?.GetHashCode() ?? 0),
                hc6 = (uint)(value6?.GetHashCode() ?? 0),
                hc7 = (uint)(value7?.GetHashCode() ?? 0),
                hc8 = (uint)(value8?.GetHashCode() ?? 0);

            Initialize(out uint v1, out uint v2, out uint v3, out uint v4);

            v1 = Round(v1, hc1);
            v2 = Round(v2, hc2);
            v3 = Round(v3, hc3);
            v4 = Round(v4, hc4);

            v1 = Round(v1, hc5);
            v2 = Round(v2, hc6);
            v3 = Round(v3, hc7);
            v4 = Round(v4, hc8);

            uint hash = MixState(v1, v2, v3, v4);

            hash += 32;

            hash = MixFinal(hash);

            return (int)hash;
        }

        /// <summary>
        /// Calculates the final hash code after consecutive <see cref="Add(int)"/>/<see cref="Add(uint, uint)"/> invocations.
        /// </summary>
        /// <remarks>
        /// This method must be called at most once per instance of <see cref="HashCode"/>.
        /// </remarks>
        /// <returns>The calculated hash code.</returns>
        public readonly int ToHashCode()
        {
            uint length = _length;

            uint position = length % 4;

            uint hash = length < 4 ? MixEmptyState() : MixState(_v1, _v2, _v3, _v4);

            hash += length * 4;

            if (position > 0)
            {
                hash = QueueRound(hash, _queue1);

                if (position > 1)
                {
                    hash = QueueRound(hash, _queue2);

                    if (position > 2)
                        hash = QueueRound(hash, _queue3);
                }
            }

            hash = MixFinal(hash);

            return (int)hash;
        }

        private void Add(int value)
        {
            uint val = (uint)value,
                previousLength = _length++,
                position = previousLength % 4;

            if (position == 0)
                _queue1 = val;

            else if (position == 1)
                _queue2 = val;

            else if (position == 2)
                _queue3 = val;

            else
                Add(val, previousLength);
        }

        private void Add(uint val, uint previousLength)
        {
            if (previousLength == 3)
                Initialize(out _v1, out _v2, out _v3, out _v4);

            _v1 = Round(_v1, _queue1);
            _v2 = Round(_v2, _queue2);
            _v3 = Round(_v3, _queue3);
            _v4 = Round(_v4, val);
        }

        private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4)
        {
            v1 = s_seed + Prime1 + Prime2;
            v2 = s_seed + Prime2;
            v3 = s_seed;
            v4 = s_seed - Prime1;
        }

        private static uint GenerateGlobalSeed()
        {
            var random = new Random();
            byte[] bytes = new byte[4];
            random.NextBytes(bytes);
            return BitConverter.ToUInt32(bytes, 0);
        }

        private static uint MixEmptyState() => s_seed + Prime5;

        private static uint MixFinal(uint hash)
        {
            hash ^= hash >> 15;
            hash *= Prime2;
            hash ^= hash >> 13;
            hash *= Prime3;
            hash ^= hash >> 16;
            return hash;
        }

        private static uint MixState(uint v1, uint v2, uint v3, uint v4) => RotateLeft(v1, 1) + RotateLeft(v2, 7) + RotateLeft(v3, 12) + RotateLeft(v4, 18);

        private static uint QueueRound(uint hash, uint queuedValue) => RotateLeft(hash + queuedValue * Prime3, 17) * Prime4;

        private static uint RotateLeft(uint value, int offset) => (value << offset) | (value >> (32 - offset));

        private static uint Round(uint hash, uint input) => RotateLeft(hash + input * Prime2, 13) * Prime1;
    }
}
