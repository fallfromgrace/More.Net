using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Units.Experimental
{
    /// <summary>
    /// Encapsulates base functionality for a unit of measure.
    /// </summary>
    public class Unit
    {
        /// <summary>
        /// Gets the conversion factor from this unit to the base unit.
        /// </summary>
        public Double ConversionFactor
        {
            get { return conversionFactor; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Exponent Exponent
        {
            get { return exponent; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toMeter"></param>
        /// <param name="name"></param>
        /// <param name="abbreviation"></param>
        /// <param name="system"></param>
        public Unit(Double conversionFactor, Exponent exponent)
        {
            this.conversionFactor = conversionFactor;
            this.exponent = exponent;
        }

        public static Unit Pow(String key, Unit unit, Int32 power)
        {
            return new KeyUnit(
                key,
                unit.conversionFactor.Pow(power),
                unit.exponent.Pow(power));
        }

        public static Unit Mul(String key, Unit left, Unit right)
        {
            return new KeyUnit(
                key,
                left.conversionFactor * right.conversionFactor,
                left.exponent * right.exponent);
        }

        public static Unit Mul(Unit left, Unit right)
        {
            return new AggregateUnit(
                left,
                right);
        }

        private readonly Double conversionFactor;
        private readonly Exponent exponent;
    }

    /// <summary>
    /// Represents a unit of measure whose String representation is tied to a resource key.
    /// </summary>
    internal class KeyUnit : Unit
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toMeter"></param>
        /// <param name="name"></param>
        /// <param name="abbreviation"></param>
        /// <param name="system"></param>
        public KeyUnit(String key, Double conversionFactor, Exponent exponent) : 
            base(conversionFactor, exponent)
        {
            this.key = key;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return key;
        }

        private readonly String key;
    }

    /// <summary>
    /// Represents a unit of measure whose String representation is controlled by it's child units.
    /// </summary>
    internal class AggregateUnit : Unit
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="toMeter"></param>
        /// <param name="name"></param>
        /// <param name="abbreviation"></param>
        /// <param name="system"></param>
        public AggregateUnit(params Unit[] units) :
            base(GetConversionFactor(units), GetExponent(units))
        {
            this.units = units;
        }

        private static Double GetConversionFactor(params Unit[] units)
        {
            return units
                .Skip(1)
                .Aggregate(
                    units.First().ConversionFactor, 
                    (total, next) => total * next.ConversionFactor);
        }

        private static Exponent GetExponent(params Unit[] units)
        {
            return units
                .Skip(1)
                .Aggregate(
                    units.First().Exponent, 
                    (total, next) => total * next.Exponent);
        }

        public override String ToString()
        {
            //units.GroupBy(unit => unit.)

            return base.ToString();
        }

        private Unit[] units;
    }
}
