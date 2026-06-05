using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the categories of units.
    /// </summary>
    [Description("Unit category")]
    public enum UnitCategory
    {
        /// <summary>
        /// The unit category is undefined.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// Units related to length measurement.
        /// </summary>
        [Description("Length")] Length,

        /// <summary>
        /// Units related to area measurement.
        /// </summary>
        [Description("Area")] Area,

        /// <summary>
        /// Units related to volume measurement.
        /// </summary>
        [Description("Volume")] Volume,

        /// <summary>
        /// Units related to temperature measurement.
        /// </summary>
        [Description("Temperature")] Temperature,

        /// <summary>
        /// Units related to time measurement.
        /// </summary>
        [Description("Time")] Time,

        /// <summary>
        /// Units related to power density measurement.
        /// </summary>
        [Description("Power Density")] PowerDensity,

        /// <summary>
        /// Units related to density measurement.
        /// </summary>
        [Description("Density")] Density,

        /// <summary>
        /// Units related to angle measurement.
        /// </summary>
        [Description("Angle")] Angle,

        /// <summary>
        /// Other unit categories not explicitly defined.
        /// </summary>
        [Description("Other")] Other,
    }
}