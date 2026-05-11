namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.Temperature)]
    public enum TemperatureUnit
    {
        [Classes.FactorUnit("Celcujs", "C", 1.0)] Celcujs,
        [Classes.FactorUnit("Kelvin", "K", 0.001)] Kelvin,
    }
}