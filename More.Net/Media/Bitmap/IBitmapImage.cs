using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace More.Net.Media
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBitmapImage
    {
        /// <summary>
        /// 
        /// </summary>
        IntPtr Data { get; }

        /// <summary>
        /// 
        /// </summary>
        Int32 Height { get; }

        /// <summary>
        /// 
        /// </summary>
        Int32 Width { get; }

        /// <summary>
        /// 
        /// </summary>
        Int32 Stride { get; }

        /// <summary>
        /// 
        /// </summary>
        PixelFormat Format { get; }
    }
}
