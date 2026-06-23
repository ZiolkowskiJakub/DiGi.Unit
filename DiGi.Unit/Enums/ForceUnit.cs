namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for force measurement.
    /// </summary>
    [Classes.Category(UnitCategory.Force)]
    public enum ForceUnit
    {
        /// <summary>
        /// Newton unit of force (SI derived unit).
        /// </summary>
        [Classes.FactorUnit("Newton", "N", 1.0)] Newton,

        /// <summary>
        /// Millinewton unit of force.
        /// </summary>
        [Classes.FactorUnit("Millinewton", "mN", 0.001)] Millinewton,

        /// <summary>
        /// Micronewton unit of force.
        /// </summary>
        [Classes.FactorUnit("Micronewton", "µN", 0.000001)] Micronewton,

        /// <summary>
        /// Kilonewton unit of force.
        /// </summary>
        [Classes.FactorUnit("Kilonewton", "kN", 1000.0)] Kilonewton,

        /// <summary>
        /// Meganewton unit of force.
        /// </summary>
        [Classes.FactorUnit("Meganewton", "MN", 1000000.0)] Meganewton,

        /// <summary>
        /// Pound-force unit of force.
        /// </summary>
        [Classes.FactorUnit("Pound-force", "lbf", 4.4482216152605)] PoundForce,
    }
}