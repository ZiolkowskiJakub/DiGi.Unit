namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for length measurement.
    /// </summary>
    [Classes.Category(UnitCategory.Length)]
    public enum LengthUnit
    {
        /// <summary>
        /// Millimeter unit of length.
        /// </summary>
        [Classes.FactorUnit("Milimeter", "mm", 0.001)] Milimeter,

        /// <summary>
        /// Meter unit of length.
        /// </summary>
        [Classes.FactorUnit("Meter", "m", 1.0)] Meter,

        /// <summary>
        /// Kilometer unit of length.
        /// </summary>
        [Classes.FactorUnit("Kilometer", "km", 1000)] Kilometer,

        /// <summary>
        /// Feet unit of length.
        /// </summary>
        [Classes.FactorUnit("Foot", "ft", 0.3048)] Feet,

        /// <summary>
        /// Inch unit of length.
        /// </summary>
        [Classes.FactorUnit("Inch", "in", 0.0254)] Inch,
    }
}