using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net
{
    ///// <summary>
    ///// 
    ///// </summary>
    //public static class ObjectExtensions
    //{
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <typeparam name="TSource"></typeparam>
    //    /// <typeparam name="TField1"></typeparam>
    //    /// <param name="source"></param>
    //    /// <param name="field1"></param>
    //    /// <returns></returns>
    //    public static Int32 GetHashCode<TSource, TField1>(
    //        this TSource source, 
    //        TField1 field1)
    //    {
    //        unchecked
    //        {
    //            Int32 hash = 17;
    //            if (field1 != null)
    //                hash = hash * 23 + field1.GetHashCode();
    //            return hash;
    //        }
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <typeparam name="TSource"></typeparam>
    //    /// <typeparam name="TField1"></typeparam>
    //    /// <typeparam name="TField2"></typeparam>
    //    /// <param name="source"></param>
    //    /// <param name="field1"></param>
    //    /// <param name="field2"></param>
    //    /// <returns></returns>
    //    public static Int32 GetHashCode<TSource, TField1, TField2>(
    //        this TSource source, 
    //        TField1 field1, 
    //        TField2 field2)
    //    {
    //        // Overflow is fine, just wrap
    //        unchecked
    //        {
    //            Int32 hash = source.GetHashCode(field1);
    //            if (field2 != null)
    //                hash = hash * 23 + field2.GetHashCode();
    //            return hash;
    //        }
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <typeparam name="TSource"></typeparam>
    //    /// <typeparam name="TField1"></typeparam>
    //    /// <typeparam name="TField2"></typeparam>
    //    /// <typeparam name="TField3"></typeparam>
    //    /// <param name="source"></param>
    //    /// <param name="field1"></param>
    //    /// <param name="field2"></param>
    //    /// <param name="field3"></param>
    //    /// <returns></returns>
    //    public static Int32 GetHashCode<TSource, TField1, TField2, TField3>(
    //        this TSource source,
    //        TField1 field1,
    //        TField2 field2,
    //        TField3 field3)
    //    {
    //        // Overflow is fine, just wrap
    //        unchecked
    //        {
    //            Int32 hash = source.GetHashCode(field1, field2);
    //            if (field3 != null)
    //                hash = hash * 23 + field3.GetHashCode();
    //            return hash;
    //        }
    //    }
    //}
}
