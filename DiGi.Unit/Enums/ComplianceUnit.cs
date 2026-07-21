using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for structural compliance measurement (displacement per unit force, or flexibility).
    /// </summary>
    [Classes.Category(UnitCategory.Compliance), Description("The inverse of stiffness, measuring the displacement per unit force")]
    public enum ComplianceUnit
    {
        /// <summary>
        /// Meter per newton (m/N).
        /// </summary>
        [Classes.FactorUnit("Meter per newton", "m/N", 1.0)] MeterPerNewton,

        /// <summary>
        /// Meter per kilonewton (m/kN).
        /// </summary>
        [Classes.FactorUnit("Meter per kilonewton", "m/kN", 0.001)] MeterPerKilonewton,

        /// <summary>
        /// Millimeter per newton (mm/N).
        /// </summary>
        [Classes.FactorUnit("Millimeter per newton", "mm/N", 0.001)] MillimeterPerNewton,

        /// <summary>
        /// Millimeter per kilonewton (mm/kN).
        /// </summary>
        [Classes.FactorUnit("Millimeter per kilonewton", "mm/kN", 0.000001)] MillimeterPerKilonewton,

        /// <summary>
        /// Inch per pound-force (in/lbf).
        /// </summary>
        [Classes.FactorUnit("Inch per pound-force", "in/lbf", 0.00571014715)] InchPerPoundForce,
    }
}
