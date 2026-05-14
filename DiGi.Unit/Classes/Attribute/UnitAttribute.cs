using DiGi.Core;
using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Unit.Classes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public abstract class UnitAttribute : Attribute, ISerializableObject, INamedObject
    {
        public UnitAttribute(string? name, string? symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public UnitAttribute(JsonObject jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        public UnitAttribute(UnitAttribute unit)
        {
            if (unit is not null)
            {
                Name = unit.Name;
                Symbol = unit.Symbol;
            }
        }

        [JsonInclude, JsonPropertyName(nameof(Name))]
        public string? Name { get; }

        [JsonInclude, JsonPropertyName(nameof(Symbol))]
        public string? Symbol { get; }

        public abstract ISerializableObject? Clone();

        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        public JsonObject? ToJsonObject()
        {
            return Core.Convert.ToJson(this);
        }

        public abstract double From(double value);

        public abstract double To(double value);
    }
}