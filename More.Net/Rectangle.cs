using System;

namespace EZMetrology
{
    /// <summary>
    /// 
    /// </summary>
    public struct Rectangle<TValue>
        where TValue : struct, IComparable, IComparable<TValue>, IEquatable<TValue>
    {
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
        public TValue Width
        {
            get { return width; }
        }

        /// <summary>
        /// 
        /// </summary>
        public TValue Height
        {
            get { return height; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rectangle(TValue x, TValue y, TValue width, TValue height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        private readonly TValue x;
        private readonly TValue y;
        private readonly TValue width;
        private readonly TValue height;
    }
}
