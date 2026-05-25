using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        public static Type? Type(this Enums.UnitDataType unitDataType)
        {
            switch (unitDataType)
            {
                case Enums.UnitDataType.Decimal:
                    return typeof(decimal);

                case Enums.UnitDataType.Double:
                    return typeof(double);

                case Enums.UnitDataType.Float:
                    return typeof(float);
            }

            return null;
        }
    }
}