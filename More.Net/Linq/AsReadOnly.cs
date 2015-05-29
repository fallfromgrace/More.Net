using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Linq
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class LinqExtensions
    {
        public static IReadOnlyCollection<TValue> AsReadOnly<TValue>(this IEnumerable<TValue> source)
        {
            return new ReadOnlyCollection<TValue>(source.ToList());
        }
    }
}
