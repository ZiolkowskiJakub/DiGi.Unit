namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.Length)]
    public enum LengthUnit
    {
        [Classes.FactorUnit("Milimeter", "mm", 0.001)] Milimeter,
        [Classes.FactorUnit("Meter", "m", 1.0)] Meter,
        [Classes.FactorUnit("Kilometer", "km", 1000)] Kilometer,

        [Classes.FactorUnit("Foot", "ft", 0.3048)] Feet,
        [Classes.FactorUnit("Inch", "in", 0.0254)] Inch,
    }
}