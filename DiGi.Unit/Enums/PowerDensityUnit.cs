using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Represents units of measurement for power density, which is the amount of power flowing through, or falling upon, a surface area.
    /// </summary>
    [Classes.Category(UnitCategory.PowerDensity), Description("The amount of power flowing through, or falling upon, a surface area")]
    public enum PowerDensityUnit
    {
        /// <summary>
        /// Watt per square meter (W/m2).
        /// </summary>
        [Classes.FactorUnit("Watt per square meter", "W/m2", 1.0)] WattPerSquareMeter,

        /// <summary>
        /// Kilowatt per square meter (kW/m2).
        /// </summary>
        [Classes.FactorUnit("Kilowatt per square meter", "kW/m2", 1000.0)] KilowattPerSquareMeter,
    }
}