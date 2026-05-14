namespace DiGi.Unit.Enums
{
    [Classes.Category(UnitCategory.Volume)]
    public enum VolumeUnit
    {
        [Classes.FactorUnit("Cubic millimeter", "mm3", 1e-9)] CubicMillimeter,
        [Classes.FactorUnit("Cubic meter", "m3", 1.0)] CubicMeter,
        [Classes.FactorUnit("Cubic kilometer", "km3", 1e+9)] CubicKilometer,
    }
}