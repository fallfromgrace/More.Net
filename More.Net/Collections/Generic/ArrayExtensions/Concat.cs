using System;
using System.Linq;

namespace EZMetrology
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// Concatenates the source array with the specified arrays.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="arrays"></param>
        /// <returns></returns>
        public static T[] Concat<T>(this T[] source, params T[][] arrays)
        {
            Int32 offset = 0;
            T[] result = new T[source.Length + arrays.Sum(a => a.Length)];

            foreach (T[] array in arrays)
            {
                array.CopyTo(result, offset);
                offset += array.Length;
            }

            return result;
        }
    }
}
