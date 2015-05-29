using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace More.Net.Reactive.Linq
{
    public static partial class ObservableExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="interval"></param>
        /// <returns></returns>
        public static IObservable<T> Pace<T>(
            this IObservable<T> source, 
            TimeSpan interval)
        {
            return source
                .Select(i => Observable
                    .Empty<T>()
                    .Delay(interval)
                    .StartWith(i))
                .Concat();

        }
    }
}
