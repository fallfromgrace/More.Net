using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Linq
{
    public static partial class LinqExtensions
    {
        public static IEnumerable<T> SkipLast<T>(this IEnumerable<T> source, int count)
        {
            var enumerator = source.GetEnumerator();
            var queue = new Queue<T>(count + 1);

            while (true)
            {
                if (!enumerator.MoveNext())
                    break;
                queue.Enqueue(enumerator.Current);
                if (queue.Count > count)
                    yield return queue.Dequeue();
            }
        }
    }
}
