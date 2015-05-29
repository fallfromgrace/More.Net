using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology
{
    /// <summary>
    /// 
    /// </summary>
    public struct Size<TValue>
        where TValue : struct, IComparable, IComparable<TValue>, IEquatable<TValue>
    {
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
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Size(TValue width, TValue height)
        {
            this.width = width;
            this.height = height;
        }

        private readonly TValue width;
        private readonly TValue height;
    }
}
