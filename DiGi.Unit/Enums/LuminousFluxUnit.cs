namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for luminous flux measurement.
    /// </summary>
    [Classes.Category(UnitCategory.LuminousFlux)]
    public enum LuminousFluxUnit
    {
        /// <summary>
        /// Lumen unit of luminous flux (SI derived unit).
        /// </summary>
        [Classes.FactorUnit("Lumen", "lm", 1.0)] Lumen,
    }
}