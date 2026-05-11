using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Unit.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Unit.Classes
{
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = true, Inherited = true)]
    public class Category : Attribute, ISerializableObject, INamedObject
    {
        public Category(UnitCategory unitCategory)
        {
            Name = unitCategory.ToString() ?? Enums.UnitCategory.Undefined.ToString();
        }

        public Category(JsonObject jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        public Category(Category category)
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

        public ISerializableObject? Clone()
        {
            throw new NotImplementedException();
        }

        public bool FromJsonObject(JsonObject? jsonObject)
        {
            throw new NotImplementedException();
        }

        public JsonObject? ToJsonObject()
        {
            throw new NotImplementedException();
        }

        public static implicit operator Category(UnitCategory unitCategory)
        {
            return new Category(unitCategory);
        }

        public static implicit operator Category(string name)
        {
            return new Category(name);
        }
    }
}