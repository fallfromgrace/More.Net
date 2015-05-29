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
    public struct Time : IQuantity<TimeUnit>
    {
        public Time(Double value, TimeUnit unit)
        {
            this.value = value;
            this.unit = unit;
        }

        private readonly Double value;
        private readonly TimeUnit unit;

        public TimeUnit Unit
        {
            get { return unit; }
        }

        public Double Value
        {
            get { return value; }
        }

        IUnit IQuantity.Unit
        {
            get { return this.Unit; }
        }

        public string ToString(String format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        public static Time operator *(Double value, Time time)
        {
            return new Time(time.Value * value, time.Unit);
        }
    }
}
