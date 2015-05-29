using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace More.Net
{
    public static class ByteArrayExtensions
    {
        //public static unsafe Int32 ToInt32(this IEnumerable<Byte> source, Boolean isLittleEndian)
        //{
        //    Contract.Requires(source != null);

        //    Byte[] buffer = source.Take(sizeof(Int32)).ToArray();
        //    fixed (Byte* pbuffer = &buffer[0])
        //        return *((Int32*)pbuffer);
        //}

        ////public static Int32 SizeOf<TSource>()
        ////{
        ////    if (typeof(TSource) == typeof(Char))
        ////        return sizeof(Char);
        ////    else if (typeof(Enum).IsAssignableFrom(typeof(TSource)))
        ////        return Marshal.SizeOf(Enum.GetUnderlyingType(typeof(TSource)));
        ////    else
        ////        return Marshal.SizeOf(typeof(TSource));
        ////}

        //public static unsafe Int32 To<TResult>(
        //    this IEnumerable<Byte> source)
        //    where TResult: struct
        //{
        //    Contract.Requires(source != null);

        //    Byte[] buffer = source.Take(sizeof(Int32)).ToArray();
        //    fixed (Byte* pbuffer = &buffer[0])
        //        return *((Int32*)pbuffer);
        //}
    }
}
