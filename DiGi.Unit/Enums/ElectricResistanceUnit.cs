namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for electric resistance measurement.
    /// </summary>
    [Classes.Category(UnitCategory.ElectricResistance)]
    public enum ElectricResistanceUnit
    {
        /// <summary>
        /// Ohm unit of electric resistance (SI derived unit).
        /// </summary>
        [Classes.FactorUnit("Ohm", "Ω", 1.0)] Ohm,

        /// <summary>
        /// Milliohm unit of electric resistance.
        /// </summary>
        [Classes.FactorUnit("Milliohm", "mΩ", 0.001)] Milliohm,

        /// <summary>
        /// Microohm unit of electric resistance.
        /// </summary>
        [Classes.FactorUnit("Microohm", "µΩ", 0.000001)] Microohm,

        /// <summary>
        /// Kilohm unit of electric resistance.
        /// </summary>
        [Classes.FactorUnit("Kilohm", "kΩ", 1000.0)] Kilohm,

        /// <summary>
        /// Megohm unit of electric resistance.
        /// </summary>
        [Classes.FactorUnit("Megohm", "MΩ", 1000000.0)] Megohm,
    }
}