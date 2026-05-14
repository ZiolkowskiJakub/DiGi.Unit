using DiGi.Unit.Classes;
using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        public static bool TryConvert(double value, Classes.Unit? from, Classes.Unit? to, out double? result)
        {
            result = null;

            if (from is null || to is null)
            {
                return false;
            }

            CategoryAttribute? category_From = from.CategoryAttribute;
            if (category_From is null)
            {
                return false;
            }

            CategoryAttribute? category_To = to.CategoryAttribute;
            if (category_To is null)
            {
                return false;
            }

            if (!category_From.Equals(category_To))
            {
                return false;
            }

            UnitAttribute? unit_From = from.UnitAttribute;
            if (unit_From is null)
            {
                return false;
            }

            UnitAttribute? unit_To = to.UnitAttribute;
            if (unit_To is null)
            {
                return false;
            }

            return TryConvert(value, unit_From, unit_To, out result);
        }

        public static bool TryConvert(double value, Classes.Unit? from, Classes.Unit? to, out double? result, double tolerance)
        {
            if (!TryConvert(value, from, to, out result) || result is null)
            {
                return false;
            }

            result = Core.Query.Round(result.Value, tolerance);
            return true;
        }

        public static bool TryConvert(double value, Enum? from, Enum? to, out double? result)
        {
            result = null;

            if (from is null || to is null)
            {
                return false;
            }

            CategoryAttribute? category_From = CategoryAttribute(from);
            if (category_From is null)
            {
                return false;
            }

            CategoryAttribute? category_To = CategoryAttribute(to);
            if (category_To is null)
            {
                return false;
            }

            if (!category_From.Equals(category_To))
            {
                return false;
            }

            UnitAttribute? unit_From = UnitAttribute(from);
            if (unit_From is null)
            {
                return false;
            }

            UnitAttribute? unit_To = UnitAttribute(to);
            if (unit_To is null)
            {
                return false;
            }

            return TryConvert(value, unit_From, unit_To, out result);
        }

        public static bool TryConvert(double value, Enum? from, Enum? to, out double? result, double tolerance)
        {
            if (!TryConvert(value, from, to, out result) || result is null)
            {
                return false;
            }

            result = Core.Query.Round(result.Value, tolerance);
            return true;
        }

        public static bool TryConvert(double value, UnitAttribute? from, UnitAttribute? to, out double? result)
        {
            result = null;

            if (from is null || to is null)
            {
                return false;
            }

            try
            {
                // Convert to the base unit (SI)
                double baseValue = from.From(value);
                if (double.IsNaN(baseValue) || double.IsInfinity(baseValue))
                {
                    return false;
                }

                // Convert from base unit to target unit
                double finalValue = to.To(baseValue);
                if (double.IsNaN(finalValue) || double.IsInfinity(finalValue))
                {
                    return false;
                }

                result = finalValue;
                return true;
            }
            catch
            {
            }

            return false;
        }

        public static bool TryConvert(double value, UnitAttribute? from, UnitAttribute? to, out double? result, double tolerance)
        {
            if (!TryConvert(value, from, to, out result) || result is null)
            {
                return false;
            }

            result = Core.Query.Round(result.Value, tolerance);
            return true;
        }
    }
}