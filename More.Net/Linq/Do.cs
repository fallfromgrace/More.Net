using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Linq
{
    public static partial class LinExtensions
    {
        public static IEnumerable<TValue> Do<TValue>(
            this IEnumerable<TValue> source, 
            Action<TValue> action)
        {
            foreach(TValue value in source)
            {
                action(value);
                yield return value;
            }
        }
    }
}
