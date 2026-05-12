namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.Volume)]
    public enum VolumeUnit
    {
        [Classes.FactorUnit("Cubic millimeter", "mm³", 1e-9)] CubicMillimeter,
        [Classes.FactorUnit("Cubic meter", "m³", 1.0)] CubicMeter,
        [Classes.FactorUnit("Cubic kilometer", "km³", 1e+9)] CubicKilometer,
    }
}