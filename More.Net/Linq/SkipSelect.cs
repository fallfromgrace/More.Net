using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Linq
{
    public static partial class LinqExtensions
    {
        /// <summary>
        /// Returns the result of combining each nth element and (n+skip)th element.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <param name="skipCount"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> SkipSelect<TSource, TResult>(
            this IEnumerable<TSource> source,
            Int32 skipCount, Func<TSource, TSource, TResult> selector)
        {
            using (IEnumerator<TSource> sourceEnumerator = source.GetEnumerator())
            using (IEnumerator<TSource> skipEnumerator = source.Skip(skipCount).GetEnumerator())
            {
                while (sourceEnumerator.MoveNext() && skipEnumerator.MoveNext())
                    yield return selector(sourceEnumerator.Current, skipEnumerator.Current);
            }
        }
    }
}
