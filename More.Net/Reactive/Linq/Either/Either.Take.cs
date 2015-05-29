using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Reactive.Linq;

namespace More.Net.Reactive.Linq
{
    public static partial class Either
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource1"></typeparam>
        /// <typeparam name="TSource2"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IObservable<TSource1> TakeFirstType<TSource1, TSource2>(
            this IObservable<IEither<TSource1, TSource2>> source)
        {
            return Observable.Create<TSource1>(
                observer =>
                {
                    return source.Subscribe(
                        observer.OnNext,
                        next2 => { },
                        observer.OnError,
                        observer.OnCompleted);
                });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource1"></typeparam>
        /// <typeparam name="TSource2"></typeparam>
        /// <typeparam name="TSource3"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IObservable<TSource1> TakeFirstType<TSource1, TSource2, TSource3>(
            this IObservable<IEither<TSource1, TSource2, TSource3>> source)
        {
            return Observable.Create<TSource1>(
                observer =>
                {
                    return source.Subscribe(
                        observer.OnNext,
                        next2 => { },
                        next3 => { },
                        observer.OnError,
                        observer.OnCompleted);
                });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource1"></typeparam>
        /// <typeparam name="TSource2"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IObservable<TSource2> TakeSecondType<TSource1, TSource2>(
            this IObservable<IEither<TSource1, TSource2>> source)
        {
            return Observable.Create<TSource2>(
                observer =>
                {
                    return source.Subscribe(
                        next1 => { },
                        observer.OnNext,
                        observer.OnError,
                        observer.OnCompleted);
                });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource1"></typeparam>
        /// <typeparam name="TSource2"></typeparam>
        /// <typeparam name="TSource3"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IObservable<TSource2> TakeSecondType<TSource1, TSource2, TSource3>(
            this IObservable<IEither<TSource1, TSource2, TSource3>> source)
        {
            return Observable.Create<TSource2>(
                observer =>
                {
                    return source.Subscribe(
                        next1 => { },
                        observer.OnNext,
                        next3 => { },
                        observer.OnError,
                        observer.OnCompleted);
                });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource1"></typeparam>
        /// <typeparam name="TSource2"></typeparam>
        /// <typeparam name="TSource3"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IObservable<TSource3> TakeThirdType<TSource1, TSource2, TSource3>(
            this IObservable<IEither<TSource1, TSource2, TSource3>> source)
        {
            return Observable.Create<TSource3>(
                observer =>
                {
                    return source.Subscribe(
                        next1 => { },
                        next2 => { },
                        observer.OnNext,
                        observer.OnError,
                        observer.OnCompleted);
                });
        }
    }
}
