using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the .NET Type associated with the specified unit data type.
        /// </summary>
        /// <param name="unitDataType">The unit data type to resolve.</param>
        /// <returns>The corresponding <see cref="Type"/>, or null if no mapping is defined for the provided value.</returns>
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