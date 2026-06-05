using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Unit.Classes
{
    /// <summary>
    /// Represents an attribute for linear unit conversion that incorporates both a multiplication factor and an additive offset.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class LinearUnitAttribute : FactorUnitAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinearUnitAttribute"/> class with specified name, symbol, factor, and offset.
        /// </summary>
        /// <param name="name">The display name of the unit.</param>
        /// <param name="symbol">The symbol representing the unit.</param>
        /// <param name="factor">The multiplication factor used for conversion.</param>
        /// <param name="offset">The additive offset used for conversion.</param>
        public LinearUnitAttribute(string? name, string? symbol, double factor, double offset)
            : base(name, symbol, factor)
        {
            Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearUnitAttribute"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the unit configuration.</param>
        public LinearUnitAttribute(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearUnitAttribute"/> class by copying an existing linear unit attribute.
        /// </summary>
        /// <param name="linearUnit">The source <see cref="LinearUnitAttribute"/> to copy from.</param>
        public LinearUnitAttribute(LinearUnitAttribute linearUnit)
            : base(linearUnit)
        {
            if (linearUnit is not null)
            {
                Offset = linearUnit.Offset;
            }
        }

        /// <summary>
        /// Gets the additive offset used in the linear conversion calculation.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Offset))]
        public double Offset { get; }

        /// <summary>
        /// Creates a clone of the current linear unit attribute.
        /// </summary>
        /// <returns>A new instance of <see cref="LinearUnitAttribute"/> as an <see cref="ISerializableObject"/>.</returns>
        public override ISerializableObject? Clone()
        {
            return new LinearUnitAttribute(this);
        }

        /// <summary>
        /// Converts a value from the base unit to the target linear unit.
        /// </summary>
        /// <param name="value">The value in the base unit.</param>
        /// <returns>The converted value after applying the factor and offset.</returns>
        public override double From(double value)
        {
            return (value * Factor) + Offset;
        }

        /// <summary>
        /// Converts a value from the target linear unit back to the base unit.
        /// </summary>
        /// <param name="value">The value in the target linear unit.</param>
        /// <returns>The converted value after removing the offset and dividing by the factor.</returns>
        public override double To(double value)
        {
            return (value - Offset) / Factor;
        }
    }
}