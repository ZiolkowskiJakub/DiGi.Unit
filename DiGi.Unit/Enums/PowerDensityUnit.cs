using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.PowerDensity), Description("The amount of power flowing through, or falling upon, a surface area")]
    public enum PowerDensityUnit
    {
        [Classes.FactorUnit("Watt per square meter", "W/m²", 1.0)] WattPerSquareMeter,
        [Classes.FactorUnit("Kilowatt per square meter", "kW/m²", 1000.0)] KilowattPerSquareMeter,
    }
}
