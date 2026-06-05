namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the units of time measurement.
    /// </summary>
    [Classes.Category(UnitCategory.Time)]
    public enum TimeUnit
    {
        /// <summary>
        /// Represents a time unit of one second.
        /// </summary>
        [Classes.FactorUnit("Second", "s", 1)] Second,

        /// <summary>
        /// Represents a time unit of one minute.
        /// </summary>
        [Classes.FactorUnit("Minute", "min", 60)] Minute,

        /// <summary>
        /// Represents a time unit of one hour.
        /// </summary>
        [Classes.FactorUnit("Hour", "hr", 3600)] Hour,
    }
}