using DiGi.Core.Parameter.Classes;
using DiGi.Core.Parameter.Interfaces;
using DiGi.Unit.Parameter.Classes;
using System;

namespace DiGi.Unit.Parameter
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the measurement unit associated with the specified parameter.
        /// </summary>
        /// <param name="parameter">The parameter to retrieve the unit for.</param>
        /// <returns>The <see cref="DiGi.Unit.Classes.Unit"/> associated with the parameter, or <c>null</c> if not found.</returns>
        public static Unit.Classes.Unit? Unit(this Core.Parameter.Classes.Parameter? parameter)
        {
            return parameter?.ParameterDefinition.Unit();
        }

        /// <summary>
        /// Retrieves the measurement unit associated with the specified parameter definition interface.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition to retrieve the unit for.</param>
        /// <returns>The <see cref="DiGi.Unit.Classes.Unit"/> associated with the parameter definition, or <c>null</c> if not found.</returns>
        public static Unit.Classes.Unit? Unit(this IParameterDefinition? parameterDefinition)
        {
            if (parameterDefinition is UnitExternalParameterDefinition unitExternalParameterDefinition)
            {
                return unitExternalParameterDefinition.Unit;
            }

            if (parameterDefinition is EnumParameterDefinition enumParameterDefinition)
            {
                return enumParameterDefinition.Unit();
            }

            return null;
        }

        /// <summary>
        /// Retrieves the measurement unit associated with the specified parameter definition.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition to retrieve the unit for.</param>
        /// <returns>The <see cref="DiGi.Unit.Classes.Unit"/> associated with the parameter definition, or <c>null</c> if not found.</returns>
        public static Unit.Classes.Unit? Unit(this ParameterDefinition? parameterDefinition)
        {
            return (parameterDefinition as IParameterDefinition).Unit();
        }

        /// <summary>
        /// Retrieves the measurement unit associated with the specified enum parameter definition.
        /// </summary>
        /// <param name="enumParameterDefinition">The enum parameter definition to retrieve the unit for.</param>
        /// <returns>The <see cref="DiGi.Unit.Classes.Unit"/> associated with the enum parameter definition, or <c>null</c> if not found.</returns>
        public static Unit.Classes.Unit? Unit(this EnumParameterDefinition? enumParameterDefinition)
        {
            return enumParameterDefinition?.Enum.Unit();
        }

        /// <summary>
        /// Retrieves the measurement unit associated with the specified unit external parameter definition.
        /// </summary>
        /// <param name="unitExternalParameterDefinition">The unit external parameter definition to retrieve the unit for.</param>
        /// <returns>The <see cref="DiGi.Unit.Classes.Unit"/> associated with the unit external parameter definition, or <c>null</c> if not found.</returns>
        public static Unit.Classes.Unit? Unit(this UnitExternalParameterDefinition? unitExternalParameterDefinition)
        {
            return unitExternalParameterDefinition?.Unit;
        }

        /// <summary>
        /// Retrieves the measurement unit associated with the specified enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value to retrieve the unit for.</param>
        /// <returns>The <see cref="DiGi.Unit.Classes.Unit"/> associated with the enumeration value, or <c>null</c> if not found.</returns>
        public static Unit.Classes.Unit? Unit(this Enum? @enum)
        {
            return Core.Parameter.Query.ParameterProperties<UnitParameterProperties>(@enum)?.Unit;
        }
    }
}