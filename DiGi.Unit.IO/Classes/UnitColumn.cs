using System.Text.Json.Serialization;

namespace DiGi.Unit.IO.Classes
{
    public class UnitColumn : Core.IO.Table.Classes.ExtendedColumn
    {
        [JsonInclude, JsonPropertyName(nameof(Unit))]
        public Unit.Classes.Unit? Unit { get; set; }

        public UnitColumn(string? name, Unit.Classes.Unit? unit, string? category, string? description)
            :base(name, typeof(double), category, description)
        {
            this.Unit = Core.Query.Clone(unit);
        }

    }
}
