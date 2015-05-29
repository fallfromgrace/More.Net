using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light.Reactive.Linq
{
    public static partial class Either
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource1"></typeparam>
        /// <typeparam name="TSource2"></typeparam>
        /// <param name="source"></param>
        /// <param name="onNext1"></param>
        /// <param name="onNext2"></param>
        /// <param name="onError"></param>
        /// <param name="onCompleted"></param>
        /// <returns></returns>
        public static IDisposable Subscribe<TSource1, TSource2>(
            this IObservable<IEither<TSource1, TSource2>> source,
            Action<TSource1> onNext1,
            Action<TSource2> onNext2,
            Action<Exception> onError,
            Action onCompleted)
        {
            return source.Subscribe(
                next => next.Switch(onNext1, onNext2),
                onError,
                onCompleted);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource1"></typeparam>
        /// <typeparam name="TSource2"></typeparam>
        /// <typeparam name="TSource3"></typeparam>
        /// <param name="source"></param>
        /// <param name="onNext1"></param>
        /// <param name="onNext2"></param>
        /// <param name="onNext3"></param>
        /// <param name="onError"></param>
        /// <param name="onCompleted"></param>
        /// <returns></returns>
        public static IDisposable Subscribe<TSource1, TSource2, TSource3>(
            this IObservable<IEither<TSource1, TSource2, TSource3>> source,
            Action<TSource1> onNext1,
            Action<TSource2> onNext2,
            Action<TSource3> onNext3,
            Action<Exception> onError,
            Action onCompleted)
        {
            return source.Subscribe(
                next => next.Switch(onNext1, onNext2, onNext3),
                onError,
                onCompleted);
        }
    }
}
