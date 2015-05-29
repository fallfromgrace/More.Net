using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Reactive.Linq
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TItem1"></typeparam>
    /// <typeparam name="TItem2"></typeparam>
    public interface IEitherFactory<TItem1, TItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IEither<TItem1, TItem2> From1stType(TItem1 value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IEither<TItem1, TItem2> From2ndType(TItem2 value);
    }
}
