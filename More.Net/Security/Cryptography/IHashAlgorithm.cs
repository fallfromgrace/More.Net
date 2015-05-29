using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Security.Cryptography
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHashAlgorithm : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        Byte[] ComputeHash(Byte[] buffer);
    }
}
