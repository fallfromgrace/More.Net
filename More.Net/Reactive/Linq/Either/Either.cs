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
    /// <summary>
    /// 
    /// </summary>
    public static partial class Either
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TItem1"></typeparam>
        /// <typeparam name="TItem2"></typeparam>
        /// <returns></returns>
        public static IEitherFactory<TItem1, TItem2> Factory<TItem1, TItem2>()
        {
            return new EitherFactory<TItem1, TItem2>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult1"></typeparam>
        /// <typeparam name="TResult2"></typeparam>
        /// <param name="subscribe"></param>
        /// <returns></returns>
        public static IObservable<IEither<TResult1, TResult2>> CreateObservable<TResult1, TResult2>(
            Func<IObserver<IEither<TResult1, TResult2>>, Action> subscribe)
        {
            Contract.Requires(subscribe != null);
            Contract.Ensures(Contract.Result<IObservable<IEither<TResult1, TResult2>>>() != null);

            return Observable.Create<IEither<TResult1, TResult2>>(subscribe);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult1"></typeparam>
        /// <typeparam name="TResult2"></typeparam>
        /// <param name="subscribe"></param>
        /// <returns></returns>
        public static IObservable<IEither<TResult1, TResult2>> CreateObservable<TResult1, TResult2>(
            Func<IObserver<IEither<TResult1, TResult2>>, IDisposable> subscribe)
        {
            Contract.Requires(subscribe != null);
            Contract.Ensures(Contract.Result<IObservable<IEither<TResult1, TResult2>>>() != null);

            return Observable.Create<IEither<TResult1, TResult2>>(subscribe);
        }

        //public static IObservable<IEither<TResult1, TResult2>> Split<TSource, TResult1, TResult2>(
        //    this IObservable<TSource> source,
        //    Func<
        //        TSource, 
        //        Func<TResult1, IEither<TResult1, TResult2>>, 
        //        Func<TResult2, IEither<TResult1, TResult2>>,
        //        IEither<TResult1, TResult2>> selector)
        //{

        //}

        //public interface IEitherObserver<TValue1, TValue2>
        //{
        //    void OnNext1(TValue1 value);
        //    void OnNext2(TValue2 value);
        //    void OnExcetion(Exception ex);
        //    void OnCompleted();
        //}

        //public static IObservable<IEither<TResult1, TResult2>> Create<TResult1, TResult2>(
        //    Func<IEitherObserver<TResult1, TResult2>, Action> subscribe)
        //{

        //}
    }
}
