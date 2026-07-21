using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Represents units of measurement for electrical conductivity, measured in Siemens per meter.
    /// </summary>
    [Classes.Category(UnitCategory.ElectricConductivity), Description("The electrical conductivity of a material, measured in Siemens per meter")]
    public enum ElectricConductivityUnit
    {
        /// <summary>
        /// Siemens per meter (S/m).
        /// </summary>
        [Classes.FactorUnit("Siemens per meter", "S/m", 1.0)] SiemensPerMeter,

        /// <summary>
        /// Millisiemens per meter (mS/m).
        /// </summary>
        [Classes.FactorUnit("Millisiemens per meter", "mS/m", 0.001)] MillisiemensPerMeter,

        /// <summary>
        /// Microsiemens per meter (µS/m).
        /// </summary>
        [Classes.FactorUnit("Microsiemens per meter", "µS/m", 0.000001)] MicrosiemensPerMeter,

        /// <summary>
        /// Kilosiemens per meter (kS/m).
        /// </summary>
        [Classes.FactorUnit("Kilosiemens per meter", "kS/m", 1000.0)] KilosiemensPerMeter,

        /// <summary>
        /// Megasiemens per meter (MS/m).
        /// </summary>
        [Classes.FactorUnit("Megasiemens per meter", "MS/m", 1000000.0)] MegasiemensPerMeter,

        /// <summary>
        /// Microsiemens per centimeter (µS/cm).
        /// </summary>
        [Classes.FactorUnit("Microsiemens per centimeter", "µS/cm", 0.0001)] MicrosiemensPerCentimeter,

        /// <summary>
        /// Millisiemens per centimeter (mS/cm).
        /// </summary>
        [Classes.FactorUnit("Millisiemens per centimeter", "mS/cm", 0.1)] MillisiemensPerCentimeter,
    }
}
