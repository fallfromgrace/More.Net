using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Linq
{
    public static partial class LinqExtensions
    {
        public static IEnumerable<TValue> Maybe<TValue>(this TValue value)
            where TValue : class
        {
            yield return value;
        }
    }
}
