using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for thermal transmittance measurement (U-value).
    /// </summary>
    [Classes.Category(UnitCategory.ThermalTransmittance), Description("The rate of heat transfer through a structure divided by the difference in temperature across the structure")]
    public enum ThermalTransmittanceUnit
    {
        /// <summary>
        /// Watt per square meter kelvin (W/m2K).
        /// </summary>
        [Classes.FactorUnit("Watt per square meter kelvin", "W/m2K", 1.0)] WattPerSquareMeterKelvin,

        /// <summary>
        /// Watt per square meter degree celsius (W/m2°C).
        /// </summary>
        [Classes.FactorUnit("Watt per square meter degree celsius", "W/m2°C", 1.0)] WattPerSquareMeterDegreeCelsius,

        /// <summary>
        /// BTU per hour square foot degree fahrenheit (BTU/hr ft2 °F).
        /// </summary>
        [Classes.FactorUnit("BTU per hour square foot degree fahrenheit", "BTU/hr ft2 °F", 5.678263337)] BtuPerHourSquareFootDegreeFahrenheit,
    }
}
