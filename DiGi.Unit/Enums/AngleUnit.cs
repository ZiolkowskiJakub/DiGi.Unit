namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units of measurement for angles.
    /// </summary>
    [Classes.Category(UnitCategory.Angle)]
    public enum AngleUnit
    {
        /// <summary>
        /// Represents an angle measured in degrees.
        /// </summary>
        [Classes.FactorUnit("Degree", "°", System.Math.PI / 180.0)] Degree,

        /// <summary>
        /// Represents an angle measured in radians.
        /// </summary>
        [Classes.FactorUnit("Radian", "rad", 1)] Radian,
    }
}