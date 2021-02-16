using System;

namespace Taksoo.Mobile.Common.RandomHelper
{
    public class RandomHelper
    {
        private static readonly Random _random = new Random();
        public static int GetRandom(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }
        public static string GetRandom(int length)
        {
            if (length <= 1) return "";

            var minValue = (int)Math.Pow(10, length - 1);
            var maxValue = (int)Math.Pow(10, length) - 1;
            return GetRandom(minValue, maxValue).ToString();
        }
    }
}
