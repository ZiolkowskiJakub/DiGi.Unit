namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for power measurement.
    /// </summary>
    [Classes.Category(UnitCategory.Power)]
    public enum PowerUnit
    {
        /// <summary>
        /// Watt unit of power (SI derived unit).
        /// </summary>
        [Classes.FactorUnit("Watt", "W", 1.0)] Watt,

        /// <summary>
        /// Milliwatt unit of power.
        /// </summary>
        [Classes.FactorUnit("Milliwatt", "mW", 0.001)] Milliwatt,

        /// <summary>
        /// Microwatt unit of power.
        /// </summary>
        [Classes.FactorUnit("Microwatt", "µW", 0.000001)] Microwatt,

        /// <summary>
        /// Kilowatt unit of power.
        /// </summary>
        [Classes.FactorUnit("Kilowatt", "kW", 1000.0)] Kilowatt,

        /// <summary>
        /// Megawatt unit of power.
        /// </summary>
        [Classes.FactorUnit("Megawatt", "MW", 1000000.0)] Megawatt,

        /// <summary>
        /// Mechanical horsepower unit of power.
        /// </summary>
        [Classes.FactorUnit("Horsepower", "hp", 550.0 * 0.3048 * 4.4482216152605)] Horsepower,
    }
}