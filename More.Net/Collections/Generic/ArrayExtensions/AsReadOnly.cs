using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace More.Net.Collections.Generic
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IReadOnlyCollection<T> AsReadOnly<T>(this T[] source)
        {
            return new ReadOnlyCollection<T>(source);
        }
    }
}
