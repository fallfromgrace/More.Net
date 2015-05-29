using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace More.Net.Reactive.Linq
{
    public static partial class ObservableExtensions
    {
        public static IObservable<TOut> Drain<TSource, TOut>(
            this IObservable<TSource> source,
            Func<TSource, IObservable<TOut>> selector)
        {
            return Observable.Defer(() =>
            {
                BehaviorSubject<Unit> queue = new BehaviorSubject<Unit>(Unit.Default);

                return source
                    .Zip(queue, (v, q) => v)
                    .SelectMany(v => selector(v)
                        .Do(_ => { }, () => queue.OnNext(Unit.Default))
                    );
            });
        }
    }
}
