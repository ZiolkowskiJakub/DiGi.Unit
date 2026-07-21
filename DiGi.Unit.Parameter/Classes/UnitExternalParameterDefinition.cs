using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Classes;
using DiGi.Core.Parameter.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Unit.Parameter.Classes
{
    using Unit = DiGi.Unit.Classes.Unit;

    /// <summary>
    /// Represents an external parameter definition that includes a unit of measurement.
    /// </summary>
    public class UnitExternalParameterDefinition : ExternalParameterDefinition
    {
        [JsonInclude, JsonPropertyName(nameof(Unit))]
        private readonly Unit? unit;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitExternalParameterDefinition"/> class with full parameters and unit.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        /// <param name="accessType">The access type.</param>
        /// <param name="parameterValue">The parameter value.</param>
        /// <param name="associatedTypes">The associated types.</param>
        /// <param name="groupName">The group name.</param>
        /// <param name="unit">The unit of measurement.</param>
        public UnitExternalParameterDefinition(
            Guid guid,
            string? name,
            string? description,
            AccessType accessType,
            ParameterValue? parameterValue,
            AssociatedTypes associatedTypes,
            string? groupName,
            Unit? unit = null)
            : base(guid, name, description, accessType, parameterValue, associatedTypes, groupName)
        {
            this.unit = Core.Query.Clone(unit);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitExternalParameterDefinition"/> class with full parameters and unit enumeration value.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        /// <param name="accessType">The access type.</param>
        /// <param name="parameterValue">The parameter value.</param>
        /// <param name="associatedTypes">The associated types.</param>
        /// <param name="groupName">The group name.</param>
        /// <param name="enum">The unit enumeration value.</param>
        public UnitExternalParameterDefinition(
            Guid guid,
            string? name,
            string? description,
            AccessType accessType,
            ParameterValue? parameterValue,
            AssociatedTypes associatedTypes,
            string? groupName,
            System.Enum? @enum)
            : this(guid, name, description, accessType, parameterValue, associatedTypes, groupName, @enum is null ? null : new Unit(@enum))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitExternalParameterDefinition"/> class by copying another instance.
        /// </summary>
        /// <param name="unitExternalParameterDefinition">The instance to copy from.</param>
        public UnitExternalParameterDefinition(UnitExternalParameterDefinition? unitExternalParameterDefinition)
            : base(unitExternalParameterDefinition)
        {
            if (unitExternalParameterDefinition != null)
            {
                unit = Core.Query.Clone(unitExternalParameterDefinition.unit);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitExternalParameterDefinition"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing parameter definition data.</param>
        public UnitExternalParameterDefinition(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitExternalParameterDefinition"/> class.
        /// </summary>
        public UnitExternalParameterDefinition()
            : base()
        {
        }

        /// <summary>
        /// Gets the unit of measurement associated with the parameter definition.
        /// </summary>
        [JsonIgnore]
        public Unit? Unit
        {
            get
            {
                return Core.Query.Clone(unit);
            }
        }
    }
}
