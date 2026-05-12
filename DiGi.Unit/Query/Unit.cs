using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        public static Classes.Unit? Unit(this Enum? @enum)
        {
            return Core.Query.CustomAttribute<Classes.Unit>(@enum);
        }
    }
}