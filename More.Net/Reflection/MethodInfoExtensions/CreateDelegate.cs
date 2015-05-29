using System;
using System.Reflection;

namespace EZMetrology.Reflection
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class MethodInfoExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TDelegate"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static TDelegate CreateDelegate<TDelegate>(
            this MethodInfo source,
            Func<Delegate, TDelegate> selector)
            where TDelegate : class
        {
            return selector(source.CreateDelegate(typeof(TDelegate)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TDelegate"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static TDelegate CreateDelegate<TTarget, TDelegate>(
            this MethodInfo source, 
            Func<Delegate, TDelegate> selector,
            TTarget target)
            where TDelegate : class
        {
            return selector(source.CreateDelegate(typeof(TDelegate), target));
        }
    }
}
