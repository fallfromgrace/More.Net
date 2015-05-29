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
    public interface IEither<TItem1, TItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        TItem1 Item1 { get; }

        /// <summary>
        /// 
        /// </summary>
        TItem2 Item2 { get; }

        /// <summary>
        /// 
        /// </summary>
        Boolean HasItem1 { get; }

        /// <summary>
        /// 
        /// </summary>
        Boolean HasItem2 { get; }

        void Switch(Action<TItem1> onNext1, Action<TItem2> onNext2);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TItem1"></typeparam>
    /// <typeparam name="TItem2"></typeparam>
    /// <typeparam name="TItem3"></typeparam>
    public interface IEither<TItem1, TItem2, TItem3>
    {
        TItem1 Item1 { get; }

        TItem2 Item2 { get; }

        TItem3 Item3 { get; }

        Boolean HasItem1 { get; }

        Boolean HasItem2 { get; }

        Boolean HasItem3 { get; }

        void Switch(Action<TItem1> onNext1, Action<TItem2> onNext2, Action<TItem3> onNext3);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TItem1"></typeparam>
    /// <typeparam name="TItem2"></typeparam>
    /// <typeparam name="TItem3"></typeparam>
    /// <typeparam name="TItem4"></typeparam>
    public interface IEither<TItem1, TItem2, TItem3, TItem4>
    {
        TItem1 Item1 { get; }

        TItem2 Item2 { get; }

        TItem3 Item3 { get; }

        TItem4 Item4 { get; }

        Boolean HasItem1 { get; }

        Boolean HasItem2 { get; }

        Boolean HasItem3 { get; }

        Boolean HasItem4 { get; }

        void Switch(
            Action<TItem1> onNext1, 
            Action<TItem2> onNext2,
            Action<TItem3> onNext3,
            Action<TItem3> onNext4);
    }
}
