namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.Time)]
    public enum TimeUnit
    {
        [Classes.FactorUnit("Second", "s", 1000000)] Second,
        [Classes.FactorUnit("Minute", "min", 1.0)] Minute,
        [Classes.FactorUnit("Hour", "hr", 0.00001)] Hour,
    }
}
