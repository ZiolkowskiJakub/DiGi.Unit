using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Unit.Classes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class LinearUnit : FactorUnit
    {
        public LinearUnit(string? name, string? symbol, double factor, double offset)
            : base(name, symbol, factor)
        {
            Offset = offset;
        }

        public LinearUnit(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public LinearUnit(LinearUnit linearUnit)
            : base(linearUnit)
        {
            if (linearUnit is not null)
            {
                Offset = linearUnit.Offset;
            }
        }

        [JsonInclude, JsonPropertyName(nameof(Offset))]
        public double Offset { get; }

        public override ISerializableObject? Clone()
        {
            return new LinearUnit(this);
        }

        public override double From(double value)
        {
            return (value * Factor) + Offset;
        }

        public override double To(double value)
        {
            return (value - Offset) / Factor;
        }
    }
}