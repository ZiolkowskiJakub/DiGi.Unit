using DiGi.Core;
using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Unit.Classes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public abstract class Unit : Attribute, ISerializableObject, INamedObject
    {
        public Unit(string? name, string? symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public Unit(JsonObject jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        public Unit(Unit unit)
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