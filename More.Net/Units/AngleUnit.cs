using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Units
{
    public struct AngleUnit : IUnit<AngleUnit>
    {
        public static AngleUnit Degree
        {
            get { return degree; }
        }

        public static AngleUnit Radian
        {
            get { return radian; }
        }

        static AngleUnit()
        {
            degree = new AngleUnit("Degree", 5.72957795e+1);
            radian = new AngleUnit("Radian", 1.0e+0);
        }

        public static IEnumerable<AngleUnit> Enumerate()
        {
            yield return degree;
            yield return radian;
        }

        public AngleUnit(String name, Double converionFactor)
        {
            this.name = name;
            this.converionFactor = converionFactor;
        }

        #region IUnit

        public Double ConversionFactor
        {
            get { return this.converionFactor; }
        }

        #endregion

        #region IEquatable<AngleUnit>

        public bool Equals(AngleUnit other)
        {
            throw new NotImplementedException();
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
            return base.Equals(obj);
        }

        public override Int32 GetHashCode()
        {
            return base.GetHashCode();
        }

        public override String ToString()
        {
            return ToString("uu");
        }

        #endregion

        #region Public Methods

        public String ToString(String format)
        {
            String[] defaultSymbols = null;
                //Resources.LengthUnit.ResourceManager
                //.GetString(name)
                //.Split(';')
                //.First()
                //.Split(',');

            switch (format)
            {
                case "uu": return defaultSymbols[2];
                case "UU": return defaultSymbols[1];
                case "U": return defaultSymbols[1].ToLowerInvariant();
                default: throw new FormatException();
            }
        }

        #endregion

        private readonly Double converionFactor;
        private readonly String name;

        private static readonly AngleUnit degree;
        private static readonly AngleUnit radian;
    }
}
