namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.Area)]
    public enum AreaUnit
    {
        [Classes.FactorUnit("Square millimeter", "mm2", 0.000001)] SquareMillimeter,
        [Classes.FactorUnit("Square meter", "m2", 1.0)] SquareMeter,
        [Classes.FactorUnit("Square kilometer", "km2", 1000000)] SquareKilometer,

        [Classes.FactorUnit("Square foot", "ft2", 0.09290304)] SquareFoot,
        [Classes.FactorUnit("Square inch", "in2", 0.00064516)] SquareInch,
    }
}