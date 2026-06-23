namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for frequency measurement.
    /// </summary>
    [Classes.Category(UnitCategory.Frequency)]
    public enum FrequencyUnit
    {
        /// <summary>
        /// Hertz unit of frequency (SI derived unit).
        /// </summary>
        [Classes.FactorUnit("Hertz", "Hz", 1.0)] Hertz,

        /// <summary>
        /// Kilohertz unit of frequency.
        /// </summary>
        [Classes.FactorUnit("Kilohertz", "kHz", 1000.0)] Kilohertz,

        /// <summary>
        /// Megahertz unit of frequency.
        /// </summary>
        [Classes.FactorUnit("Megahertz", "MHz", 1000000.0)] Megahertz,

        /// <summary>
        /// Gigahertz unit of frequency.
        /// </summary>
        [Classes.FactorUnit("Gigahertz", "GHz", 1000000000.0)] Gigahertz,
    }
}