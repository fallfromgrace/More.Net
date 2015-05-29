using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;

namespace Light.Channels
{
    /// <summary>
    /// 
    /// </summary>
    public interface IChannel
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean IsConnected { get; }

        /// <summary>
        /// Asynchronously attempts to connect to the channel, returning a stream.
        /// </summary>
        /// <returns></returns>
        IObservable<IChannelStream> ConnectAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IObservable<Unit> CloseAsync();
    }
}
