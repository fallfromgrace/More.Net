using System;

namespace Light
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// Creates a new array from a contiguous portion of the source array,
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TElement"></typeparam>
        /// <param name="source"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static ArraySegment<TElement> ArraySlice<TElement>(
            this TElement[] source, 
            Int32 offset,
            Int32 count)
        {
            return new ArraySegment<TElement>(source, offset, count);
        }
    }
}
