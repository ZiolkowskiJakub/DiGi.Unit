using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    [Description("UnitDataType")]
    public enum UnitDataType
    {
        [Description("Undefined")] Undefined,
        [Description("Signed 4 bytes float")] Float,
        [Description("Signed 8 bytes double")] Double,
        [Description("Signed 16 bytes decimal")] Decimal,
    }
}
