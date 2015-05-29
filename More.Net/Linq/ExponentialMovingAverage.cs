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
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<Double> ExponentialMovingAverage(
            this IEnumerable<Double> source, 
            Int32 count)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (count <= 0)
                throw new ArgumentOutOfRangeException("count", "Invalid sample length");

            using (IEnumerator<Double> sourceEnumerator = source.GetEnumerator())
            {
                Double average;
                Double alpha;
                Double beta;
                if (sourceEnumerator.MoveNext())
                {
                    alpha = 2.0d / (count + 1.0d);
                    beta = 1 - alpha;
                    average = sourceEnumerator.Current;
                    yield return average;
                    while (sourceEnumerator.MoveNext())
                    {
                        average = (alpha * sourceEnumerator.Current) + (beta * average);
                        yield return average;
                    }
                }
            }
        }
    }
}

