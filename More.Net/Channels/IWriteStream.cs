using System;
using System.Collections.Generic;

namespace More.Net.Channels
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
        /// <returns></returns>
        IObservable<Int32> WriteAsync(IReadOnlyList<Byte> buffer);
    }
}
