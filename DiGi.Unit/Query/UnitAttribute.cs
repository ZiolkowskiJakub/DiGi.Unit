using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the UnitAttribute associated with the provided enum value.
        /// </summary>
        /// <param name="enum">The enum value to check for the attribute.</param>
        /// <returns>The <see cref="Classes.UnitAttribute"/> if found; otherwise, null.</returns>
        public static Classes.UnitAttribute? UnitAttribute(this Enum? @enum)
        {
            return Core.Query.CustomAttribute<Classes.UnitAttribute>(@enum);
        }
    }
}