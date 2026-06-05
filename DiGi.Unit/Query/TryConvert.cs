using DiGi.Unit.Classes;
using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to convert a numeric value from one unit to another.
        /// </summary>
        /// <param name="value">The numeric value to be converted.</param>
        /// <param name="from">The source unit.</param>
        /// <param name="to">The target unit.</param>
        /// <param name="result">When this method returns, contains the converted value if successful; otherwise, null.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
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

        /// <summary>
        /// Attempts to convert a numeric value from one unit to another and rounds the result based on the specified tolerance.
        /// </summary>
        /// <param name="value">The numeric value to be converted.</param>
        /// <param name="from">The source unit.</param>
        /// <param name="to">The target unit.</param>
        /// <param name="result">When this method returns, contains the converted and rounded value if successful; otherwise, null.</param>
        /// <param name="tolerance">The precision used to round the resulting value.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert(double value, Classes.Unit? from, Classes.Unit? to, out double? result, double tolerance)
        {
            if (!TryConvert(value, from, to, out result) || result is null)
            {
                return false;
            }

            result = Core.Query.Round(result.Value, tolerance);
            return true;
        }

        /// <summary>
        /// Attempts to convert a numeric value between two units specified as enum values.
        /// </summary>
        /// <param name="value">The numeric value to be converted.</param>
        /// <param name="from">The source unit represented as an Enum.</param>
        /// <param name="to">The target unit represented as an Enum.</param>
        /// <param name="result">When this method returns, contains the converted value if successful; otherwise, null.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert(double value, Enum from, Enum to, out double? result)
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

        /// <summary>
        /// Attempts to convert a numeric value between two units specified as enum values and rounds the result based on the specified tolerance.
        /// </summary>
        /// <param name="value">The numeric value to be converted.</param>
        /// <param name="from">The source unit represented as an Enum.</param>
        /// <param name="to">The target unit represented as an Enum.</param>
        /// <param name="result">When this method returns, contains the converted and rounded value if successful; otherwise, null.</param>
        /// <param name="tolerance">The precision used to round the resulting value.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert(double value, Enum from, Enum to, out double? result, double tolerance)
        {
            if (!TryConvert(value, from, to, out result) || result is null)
            {
                return false;
            }

            result = Core.Query.Round(result.Value, tolerance);
            return true;
        }

        /// <summary>
        /// Attempts to convert a numeric value using the provided unit attributes.
        /// </summary>
        /// <param name="value">The numeric value to be converted.</param>
        /// <param name="from">The source unit attribute.</param>
        /// <param name="to">The target unit attribute.</param>
        /// <param name="result">When this method returns, contains the converted value if successful; otherwise, null.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
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

        /// <summary>
        /// Attempts to convert a numeric value using the provided unit attributes and rounds the result based on the specified tolerance.
        /// </summary>
        /// <param name="value">The numeric value to be converted.</param>
        /// <param name="from">The source unit attribute.</param>
        /// <param name="to">The target unit attribute.</param>
        /// <param name="result">When this method returns, contains the converted and rounded value if successful; otherwise, null.</param>
        /// <param name="tolerance">The precision used to round the resulting value.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
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