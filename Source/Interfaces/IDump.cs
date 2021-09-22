#if !SIMPLIFIED
using System;
using System.Linq.Expressions;

namespace KeepCoding
{
    /// <summary>
    /// An interface to implement dump methods. Make each method return the same method in your <see cref="Logger"/> instance. 
    /// </summary>
    public interface IDump
    {
        /// <summary>
        /// Dumps all information that it can find of the type using reflection. This should only be used to debug.
        /// </summary>
        /// <param name="obj">The object to reflect on.</param>
        /// <param name="getVariables">Whether it should search recursively for the elements within the elements.</param>
        public void Dump<T>(T obj, bool getVariables = false);

        /// <summary>
        /// Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.
        /// </summary>
        /// <param name="getVariables">Whether it should search recursively for the elements within the elements.</param>
        /// <param name="logs">All of the variables to throughly log.</param>
        public void Dump(bool getVariables, params Expression<Func<object>>[] logs);

        /// <summary>
        /// Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.
        /// </summary>
        /// <param name="logs">All of the variables to throughly log.</param>
        public void Dump(params Expression<Func<object>>[] logs);
    }
}
#endif
