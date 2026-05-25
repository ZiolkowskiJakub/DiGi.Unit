using DiGi.Unit.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Unit.IO.Classes
{
    public class UnitColumn : Core.IO.Table.Classes.ExtendedColumn
    {
        public UnitColumn(string? name, Unit.Classes.Unit? unit, string? category, string? description)
            : base(name, typeof(double), category, description)
        {
            Unit = Core.Query.Clone(unit);
        }

        public UnitColumn(string? name, Unit.Classes.Unit? unit, string? category, string? description, UnitDataType unitDataType)
            : base(name, Query.Type(unitDataType), category, description)
        {
            Unit = Core.Query.Clone(unit);
        }

        public UnitColumn(UnitColumn unitColumn)
            : base(unitColumn)
        {
            if (unitColumn is not null)
            {
                Unit = Core.Query.Clone(unitColumn.Unit);
            }
        }

        public UnitColumn(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonInclude, JsonPropertyName(nameof(Unit))]
        public Unit.Classes.Unit? Unit { get; set; }
        
        public UnitDataType UnitDataType
        {
            get
            {
                return Query.UnitDataType(Type);
            }
        }

    }
}
