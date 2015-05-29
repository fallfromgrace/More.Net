using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Units
{
    /// <summary>
    /// 
    /// </summary>
    public struct LengthUnit : IUnit<LengthUnit>
    {
        #region Public Properties

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Femtometer
        {
            get { return femtoMeter; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Nanometer
        {
            get { return nanometer; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Micrometer
        {
            get { return micrometer; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Millimeter
        {
            get { return millimeter; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Centimeter
        {
            get { return centimeter; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Decimeter
        {
            get { return decimeter; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Meter
        {
            get { return meter; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Kilometer
        {
            get { return kilometer; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Angstrom
        {
            get { return angstrom; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit LightYear
        {
            get { return LightYear; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Parsec
        {
            get { return parsec; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Mils
        {
            get { return mils; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Inch
        {
            get { return inch; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Foot
        {
            get { return foot; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Yard
        {
            get { return yard; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit Mile
        {
            get { return mile; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static LengthUnit NauticalMile
        {
            get { return nauticalMile; }
        }

        #endregion

        /// <summary>
        /// Enumerates all available units.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<LengthUnit> Enumerate()
        {
            yield return femtoMeter;
            yield return picometer;
            yield return nanometer;
            yield return micrometer;
            yield return millimeter;
            yield return centimeter;
            yield return decimeter;
            yield return meter;
            yield return kilometer;
            yield return angstrom;
            yield return lightYear;
            yield return parsec;
            yield return furlong;
            yield return mils;
            yield return inch;
            yield return foot;
            yield return yard;
            yield return mile;
            yield return nauticalMile;
        }

        static LengthUnit()
        {
            femtoMeter = new LengthUnit("Femtometer", 1.0e-15);
            picometer = new LengthUnit("Picometer", 1.0e-12);
            nanometer = new LengthUnit("Nanometer", 1.0e-9);
            micrometer = new LengthUnit("Micrometer", 1.0e-6);
            millimeter = new LengthUnit("Millimeter", 1.0e-3);
            centimeter = new LengthUnit("Centimeter", 1.0e-2);
            decimeter = new LengthUnit("Decimeter", 1.0e-1);
            meter = new LengthUnit("Meter", 1.0e+0);
            kilometer = new LengthUnit("Kilometer", 1.0e+3);

            angstrom = new LengthUnit("Angstrom", 1.0e-10);
            lightYear = new LengthUnit("LightYear", 9.4605284e+15);
            parsec = new LengthUnit("Parsec", 3.0856776e+16);

            mils = new LengthUnit("Mils", 2.54e-5);
            inch = new LengthUnit("Inch", 2.54e-2);
            foot = new LengthUnit("Foot", 3.048e-1);
            yard = new LengthUnit("Yard", 9.144e-1);
            furlong = new LengthUnit("Furlong", 2.01168e+2);
            mile = new LengthUnit("Mile", 1.609344e+3);
            nauticalMile = new LengthUnit("NauticalMile", 1.852e+3);
        }

        public LengthUnit(String name, Double converionFactor)
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

        #region IEquatable<LengthUnit>

        public bool Equals(LengthUnit other)
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

        #region Private Fields

        private readonly Double converionFactor;
        private readonly String name;

        private static readonly LengthUnit femtoMeter;
        private static readonly LengthUnit picometer;
        private static readonly LengthUnit nanometer;
        private static readonly LengthUnit micrometer;
        private static readonly LengthUnit millimeter;
        private static readonly LengthUnit centimeter;
        private static readonly LengthUnit decimeter;
        private static readonly LengthUnit meter;
        private static readonly LengthUnit kilometer;
        private static readonly LengthUnit angstrom;
        private static readonly LengthUnit lightYear;
        private static readonly LengthUnit parsec;
        private static readonly LengthUnit furlong;
        private static readonly LengthUnit mils;
        private static readonly LengthUnit inch;
        private static readonly LengthUnit foot;
        private static readonly LengthUnit yard;
        private static readonly LengthUnit mile;
        private static readonly LengthUnit nauticalMile;

        #endregion
    }
}
