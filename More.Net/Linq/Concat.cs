using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Linq
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class LinqExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static String Concat(this IEnumerable<Char> source)
        {
            StringBuilder builder = new StringBuilder();
            foreach (Char c in source)
                builder.Append(c);
            return builder.ToString();
        }

        public static String Concat(this IEnumerable<String> source)
        {
            return source.Concat(String.Empty);
        }

        public static String Concat(this IEnumerable<String> source, String seperator)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            using (IEnumerator<String> enumerator = source.GetEnumerator())
            {
                StringBuilder builder = new StringBuilder();
                if (enumerator.MoveNext() == true)
                    builder.Append(enumerator.Current);

                while (enumerator.MoveNext() == true)
                {
                    builder.Append(seperator);
                    builder.Append(enumerator.Current);
                }

                return builder.ToString();
            }
        }
    }
}
