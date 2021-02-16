using System;
using System.Text.RegularExpressions;
using Taksoo.Mobile.Common.Constant;

namespace Taksoo.Mobile.Common.TypeHelper
{
    public static class StringHelper
    {
        public static bool IsPhoneNoFormat(this string str)
        {
            return !string.IsNullOrEmpty(str) && Regex.Match(str, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$").Success;
        }
        public static string ToPersianPhoneNumber(this string str)
        {
            try
            {
                if (str != null && str.StartsWith("0"))
                {
                    var strTemp = str.Substring(1, str.Length - 1);
                    return AppConstant.PersianPhoneNoPrefix + strTemp;
                    //return str.StartsWith("0") ? str.Replace("0", AppConstant.PersianPhoneNoPrefix) : str;
                }
                return str;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public static string TruncateAtWord(this string input, int length)
        {
            if (input == null || input.Length < length)
                return input;
            int iNextSpace = input.LastIndexOf(" ", length, StringComparison.Ordinal);
            return string.Format("{0}...", input.Substring(0, (iNextSpace > 0) ? iNextSpace : length).Trim());
        }
    }
}