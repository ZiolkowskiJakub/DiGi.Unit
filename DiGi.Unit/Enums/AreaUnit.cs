namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.Area)]
    public enum AreaUnit
    {
        [Classes.FactorUnit("Square milimeter", "mm²", 0.00001)] SquareMilimeter,
        [Classes.FactorUnit("Square meter", "m²", 1.0)] SquareMeter,
        [Classes.FactorUnit("Square kilometer", "km²", 1000000)] SquareKilometer,
    }
}
