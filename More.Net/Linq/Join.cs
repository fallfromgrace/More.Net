using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Linq
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// Performs the same action as String.Join
        /// </summary>
        /// <param name="source"></param>
        /// <param name="seperator"></param>
        /// <returns></returns>
        public static String StringJoin<TValue>(
            this IEnumerable<TValue> source,
            String seperator)
        {
            Contract.Requires(source != null);
            Contract.Requires(seperator != null);

            StringBuilder result = new StringBuilder();

            using (IEnumerator<TValue> enumerator = source.GetEnumerator())
            {
                if (enumerator.MoveNext() == true)
                    result.Append(enumerator.Current.ToString());

                while (enumerator.MoveNext() == true)
                {
                    result.Append(seperator);
                    result.Append(enumerator.Current.ToString());
                }
            }

            return result.ToString();
        }
    }
}
