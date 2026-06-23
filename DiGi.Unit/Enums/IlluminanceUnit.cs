namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for illuminance measurement.
    /// </summary>
    [Classes.Category(UnitCategory.Illuminance)]
    public enum IlluminanceUnit
    {
        /// <summary>
        /// Lux unit of illuminance (SI derived unit).
        /// </summary>
        [Classes.FactorUnit("Lux", "lx", 1.0)] Lux,

        /// <summary>
        /// Footcandle unit of illuminance.
        /// </summary>
        [Classes.FactorUnit("Footcandle", "fc", 1.0 / (0.3048 * 0.3048))] Footcandle,
    }
}