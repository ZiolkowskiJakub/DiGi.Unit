using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the categories of units.
    /// </summary>
    [Description("Unit category")]
    public enum UnitCategory
    {
        /// <summary>
        /// The unit category is undefined.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// Units related to length measurement.
        /// </summary>
        [Description("Length")] Length,

        /// <summary>
        /// Units related to wavenumber measurement.
        /// </summary>
        [Description("Wavenumber")] Wavenumber,

        /// <summary>
        /// Units related to area measurement.
        /// </summary>
        [Description("Area")] Area,

        /// <summary>
        /// Units related to volume measurement.
        /// </summary>
        [Description("Volume")] Volume,

        /// <summary>
        /// Units related to temperature measurement.
        /// </summary>
        [Description("Temperature")] Temperature,

        /// <summary>
        /// Units related to thermal resistance measurement.
        /// </summary>
        [Description("Thermal Resistance")] ThermalResistance,

        /// <summary>
        /// Units related to thermal transmittance measurement.
        /// </summary>
        [Description("Thermal Transmittance")] ThermalTransmittance,

        /// <summary>
        /// Units related to time measurement.
        /// </summary>
        [Description("Time")] Time,

        /// <summary>
        /// Units related to power density measurement.
        /// </summary>
        [Description("Power Density")] PowerDensity,

        /// <summary>
        /// Units related to density measurement.
        /// </summary>
        [Description("Density")] Density,

        /// <summary>
        /// Units related to angle measurement.
        /// </summary>
        [Description("Angle")] Angle,

        /// <summary>
        /// Units related to mass measurement.
        /// </summary>
        [Description("Mass")] Mass,

        /// <summary>
        /// Units related to electric current measurement.
        /// </summary>
        [Description("Electric Current")] ElectricCurrent,

        /// <summary>
        /// Units related to amount of substance measurement.
        /// </summary>
        [Description("Amount of Substance")] AmountOfSubstance,

        /// <summary>
        /// Units related to luminous intensity measurement.
        /// </summary>
        [Description("Luminous Intensity")] LuminousIntensity,

        /// <summary>
        /// Units related to force measurement.
        /// </summary>
        [Description("Force")] Force,

        /// <summary>
        /// Units related to stiffness measurement.
        /// </summary>
        [Description("Stiffness")] Stiffness,

        /// <summary>
        /// Units related to compliance measurement.
        /// </summary>
        [Description("Compliance")] Compliance,

        /// <summary>
        /// Units related to pressure measurement.
        /// </summary>
        [Description("Pressure")] Pressure,

        /// <summary>
        /// Units related to energy measurement.
        /// </summary>
        [Description("Energy")] Energy,

        /// <summary>
        /// Units related to power measurement.
        /// </summary>
        [Description("Power")] Power,

        /// <summary>
        /// Units related to electric potential measurement.
        /// </summary>
        [Description("Electric Potential")] ElectricPotential,

        /// <summary>
        /// Units related to electric resistance measurement.
        /// </summary>
        [Description("Electric Resistance")] ElectricResistance,

        /// <summary>
        /// Units related to electric conductance measurement.
        /// </summary>
        [Description("Electric Conductance")] ElectricConductance,

        /// <summary>
        /// Units related to electric conductivity measurement.
        /// </summary>
        [Description("Electric Conductivity")] ElectricConductivity,

        /// <summary>
        /// Units related to frequency measurement.
        /// </summary>
        [Description("Frequency")] Frequency,

        /// <summary>
        /// Units related to speed measurement.
        /// </summary>
        [Description("Speed")] Speed,

        /// <summary>
        /// Units related to acceleration measurement.
        /// </summary>
        [Description("Acceleration")] Acceleration,

        /// <summary>
        /// Units related to luminous flux measurement.
        /// </summary>
        [Description("Luminous Flux")] LuminousFlux,

        /// <summary>
        /// Units related to illuminance measurement.
        /// </summary>
        [Description("Illuminance")] Illuminance,

        /// <summary>
        /// Other unit categories not explicitly defined.
        /// </summary>
        [Description("Other")] Other,
    }
}