using System;
using System.Collections.Generic;
using System.Reflection;

namespace DiGi.Unit.Classes
{
    /// <summary>
    /// Manages a collection of units, providing functionality to add, retrieve, and perform conversions between different unit types.
    /// </summary>
    public class UnitManager
    {
        private readonly Dictionary<Enum, Unit> units = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitManager"/> class.
        /// </summary>
        public UnitManager()
        {
        }

        /// <summary>
        /// Adds a unit associated with the specified enum value to the manager.
        /// </summary>
        /// <param name="enum">The enum value representing the unit.</param>
        /// <returns>The created or existing <see cref="Unit"/> object, or null if the enum is null or the unit is invalid.</returns>
        public Unit? Add(Enum? @enum)
        {
            if (@enum is null)
            {
                return null;
            }

            if (units.TryGetValue(@enum, out Unit result) && result is not null)
            {
                return result;
            }

            Unit unit = new(@enum);
            if (!unit.IsValid())
            {
                return null;
            }

            units[@enum] = unit;
            return unit;
        }

        /// <summary>
        /// Adds all units defined within the specified Enum type to the manager.
        /// </summary>
        /// <param name="type">The Type of the enum containing the units.</param>
        /// <returns>A list of successfully added <see cref="Unit"/> objects, or null if the type is null.</returns>
        public List<Unit>? AddRange(Type? type)
        {
            if (type is null)
            {
                return null;
            }

            List<Unit> result = [];
            foreach (Enum value in Enum.GetValues(type))
            {
                if (Add(value) is Unit unit)
                {
                    result.Add(unit);
                }
            }
            return result;
        }

        /// <summary>
        /// Scans the specified assembly for all Enum types decorated with a <see cref="CategoryAttribute"/> and adds them to the manager.
        /// </summary>
        /// <param name="assembly">The assembly to scan for unit enums.</param>
        /// <returns>A list of all successfully added <see cref="Unit"/> objects, or null if the assembly is null.</returns>
        public List<Unit>? AddRange(Assembly? assembly)
        {
            if(assembly is null)
            {
                return null;
            }

            Type[] types = assembly.GetTypes();

            List<Unit> result = [];

            foreach (Type type in types)
            {
                if (!type.IsEnum)
                {
                    continue;
                }

                if (type.GetCustomAttribute<CategoryAttribute>() is null)
                {
                    continue;
                }

                List<Unit>? units = AddRange(type);
                if (units is not null)
                {
                    result.AddRange(units);
                }
            }

            return result;
        }

        /// <summary>
        /// Converts a value from the specified unit to its base representation.
        /// </summary>
        /// <param name="enum">The enum value representing the source unit.</param>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="update">Whether to automatically add the unit to the manager if it is not already present.</param>
        /// <returns>The converted value, or double.NaN if the unit could not be retrieved.</returns>
        public double From(Enum? @enum, double value, bool update = true)
        {
            Unit? unit = GetUnit(@enum, update);
            if (unit is null)
            {
                return double.NaN;
            }

            return unit.From(value);
        }

        /// <summary>
        /// Retrieves the category attribute associated with the specified unit enum.
        /// </summary>
        /// <param name="enum">The enum value representing the unit.</param>
        /// <param name="update">Whether to automatically add the unit to the manager if it is not already present.</param>
        /// <returns>The <see cref="CategoryAttribute"/> associated with the unit, or null if the unit could not be retrieved.</returns>
        public CategoryAttribute? GetCategoryAttribute(Enum? @enum, bool update = true)
        {
            Unit? unit = GetUnit(@enum, update);
            if (unit is null)
            {
                return null;
            }

            return unit.CategoryAttribute;
        }

        /// <summary>
        /// Retrieves the <see cref="Unit"/> object associated with the specified enum value.
        /// </summary>
        /// <param name="enum">The enum value representing the unit.</param>
        /// <param name="update">Whether to automatically add the unit to the manager if it is not already present.</param>
        /// <returns>The <see cref="Unit"/> object, or null if the enum is null or the unit cannot be found/created.</returns>
        public Unit? GetUnit(Enum? @enum, bool update = true)
        {
            if (@enum is null)
            {
                return null;
            }

            if (units.TryGetValue(@enum, out Unit result))
            {
                return result;
            }

            if(!update)
            {
                return null;
            }

            return Add(@enum);
        }
        
        /// <summary>
        /// Retrieves the unit attribute associated with the specified unit enum.
        /// </summary>
        /// <param name="enum">The enum value representing the unit.</param>
        /// <param name="update">Whether to automatically add the unit to the manager if it is not already present.</param>
        /// <returns>The <see cref="UnitAttribute"/> associated with the unit, or null if the unit could not be retrieved.</returns>
        public UnitAttribute? GetUnitAttribute(Enum? @enum, bool update = true)
        {
            Unit? unit = GetUnit(@enum, update);
            if (unit is null)
            {
                return null;
            }

            return unit.UnitAttribute;
        }
        
        /// <summary>
        /// Converts a base representation value to the specified unit.
        /// </summary>
        /// <param name="enum">The enum value representing the target unit.</param>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="update">Whether to automatically add the unit to the manager if it is not already present.</param>
        /// <returns>The converted value, or double.NaN if the unit could not be retrieved.</returns>
        public double To(Enum? @enum, double value, bool update = true)
        {
            Unit? unit = GetUnit(@enum, update);
            if (unit is null)
            {
                return double.NaN;
            }

            return unit.To(value);
        }
    }
}