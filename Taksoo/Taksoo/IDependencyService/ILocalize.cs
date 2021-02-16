using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.IDependencyService
{
    public interface ILocalize
    {
        void SetLocale(string language);
        CultureInfo GetCurrentCultureInfo();
    }
}
