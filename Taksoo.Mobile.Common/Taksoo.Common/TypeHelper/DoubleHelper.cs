using System;

namespace Taksoo.Mobile.Common.TypeHelper
{
    public static class DoubleHelper
    {
        public static bool IsNullOrEqual(this double? value, double valueToCheck)
        {
            return (value ?? valueToCheck) == valueToCheck;
        }
        public static bool IsNullOrGreater(this double? value, double valueToCheck)
        {
            return (value ?? valueToCheck) > valueToCheck;
        }

        public static bool IsNullOrGreaterOrEqualTo(this double? value, double valueToCheck)
        {
            return (value ?? valueToCheck) >= valueToCheck;
        }

        public static bool IsNullOrLess(this double? value, double valueToCheck)
        {
            return (value ?? valueToCheck) < valueToCheck;
        }

    }
}
