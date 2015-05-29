using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Security
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILicenseProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TLicenseTerms"></typeparam>
        /// <returns></returns>
        ILicense Open();
    }
}
