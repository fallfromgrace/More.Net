using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;

namespace More.Net.Channels.Experimental
{
    public interface IBluetoothChannel : IChannel
    {
        IObservable<Unit> AuthenticateAsync(String key);
    }
}
