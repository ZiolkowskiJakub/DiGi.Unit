namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the units of measurement for volume.
    /// </summary>
    [Classes.Category(UnitCategory.Volume)]
    public enum VolumeUnit
    {
        /// <summary>
        /// Represents a volume in cubic millimeters.
        /// </summary>
        [Classes.FactorUnit("Cubic millimeter", "mm3", 1e-9)] CubicMillimeter,

        /// <summary>
        /// Represents a volume in cubic meters.
        /// </summary>
        [Classes.FactorUnit("Cubic meter", "m3", 1.0)] CubicMeter,

        /// <summary>
        /// Represents a volume in cubic kilometers.
        /// </summary>
        [Classes.FactorUnit("Cubic kilometer", "km3", 1e+9)] CubicKilometer,
    }
}