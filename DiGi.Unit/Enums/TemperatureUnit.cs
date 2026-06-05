namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Specifies the units of measurement for temperature.
    /// </summary>
    [Classes.Category(UnitCategory.Temperature)]
    public enum TemperatureUnit
    {
        /// <summary>
        /// The Celsius scale for temperature.
        /// </summary>
        [Classes.LinearUnit("Celsius", "C", 1.0, 273.15)] Celsius,

        /// <summary>
        /// The Fahrenheit scale for temperature.
        /// </summary>
        [Classes.LinearUnit("Fahrenheit", "F", 5.0 / 9.0, 459.67 * (5.0 / 9.0))] Fahrenheit,

        /// <summary>
        /// The Kelvin scale for temperature.
        /// </summary>
        [Classes.FactorUnit("Kelvin", "K", 1.0)] Kelvin,
    }
}