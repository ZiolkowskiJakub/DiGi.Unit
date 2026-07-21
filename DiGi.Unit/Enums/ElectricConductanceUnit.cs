namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for electric conductance measurement.
    /// </summary>
    [Classes.Category(UnitCategory.ElectricConductance)]
    public enum ElectricConductanceUnit
    {
        /// <summary>
        /// Siemens unit of electric conductance (SI derived unit).
        /// </summary>
        [Classes.FactorUnit("Siemens", "S", 1.0)] Siemens,

        /// <summary>
        /// Millisiemens unit of electric conductance.
        /// </summary>
        [Classes.FactorUnit("Millisiemens", "mS", 0.001)] Millisiemens,

        /// <summary>
        /// Microsiemens unit of electric conductance.
        /// </summary>
        [Classes.FactorUnit("Microsiemens", "µS", 0.000001)] Microsiemens,

        /// <summary>
        /// Kilosiemens unit of electric conductance.
        /// </summary>
        [Classes.FactorUnit("Kilosiemens", "kS", 1000.0)] Kilosiemens,

        /// <summary>
        /// Megasiemens unit of electric conductance.
        /// </summary>
        [Classes.FactorUnit("Megasiemens", "MS", 1000000.0)] Megasiemens,
    }
}
