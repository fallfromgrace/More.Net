using System;
using System.Reactive.Disposables;

namespace EZMetrology
{
    /// <summary>
    /// Extensions for IDisposable using reactive extensions.
    /// </summary>
    public static class DisposableExtensions
    {
        /// <summary>
        /// Adds the disposable object to a CompositeDisposable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="disposable"></param>
        /// <param name="cd"></param>
        public static void DisposeWith<TDisposable>(
            this TDisposable disposable, 
            CompositeDisposable cd)
            where TDisposable : IDisposable
        {
            cd.Add(disposable);
        }
    }
}
