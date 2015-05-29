using System;
using System.Runtime.InteropServices;

namespace More.Net
{
    /// <summary>
    /// Represents a 24-bit unsigned integer.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct UInt24 : IComparable, IComparable<UInt24>, IEquatable<UInt24>, IFormattable
    {
        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        private UInt24(UInt32 value)
        {
            b0 = (Byte)(value & 0xFF);
            b1 = (Byte)(value >> 8);
            b2 = (Byte)(value >> 16);
        }

        #endregion

        #region IComparable

        public Int32 CompareTo(Object obj)
        {
            return CompareTo((UInt24)obj);
        }

        #endregion

        #region IComparable<UInt24>

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

        public Boolean Equals(UInt24 other)
        {
            return CompareTo(other) == 0;
        }

        #endregion

        #region IFormattable

        public String ToString(String format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Overrides

        public override Boolean Equals(Object obj)
        {
            return Equals((UInt24)obj);
        }

        public override Int32 GetHashCode()
        {
            return (Int32)(UInt32)this;
        }

        public override String ToString()
        {
            return base.ToString();
        }

        #endregion

        #region Operator Overloads

        public static Boolean operator ==(UInt24 left, UInt24 right)
        {
            return left.Equals(right) == true;
        }

        public static Boolean operator !=(UInt24 left, UInt24 right)
        {
            return left.Equals(right) == false;
        }

        [CLSCompliant(false)]
        public static implicit operator UInt24(UInt32 uint32)
        {
            return new UInt24(uint32);
        }

        [CLSCompliant(false)]
        public static implicit operator UInt32(UInt24 uint24)
        {
            return ((UInt32)uint24.b0) | ((UInt32)uint24.b1 << 8) | ((UInt32)uint24.b2 << 16);
        }

        #endregion

        #region Private Fields

        private Byte b0;
        private Byte b1;
        private Byte b2;

        #endregion
    }
}
