using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Linq
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class LinqExtensions
    {
        /// <summary>
        /// Curry first argument.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="F"></param>
        /// <returns></returns>
        public static Func<T1, Func<T2, TResult>> Curry<T1, T2, TResult>(Func<T1, T2, TResult> F)
        {
            return t1 => t2 => F(t1, t2);
        }

        /// <summary>
        /// Curry second argument.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="F"></param>
        /// <returns></returns>
        public static Func<T2, Func<T1, TResult>> Curry2nd<T1, T2, TResult>(Func<T1, T2, TResult> F)
        {
            return t2 => t1 => F(t1, t2);
        }

        /// <summary>
        /// Uncurry first argument.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="F"></param>
        /// <returns></returns>
        public static Func<T1, T2, TResult> Uncurry<T1, T2, TResult>(Func<T1, Func<T2, TResult>> F)
        {
            return (t1, t2) => F(t1)(t2);
        }

        /// <summary>
        /// Uncurry second argument.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="F"></param>
        /// <returns></returns>
        public static Func<T1, T2, TResult> Uncurry2nd<T1, T2, TResult>(Func<T2, Func<T1, TResult>> F)
        {
            return (t1, t2) => F(t2)(t1);
        }
    }
}
