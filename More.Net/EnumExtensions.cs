using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Light
{
    /// <summary>
    /// 
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetFlags<T>(this Enum value)
        {
            Contract.Requires(value != null);

            return Enum
                .GetValues(typeof(T))
                .OfType<Enum>()
                .Where(value.HasFlag)
                .Cast<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <param name="flags"></param>
        /// <returns></returns>
        public static Boolean HasFlags<TEnum>(this Enum value, params TEnum[] flags)
        {
            Contract.Requires(value != null);

            return flags
                .OfType<Enum>()
                .All(flag => value.HasFlag(flag));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Int32 ToInt32(this Enum value)
        {
            return Convert.ToInt32(value);
        }
    }
}
