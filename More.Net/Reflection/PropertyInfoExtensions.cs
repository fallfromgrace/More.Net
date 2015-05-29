using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace EZMetrology.Reflection
{
    public static class PropertyInfoExtensions
    {

        public static TProperty GetValue<TProperty>(
            this PropertyInfo propertyInfo,
            Object source)
        {
            return (TProperty)propertyInfo.GetValue(source);
        }

        public static TProperty GetValue<TSource, TProperty>(
            this PropertyInfo propertyInfo, 
            TSource source)
        {
            return propertyInfo.GetValue<TProperty>((Object)source);
        }

        public static void SetValue<TSource, TProperty>(
            this PropertyInfo propertyInfo,
            TSource source,
            TProperty value)
        {
            propertyInfo.SetValue((Object)source, (Object)value);
        }
    }
}
