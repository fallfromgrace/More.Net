using System;
using System.Collections.Generic;
using System.Reactive.Linq;

namespace Light.Channels
{
    /// <summary>
    /// 
    /// </summary>
    public static class IReadStreamExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TReadStream"></typeparam>
        /// <param name="readStream"></param>
        /// <returns></returns>
        public static IObservable<ArrayView<Byte>> ReadUntilEnd<TReadStream>(
            this TReadStream readStream)
            where TReadStream : IReadStream
        {
            return readStream
                .ReadAsync()
                .Repeat()
                .TakeWhile(view => view.Count > 0);
        }
    }
}
