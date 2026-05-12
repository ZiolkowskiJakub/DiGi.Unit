using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Unit.Classes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class FactorUnit : Unit
    {
        public FactorUnit(string? name, string? symbol, double factor)
            : base(name, symbol)
        {
            Factor = factor;
        }

        public FactorUnit(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public FactorUnit(FactorUnit factorUnit)
            : base(factorUnit)
        {
            if (factorUnit is not null)
            {
                Factor = factorUnit.Factor;
            }
        }

        [JsonInclude, JsonPropertyName(nameof(Factor))]
        public double Factor { get; }

        public override ISerializableObject? Clone()
        {
            return new FactorUnit(this);
        }

        public override double From(double value)
        {
            return value * Factor;
        }

        public override double To(double value)
        {
            return value / Factor;
        }
    }
}