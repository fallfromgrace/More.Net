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
        /// One argument Y-Combinator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="F"></param>
        /// <returns></returns>
        public static Func<T, TResult> Y<T, TResult>(Func<Func<T, TResult>, Func<T, TResult>> F)
        {
            return t => F(Y(F))(t);
        }

        /// <summary>
        /// Two argument Y-Combinator.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="F"></param>
        /// <returns></returns>
        public static Func<T1, T2, TResult> Y<T1, T2, TResult>(Func<Func<T1, T2, TResult>, Func<T1, T2, TResult>> F)
        {
            return (t1, t2) => F(Y(F))(t1, t2);
        }

        /// <summary>
        /// Three argument Y-Combinator.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="F"></param>
        /// <returns></returns>
        public static Func<T1, T2, T3, TResult> Y<T1, T2, T3, TResult>(Func<Func<T1, T2, T3, TResult>, Func<T1, T2, T3, TResult>> F)
        {
            return (t1, t2, t3) => F(Y(F))(t1, t2, t3);
        }

        /// <summary>
        /// Four argument Y-Combinator.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="F"></param>
        /// <returns></returns>
        public static Func<T1, T2, T3, T4, TResult> Y<T1, T2, T3, T4, TResult>(Func<Func<T1, T2, T3, T4, TResult>, Func<T1, T2, T3, T4, TResult>> F)
        {
            return (t1, t2, t3, t4) => F(Y(F))(t1, t2, t3, t4);
        }
    }
}
