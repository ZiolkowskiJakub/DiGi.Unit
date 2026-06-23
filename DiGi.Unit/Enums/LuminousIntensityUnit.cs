namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for luminous intensity measurement.
    /// </summary>
    [Classes.Category(UnitCategory.LuminousIntensity)]
    public enum LuminousIntensityUnit
    {
        /// <summary>
        /// Candela unit of luminous intensity (SI base unit).
        /// </summary>
        [Classes.FactorUnit("Candela", "cd", 1.0)] Candela,

        /// <summary>
        /// Millicandela unit of luminous intensity.
        /// </summary>
        [Classes.FactorUnit("Millicandela", "mcd", 0.001)] Millicandela,

        /// <summary>
        /// Microcandela unit of luminous intensity.
        /// </summary>
        [Classes.FactorUnit("Microcandela", "µcd", 0.000001)] Microcandela,
    }
}