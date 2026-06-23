namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for electric current measurement.
    /// </summary>
    [Classes.Category(UnitCategory.ElectricCurrent)]
    public enum ElectricCurrentUnit
    {
        /// <summary>
        /// Ampere unit of electric current (SI base unit).
        /// </summary>
        [Classes.FactorUnit("Ampere", "A", 1.0)] Ampere,

        /// <summary>
        /// Milliampere unit of electric current.
        /// </summary>
        [Classes.FactorUnit("Milliampere", "mA", 0.001)] Milliampere,

        /// <summary>
        /// Microampere unit of electric current.
        /// </summary>
        [Classes.FactorUnit("Microampere", "µA", 0.000001)] Microampere,

        /// <summary>
        /// Kiloampere unit of electric current.
        /// </summary>
        [Classes.FactorUnit("Kiloampere", "kA", 1000.0)] Kiloampere,
    }
}