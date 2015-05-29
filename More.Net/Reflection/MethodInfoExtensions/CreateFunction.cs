using System;
using System.Reflection;

namespace More.Net.Reflection
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class MethodInfoExtensions
    {
        /// <summary>
        /// Creates a function that takes no parameters and returns the specified type from the 
        /// specified static method.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Func<TResult> CreateFunction<TResult>(
            this MethodInfo source)
        {
            return source.CreateDelegate(d => (Func<TResult>)d);
        }

        /// <summary>
        /// Creates a function that takes one parameters and returns the specified type from the 
        /// specified static or instance method.
        /// </summary>
        /// <typeparam name="TParam1"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Func<TParam1, TResult> CreateFunction<TParam1, TResult>(
            this MethodInfo source)
        {
            return source.CreateDelegate(d => (Func<TParam1, TResult>)d);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TParam1"></typeparam>
        /// <typeparam name="TParam2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Func<TParam1, TParam2, TResult> CreateFunction<TParam1, TParam2, TResult>(
            this MethodInfo source)
        {
            return source.CreateDelegate(d => (Func<TParam1, TParam2, TResult>)d);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static Func<TResult> CreateFunction<TResult, TTarget>(
            this MethodInfo source,
            TTarget target)
        {
            return source.CreateDelegate(d => (Func<TResult>)d, target);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TParam1"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static Func<TParam1, TResult> CreateFunction<TParam1, TResult, TTarget>(
            this MethodInfo source,
            TTarget target)
        {
            return source.CreateDelegate(d => (Func<TParam1, TResult>)d, target);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TParam1"></typeparam>
        /// <typeparam name="TParam2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static Func<TParam1, TParam2, TResult> CreateFunction<TParam1, TParam2, TResult, TTarget>(
            this MethodInfo source,
            TTarget target)
        {
            return source.CreateDelegate(d => (Func<TParam1, TParam2, TResult>)d, target);
        }
    }
}
