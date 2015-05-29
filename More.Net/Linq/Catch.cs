using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Linq
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class LinqExtensions
    {
        /// <summary>
        /// Catches all exceptions.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> Catch<TSource>(
            this IEnumerable<TSource> source)
        {
            using (IEnumerator<TSource> enumerator = source.GetEnumerator())
            {
                for (; ; )
                {
                    Boolean moved = false;
                    Boolean exception = false;
                    try
                    {
                        moved = enumerator.MoveNext();
                    }
                    catch (Exception)
                    {
                        exception = true;
                        moved = true;
                    }

                    if (moved == false)
                        break;
                    if (moved == true && exception == false)
                        yield return enumerator.Current;
                }
            }
        }

        /// <summary>
        /// Catches all exceptions of the specified type.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TException"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> Catch<TSource, TException>(
            this IEnumerable<TSource> source)
            where TException : Exception
        {
            using (IEnumerator<TSource> enumerator = source.GetEnumerator())
            {
                for (; ; )
                {
                    Boolean moved = false;
                    Boolean exception = false;
                    try
                    {
                        moved = enumerator.MoveNext();
                    }
                    catch (TException)
                    {
                        exception = true;
                        moved = true;
                    }

                    if (moved == false)
                        break;
                    if (moved == true && exception == false)
                        yield return enumerator.Current;
                }
            }
        }

        /// <summary>
        /// Catches all exceptions of the specified type, and specified callback.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TException"></typeparam>
        /// <param name="source"></param>
        /// <param name="onError"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> Catch<TSource, TException>(
            this IEnumerable<TSource> source,
            Action<TException> onError)
            where TException : Exception
        {
            using (IEnumerator<TSource> enumerator = source.GetEnumerator())
            {
                for (; ; )
                {
                    Boolean moved = false;
                    Boolean exception = false;
                    try
                    {
                        moved = enumerator.MoveNext();
                    }
                    catch (TException ex)
                    {
                        exception = true;
                        moved = true;
                        onError(ex);
                    }

                    if (moved == false)
                        break;
                    if (moved == true && exception == false)
                        yield return enumerator.Current;
                }
            }
        }
    }
}
