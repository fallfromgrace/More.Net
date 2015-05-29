using System;
using System.Reflection;

namespace More.Net.Reflection
{
    /// <summary>
    /// System.Reflection.MethodInfo Extensions
    /// </summary>
    /// <remarks>
    /// Due to the limitations of the C# compiler, we cannot have variadic generic arguments nor 
    /// specify the delegates themselves as a single generic parameter.  Therefore, we must 
    /// essentially copy-paste each overload.
    /// </remarks>
    public static partial class MethodInfoExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Action CreateAction(
            this MethodInfo source)
        {
            return source.CreateDelegate(d => (Action)d);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TParam1"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Action<TParam1> CreateAction<TParam1>(
            this MethodInfo source)
        {
            return source.CreateDelegate(d => (Action<TParam1>)d);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TParam1"></typeparam>
        /// <typeparam name="TParam2"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Action<TParam1, TParam2> CreateAction<TParam1, TParam2>(
            this MethodInfo source)
        {
            return source.CreateDelegate(d => (Action<TParam1, TParam2>)d);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static Action CreateAction<TTarget>(this MethodInfo source, TTarget target)
        {
            return source.CreateDelegate(d => (Action)d, target);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TParam1"></typeparam>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static Action<TParam1> CreateAction<TParam1, TTarget>(
            this MethodInfo source,
            TTarget target)
        {
            return source.CreateDelegate(d => (Action<TParam1>)d, target);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TParam1"></typeparam>
        /// <typeparam name="TParam2"></typeparam>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static Action<TParam1, TParam2> CreateAction<TParam1, TParam2, TTarget>(
            this MethodInfo source,
            TTarget target)
        {
            return source.CreateDelegate(d => (Action<TParam1, TParam2>)d, target);
        }
    }
}
