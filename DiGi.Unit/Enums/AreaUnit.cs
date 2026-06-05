namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the units of measurement for area.
    /// </summary>
    [Classes.Category(UnitCategory.Area)]
    public enum AreaUnit
    {
        /// <summary>
        /// Square millimeter.
        /// </summary>
        [Classes.FactorUnit("Square millimeter", "mm2", 0.000001)] SquareMillimeter,

        /// <summary>
        /// Square meter.
        /// </summary>
        [Classes.FactorUnit("Square meter", "m2", 1.0)] SquareMeter,

        /// <summary>
        /// Square kilometer.
        /// </summary>
        [Classes.FactorUnit("Square kilometer", "km2", 1000000)] SquareKilometer,

        /// <summary>
        /// Square foot.
        /// </summary>
        [Classes.FactorUnit("Square foot", "ft2", 0.09290304)] SquareFoot,

        /// <summary>
        /// Square inch.
        /// </summary>
        [Classes.FactorUnit("Square inch", "in2", 0.00064516)] SquareInch,
    }
}