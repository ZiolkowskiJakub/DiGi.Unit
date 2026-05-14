using System;

namespace DiGi.Unit
{
    public static partial class Query
    {
        public static double Convert(double value, Classes.Unit? from, Classes.Unit? to, double defaultValue, double tolerance)
        {
            if (!TryConvert(value, from, to, out double? result, tolerance) || result is null)
            {
                return defaultValue;
            }

            return result.Value;
        }

        public static double Convert(double value, Classes.Unit? from, Classes.Unit? to, double defaultValue)
        {
            if (!TryConvert(value, from, to, out double? result) || result is null)
            {
                return defaultValue;
            }

            return result.Value;
        }

        public static double Convert(double value, Enum? from, Enum? to, double defaultValue, double tolerance)
        {
            if(from is null || to is null)
            {
                return defaultValue;
            }

            if (!TryConvert(value, from, to, out double? result, tolerance) || result is null)
            {
                return defaultValue;
            }

            return result.Value;
        }

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

        public static double Convert(double value, Classes.UnitAttribute? from, Classes.UnitAttribute? to, double defaultValue)
        {
            if (!TryConvert(value, from, to, out double? result) || result is null)
            {
                return defaultValue;
            }

            return result.Value;
        }

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