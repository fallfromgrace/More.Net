using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Reactive.Threading.Tasks;

namespace EZMetrology.Reactive.Linq
{
    public static class ObservableEx
    {
        //public static IObservable<Unit> FromAsyncPattern<TArg1>(
        //    Func<TArg1, AsyncCallback, Object, IAsyncResult> begin,
        //    Action<IAsyncResult> end,
        //    TArg1 arg1,
        //    Object state)
        //{
        //    //return Task.Factory.FromAsync(begin, end, arg1, state).ToObservable();

        //    return System.Reactive.Linq.Observable.Create<Unit>(observer => 
        //    {
        //        IAsyncResult result = begin(
        //            arg1,
        //            new AsyncCallback(iar =>
        //            {
        //                try
        //                {

        //                    end(iar);
        //                }
        //                catch (Exception ex)
        //                {
        //                    observer.OnError(ex);
        //                }
        //                observer.OnNext(Unit.Default);
        //                observer.OnCompleted();
        //            }),
        //            state);
        //    });
        //}
    }
}
