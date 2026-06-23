namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for pressure measurement.
    /// </summary>
    [Classes.Category(UnitCategory.Pressure)]
    public enum PressureUnit
    {
        /// <summary>
        /// Pascal unit of pressure (SI derived unit).
        /// </summary>
        [Classes.FactorUnit("Pascal", "Pa", 1.0)] Pascal,

        /// <summary>
        /// Millipascal unit of pressure.
        /// </summary>
        [Classes.FactorUnit("Millipascal", "mPa", 0.001)] Millipascal,

        /// <summary>
        /// Micropascal unit of pressure.
        /// </summary>
        [Classes.FactorUnit("Micropascal", "µPa", 0.000001)] Micropascal,

        /// <summary>
        /// Kilopascal unit of pressure.
        /// </summary>
        [Classes.FactorUnit("Kilopascal", "kPa", 1000.0)] Kilopascal,

        /// <summary>
        /// Megapascal unit of pressure.
        /// </summary>
        [Classes.FactorUnit("Megapascal", "MPa", 1000000.0)] Megapascal,

        /// <summary>
        /// Bar unit of pressure.
        /// </summary>
        [Classes.FactorUnit("Bar", "bar", 100000.0)] Bar,

        /// <summary>
        /// Millibar unit of pressure.
        /// </summary>
        [Classes.FactorUnit("Millibar", "mbar", 100.0)] Millibar,

        /// <summary>
        /// Pounds per square inch unit of pressure.
        /// </summary>
        [Classes.FactorUnit("Pounds per square inch", "psi", 4.4482216152605 / (0.0254 * 0.0254))] Psi,

        /// <summary>
        /// Standard atmosphere unit of pressure.
        /// </summary>
        [Classes.FactorUnit("Standard atmosphere", "atm", 101325.0)] Atmosphere,
    }
}