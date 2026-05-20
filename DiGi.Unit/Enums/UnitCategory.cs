using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    [Description("Unit category")]
    public enum UnitCategory
    {
        [Description("Undefined")] Undefined,
        [Description("Length")] Length,
        [Description("Area")] Area,
        [Description("Volume")] Volume,
        [Description("Temperature")] Temperature,
        [Description("Time")] Time,
        [Description("Power Density")] PowerDensity,
        [Description("Density")] Density,
        [Description("Angle")] Angle,
        [Description("Other")] Other,
    }
}