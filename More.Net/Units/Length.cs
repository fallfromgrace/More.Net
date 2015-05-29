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
    public struct Length : IQuantity<LengthUnit>
    {

        public Length(Double value, LengthUnit unit)
        {
            this.value = value;
            this.unit = unit;
        }

        #region IQuantity<LengthUnit>

        //public Double ConvertTo(LengthUnit unit)
        //{
        //    
        //}

        public LengthUnit Unit
        {
            get { return unit; }
        }

        #endregion

        #region IQuantity

        public Double Value
        {
            get { return value; }
        }


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

        public String ToString(String format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Overrides

        public override String ToString()
        {
            return ToString(null);
        }

        #endregion

        public String ToString(String valueFormat)
        {
            return String.Format("{0} {1}", value.ToString(valueFormat), unit.ToString());
        }

        private readonly Double value;
        private readonly LengthUnit unit;
    }
}
