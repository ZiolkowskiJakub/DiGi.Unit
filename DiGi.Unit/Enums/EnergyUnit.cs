namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for energy measurement.
    /// </summary>
    [Classes.Category(UnitCategory.Energy)]
    public enum EnergyUnit
    {
        /// <summary>
        /// Joule unit of energy (SI derived unit).
        /// </summary>
        [Classes.FactorUnit("Joule", "J", 1.0)] Joule,

        /// <summary>
        /// Millijoule unit of energy.
        /// </summary>
        [Classes.FactorUnit("Millijoule", "mJ", 0.001)] Millijoule,

        /// <summary>
        /// Microjoule unit of energy.
        /// </summary>
        [Classes.FactorUnit("Microjoule", "µJ", 0.000001)] Microjoule,

        /// <summary>
        /// Kilojoule unit of energy.
        /// </summary>
        [Classes.FactorUnit("Kilojoule", "kJ", 1000.0)] Kilojoule,

        /// <summary>
        /// Megajoule unit of energy.
        /// </summary>
        [Classes.FactorUnit("Megajoule", "MJ", 1000000.0)] Megajoule,

        /// <summary>
        /// Watt-hour unit of energy.
        /// </summary>
        [Classes.FactorUnit("Watt-hour", "Wh", 3600.0)] WattHour,

        /// <summary>
        /// Kilowatt-hour unit of energy.
        /// </summary>
        [Classes.FactorUnit("Kilowatt-hour", "kWh", 3600000.0)] KilowattHour,

        /// <summary>
        /// Calorie unit of energy.
        /// </summary>
        [Classes.FactorUnit("Calorie", "cal", 4.184)] Calorie,

        /// <summary>
        /// Kilocalorie unit of energy.
        /// </summary>
        [Classes.FactorUnit("Kilocalorie", "kcal", 4184.0)] Kilocalorie,

        /// <summary>
        /// British thermal unit of energy.
        /// </summary>
        [Classes.FactorUnit("British thermal unit", "Btu", 1055.05585262)] Btu,
    }
}