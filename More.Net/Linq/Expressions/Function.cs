﻿using System;
using System.Linq.Expressions;

namespace More.Net.Linq.Expressions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// From MiscUtil written by Jon with minor bug fixes and modifications.
    /// </remarks>
    public static class Function
    {
        /// <summary>
        /// Create a function delegate representing a unary operation
        /// </summary>
        /// <typeparam name="TArg1">The parameter type</typeparam>
        /// <typeparam name="TResult">The return type</typeparam>
        /// <param name="body">Body factory</param>
        /// <returns>Compiled function delegate</returns>
        public static Func<TArg1, TResult> FromExpression<TArg1, TResult>(
            Func<Expression, UnaryExpression> body)
        {
            ParameterExpression inp = Expression.Parameter(typeof(TArg1), "inp");
            try
            {
                return Expression.Lambda<Func<TArg1, TResult>>(body(inp), inp).Compile();
            }
            catch (Exception ex)
            {
                string msg = ex.Message; // avoid capture of ex itself
                return delegate { throw new InvalidOperationException(msg); };
            }
        }

        /// <summary>
        /// Create a function delegate representing a binary operation
        /// </summary>
        /// <typeparam name="TArg1">The first parameter type</typeparam>
        /// <typeparam name="TArg2">The second parameter type</typeparam>
        /// <typeparam name="TResult">The return type</typeparam>
        /// <param name="body">Body factory</param>
        /// <returns>Compiled function delegate</returns>
        public static Func<TArg1, TArg2, TResult> FromExpression<TArg1, TArg2, TResult>(
            Func<Expression, Expression, BinaryExpression> body)
        {
            return FromExpression<TArg1, TArg2, TResult>(body, false);
        }

        /// <summary>
        /// Create a function delegate representing a binary operation
        /// </summary>
        /// <typeparam name="TArg1">The first parameter type</typeparam>
        /// <typeparam name="TArg2">The second parameter type</typeparam>
        /// <typeparam name="TResult">The return type</typeparam>
        /// <param name="bodyFactory">Body factory</param>
        /// <param name="castArgsToResultOnFailure">
        /// If no matching operation is possible, attempt to convert
        /// TArg1 and TArg2 to TResult for a match? For example, there is no
        /// "decimal operator /(decimal, int)", but by converting TArg2 (int) to
        /// TResult (decimal) a match is found.
        /// </param>
        /// <returns>
        /// Compiled function delegate
        /// </returns>
        public static Func<TArg1, TArg2, TResult> FromExpression<TArg1, TArg2, TResult>(
            Func<Expression, Expression, BinaryExpression> bodyFactory, bool castArgsToResultOnFailure)
        {
            ParameterExpression lhs = Expression.Parameter(typeof(TArg1), "lhs");
            ParameterExpression rhs = Expression.Parameter(typeof(TArg2), "rhs");
            
            try
            {
                try
                {
                    Expression body;

                    if (typeof(TArg1) == typeof(byte) ||
                       typeof(TArg1) == typeof(sbyte) ||
                       typeof(TArg2) == typeof(byte) ||
                       typeof(TArg2) == typeof(sbyte))
                    {
                        body = Expression.Convert(
                            bodyFactory(
                                Expression.Convert(lhs, typeof(Int32)),
                                Expression.Convert(rhs, typeof(Int32))),
                            typeof(TResult));
                    }
                    else
                    {
                        body = bodyFactory(lhs, rhs);
                    }

                    return Expression
                        .Lambda<Func<TArg1, TArg2, TResult>>(body, lhs, rhs)
                        .Compile();
                }
                catch (InvalidOperationException)
                {
                    if (castArgsToResultOnFailure && !(         // if we show retry                                                        
                            typeof(TArg1) == typeof(TResult) &&  // and the args aren't
                            typeof(TArg2) == typeof(TResult)))
                    { // already "TValue, TValue, TValue"...
                        // convert both lhs and rhs to TResult (as appropriate)
                        Expression castLhs = typeof(TArg1) == typeof(TResult) ?
                                (Expression)lhs :
                                (Expression)Expression.Convert(lhs, typeof(TResult));
                        Expression castRhs = typeof(TArg2) == typeof(TResult) ?
                                (Expression)rhs :
                                (Expression)Expression.Convert(rhs, typeof(TResult));

                        return Expression.Lambda<Func<TArg1, TArg2, TResult>>(
                            bodyFactory(castLhs, castRhs), lhs, rhs).Compile();
                    }
                    else throw;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message; // avoid capture of ex itself
                return delegate { throw new InvalidOperationException(msg); };
            }
        }
    }
}
