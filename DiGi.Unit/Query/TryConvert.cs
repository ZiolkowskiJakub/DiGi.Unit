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

            if (!category_From.Equals(category_To))
            {
                if (IsInverseCategoryPair(category_From.UnitCategory, category_To.UnitCategory))
                {
                    return TryConvertInverse(value, unit_From, unit_To, out result);
                }

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

            if (!category_From.Equals(category_To))
            {
                if (IsInverseCategoryPair(category_From.UnitCategory, category_To.UnitCategory))
                {
                    return TryConvertInverse(value, unit_From, unit_To, out result);
                }

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

        /// <summary>
        /// Checks whether two unit categories form an inverse conversion pair (e.g. ElectricConductance and ElectricResistance).
        /// </summary>
        /// <param name="unitCategory_1">The first unit category.</param>
        /// <param name="unitCategory_2">The second unit category.</param>
        /// <returns>True if the categories form an inverse pair; otherwise, false.</returns>
        public static bool IsInverseCategoryPair(Enums.UnitCategory? unitCategory_1, Enums.UnitCategory? unitCategory_2)
        {
            if (unitCategory_1 is null || unitCategory_2 is null)
            {
                return false;
            }

            if (unitCategory_1 == Enums.UnitCategory.ElectricConductance && unitCategory_2 == Enums.UnitCategory.ElectricResistance)
            {
                return true;
            }

            if (unitCategory_1 == Enums.UnitCategory.ElectricResistance && unitCategory_2 == Enums.UnitCategory.ElectricConductance)
            {
                return true;
            }

            if (unitCategory_1 == Enums.UnitCategory.Time && unitCategory_2 == Enums.UnitCategory.Frequency)
            {
                return true;
            }

            if (unitCategory_1 == Enums.UnitCategory.Frequency && unitCategory_2 == Enums.UnitCategory.Time)
            {
                return true;
            }

            if (unitCategory_1 == Enums.UnitCategory.ThermalResistance && unitCategory_2 == Enums.UnitCategory.ThermalTransmittance)
            {
                return true;
            }

            if (unitCategory_1 == Enums.UnitCategory.ThermalTransmittance && unitCategory_2 == Enums.UnitCategory.ThermalResistance)
            {
                return true;
            }

            if (unitCategory_1 == Enums.UnitCategory.Length && unitCategory_2 == Enums.UnitCategory.Wavenumber)
            {
                return true;
            }

            if (unitCategory_1 == Enums.UnitCategory.Wavenumber && unitCategory_2 == Enums.UnitCategory.Length)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Attempts to perform an inverse unit conversion (1 / baseValue) between two unit attributes.
        /// </summary>
        /// <param name="value">The numeric value to be converted.</param>
        /// <param name="unitAttribute_From">The source unit attribute.</param>
        /// <param name="unitAttribute_To">The target unit attribute.</param>
        /// <param name="result">When this method returns, contains the converted inverse value if successful; otherwise, null.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvertInverse(double value, UnitAttribute? unitAttribute_From, UnitAttribute? unitAttribute_To, out double? result)
        {
            result = null;

            if (unitAttribute_From is null || unitAttribute_To is null)
            {
                return false;
            }

            try
            {
                double double_BaseValue = unitAttribute_From.From(value);
                if (double.IsNaN(double_BaseValue) || double.IsInfinity(double_BaseValue) || Math.Abs(double_BaseValue) < double.Epsilon)
                {
                    return false;
                }

                double double_InverseBaseValue = 1.0 / double_BaseValue;
                double double_FinalValue = unitAttribute_To.To(double_InverseBaseValue);
                if (double.IsNaN(double_FinalValue) || double.IsInfinity(double_FinalValue))
                {
                    return false;
                }

                result = double_FinalValue;
                return true;
            }
            catch
            {
            }

            return false;
        }
    }
}