namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.Temperature)]
    public enum TemperatureUnit
    {
        [Classes.LinearUnit("Celsius", "C", 1.0, 273.15)] Celsius,
        [Classes.LinearUnit("Fahrenheit", "F", 5.0 / 9.0, 459.67 * (5.0 / 9.0))] Fahrenheit,
        [Classes.FactorUnit("Kelvin", "K", 1.0)] Kelvin,
    }
}