using System;
using System.Runtime.InteropServices;

namespace EZMetrology
{
    /// <summary>
    /// 
    /// </summary>
    public enum EZeroDirection
    {
        /// <summary>
        /// 
        /// </summary>
        TowardsZero,

        /// <summary>
        /// 
        /// </summary>
        AwayFromZero
    }

    /// <summary>
    /// 
    /// </summary>
    public static class FloatingPointExtensions
    {
        #region Single Precision

        /// <summary>
        /// 
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        private struct FloatInt32
        {
            /// <summary>
            /// 
            /// </summary>
            [FieldOffset(0)]
            public Single Float;

            /// <summary>
            /// 
            /// </summary>
            [FieldOffset(0)]
            public Int32 Int;
        }

        /// <summary>
        /// Returns the dynamic epsilon of a single precision floating point value. If the value is 
        /// NaN or ±Inf, or the initial result overflows, the result will be null.
        /// </summary>
        /// <remarks>See (http://bit.ly/10KS2wo)</remarks>
        /// <returns>Double?</returns>
        public static Single? DynamicEpsilon(this Single source)
        {
            return source.DynamicEpsilon(EZeroDirection.TowardsZero);
        }

        /// <summary>
        /// Returns the dynamic epsilon of a single precision floating point value. If the value is 
        /// NaN or ±Inf, or the initial result overflows, the result will be null.
        /// </summary>
        /// <remarks>See (http://bit.ly/10KS2wo)</remarks>
        /// <param name="direction">
        /// Determines if the epsilon is calculated from the delta of its next value towards zero 
        /// or away from zero. Choose the direction the value moves in. EZeroDirection.TowardsZero 
        /// allows proper processing of Double.MaxValue and Double.MinValue.
        /// </param>
        /// <returns>Double?</returns>
        public static Single? DynamicEpsilon(this Single source, EZeroDirection direction)
        {
            if (Single.IsNaN(source) == false && 
                source != Single.NegativeInfinity && 
                source != Single.PositiveInfinity)
            {
                FloatInt32 fi = new FloatInt32();
                fi.Float = source;
                fi.Int -= ((direction == EZeroDirection.TowardsZero) ? 1 : -1);

                if (Single.IsNaN(fi.Float) == false)
                    return Math.Abs(source - fi.Float);
            }

            return null;
        }

        #endregion

        #region Double Precision

        /// <summary>
        /// 
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        private struct FloatInt64
        {
            /// <summary>
            /// 
            /// </summary>
            [FieldOffset(0)]
            internal Double Float;

            /// <summary>
            /// 
            /// </summary>
            [FieldOffset(0)]
            internal Int64 Int;
        }

        /// <summary>
        /// Returns the dynamic epsilon of a double precision floating point value. If the value is 
        /// NaN or ±Inf, or the initial result overflows, the result will be null.
        /// </summary>
        /// <remarks>See (http://bit.ly/10KS2wo)</remarks>
        /// <returns>Double?</returns>
        public static Double? DynamicEpsilon(this Double source)
        {
            return source.DynamicEpsilon(EZeroDirection.TowardsZero);
        }

        /// <summary>
        /// Returns the dynamic epsilon of a double precision floating point value. If the value is 
        /// NaN or ±Inf, or the initial result overflows, the result will be null.
        /// </summary>
        /// <remarks>See (http://bit.ly/10KS2wo)</remarks>
        /// <param name="direction">
        /// Determines if the epsilon is calculated from the delta of its next value towards zero 
        /// or away from zero. Choose the direction the value moves in. EZeroDirection.TowardsZero 
        /// allows proper processing of Double.MaxValue and Double.MinValue.
        /// </param>
        /// <returns>Double?</returns>
        public static Double? DynamicEpsilon(this Double source, EZeroDirection direction)
        {
            if (Double.IsNaN(source) == false && 
                source != Double.NegativeInfinity && 
                source != Double.PositiveInfinity)
            {
                FloatInt64 fi = new FloatInt64();
                fi.Float = source;
                fi.Int -= ((direction == EZeroDirection.TowardsZero) ? 1 : -1);

                if (Double.IsNaN(fi.Float) == false)
                    return Math.Abs(source - fi.Float);
            }

            return null;
        }

        #endregion
    }
}
