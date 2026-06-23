namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for electric potential (voltage) measurement.
    /// </summary>
    [Classes.Category(UnitCategory.ElectricPotential)]
    public enum ElectricPotentialUnit
    {
        /// <summary>
        /// Volt unit of voltage (SI derived unit).
        /// </summary>
        [Classes.FactorUnit("Volt", "V", 1.0)] Volt,

        /// <summary>
        /// Millivolt unit of voltage.
        /// </summary>
        [Classes.FactorUnit("Millivolt", "mV", 0.001)] Millivolt,

        /// <summary>
        /// Microvolt unit of voltage.
        /// </summary>
        [Classes.FactorUnit("Microvolt", "µV", 0.000001)] Microvolt,

        /// <summary>
        /// Kilovolt unit of voltage.
        /// </summary>
        [Classes.FactorUnit("Kilovolt", "kV", 1000.0)] Kilovolt,
    }
}