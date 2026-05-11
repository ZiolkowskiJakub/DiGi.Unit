using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        public static bool TryConvert(double value, Enum? from, Enum? to, out double? result)
        {
            result = null;

            if (from is null || to is null)
            {
                return false;
            }

            Classes.Category? category_From = Category(from);
            if(category_From is null)
            {
                return false;
            }

            Classes.Category? category_To = Category(to);
            if (category_To is null)
            {
                return false;
            }

            if(category_To != category_From)
            {
                return false;
            }

            return true;
        }
    }
}