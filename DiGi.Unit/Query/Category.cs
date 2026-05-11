using System;
using System.Linq;
using System.Reflection;

namespace DiGi.Unit
{
    public static partial class Query
    {
        public static Classes.Category? Category(this Enum? @enum)
        {
            Type? type = @enum?.GetType();
            if (type == null)
            {
                return null;
            }

            Type type_Temp = Nullable.GetUnderlyingType(type);
            if (type_Temp != null)
            {
                type = type_Temp;
            }

            FieldInfo fieldInfo = type.GetField(@enum!.ToString());

            if (fieldInfo.GetCustomAttributes(typeof(Classes.Category), false) is Classes.Category[] categoryAttributes && categoryAttributes.Any())
            {
                return categoryAttributes[0];
            }

            return @enum.ToString();
        }
    }
}