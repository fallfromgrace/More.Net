using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Media
{
    public struct BitmapImageInfo
    {
        public BitmapImageInfo(PixelFormat format, Int32 height, Int32 stride, Int32 width)
        {
            this.format = format;
            this.height = height;
            this.stride = stride;
            this.width = width;
        }

        private readonly PixelFormat format;
        private readonly Int32 height;
        private readonly Int32 stride;
        private readonly Int32 width;
    }
}
