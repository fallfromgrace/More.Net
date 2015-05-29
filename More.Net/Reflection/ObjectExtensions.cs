using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Reflection;
using More.Net.Linq.Expressions;

namespace More.Net.Reflection
{
    public static class ObjectExtensions
    {

        public static TProperty GetPropertyValue<TSource, TProperty>(
            this TSource source,
            Expression<Func<TSource, TProperty>> propertyExpression)
        {
            return (TProperty)source
                .GetPropertyInfo(propertyExpression)
                .GetValue((Object)source);
        }

        public static void SetPropertyValue<TSource, TProperty>(
            this TSource source,
            Expression<Func<TSource, TProperty>> propertyExpression,
            TProperty value)
        {
            source
                .GetPropertyInfo(propertyExpression)
                .SetValue((Object)source, (Object)value);
        }

        public static PropertyInfo GetPropertyInfo<TSource, TProperty>(
            this TSource source,
            Expression<Func<TSource, TProperty>> propertyExpression)
        {
            if (propertyExpression == null)
                throw new ArgumentNullException("propertyExpression");

            MemberExpression memberExpression = propertyExpression.Body.GetMemberExpression();
            if (memberExpression == null)
                throw new ArgumentException("propertyExpression does not select a property.");

            PropertyInfo propertyInfo = memberExpression.Member as PropertyInfo;
            if (propertyInfo == null)
                throw new ArgumentException("propertyExpression does not select a property.");

            return propertyInfo;
        }
    }
}
