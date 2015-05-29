using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net
{
    /// <summary>
    /// 
    /// </summary>
    public struct Point3<TValue> : IEquatable<Point3<TValue>>
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

        /// <summary>
        /// 
        /// </summary>
        public TValue Z
        {
            get { return z; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point3(TValue x, TValue y, TValue z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion

        #region IEquatable

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(Point3<TValue> other)
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
            return Equals((Point3<TValue>)obj);
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
        public static Boolean operator ==(Point3<TValue> left, Point3<TValue> right)
        {
            return
                (EqualityComparer<TValue>.Default.Equals(left.x, right.x) == true) &&
                (EqualityComparer<TValue>.Default.Equals(left.y, right.y) == true) &&
                (EqualityComparer<TValue>.Default.Equals(left.z, right.z) == true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(Point3<TValue> left, Point3<TValue> right)
        {
            return (left == right) == false;
        }

        #endregion

        #region Private Fields

        private readonly TValue x;
        private readonly TValue y;
        private readonly TValue z;

        #endregion
    }
}
