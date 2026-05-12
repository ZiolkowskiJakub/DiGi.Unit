namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.Area)]
    public enum AreaUnit
    {
        [Classes.FactorUnit("Square millimeter", "mm²", 0.000001)] SquareMillimeter,
        [Classes.FactorUnit("Square meter", "m²", 1.0)] SquareMeter,
        [Classes.FactorUnit("Square kilometer", "km²", 1000000)] SquareKilometer,

        [Classes.FactorUnit("Square foot", "ft²", 0.09290304)] SquareFoot,
        [Classes.FactorUnit("Square inch", "in²", 0.00064516)] SquareInch,
    }
}
