using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Unit.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Unit.Classes
{
    /// <summary>
    /// An attribute used to categorize enums, implementing serialization and naming contracts.
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = true, Inherited = true)]
    public sealed class CategoryAttribute : Attribute, ISerializableObject, INamedObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryAttribute"/> class using a specified unit category.
        /// </summary>
        /// <param name="unitCategory">The unit category to assign.</param>
        public CategoryAttribute(UnitCategory unitCategory)
        {
            Name = unitCategory.ToString() ?? Enums.UnitCategory.Undefined.ToString();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryAttribute"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing category data.</param>
        public CategoryAttribute(JsonObject jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryAttribute"/> class by copying an existing category attribute.
        /// </summary>
        /// <param name="category">The source category attribute to copy.</param>
        public CategoryAttribute(CategoryAttribute category)
        {
            if (category is not null)
            {
                Name = category.Name;
            }
        }

        /// <summary>
        /// Gets the name associated with the category.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Name))]
        public string Name { get; } = Enums.UnitCategory.Other.ToString();

        /// <summary>
        /// Gets the <see cref="UnitCategory"/> enum value corresponding to the current name.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(UnitCategory))]
        public UnitCategory? UnitCategory
        {
            get
            {
                if (Enums.UnitCategory.Other.ToString() == Name)
                {
                    return Enums.UnitCategory.Other;
                }

                if (!Core.Query.TryGetEnum(Name, out UnitCategory result))
                {
                    return Enums.UnitCategory.Undefined;
                }

                return result;
            }
        }

        /// <summary>
        /// Implicitly converts a <see cref="UnitCategory"/> value to a <see cref="CategoryAttribute"/>.
        /// </summary>
        /// <param name="unitCategory">The unit category to convert.</param>
        /// <returns>A new <see cref="CategoryAttribute"/> instance.</returns>
        public static implicit operator CategoryAttribute(UnitCategory unitCategory)
        {
            return new CategoryAttribute(unitCategory);
        }

        /// <summary>
        /// Implicitly converts a string name to a <see cref="CategoryAttribute"/>.
        /// </summary>
        /// <param name="name">The category name to convert.</param>
        /// <returns>A new <see cref="CategoryAttribute"/> instance.</returns>
        public static implicit operator CategoryAttribute(string name)
        {
            return new CategoryAttribute(name);
        }

        /// <summary>
        /// Creates a clone of the current category attribute.
        /// </summary>
        /// <returns>A cloned <see cref="ISerializableObject"/> instance.</returns>
        public ISerializableObject? Clone()
        {
            return new CategoryAttribute(this);
        }

        /// <summary>
        /// Populates the current category attribute from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to read data from.</param>
        /// <returns>True if the population was successful; otherwise, false.</returns>
        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        /// <summary>
        /// Converts the current category attribute to a JSON object.
        /// </summary>
        /// <returns>A <see cref="JsonObject"/> representation of the attribute.</returns>
        public JsonObject? ToJsonObject()
        {
            return Core.Convert.ToJson(this);
        }
    }
}