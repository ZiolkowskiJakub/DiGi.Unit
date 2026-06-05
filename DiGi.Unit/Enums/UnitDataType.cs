using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Specifies the data type of a unit.
    /// </summary>
    [Description("UnitDataType")]
    public enum UnitDataType
    {
        /// <summary>
        /// The data type is undefined.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// Signed 4 bytes float.
        /// </summary>
        [Description("Signed 4 bytes float")] Float,

        /// <summary>
        /// Signed 8 bytes double.
        /// </summary>
        [Description("Signed 8 bytes double")] Double,

        /// <summary>
        /// Signed 16 bytes decimal.
        /// </summary>
        [Description("Signed 16 bytes decimal")] Decimal,
    }
}