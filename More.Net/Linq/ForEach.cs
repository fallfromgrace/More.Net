using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace More.Net.Linq
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class LinqExtensions
    {
        /// <summary>
        /// Immediately executes the given action on each element in the source sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements in the sequence</typeparam>
        /// <param name="source">The sequence of elements</param>
        /// <param name="action">The action to execute on each element</param>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="action"/> is null.</exception>
        public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            Contract.Requires(source != null, "source cannot be null.");
            Contract.Requires(action != null, "action cannot be null.");

            foreach (TSource element in source)
                action(element);
        }

        ///// <summary>
        ///// Immediately executes the given action on each element in the source sequence.
        ///// </summary>
        ///// <typeparam name="T">The type of the elements in the sequence</typeparam>
        ///// <param name="source">The sequence of elements</param>
        ///// <param name="action">The action to execute on each element</param>
        ///// <exception cref="ArgumentNullException">
        ///// <paramref name="source"/> or <paramref name="selector"/> is null.
        ///// </exception>
        //public static void UsingEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        //    where TSource : IDisposable
        //{
        //    Contract.Requires(source != null, "source cannot be null.");
        //    Contract.Requires(action != null, "action cannot be null.");

        //    foreach (TSource element in source)
        //        using (element)
        //            action(element);
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <typeparam name="TSource">The type of the elements in the sequence</typeparam>
        ///// <param name="source">The sequence of elements</param>
        ///// <param name="action">The action to execute on each element</param>
        ///// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
        //public static IEnumerable<TResult> SelectUsing<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        //    where TResult : IDisposable
        //{
        //    if (source == null)
        //        throw new ArgumentNullException("source");
        //    if (selector == null)
        //        throw new ArgumentNullException("action");

        //    foreach (TSource sourceElement in source)
        //        using (TResult resultElement = selector(sourceElement))
        //            yield return resultElement;
        //}
    }
}
