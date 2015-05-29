using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Units
{
    public interface IUnit : IFormattable
    {
        Double ConversionFactor { get; }
    }

    public interface IUnit<TUnit> : IEquatable<TUnit>, IUnit
    {

    }

    public interface IQuantity : IFormattable
    {
        Double Value { get; }

        IUnit Unit { get; }
    }

    public interface IQuantity<TUnit> : IQuantity
        where TUnit : IUnit
    {
        new TUnit Unit { get; }
    }
}
