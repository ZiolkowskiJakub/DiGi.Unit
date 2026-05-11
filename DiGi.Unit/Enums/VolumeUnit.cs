namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.Volume)]
    public enum VolumeUnit
    {
        [Classes.FactorUnit("Cubric milimeter", "mm³", 0.00001)] SquareMilimeter,
        [Classes.FactorUnit("Cubric meter", "m³", 1.0)] SquareMeter,
        [Classes.FactorUnit("Cubric kilometer", "km³", 1000000)] SquareKilometer,
    }
}
