using DiGi.Core.Parameter.Classes;
using DiGi.Core.Parameter.Enums;
using System;

namespace DiGi.Unit.Parameter.Classes
{
    /// <summary>
    /// Contains metadata and properties for a parameter definition, including unit of measurement.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class UnitParameterProperties : ParameterProperties
    {
        private readonly Unit.Classes.Unit? unit = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitParameterProperties"/> class with a unique identifier, name, and unit.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="unit">The unit of measurement associated with the parameter.</param>
        public UnitParameterProperties(string? uniqueId, string? name, Unit.Classes.Unit? unit = null)
            : base(uniqueId, name)
        {
            this.unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitParameterProperties"/> class with a unique identifier, name, description, and unit.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        /// <param name="unit">The unit of measurement associated with the parameter.</param>
        public UnitParameterProperties(string? uniqueId, string? name, string? description, Unit.Classes.Unit? unit = null)
            : base(uniqueId, name, description)
        {
            this.unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitParameterProperties"/> class with a unique identifier, name, description, access type, and unit.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        /// <param name="accessType">The access type of the parameter.</param>
        /// <param name="unit">The unit of measurement associated with the parameter.</param>
        public UnitParameterProperties(string? uniqueId, string? name, string? description, AccessType accessType, Unit.Classes.Unit? unit = null)
            : base(uniqueId, name, description, accessType)
        {
            this.unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitParameterProperties"/> class with full metadata including group name and unit.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        /// <param name="accessType">The access type of the parameter.</param>
        /// <param name="groupName">The name of the group to which the parameter belongs.</param>
        /// <param name="unit">The unit of measurement associated with the parameter.</param>
        public UnitParameterProperties(string? uniqueId, string? name, string? description, AccessType accessType, string? groupName, Unit.Classes.Unit? unit = null)
            : base(uniqueId, name, description, accessType, groupName)
        {
            this.unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitParameterProperties"/> class with a name and unit.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="unit">The unit of measurement associated with the parameter.</param>
        public UnitParameterProperties(string? name, Unit.Classes.Unit? unit = null)
            : base(name)
        {
            this.unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitParameterProperties"/> class with a name, description, access type, and unit.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        /// <param name="accessType">The access type of the parameter.</param>
        /// <param name="unit">The unit of measurement associated with the parameter.</param>
        public UnitParameterProperties(string? name, string? description, AccessType accessType, Unit.Classes.Unit? unit = null)
            : base(name, description, accessType)
        {
            this.unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitParameterProperties"/> class with a unique identifier, name, and unit enumeration value.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="enum">The unit enumeration value associated with the parameter.</param>
        public UnitParameterProperties(string? uniqueId, string? name, Enum? @enum)
            : this(uniqueId, name, @enum is null ? null : new Unit.Classes.Unit(@enum))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitParameterProperties"/> class with a unique identifier, name, description, and unit enumeration value.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        /// <param name="enum">The unit enumeration value associated with the parameter.</param>
        public UnitParameterProperties(string? uniqueId, string? name, string? description, Enum? @enum)
            : this(uniqueId, name, description, @enum is null ? null : new Unit.Classes.Unit(@enum))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitParameterProperties"/> class with a unique identifier, name, description, access type, and unit enumeration value.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        /// <param name="accessType">The access type of the parameter.</param>
        /// <param name="enum">The unit enumeration value associated with the parameter.</param>
        public UnitParameterProperties(string? uniqueId, string? name, string? description, AccessType accessType, Enum? @enum)
            : this(uniqueId, name, description, accessType, @enum is null ? null : new Unit.Classes.Unit(@enum))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitParameterProperties"/> class with full metadata including group name and unit enumeration value.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        /// <param name="accessType">The access type of the parameter.</param>
        /// <param name="groupName">The name of the group to which the parameter belongs.</param>
        /// <param name="enum">The unit enumeration value associated with the parameter.</param>
        public UnitParameterProperties(string? uniqueId, string? name, string? description, AccessType accessType, string? groupName, Enum? @enum)
            : this(uniqueId, name, description, accessType, groupName, @enum is null ? null : new Unit.Classes.Unit(@enum))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitParameterProperties"/> class with a name and unit enumeration value.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="enum">The unit enumeration value associated with the parameter.</param>
        public UnitParameterProperties(string? name, Enum? @enum)
            : this(name, @enum is null ? null : new Unit.Classes.Unit(@enum))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitParameterProperties"/> class with a name, description, access type, and unit enumeration value.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        /// <param name="accessType">The access type of the parameter.</param>
        /// <param name="enum">The unit enumeration value associated with the parameter.</param>
        public UnitParameterProperties(string? name, string? description, AccessType accessType, Enum? @enum)
            : this(name, description, accessType, @enum is null ? null : new Unit.Classes.Unit(@enum))
        {
        }

        /// <summary>
        /// Gets the unit of measurement associated with the parameter.
        /// </summary>
        public Unit.Classes.Unit? Unit
        {
            get
            {
                return unit;
            }
        }
    }
}
