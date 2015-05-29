using System;
using System.Runtime.InteropServices;

namespace More.Net
{
    /// <summary>
    /// Represents a 24-bit unsigned integer.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Int24 : IComparable, IComparable<UInt24>, IEquatable<UInt24>, IFormattable
    {
        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        private Int24(Int32 value)
        {
            b0 = (Byte)(value & 0xFF);
            b1 = (Byte)(value >> 8);
            b2 = (Byte)(value >> 16);
        }

        #endregion

        #region IComparable

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public Int32 CompareTo(Object obj)
        {
            return CompareTo((UInt24)obj);
        }

        #endregion

        #region IComparable<UInt24>

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Int32 CompareTo(UInt24 other)
        {
            Int32 compare;
            if (this > other)
                compare = 1;
            else if (this < other)
                compare = -1;
            else
                compare = 0;
            return compare;
        }

        #endregion

        #region IEquatable<Uint24>

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(UInt24 other)
        {
            return CompareTo(other) == 0;
        }

        #endregion

        #region IFormattable

        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        /// <param name="formatProvider"></param>
        /// <returns></returns>
        public String ToString(String format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj)
        {
            return Equals((UInt24)obj);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode()
        {
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return base.ToString();
        }

        #endregion

        #region Operator Overloads

        public static Boolean operator ==(Int24 left, Int24 right)
        {
            return left.Equals(right) == true;
        }

        public static Boolean operator !=(Int24 left, Int24 right)
        {
            return left.Equals(right) == false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uint32"></param>
        /// <returns></returns>
        public static implicit operator Int24(Int32 uint32)
        {
            return new Int24(uint32);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uint24"></param>
        /// <returns></returns>
        public static implicit operator Int32(Int24 uint24)
        {
            return ((Int32)uint24.b0) | ((Int32)uint24.b1 << 8) | ((Int32)uint24.b2 << 16);
        }

        #endregion

        public static Int24 FromBytes(Byte[] bytes, Int32 startIndex)
        {
            Int24 value = new Int24();
            value.b0 = bytes[startIndex];
            value.b1 = bytes[startIndex + 1];
            value.b2 = bytes[startIndex + 2];
            return value;
        }

        #region Private Fields

        private Byte b0;
        private Byte b1;
        private Byte b2;

        #endregion
    }
}