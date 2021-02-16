namespace Taksoo.Mobile.Common.TypeHelper
{
    public static class IntHelper
    {
        public static bool IsNullOrEqual(this int? value, int valueToCheck)
        {
            return (value ?? valueToCheck) == valueToCheck;
        }
        public static bool IsNullOrGreater(this int? value, int valueToCheck)
        {
            return (value ?? valueToCheck) > valueToCheck;
        }

        public static bool IsNullOrLess(this int? value, int valueToCheck)
        {
            return (value ?? valueToCheck) < valueToCheck;
        }

    }
}