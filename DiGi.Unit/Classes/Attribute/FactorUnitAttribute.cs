using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Unit.Classes
{
    /// <summary>
    /// Represents an attribute that defines a unit of measurement based on a conversion factor.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class FactorUnitAttribute : UnitAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactorUnitAttribute"/> class.
        /// </summary>
        /// <param name="name">The name of the unit.</param>
        /// <param name="symbol">The symbol representing the unit.</param>
        /// <param name="factor">The conversion factor for the unit.</param>
        public FactorUnitAttribute(string? name, string? symbol, double factor)
            : base(name, symbol)
        {
            Factor = factor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactorUnitAttribute"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the attribute data.</param>
        public FactorUnitAttribute(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactorUnitAttribute"/> class by copying an existing instance.
        /// </summary>
        /// <param name="factorUnit">The source attribute to copy from.</param>
        public FactorUnitAttribute(FactorUnitAttribute factorUnit)
            : base(factorUnit)
        {
            if (factorUnit is not null)
            {
                Factor = factorUnit.Factor;
            }
        }

        /// <summary>
        /// Gets the conversion factor used for value transformations.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Factor))]
        public double Factor { get; }

        /// <summary>
        /// Creates a clone of the current <see cref="FactorUnitAttribute"/> instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> representing the cloned attribute.</returns>
        public override ISerializableObject? Clone()
        {
            return new FactorUnitAttribute(this);
        }

        /// <summary>
        /// Converts a value from the base unit to this specific unit by multiplying it by the factor.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <returns>The converted value.</returns>
        public override double From(double value)
        {
            return value * Factor;
        }

        /// <summary>
        /// Converts a value from this specific unit back to the base unit by dividing it by the factor.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <returns>The converted value.</returns>
        public override double To(double value)
        {
            return value / Factor;
        }
    }
}