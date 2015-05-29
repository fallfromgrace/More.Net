using System;
using System.Collections.Generic;

namespace EZMetrology
{
    /// <summary>
    /// 
    /// </summary>
    public struct Point2<TValue> : IEquatable<Point2<TValue>>
        where TValue : struct, IComparable, IComparable<TValue>, IEquatable<TValue>
    {
        #region Public Properties

        /// <summary>
        /// 
        /// </summary>
        public TValue X
        {
            get { return x; }
        }

        /// <summary>
        /// 
        /// </summary>
        public TValue Y
        {
            get { return y; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point2(TValue x, TValue y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region IEquatable

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(Point2<TValue> other)
        {
            return this == other;
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
            return Equals((Point2<TValue>)obj);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return String.Format("({0}, {1})", x, y);
        }

        #endregion

        #region Operators

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(Point2<TValue> left, Point2<TValue> right)
        {
            return
                (EqualityComparer<TValue>.Default.Equals(left.x, right.x) == true) &&
                (EqualityComparer<TValue>.Default.Equals(left.y, right.y) == true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(Point2<TValue> left, Point2<TValue> right)
        {
            return (left == right) == false;
        }

        #endregion

        #region Private Fields

        private readonly TValue x;
        private readonly TValue y;

        #endregion
    }
}
