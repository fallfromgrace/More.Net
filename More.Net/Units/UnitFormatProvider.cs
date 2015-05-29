using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Light.Linq;

namespace EZMetrology.Units
{
    public interface IUnitFormatProvider : IFormatProvider
    {
    }

    public class UnitFormatProvider : IUnitFormatProvider
    {
        public static IUnitFormatProvider Default
        {
            get { return defaultUnitFormatProvider; }
        }

        public UnitFormatProvider()
        {
            this.Register(this);
        }

        static UnitFormatProvider()
        {
            defaultUnitFormatProvider = new UnitFormatProvider();
        }

        public String Format<TQuantity>(String valueFormat, String unitFormat, TQuantity quantity)
        {
            throw new NotImplementedException();
        }

        private void Register<TUnitFormatProvider>(TUnitFormatProvider unitFormatProvider)
            where TUnitFormatProvider : IUnitFormatProvider
        {
            Assembly formatProviderAssembly = typeof(TUnitFormatProvider).GetTypeInfo().Assembly;
            formatProviderAssembly.DefinedTypes
                .Where(typeInfo => typeof(IUnit).GetTypeInfo().IsAssignableFrom(typeInfo))
                .SelectMany(typeInfo => typeInfo.DeclaredProperties)
                .ForEach(propertyInfo => propertyInfo.GetCustomAttributes<UnitAttribute>()
                    .ForEach(attribute => this
                        .RegisterUnit((IUnit)propertyInfo.GetValue(null, null), attribute.Name)));
        }

        private void RegisterUnit<TUnit>(TUnit unit, String unitName) 
            where TUnit : IUnit
        {

        }

        private static readonly IUnitFormatProvider defaultUnitFormatProvider;

        public object GetFormat(Type formatType)
        {
            throw new NotImplementedException();
        }
    }

    public class UnitAttribute : Attribute
    {
        public String Name
        {
            get;
            set;
        }
    }
}
