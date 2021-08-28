using System;
using System.Collections;

namespace KeepCoding
{
    /// <summary>
    /// A pseudo-random number generator that is primarily used to get multiple platforms to share the same random number generator.
    /// </summary>
    public class MonoRandom
    {
        private int _inext = 0, _inextp = 31;

        private readonly int[] _seedArray = new int[56];

        /// <summary>
        /// Initializes a new instance of the <see cref="MonoRandom"/> class, using a time-dependent default seed value.
        /// </summary>
        /// <exception cref="OverflowException"></exception>
        public MonoRandom() : this(Environment.TickCount) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Random"/> class, using the specified seed value.
        /// </summary>
        /// <exception cref="OverflowException"></exception>
        /// <param name="seed">A number used to calculate a starting value for the pseudo-random number sequence. If a negative number is specified, the absolute value of the number is used.</param>
        public MonoRandom(int seed)
        {
            Seed = seed;

            int num = 161803398 - Math.Abs(seed),
                num2 = 1;

            _seedArray[55] = num;

            for (int i = 1; i < 55; i++)
            {
                int num3 = 21 * i % 55;

                _seedArray[num3] = num2;

                num2 = num - num2;

                if (num2 < 0)
                    num2 += int.MaxValue;

                num = _seedArray[num3];
            }

            for (int j = 1; j < 5; j++)
            {
                for (int k = 1; k < 56; k++)
                {
                    _seedArray[k] -= _seedArray[1 + (k + 30) % 55];

                    if (_seedArray[k] < 0)
                        _seedArray[k] += int.MaxValue;
                }
            }
        }

        /// <summary>
        /// The seed used for the randomization.
        /// </summary>
        public int Seed { get; }

        /// <summary>
        /// Fills the elements of a specified array of bytes with random numbers.
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="buffer">An array of bytes to contain random numbers.</param>
        public virtual void NextBytes(byte[] buffer)
        {
            if (buffer is null)
                throw new ArgumentNullException(nameof(buffer));

            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = (byte)(Sample() * 256);
        }

        /// <summary>
        /// Returns a nonnegative random number.
        /// </summary>
        /// <returns>A 32-bit signed integer greater than or equal to zero and less than <see cref="int.MaxValue"/>.</returns>
        public virtual int Next() => (int)(Sample() * int.MaxValue);

        /// <summary>
        /// Returns a nonnegative random number less than the specified maximum.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="maxValue">The exclusive upper bound of the random number to be generated. <paramref name="maxValue" /> must be greater than or equal to zero.</param>
        /// <returns>A 32-bit signed integer greater than or equal to zero, and less than <paramref name="maxValue" />; that is, the range of return values ordinarily includes zero but not <paramref name="maxValue" />. However, if <paramref name="maxValue" /> equals zero, <paramref name="maxValue" /> is returned.</returns>
        public virtual int Next(int maxValue) => maxValue < 0 ? throw new ArgumentOutOfRangeException(nameof(maxValue)) : (int)(Sample() * maxValue);

        /// <summary>
        /// Returns a random number within a specified range.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive upper bound of the random number returned. <paramref name="maxValue" /> must be greater than or equal to <paramref name="minValue" />.</param>
        /// <returns>A 32-bit signed integer greater than or equal to <paramref name="minValue" /> and less than <paramref name="maxValue" />; that is, the range of return values includes <paramref name="minValue" /> but not <paramref name="maxValue" />. If <paramref name="minValue" /> equals <paramref name="maxValue" />, <paramref name="minValue" /> is returned.</returns>
        public virtual int Next(int minValue, int maxValue)
        {
            if (minValue > maxValue)
                throw new ArgumentOutOfRangeException(nameof(minValue));

            uint num = (uint)(maxValue - minValue);

            return num <= 1u ? minValue : (int)((uint)(Sample() * num) + (ulong)minValue);
        }

        /// <summary>
        /// Returns a random number between 0.0 and 1.0.
        /// </summary>
        /// <returns>A double-precision floating point number greater than or equal to 0.0, and less than 1.0.</returns>
        public virtual double NextDouble() => Sample();

        /// <summary>
        /// Returns a random number between 0.0 and 1.0.
        /// </summary>
        /// <returns>A double-precision floating point number greater than or equal to 0.0, and less than 1.0.</returns>
        protected virtual double Sample()
        {
            if (++_inext >= 56)
                _inext = 1;

            if (++_inextp >= 56)
                _inextp = 1;

            int num = _seedArray[_inext] - _seedArray[_inextp];

            if (num < 0)
                num += int.MaxValue;

            _seedArray[_inext] = num;

            return num * 4.6566128752457969E-10;
        }

        /// <summary>
        /// Shuffles a list using an in-place algorithm; the original list is modified.
        /// </summary>
        /// <typeparam name="T">The type of list to shuffle.</typeparam>
        /// <param name="list">The list to shuffle.</param>
        /// <returns><paramref name="list"/> shuffled using Fisher-Yates shuffle.</returns>
        public T Shuffle<T>(T list) where T : IList
        {
            int i = list.Count;

            while (i > 1)
            {
                int index = Next(0, i);
                i--;

                object value = list[index];
                list[index] = list[i];
                list[i] = value;
            }

            return list;
        }
    }
}
