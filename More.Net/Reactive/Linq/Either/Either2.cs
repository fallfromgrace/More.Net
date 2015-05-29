using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light.Reactive.Linq
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TItem1"></typeparam>
    /// <typeparam name="TItem2"></typeparam>
    internal class Either2_Item1<TItem1, TItem2> : IEither<TItem1, TItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public TItem1 Item1
        {
            get { return this.value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public TItem2 Item2
        {
            get { return default(TItem2); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Boolean HasItem1
        {
            get { return true; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Boolean HasItem2
        {
            get { return false; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public Either2_Item1(TItem1 value)
        {
            this.value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="onNext1"></param>
        /// <param name="onNext2"></param>
        public void Switch(Action<TItem1> onNext1, Action<TItem2> onNext2)
        {
            onNext1(this.value);
        }

        private readonly TItem1 value;
    }

    internal class Either2_Item2<TItem1, TItem2> : IEither<TItem1, TItem2>
    {

        public TItem1 Item1
        {
            get { return default(TItem1); }
        }

        public TItem2 Item2
        {
            get { return this.value; }
        }

        public Boolean HasItem1
        {
            get { return true; }
        }

        public Boolean HasItem2
        {
            get { return false; }
        }

        public Either2_Item2(TItem2 value)
        {
            this.value = value;
        }


        public void Switch(Action<TItem1> onNext1, Action<TItem2> onNext2)
        {
            onNext2(this.value);
        }

        private readonly TItem2 value;
    }
}
