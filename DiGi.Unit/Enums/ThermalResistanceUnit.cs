using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for thermal resistance measurement (R-value).
    /// </summary>
    [Classes.Category(UnitCategory.ThermalResistance), Description("The resistance to heat flow across a material or assembly")]
    public enum ThermalResistanceUnit
    {
        /// <summary>
        /// Square meter kelvin per watt (m2K/W).
        /// </summary>
        [Classes.FactorUnit("Square meter kelvin per watt", "m2K/W", 1.0)] SquareMeterKelvinPerWatt,

        /// <summary>
        /// Square meter degree celsius per watt (m2°C/W).
        /// </summary>
        [Classes.FactorUnit("Square meter degree celsius per watt", "m2°C/W", 1.0)] SquareMeterDegreeCelsiusPerWatt,

        /// <summary>
        /// Square foot hour degree fahrenheit per BTU (ft2 hr °F/BTU).
        /// </summary>
        [Classes.FactorUnit("Square foot hour degree fahrenheit per BTU", "ft2 hr °F/BTU", 0.1761101838)] SquareFootHourDegreeFahrenheitPerBtu,
    }
}
