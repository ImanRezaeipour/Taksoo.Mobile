using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.Mobile.Common.StringHelper
{
    public static class StringHelper
    {
        public static string ApplyUnifiedYeKe(this string data)
        {
            if (string.IsNullOrEmpty(data)) return data;
            return data.Replace("ي", "ی").Replace("ك", "ک");
            
        }

    }
}
