using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Unit.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Unit.Classes
{
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = true, Inherited = true)]
    public sealed class CategoryAttribute : Attribute, ISerializableObject, INamedObject
    {
        public CategoryAttribute(UnitCategory unitCategory)
        {
            Name = unitCategory.ToString() ?? Enums.UnitCategory.Undefined.ToString();
        }

        public CategoryAttribute(JsonObject jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        public CategoryAttribute(CategoryAttribute category)
        {
            if (category is not null)
            {
                Name = category.Name;
            }
        }

        [JsonInclude, JsonPropertyName(nameof(Name))]
        public string Name { get; } = Enums.UnitCategory.Other.ToString();

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

        public static implicit operator CategoryAttribute(UnitCategory unitCategory)
        {
            return new CategoryAttribute(unitCategory);
        }

        public static implicit operator CategoryAttribute(string name)
        {
            return new CategoryAttribute(name);
        }

        public ISerializableObject? Clone()
        {
            return new CategoryAttribute(this);
        }

        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        public JsonObject? ToJsonObject()
        {
            return Core.Convert.ToJson(this);
        }
    }
}