using System;
using System.Collections.Generic;

namespace Light.Channels
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWriteStream : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean CanWrite { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        IObservable<Int32> WriteAsync(IReadOnlyList<Byte> buffer);
    }
}
