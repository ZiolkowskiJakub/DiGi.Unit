using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        public static Classes.Category? Category(this Enum? @enum)
        {
            if(@enum is null)
            {
                return null;
            }

            return Core.Query.CustomAttribute<Classes.Category>(@enum.GetType());
        }
    }
}