using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Security
{
    public interface ILicense
    {
        Boolean IsValid();

        IReadOnlyDictionary<String, String> Features { get; }
    }
}
