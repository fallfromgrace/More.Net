using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Media
{
    public struct PixelFormat
    {
        public Int32 BitsPerPixel
        {
            get { return bitsPerPixel; }
        }

        //public IReadOnlyCollection<ChannelMask> Masks
        //{
        //    get { return masks; }
        //}
        //private readonly IReadOnlyCollection<ChannelMask> masks;

        public PixelFormat(Int32 bitsPerPixel)
        {
            this.bitsPerPixel = bitsPerPixel;
        }

        private readonly Int32 bitsPerPixel;
    }
}
