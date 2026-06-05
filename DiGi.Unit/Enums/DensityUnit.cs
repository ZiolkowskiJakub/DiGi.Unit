using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the units of measurement for density, representing the amount of mass per unit volume.
    /// </summary>
    [Classes.Category(UnitCategory.Density), Description("The amount of mass per unit volume")]
    public enum DensityUnit
    {
        /// <summary>
        /// Kilogram per cubic meter (kg/m3).
        /// </summary>
        [Classes.FactorUnit("Kilogram per cubic meter", "kg/m3", 1.0)] KilogramPerCubicMeter,
        /// <summary>
        /// Gram per cubic centimeter (g/cm3).
        /// </summary>
        [Classes.FactorUnit("Gram per cubic centimeter", "g/cm3", 0.001)] GramPerCubicCentimeter,
    }
}