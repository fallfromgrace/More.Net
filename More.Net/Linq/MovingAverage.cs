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
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<Double> MovingAverage(this IEnumerable<Double> source, Int32 count)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (count <= 0)
                throw new ArgumentException("Invalid sample length");

            using (IEnumerator<Double> sourceEnumerator = source.GetEnumerator())
            {
                Queue<Double> sampleBuffer = new Queue<Double>(count);
                while (sampleBuffer.Count < count && sourceEnumerator.MoveNext())
                    sampleBuffer.Enqueue(sourceEnumerator.Current);

                while (sourceEnumerator.MoveNext())
                {
                    yield return sampleBuffer.Average();
                    sampleBuffer.Dequeue();
                    sampleBuffer.Enqueue(sourceEnumerator.Current);
                }
            }
        }
    }
}
