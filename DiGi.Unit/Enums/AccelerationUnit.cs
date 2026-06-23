namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for acceleration measurement.
    /// </summary>
    [Classes.Category(UnitCategory.Acceleration)]
    public enum AccelerationUnit
    {
        /// <summary>
        /// Meters per second squared unit of acceleration (SI base unit equivalent).
        /// </summary>
        [Classes.FactorUnit("Meter per second squared", "m/s²", 1.0)] MeterPerSecondSquared,

        /// <summary>
        /// Standard gravity unit of acceleration.
        /// </summary>
        [Classes.FactorUnit("Standard gravity", "g", 9.80665)] StandardGravity,

        /// <summary>
        /// Feet per second squared unit of acceleration.
        /// </summary>
        [Classes.FactorUnit("Foot per second squared", "ft/s²", 0.3048)] FootPerSecondSquared,
    }
}