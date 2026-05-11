namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.Length)]
    public enum LengthUnit
    {
        [Classes.FactorUnit("Milimeter", "mm", 0.001)] Milimeter,
        [Classes.FactorUnit("Meter", "m", 1.0)] Meter,
        [Classes.FactorUnit("Kilometer", "km", 1000)] Kilometer,

        [Classes.FactorUnit("Feet", "ft", 1.0)] Feet,
        [Classes.FactorUnit("Inch", "in", 1.0)] Inch,
    }
}