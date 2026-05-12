namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.Time)]
    public enum TimeUnit
    {
        [Classes.FactorUnit("Second", "s", 1)] Second,
        [Classes.FactorUnit("Minute", "min", 60)] Minute,
        [Classes.FactorUnit("Hour", "hr", 3600)] Hour,
    }
}
