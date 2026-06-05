using DiGi.Unit.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Unit.IO.Classes
{
    /// <summary>
    /// Represents a column in a table that is associated with a specific unit of measurement, extending the basic extended column functionality.
    /// </summary>
    public class UnitColumn : Core.IO.Table.Classes.ExtendedColumn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitColumn"/> class with specified name, unit, category, and description, defaulting the type to double.
        /// </summary>
        /// <param name="name">The name of the column.</param>
        /// <param name="unit">The unit associated with the column.</param>
        /// <param name="category">The category metadata for the column.</param>
        /// <param name="description">The description metadata for the column.</param>
        public UnitColumn(string? name, Unit.Classes.Unit? unit, string? category, string? description)
            : base(name, typeof(double), category, description)
        {
            Unit = Core.Query.Clone(unit);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitColumn"/> class with specified name, unit, category, description, and specific unit data type.
        /// </summary>
        /// <param name="name">The name of the column.</param>
        /// <param name="unit">The unit associated with the column.</param>
        /// <param name="category">The category metadata for the column.</param>
        /// <param name="description">The description metadata for the column.</param>
        /// <param name="unitDataType">The data type of the unit column.</param>
        public UnitColumn(string? name, Unit.Classes.Unit? unit, string? category, string? description, UnitDataType unitDataType)
            : base(name, Query.Type(unitDataType), category, description)
        {
            Unit = Core.Query.Clone(unit);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitColumn"/> class by cloning an existing <see cref="UnitColumn"/> instance.
        /// </summary>
        /// <param name="unitColumn">The source column to clone.</param>
        public UnitColumn(UnitColumn unitColumn)
            : base(unitColumn)
        {
            if (unitColumn is not null)
            {
                Unit = Core.Query.Clone(unitColumn.Unit);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitColumn"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the column data.</param>
        public UnitColumn(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        /// <summary>
        /// Gets or sets the unit associated with this column.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Unit))]
        public Unit.Classes.Unit? Unit { get; set; }
        
        /// <summary>
        /// Gets the unit data type based on the underlying type of the column.
        /// </summary>
        public UnitDataType UnitDataType
        {
            get
            {
                return Query.UnitDataType(Type);
            }
        }

    }
}