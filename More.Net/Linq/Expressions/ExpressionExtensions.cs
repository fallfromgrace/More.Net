using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Reflection;

namespace More.Net.Linq.Expressions
{
    /// <summary>
    /// 
    /// </summary>
    public static class ExpressionExtensions
    {        
        /// <summary>
        /// Gets the dot seperated property path for the given property expression.  Ignores 
        /// any implicit or explicit casts.
        /// </summary>
        /// <typeparam name="TSource">Source type.</typeparam>
        /// <typeparam name="TProperty">Property type.</typeparam>
        /// <param name="propertyExpression">
        /// Expression that selects the desired property.
        /// </param>
        /// <returns></returns>
        public static String GetPropertyPath<TSource, TProperty>(
            this Expression<Func<TSource, TProperty>> propertyExpression)
        {
            if (propertyExpression == null)
                throw new ArgumentNullException("propertyExpression");

            MemberExpression memberExpression = propertyExpression.Body.GetMemberExpression();
            Stack<String> memberNames = new Stack<String>();

            while (memberExpression != null)
            {
                memberNames.Push(memberExpression.Member.Name);
                memberExpression = memberExpression.Expression.GetMemberExpression();
            }

            return memberNames.StringJoin(".");
        }

        /// <summary>
        /// Gets a MemberExpression from the specified expression, if any exists.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static MemberExpression GetMemberExpression(this Expression expression)
        {
            MemberExpression memberExpression = expression as MemberExpression;
            if (memberExpression == null)
            {
                UnaryExpression unaryExpression = expression as UnaryExpression;
                if (unaryExpression != null &&
                    (unaryExpression.NodeType == ExpressionType.Convert ||
                    unaryExpression.NodeType == ExpressionType.ConvertChecked))
                {
                    memberExpression = unaryExpression.Operand as MemberExpression;
                }
            }

            return memberExpression;
        }
    }
}
