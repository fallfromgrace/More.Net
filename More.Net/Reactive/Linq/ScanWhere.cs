using System;
using System.Reactive.Linq;

namespace EZMetrology.Reactive.Linq
{
    public static partial class ObservableExtensions
    {

        /// <summary>
        /// Combines the scan and where functionality into one.  Applies an accumulator function to 
        /// each element and evaluates both the element and intermediate result based on a 
        /// predicate. 
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="source"></param>
        /// <param name="accumulator"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static IObservable<TValue> ScanWhere<TValue>(
            this IObservable<TValue> source,
            Func<TValue, TValue, TValue> accumulator,
            Func<TValue, TValue, Boolean> predicate)
        {
            return Observable.Create<TValue>(observer =>
            {
                TValue accumulated = default(TValue);
                Boolean previousSet = false;
                return source.Subscribe(v =>
                {
                    if (previousSet == false)
                    {
                        accumulated = v;
                        previousSet = true;
                    }
                    else
                    {
                        accumulated = accumulator(accumulated, v);
                        if (predicate(accumulated, v))
                            observer.OnNext(v);
                    }
                });
            });
        }
    }
}
