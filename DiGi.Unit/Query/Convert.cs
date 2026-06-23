using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        /// <summary>
        /// Converts a value from one unit to another using the specified tolerance. Returns the default value if conversion fails.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of measurement.</param>
        /// <param name="to">The target unit of measurement.</param>
        /// <param name="defaultValue">The value to return if the conversion cannot be performed.</param>
        /// <param name="tolerance">The allowed margin of error for the conversion.</param>
        /// <returns>The converted value, or <paramref name="defaultValue"/> if conversion fails.</returns>
        public static double Convert(double value, Classes.Unit? from, Classes.Unit? to, double defaultValue, double tolerance)
        {
            if (!TryConvert(value, from, to, out double? result, tolerance) || result is null)
            {
                return defaultValue;
            }

            return result.Value;
        }

        /// <summary>
        /// Converts a value from one unit to another. Returns the default value if conversion fails.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of measurement.</param>
        /// <param name="to">The target unit of measurement.</param>
        /// <param name="defaultValue">The value to return if the conversion cannot be performed.</param>
        /// <returns>The converted value, or <paramref name="defaultValue"/> if conversion fails.</returns>
        public static double Convert(double value, Classes.Unit? from, Classes.Unit? to, double defaultValue)
        {
            if (!TryConvert(value, from, to, out double? result) || result is null)
            {
                return defaultValue;
            }

            return result.Value;
        }

        /// <summary>
        /// Converts a value between units defined by Enums using the specified tolerance. Returns the default value if conversion fails or inputs are null.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit Enum.</param>
        /// <param name="to">The target unit Enum.</param>
        /// <param name="defaultValue">The value to return if the conversion cannot be performed.</param>
        /// <param name="tolerance">The allowed margin of error for the conversion.</param>
        /// <returns>The converted value, or <paramref name="defaultValue"/> if conversion fails.</returns>
        public static double Convert(double value, Enum? from, Enum? to, double defaultValue, double tolerance)
        {
            if (from is null || to is null)
            {
                return defaultValue;
            }

            if (!TryConvert(value, from, to, out double? result, tolerance) || result is null)
            {
                return defaultValue;
            }

            return result.Value;
        }

        /// <summary>
        /// Converts a value between units defined by Enums. Returns the default value if conversion fails or inputs are null.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit Enum.</param>
        /// <param name="to">The target unit Enum.</param>
        /// <param name="defaultValue">The value to return if the conversion cannot be performed.</param>
        /// <returns>The converted value, or <paramref name="defaultValue"/> if conversion fails.</returns>
        public static double Convert(double value, Enum? from, Enum? to, double defaultValue)
        {
            if (from is null || to is null)
            {
                return defaultValue;
            }

            if (!TryConvert(value, from, to, out double? result) || result is null)
            {
                return defaultValue;
            }

            return result.Value;
        }

        /// <summary>
        /// Converts a value between units defined by UnitAttributes. Returns the default value if conversion fails.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit attribute.</param>
        /// <param name="to">The target unit attribute.</param>
        /// <param name="defaultValue">The value to return if the conversion cannot be performed.</param>
        /// <returns>The converted value, or <paramref name="defaultValue"/> if conversion fails.</returns>
        public static double Convert(double value, Classes.UnitAttribute? from, Classes.UnitAttribute? to, double defaultValue)
        {
            if (!TryConvert(value, from, to, out double? result) || result is null)
            {
                return defaultValue;
            }

            return result.Value;
        }

        /// <summary>
        /// Converts a value between units defined by UnitAttributes using the specified tolerance. Returns the default value if conversion fails.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit attribute.</param>
        /// <param name="to">The target unit attribute.</param>
        /// <param name="defaultValue">The value to return if the conversion cannot be performed.</param>
        /// <param name="tolerance">The allowed margin of error for the conversion.</param>
        /// <returns>The converted value, or <paramref name="defaultValue"/> if conversion fails.</returns>
        public static double Convert(double value, Classes.UnitAttribute? from, Classes.UnitAttribute? to, double defaultValue, double tolerance)
        {
            if (!TryConvert(value, from, to, out double? result, tolerance) || result is null)
            {
                return defaultValue;
            }

            return result.Value;
        }
    }
}