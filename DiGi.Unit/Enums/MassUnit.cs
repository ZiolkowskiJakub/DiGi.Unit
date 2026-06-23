namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for mass measurement.
    /// </summary>
    [Classes.Category(UnitCategory.Mass)]
    public enum MassUnit
    {
        /// <summary>
        /// Kilogram unit of mass (SI base unit).
        /// </summary>
        [Classes.FactorUnit("Kilogram", "kg", 1.0)] Kilogram,

        /// <summary>
        /// Gram unit of mass.
        /// </summary>
        [Classes.FactorUnit("Gram", "g", 0.001)] Gram,

        /// <summary>
        /// Milligram unit of mass.
        /// </summary>
        [Classes.FactorUnit("Milligram", "mg", 0.000001)] Milligram,

        /// <summary>
        /// Microgram unit of mass.
        /// </summary>
        [Classes.FactorUnit("Microgram", "µg", 0.000000001)] Microgram,

        /// <summary>
        /// Ton (metric ton) unit of mass.
        /// </summary>
        [Classes.FactorUnit("Ton", "t", 1000.0)] Ton,

        /// <summary>
        /// Pound unit of mass.
        /// </summary>
        [Classes.FactorUnit("Pound", "lb", 0.45359237)] Pound,

        /// <summary>
        /// Ounce unit of mass.
        /// </summary>
        [Classes.FactorUnit("Ounce", "oz", 0.028349523125)] Ounce,
    }
}