using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for structural stiffness measurement (force per unit displacement).
    /// </summary>
    [Classes.Category(UnitCategory.Stiffness), Description("The extent to which an object resists deformation in response to an applied force")]
    public enum StiffnessUnit
    {
        /// <summary>
        /// Newton per meter (N/m).
        /// </summary>
        [Classes.FactorUnit("Newton per meter", "N/m", 1.0)] NewtonPerMeter,

        /// <summary>
        /// Kilonewton per meter (kN/m).
        /// </summary>
        [Classes.FactorUnit("Kilonewton per meter", "kN/m", 1000.0)] KilonewtonPerMeter,

        /// <summary>
        /// Meganewton per meter (MN/m).
        /// </summary>
        [Classes.FactorUnit("Meganewton per meter", "MN/m", 1000000.0)] MeganewtonPerMeter,

        /// <summary>
        /// Newton per millimeter (N/mm).
        /// </summary>
        [Classes.FactorUnit("Newton per millimeter", "N/mm", 1000.0)] NewtonPerMillimeter,

        /// <summary>
        /// Kilonewton per millimeter (kN/mm).
        /// </summary>
        [Classes.FactorUnit("Kilonewton per millimeter", "kN/mm", 1000000.0)] KilonewtonPerMillimeter,

        /// <summary>
        /// Pound-force per inch (lbf/in).
        /// </summary>
        [Classes.FactorUnit("Pound-force per inch", "lbf/in", 175.126835)] PoundForcePerInch,

        /// <summary>
        /// Kip per inch (kip/in).
        /// </summary>
        [Classes.FactorUnit("Kip per inch", "kip/in", 175126.835)] KipPerInch,
    }
}
