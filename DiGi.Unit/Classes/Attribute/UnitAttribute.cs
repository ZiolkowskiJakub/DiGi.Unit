using DiGi.Core;
using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Unit.Classes
{
    /// <summary>
    /// Base abstract class for unit attributes, implementing <see cref="ISerializableObject"/> and <see cref="INamedObject"/> to provide 
    /// standardization for units of measurement including serialization and conversion logic.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public abstract class UnitAttribute : Attribute, ISerializableObject, INamedObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitAttribute"/> class with a specified name and symbol.
        /// </summary>
        /// <param name="name">The descriptive name of the unit.</param>
        /// <param name="symbol">The shorthand symbol representing the unit.</param>
        public UnitAttribute(string? name, string? symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitAttribute"/> class using data from a <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the unit attribute data.</param>
        public UnitAttribute(JsonObject jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitAttribute"/> class by copying values from an existing <see cref="UnitAttribute"/>.
        /// </summary>
        /// <param name="unit">The source unit attribute to copy from.</param>
        public UnitAttribute(UnitAttribute unit)
        {
            if (unit is not null)
            {
                Name = unit.Name;
                Symbol = unit.Symbol;
            }
        }

        /// <summary>
        /// Gets the name of the unit.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Name))]
        public string? Name { get; }

        /// <summary>
        /// Gets the symbol of the unit.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Symbol))]
        public string? Symbol { get; }

        /// <summary>
        /// Creates a clone of the current object.
        /// </summary>
        /// <returns>A cloned instance as an <see cref="ISerializableObject"/>, or null if cloning fails.</returns>
        public abstract ISerializableObject? Clone();

        /// <summary>
        /// Populates the properties of this object from a <see cref="JsonObject"/> using <see cref="Core.Modify.FromJsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object to populate from.</param>
        /// <returns>True if the object was successfully populated; otherwise, false.</returns>
        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        /// <summary>
        /// Converts this object into a <see cref="JsonObject"/> using <see cref="Core.Convert.ToJson"/>.
        /// </summary>
        /// <returns>A <see cref="JsonObject"/> representation of the current instance.</returns>
        public JsonObject? ToJsonObject()
        {
            return Core.Convert.ToJson(this);
        }

        /// <summary>
        /// Converts a value from this unit's scale to a base reference scale.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <returns>The converted value in the base reference scale.</returns>
        public abstract double From(double value);

        /// <summary>
        /// Converts a value from a base reference scale to this unit's scale.
        /// </summary>
        /// <param name="value">The numeric value in the base reference scale.</param>
        /// <returns>The converted value in this unit's scale.</returns>
        public abstract double To(double value);
    }
}