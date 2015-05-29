using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Linq
{
    public static partial class LinqExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="aggregator"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> Scan<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, TSource, TSource> aggregator)
        {
            using (IEnumerator<TSource> sourceEnumerator = source.GetEnumerator())
            {
                if (sourceEnumerator.MoveNext() == false)
                    throw new InvalidOperationException("Sequence contains no elements.");
                TSource aggregate = sourceEnumerator.Current;
                while (sourceEnumerator.MoveNext())
                {
                    aggregate = aggregator(aggregate, sourceEnumerator.Current);
                    yield return aggregate;
                }
            }
        }
    }
}
