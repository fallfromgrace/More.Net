using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Units
{
    /// <summary>
    /// 
    /// </summary>
    public struct Angle : IQuantity<AngleUnit>
    {
        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unit"></param>
        public Angle(Double value, AngleUnit unit)
        {
            this.value = value;
            this.unit = unit;
        }

        #endregion

        #region IQuantity<AngleUnit>

        //public Double ConvertTo(AngleUnit unit)
        //{
        //    
        //}

        public AngleUnit Unit
        {
            get { return unit; }
        }

        #endregion

        #region IQuantity

        /// <summary>
        /// 
        /// </summary>
        public Double Value
        {
            get { return value; }
        }

        /// <summary>
        /// 
        /// </summary>
        IUnit IQuantity.Unit
        {
            get { return this.Unit; }
        }

        //Double IQuantity.ConvertTo(IUnit unit)
        //{
        //    return this.ConvertTo((LengthUnit)unit);
        //}

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
        /// <returns></returns>
        public override String ToString()
        {
            return ToString(null);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valueFormat"></param>
        /// <returns></returns>
        public String ToString(String valueFormat)
        {
            return String.Format("{0} {1}", value.ToString(valueFormat), unit.ToString());
        }

        #endregion

        #region Private Fields

        private readonly Double value;
        private readonly AngleUnit unit;

        #endregion
    }
}
