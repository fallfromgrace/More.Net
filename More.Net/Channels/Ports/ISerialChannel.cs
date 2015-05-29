using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Channels.Ports
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISerialChannel : IChannel
    {
        /// <summary>
        /// 
        /// </summary>
        Int32 Baudrate { get; }

        ///// <summary>
        ///// 
        ///// </summary>
        //Int32 DataBits { get; }

        ///// <summary>
        ///// 
        ///// </summary>
        //Int32 HandShake { get; }

        ///// <summary>
        ///// 
        ///// </summary>
        //Int32 Parity { get; }

        /// <summary>
        /// 
        /// </summary>
        String Port { get; }

        ///// <summary>
        ///// 
        ///// </summary>
        //Int32 StopBits { get; }
    }
}
