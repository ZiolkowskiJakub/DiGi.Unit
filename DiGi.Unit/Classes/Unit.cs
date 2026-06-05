using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Unit.Enums;
using System.Text.Json.Serialization;

namespace DiGi.Unit.Classes
{
    /// <summary>
    /// Represents a measurement unit associated with an enumeration value, providing access to its attributes and conversion capabilities.
    /// </summary>
    public class Unit : SerializableObject, INamedObject
    {
        [JsonInclude, JsonPropertyName(nameof(Enum))]
        private readonly System.Enum @enum;

        [JsonIgnore]
        private CategoryAttribute? categoryAttribute;

        [JsonIgnore]
        private UnitAttribute? unitAttribute;

        /// <summary>
        /// Initializes a new instance of the <see cref="Unit"/> class with the specified enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value representing the unit.</param>
        public Unit(System.Enum @enum)
        {
            this.@enum = @enum;
        }

        /// <summary>
        /// Gets the category attribute associated with this unit.
        /// </summary>
        public CategoryAttribute? CategoryAttribute
        {
            get
            {
                categoryAttribute ??= Query.CategoryAttribute(@enum);
                return categoryAttribute;
            }
        }

        /// <summary>
        /// Gets the underlying enumeration value of this unit.
        /// </summary>
        public System.Enum Enum
        {
            get
            {
                return @enum;
            }
        }

        /// <summary>
        /// Gets the name of the unit as defined in its attributes.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return UnitAttribute?.Name;
            }
        }

        /// <summary>
        /// Gets the symbol of the unit as defined in its attributes.
        /// </summary>
        [JsonIgnore]
        public string? Symbol
        {
            get
            {
                return UnitAttribute?.Symbol;
            }
        }

        /// <summary>
        /// Gets the unit attribute containing metadata and conversion logic for this unit.
        /// </summary>
        [JsonIgnore]
        public UnitAttribute? UnitAttribute
        {
            get
            {
                unitAttribute ??= Query.UnitAttribute(@enum);
                return unitAttribute;
            }
        }

        /// <summary>
        /// Gets the category to which this unit belongs, or <see cref="UnitCategory.Undefined"/> if not specified.
        /// </summary>
        [JsonIgnore]
        public UnitCategory UnitCategory
        {
            get
            {
                return CategoryAttribute?.UnitCategory ?? UnitCategory.Undefined;
            }
        }

        /// <summary>
        /// Explicitly converts a <see cref="Unit"/> instance to its underlying enumeration value.
        /// </summary>
        /// <param name="unit">The unit instance to convert.</param>
        /// <returns>The underlying <see cref="System.Enum"/> value, or null if the unit is null.</returns>
        public static explicit operator System.Enum?(Unit unit)
        {
            return unit?.Enum;
        }

        /// <summary>
        /// Explicitly converts an enumeration value to a <see cref="Unit"/> instance.
        /// </summary>
        /// <param name="enum">The enumeration value to convert.</param>
        /// <returns>A new <see cref="Unit"/> instance, or null if the provided enum is null.</returns>
        public static explicit operator Unit?(System.Enum? @enum)
        {
            if (@enum is null)
            {
                return null;
            }

            return new Unit(@enum);
        }

        /// <summary>
        /// Converts a value from the unit's scale to its base representation.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value, or <see cref="double.NaN"/> if the unit attribute is missing.</returns>
        public double From(double value)
        {
            if (UnitAttribute is not null)
            {
                return UnitAttribute.From(value);
            }

            return double.NaN;
        }

        /// <summary>
        /// Attempts to retrieve the underlying enumeration value cast to a specific enum type.
        /// </summary>
        /// <typeparam name="TEnum">The expected enumeration type.</typeparam>
        /// <returns>The enumeration value cast to <typeparamref name="TEnum"/>, or default if the types do not match.</returns>
        public TEnum? GetEnum<TEnum>() where TEnum : System.Enum
        {
            if (@enum is TEnum enum_Temp)
            {
                return enum_Temp;
            }

            return default;
        }

        /// <summary>
        /// Determines whether the unit is valid by checking if both its category and unit attributes are present.
        /// </summary>
        /// <returns>True if the unit is valid; otherwise, false.</returns>
        public bool IsValid()
        {
            return CategoryAttribute is not null && UnitAttribute is not null;
        }

        /// <summary>
        /// Converts a base value to the unit's scale.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value, or <see cref="double.NaN"/> if the unit attribute is missing.</returns>
        public double To(double value)
        {
            if (UnitAttribute is not null)
            {
                return UnitAttribute.From(value);
            }

            return double.NaN;
        }

        /// <summary>
        /// Attempts to extract the underlying enumeration value as a specific type.
        /// </summary>
        /// <typeparam name="TEnum">The expected enumeration type.</typeparam>
        /// <param name="enum">When this method returns, contains the enumeration value if successful; otherwise, the default value of <typeparamref name="TEnum"/>.</param>
        /// <returns>True if the underlying enum is of type <typeparamref name="TEnum"/>; otherwise, false.</returns>
        public bool TryGetEnum<TEnum>(out TEnum? @enum) where TEnum : System.Enum
        {
            @enum = default;

            if (this.@enum is TEnum enum_Temp)
            {
                @enum = enum_Temp;
                return true;
            }

            return false;
        }
    }
}