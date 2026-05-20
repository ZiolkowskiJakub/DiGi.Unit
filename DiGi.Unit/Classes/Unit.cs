using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Unit.Enums;
using System.Text.Json.Serialization;

namespace DiGi.Unit.Classes
{
    public class Unit : SerializableObject, INamedObject
    {
        [JsonInclude, JsonPropertyName(nameof(Enum))]
        private readonly System.Enum @enum;

        [JsonIgnore]
        private CategoryAttribute? categoryAttribute;

        [JsonIgnore]
        private UnitAttribute? unitAttribute;

        public Unit(System.Enum @enum)
        {
            this.@enum = @enum;
        }

        public CategoryAttribute? CategoryAttribute
        {
            get
            {
                categoryAttribute ??= Query.CategoryAttribute(@enum);
                return categoryAttribute;
            }
        }

        public System.Enum Enum
        {
            get
            {
                return @enum;
            }
        }

        [JsonIgnore]
        public string? Name
        {
            get
            {
                return UnitAttribute?.Name;
            }
        }

        [JsonIgnore]
        public string? Symbol
        {
            get
            {
                return UnitAttribute?.Symbol;
            }
        }

        [JsonIgnore]
        public UnitAttribute? UnitAttribute
        {
            get
            {
                unitAttribute ??= Query.UnitAttribute(@enum);
                return unitAttribute;
            }
        }

        [JsonIgnore]
        public UnitCategory UnitCategory
        {
            get
            {
                return CategoryAttribute?.UnitCategory ?? UnitCategory.Undefined;
            }
        }

        public static explicit operator System.Enum?(Unit unit)
        {
            return unit?.Enum;
        }

        public static explicit operator Unit?(System.Enum? @enum)
        {
            if (@enum is null)
            {
                return null;
            }

            return new Unit(@enum);
        }

        public double From(double value)
        {
            if (UnitAttribute is not null)
            {
                return UnitAttribute.From(value);
            }

            return double.NaN;
        }

        public TEnum? GetEnum<TEnum>() where TEnum : System.Enum
        {
            if (@enum is TEnum enum_Temp)
            {
                return enum_Temp;
            }

            return default;
        }

        public bool IsValid()
        {
            return CategoryAttribute is not null && UnitAttribute is not null;
        }

        public double To(double value)
        {
            if (UnitAttribute is not null)
            {
                return UnitAttribute.From(value);
            }

            return double.NaN;
        }

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