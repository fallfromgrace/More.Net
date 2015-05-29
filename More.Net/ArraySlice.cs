using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace Light
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
    public struct ArrayView<TElement> : IReadOnlyList<TElement>, IEquatable<ArrayView<TElement>>
    {
        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        public ArrayView(IReadOnlyList<TElement> source, Int32 offset, Int32 count)
        {
            Contract.Requires<ArgumentNullException>(source != null, "source");
            Contract.Requires<ArgumentOutOfRangeException>(offset < 0, "offset");
            Contract.Requires<ArgumentOutOfRangeException>(count < 0, "count");
            Contract.Requires<ArgumentException>(offset + count > source.Count, "source");

            this.source = source;
            this.offset = offset;
            this.count = count;
        }

        #endregion

        #region IReadOnlyList<TElement>

        #region IReadOnlyCollection<TElement

        #region IEnumerable<TElement>

        #region IEnumerable

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerator<TElement> GetEnumerator()
        {
            for (Int32 i = offset; i < count; i++)
                yield return this.source[i];
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        public Int32 Count
        {
            get { return this.count; }
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public TElement this[Int32 index]
        {
            get { return this.source[index + offset]; }
        }

        #endregion

        #region IEquatable<ListView<TElement>>

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(ArrayView<TElement> other)
        {
            return this.source == other.source &&
                this.offset == other.offset &&
                this.count == other.count;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj)
        {
            if (obj != null && obj is ArrayView<TElement>)
                return this.Equals((ArrayView<TElement>)obj);
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode()
        {
            return offset.GetHashCode() ^ 
                count.GetHashCode() ^ 
                (source == null ? 0 : source.GetHashCode());
        }

        #endregion

        #region

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(ArrayView<TElement> left, ArrayView<TElement> right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(ArrayView<TElement> left, ArrayView<TElement> right)
        {
            return (left == right) == false;
        }

        #endregion

        #region Private Fields

        private readonly IReadOnlyList<TElement> source;
        private readonly Int32 offset;
        private readonly Int32 count;

        #endregion
    }

    /// <summary>
    /// 
    /// </summary>
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TElement"></typeparam>
        /// <param name="source"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IReadOnlyList<TElement> GetView<TElement>(
            this IReadOnlyList<TElement> source,
            Int32 offset,
            Int32 count)
        {
            return new ArrayView<TElement>(source, offset, count);
        }

        public class ByteArrayBuilder
        {

        }
    }
}
