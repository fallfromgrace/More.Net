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
    public static class IQuantityExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TQuantity"></typeparam>
        /// <typeparam name="TUnit"></typeparam>
        /// <param name="quantity"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static Double ConvertTo<TQuantity, TUnit>(
            this TQuantity quantity, 
            TUnit unit)
            where TQuantity : IQuantity<TUnit>
            where TUnit : IUnit
        {
            return quantity.Value * quantity.Unit.ConversionFactor / unit.ConversionFactor;
        }
    }
}
