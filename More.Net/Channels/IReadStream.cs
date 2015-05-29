using System;
using System.Collections.Generic;

namespace More.Net.Channels
{
    /// <summary>
    /// 
    /// </summary>
    public interface IReadStream : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean CanRead { get; }

        /// <summary>
        /// 
        /// </summary>
        Int32 ReadBufferSize { get; }

        ///// <summary>
        ///// 
        ///// </summary>
        //Boolean DataAvailable { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IObservable<ArrayView<Byte>> ReadAsync();
    }
}
