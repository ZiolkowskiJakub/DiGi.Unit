using System.ComponentModel;

namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for wavenumber measurement (spatial frequency).
    /// </summary>
    [Classes.Category(UnitCategory.Wavenumber), Description("The spatial frequency of a wave, expressed as the number of waves per unit distance")]
    public enum WavenumberUnit
    {
        /// <summary>
        /// Reciprocal meter (1/m).
        /// </summary>
        [Classes.FactorUnit("Reciprocal meter", "1/m", 1.0)] ReciprocalMeter,

        /// <summary>
        /// Reciprocal centimeter (1/cm).
        /// </summary>
        [Classes.FactorUnit("Reciprocal centimeter", "1/cm", 100.0)] ReciprocalCentimeter,

        /// <summary>
        /// Reciprocal millimeter (1/mm).
        /// </summary>
        [Classes.FactorUnit("Reciprocal millimeter", "1/mm", 1000.0)] ReciprocalMillimeter,

        /// <summary>
        /// Reciprocal micrometer (1/µm).
        /// </summary>
        [Classes.FactorUnit("Reciprocal micrometer", "1/µm", 1000000.0)] ReciprocalMicrometer,
    }
}
