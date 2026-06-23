namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for amount of substance measurement.
    /// </summary>
    [Classes.Category(UnitCategory.AmountOfSubstance)]
    public enum AmountOfSubstanceUnit
    {
        /// <summary>
        /// Mole unit of substance amount (SI base unit).
        /// </summary>
        [Classes.FactorUnit("Mole", "mol", 1.0)] Mole,

        /// <summary>
        /// Millimole unit of substance amount.
        /// </summary>
        [Classes.FactorUnit("Millimole", "mmol", 0.001)] Millimole,

        /// <summary>
        /// Micromole unit of substance amount.
        /// </summary>
        [Classes.FactorUnit("Micromole", "µmol", 0.000001)] Micromole,

        /// <summary>
        /// Kilomole unit of substance amount.
        /// </summary>
        [Classes.FactorUnit("Kilomole", "kmol", 1000.0)] Kilomole,
    }
}