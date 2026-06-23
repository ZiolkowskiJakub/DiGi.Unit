using DiGi.Unit.Enums;
using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        /// <summary>
        /// Determines the corresponding <see cref="UnitDataType"/> for a given <see cref="Type"/>.
        /// </summary>
        /// <param name="type">The type to evaluate.</param>
        /// <returns>The matching <see cref="UnitDataType"/> value, or <see cref="UnitDataType.Undefined"/> if the type is null or not a recognized numeric type.</returns>
        public static UnitDataType UnitDataType(this Type? type)
        {
            if (type is null)
            {
                return Enums.UnitDataType.Undefined;
            }

            Type type_Temp = Nullable.GetUnderlyingType(type) ?? type;

            TypeCode typeCode = System.Type.GetTypeCode(type_Temp);

            switch (typeCode)
            {
                case TypeCode.Decimal:
                    return Enums.UnitDataType.Decimal;

                case TypeCode.Double:
                    return Enums.UnitDataType.Double;

                case TypeCode.Single:
                    return Enums.UnitDataType.Float;

                default:
                    break;
            }

            return Enums.UnitDataType.Undefined;
        }
    }
}