using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.Density), Description("The amount of mass per unit volume")]
    public enum DensityUnit
    {
        [Classes.FactorUnit("Kilogram per cubic meter", "kg/m3", 1.0)] KilogramPerCubicMeter,
        [Classes.FactorUnit("Gram per cubic centimeter", "g/cm3", 0.001)] GramPerCubicCentimeter,
    }
}