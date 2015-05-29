using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Units.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    public struct Exponent : IEquatable<Exponent>
    {
        /// <summary>
        /// 
        /// </summary>
        public Int32 Mass
        {
            get { return mass; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int32 Length
        {
            get { return length; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int32 Time
        {
            get { return time; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="length"></param>
        /// <param name="time"></param>
        public Exponent(Int32 mass, Int32 length, Int32 time)
        {
            this.mass = mass;
            this.length = length;
            this.time = time;
        }

        public static Exponent Pow(Exponent exponent, Int32 power)
        {
            return new Exponent(
                exponent.mass * power,
                exponent.length * power,
                exponent.time * power);
        }

        public Exponent Pow(Int32 power)
        {
            return Exponent.Pow(this, power);
        }

        public static Exponent operator *(Exponent left, Exponent right)
        {
            return new Exponent(
                left.mass + right.mass,
                left.length + right.length,
                left.time + right.time);
        }

        #region IEquatable

        public override Boolean Equals(Object obj)
        {
            if (obj is Exponent)
                return Equals((Exponent)obj);
            else
                return false;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(Exponent other)
        {
            return
                this.mass == other.mass &&
                this.length == other.length &&
                this.time == other.time;
        }

        public override Int32 GetHashCode()
        {
            return mass | length << 2 | time << 4;
        }

        #endregion

        #region Operators

        public static Boolean operator ==(Exponent left, Exponent right)
        {
            return left.Equals(right);
        }

        public static Boolean operator !=(Exponent left, Exponent right)
        {
            return !(left == right);
        }

        #endregion

        #region Private Fields

        private readonly Int32 mass;
        private readonly Int32 length;
        private readonly Int32 time;

        #endregion
    }
}
