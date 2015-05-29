using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace Light.Channels
{
    /// <summary>
    /// 
    /// </summary>
    public static class WriteStreamExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TWriteStream"></typeparam>
        /// <param name="source"></param>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static IObservable<Int32> WriteUntilEnd<TWriteStream>(
            this TWriteStream source,
            IObservable<IReadOnlyList<Byte>> stream)
            where TWriteStream : IWriteStream
        {
            return stream
                .SelectMany(view => source.WriteAsync(view))
                //.Synchronize()
                .Aggregate((total, next) => total + next);
        }
    }
}
