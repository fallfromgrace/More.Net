using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Media
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICameraDiscovery
    {
        /// <summary>
        /// Discovers all cameras on the local device.
        /// </summary>
        /// <returns></returns>
        IObservable<ICamera> Discover();
    }
}
