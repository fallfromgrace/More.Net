using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Linq
{
    /// <summary>
    /// 
    /// </summary>
    public static class Enumerable
    {
        /// <summary>
        /// Converts a sets of variadic arguments to an enumerable collection.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IEnumerable<TValue> Create<TValue>(params TValue[] values)
        {
            foreach (TValue value in values)
                yield return value;
        }
    }
}
