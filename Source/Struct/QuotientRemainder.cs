#if !LITE
namespace KeepCoding
{
    /// <summary>
    /// Encapsulates the two-valued result of a division/modulo operation (<see cref="BigInt.DivideModulo(BigInt)"/>).
    /// </summary>
    /// <remarks>
    /// This struct has been written by Timwi. <see href="https://github.com/Timwi/"/>
    /// </remarks>
    public readonly struct QuotientRemainder
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public QuotientRemainder(BigInt quotient, BigInt remainder)
        {
            Quotient = quotient;
            Remainder = remainder;
        }

        /// <summary>
        /// The quotient (result of the integer division).
        /// </summary>
        public BigInt Quotient { get; }

        /// <summary>
        /// The remainder (result of the modulo).
        /// </summary>
        public BigInt Remainder { get; }

        /// <summary>
        /// Deconstructor.
        /// </summary>
        public void Deconstruct(out BigInt quotient, out BigInt remainder)
        {
            quotient = Quotient;
            remainder = Remainder;
        }
    }
}
#endif
