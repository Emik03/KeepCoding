using System;
using System.Collections;
using KeepCoding.Internal;
using static System.Globalization.CultureInfo;

namespace KeepCoding
{
    /// <summary>
    /// Specfies a format for <see cref="Helper.Stringify{T}(T, StringifyFormat)"/>.
    /// </summary>
    public sealed class StringifyFormat
    {
        /// <summary>
        /// Indicates how <see cref="IEnumerator"/>s and <see cref="IEnumerable"/>s should end with.
        /// </summary>
        public string ArrayEnd { get; set; } = "]";

        /// <summary>
        /// Indicates how <see cref="Tuple"/> should start with.
        /// </summary>
        public string ArraySeparator { get; set; } = ", ";

        /// <summary>
        /// Indicates how <see cref="IEnumerator"/>s and <see cref="IEnumerable"/>s should start with.
        /// </summary>
        public string ArrayStart { get; set; } = "[";

        /// <summary>
        /// Indicates how <see cref="char"/> should be surrounded with.
        /// </summary>
        public string CharIndicator { get; set; } = "'";

        /// <summary>
        /// Indicates how <see cref="IDictionary"/>s should end with.
        /// </summary>
        public string DictionaryEnd { get; set; } = " }";

        /// <summary>
        /// Indicates how <see cref="Tuple"/> should start with.
        /// </summary>
        public string DictionarySeparator { get; set; } = ", ";

        /// <summary>
        /// Indicates how <see cref="IDictionary"/>s should start with.
        /// </summary>
        public string DictionaryStart { get; set; } = "{ ";

        /// <summary>
        /// Indicates how <see langword="false"/> should be written as.
        /// </summary>
        public string FalseArg { get; set; } = "false";

        /// <summary>
        /// Indicates how <see cref="KeyValuePairs"/> should be surrounded with.
        /// </summary>
        public string KeyValuePairSeparator { get; set; } = ": ";

        /// <summary>
        /// Indicates how <see langword="null"/> should be written as.
        /// </summary>
        public string NullArg { get; set; } = "null";

        /// <summary>
        /// Indicates how <see cref="string"/> should be surrounded with.
        /// </summary>
        public string StringIndicator { get; set; } = "\"";

        /// <summary>
        /// Indicates how <see langword="true"/> should be written as.
        /// </summary>
        public string TrueArg { get; set; } = "true";

        /// <summary>
        /// Indicates how <see cref="Tuple"/> should end with.
        /// </summary>
        public string TupleEnd { get; set; } = ")";

        /// <summary>
        /// Indicates how <see cref="Tuple"/> should start with.
        /// </summary>
        public string TupleSeparator { get; set; } = ", ";

        /// <summary>
        /// Indicates how <see cref="Tuple"/> should start with.
        /// </summary>
        public string TupleStart { get; set; } = "(";

        /// <summary>
        /// Indicates how <see cref="float"/>, <see cref="double"/>, and <see cref="decimal"/> should be formatted.
        /// </summary>
        public IFormatProvider DecimalFormat { get; set; } = InvariantCulture;
    }
}
