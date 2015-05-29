using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
    public interface IEither<T1, T2>
    {
        Boolean Is1 { get; }
        Boolean Is2 { get; }
        T1 Value1 { get; }
        T2 Value2 { get; }
    }

    //public static class Either
    //{
    //    private sealed class Either1<T1, T2> : IEither<T1, T2>
    //    {
    //        private readonly T1 value;

    //        public Either1(T1 value)
    //        {
    //            this.value = value;
    //        }
    //    }

    //    private sealed class Either2<T1, T2> : IEither<T1, T2>
    //    {
    //        private readonly T2 value;

    //        public Either2(T2 value)
    //        {
    //            this.value = value;
    //        }

    //        public Boolean Is1
    //        {
    //            get { return false; }
    //        }

    //        public Boolean Is2
    //        {
    //            get { return true; }
    //        }


    //    }

    //    public static IEither<T1, T2> From1<T1, T2>(T1 value)
    //    {
    //        return new Either1<T1, T2>(value);
    //    }

    //    public static IEither<T1, T2> From2<T1, T2>(T2 value)
    //    {
    //        return new Either2<T1, T2>(value);
    //    }
    //}
}
