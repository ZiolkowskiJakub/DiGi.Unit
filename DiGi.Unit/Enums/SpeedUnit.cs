namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for speed/velocity measurement.
    /// </summary>
    [Classes.Category(UnitCategory.Speed)]
    public enum SpeedUnit
    {
        /// <summary>
        /// Meters per second unit of speed (SI base unit equivalent).
        /// </summary>
        [Classes.FactorUnit("Meter per second", "m/s", 1.0)] MeterPerSecond,

        /// <summary>
        /// Kilometers per hour unit of speed.
        /// </summary>
        [Classes.FactorUnit("Kilometer per hour", "km/h", 1.0 / 3.6)] KilometerPerHour,

        /// <summary>
        /// Miles per hour unit of speed.
        /// </summary>
        [Classes.FactorUnit("Mile per hour", "mph", 0.44704)] MilePerHour,

        /// <summary>
        /// Feet per second unit of speed.
        /// </summary>
        [Classes.FactorUnit("Foot per second", "fps", 0.3048)] FootPerSecond,
    }
}