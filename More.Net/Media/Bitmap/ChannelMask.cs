using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using More.Net.Collections.Generic;

namespace More.Net.Media
{
    public struct ChannelMask
    {
        public IReadOnlyCollection<Byte> Mask
        {
            get { return mask; }
        }

        public ChannelMask(IEnumerable<Byte> mask)
        {
            this.mask = mask.ToArray().AsReadOnly();
        }

        private readonly IReadOnlyCollection<Byte> mask;
    }
}
