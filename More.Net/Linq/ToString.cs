using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light.Linq
{
    public static partial class LinqExtensions
    {
        public static String DecodeToString(
            this IEnumerable<Byte> source,
            Encoding encoding)
        {
            Byte[] buffer = source.ToArray();
            return encoding
                .GetString(buffer, 0, buffer.Length);
        }
    }
}
