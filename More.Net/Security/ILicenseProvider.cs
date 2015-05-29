using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Security
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILicenseProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ILicense Open();
    }
}
