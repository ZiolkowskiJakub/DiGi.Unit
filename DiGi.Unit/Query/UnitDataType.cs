using DiGi.Unit.Enums;
using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        public static UnitDataType UnitDataType(this Type? type)
        {
            if(type is null)
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