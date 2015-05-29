using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EZMetrology.Linq
{
    public static partial class LinqExtensions
    {
        ///// <summary>
        ///// Wraps the given IEnumarable into a DisposeableEnumerable which ensures that all the disposeables are disposed correctly
        ///// </summary>
        ///// <typeparam name="T">The IDisposeable type</typeparam>
        ///// <param name="enumerable">The enumerable to ensure disposing the elements of</param>
        ///// <returns></returns>
        //public static DisposableEnumerable<TValue> AsDisposableEnumerable<TValue>(
        //    this IEnumerable<TValue> enumerable)
        //    where TValue : IDisposable
        //{
        //    return new DisposableEnumerable<TValue>(enumerable);
        //}


        //public static IEnumerable<TSource> Where<TSource>(
        //    this IEnumerable<TSource> source, 
        //    Func<TSource, Boolean> predicate)
        //    where TSource : IDisposable
        //{
        //    foreach (TSource s in source)
        //    {
        //        if (predicate(s) == true)
        //            yield return s;
        //        else
        //            s.Dispose();
        //    }
        //}
    }

    public class DisposableEnumerable<T> : IEnumerable<T> 
        where T : IDisposable
    {
        public DisposableEnumerable(IEnumerable<T> enumerable)
        {
            this.enumerable = enumerable;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new DisposableEnumerator<T>(enumerable.GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private readonly IEnumerable<T> enumerable;
    }

    public class DisposableEnumerator<T> : IEnumerator<T> 
        where T : IDisposable
    {
        readonly List<T> toBeDisposed = new List<T>();

        private readonly IEnumerator<T> _enumerator;

        public DisposableEnumerator(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
        }

        public void Dispose()
        {
            // dispose the remaining disposeables
            while (_enumerator.MoveNext())
            {
                T current = _enumerator.Current;
                current.Dispose();
            }

            // dispose the provided disposeables
            foreach (T disposeable in toBeDisposed)
            {
                disposeable.Dispose();
            }

            // dispose the internal enumerator
            _enumerator.Dispose();
        }

        public bool MoveNext()
        {
            bool result = _enumerator.MoveNext();

            if (result)
            {
                toBeDisposed.Add(_enumerator.Current);
            }

            return result;
        }

        public void Reset()
        {
            _enumerator.Reset();
        }

        public T Current
        {
            get
            {
                return _enumerator.Current;
            }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
