using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net
{
    public static class PrimitiveExtensions
    {
        public static Int32 Pow(this Int32 value, Int32 power)
        {
            if (power == 0) return 1;
            if (power == 1) return value;
            
            int n = 15;
            while ((power <<= 1) >= 0) n--;

            Int32 tmp = value;
            while (--n > 0)
                tmp = tmp * tmp *
                     (((power <<= 1) < 0) ? value : 1);
            return tmp;
        }
    }
}
