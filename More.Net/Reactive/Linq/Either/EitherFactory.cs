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
    internal struct EitherFactory<TItem1, TItem2> : IEitherFactory<TItem1, TItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public IEither<TItem1, TItem2> From1stType(TItem1 value)
        {
            return new Either2_Item1<TItem1, TItem2>(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public IEither<TItem1, TItem2> From2ndType(TItem2 value)
        {
            return new Either2_Item2<TItem1, TItem2>(value);
        }
    }
}
