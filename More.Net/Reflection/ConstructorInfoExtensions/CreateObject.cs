using System;
using System.Linq.Expressions;
using System.Reflection;

namespace More.Net.Reflection
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class ConstructorInfoExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Func<TResult> CreateFactory<TResult>(
            this ConstructorInfo source)
        {
            Expression constructor = Expression.New(source);
            return Expression.Lambda<Func<TResult>>(constructor).Compile();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TParam1"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Func<TParam1, TResult> CreateFactory<TParam1, TResult>(
            this ConstructorInfo source)
        {
            ParameterExpression parameter1 = Expression.Parameter(typeof(TParam1));
            NewExpression constructor = Expression.New(source, parameter1);
            return Expression.Lambda<Func<TParam1, TResult>>(constructor, parameter1).Compile();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TParam1"></typeparam>
        /// <typeparam name="TParam2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Func<TParam1, TParam2, TResult> CreateFactory<TParam1, TParam2, TResult>(
            this ConstructorInfo source)
        {
            ParameterExpression parameter1 = Expression.Parameter(typeof(TParam1));
            ParameterExpression parameter2 = Expression.Parameter(typeof(TParam2));
            NewExpression constructor = Expression.New(source, parameter1, parameter2);
            return Expression
                .Lambda<Func<TParam1, TParam2, TResult>>(constructor, parameter1, parameter2)
                .Compile();
        }
    }
}
