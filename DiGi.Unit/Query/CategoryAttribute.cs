using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the CategoryAttribute associated with the specified enumeration type.
        /// </summary>
        /// <param name="enum">The enumeration value to evaluate.</param>
        /// <returns>The <see cref="Classes.CategoryAttribute"/> attribute if found; otherwise, null.</returns>
        public static Classes.CategoryAttribute? CategoryAttribute(this Enum? @enum)
        {
            if (@enum is null)
            {
                return null;
            }

            return Core.Query.CustomAttribute<Classes.CategoryAttribute>(@enum.GetType());
        }
    }
}