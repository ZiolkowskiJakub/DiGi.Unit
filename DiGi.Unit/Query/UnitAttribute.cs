using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        public static Classes.UnitAttribute? UnitAttribute(this Enum? @enum)
        {
            return Core.Query.CustomAttribute<Classes.UnitAttribute>(@enum);
        }
    }
}