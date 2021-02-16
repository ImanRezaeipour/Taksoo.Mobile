using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Taksoo.Mobile.Common.Constant;
using Taksoo.Droid.DependencyService;
using Taksoo.IDependencyService;
using Xamarin.Forms;

[assembly: Dependency(typeof(Localize))]
namespace Taksoo.Droid.DependencyService
{
    public class Localize : ILocalize
    {
        public void SetLocale(string language)
        {
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            if (Forms.Context != null && Forms.Context is MainActivity)
                ((MainActivity)Forms.Context).Window.DecorView.LayoutDirection = Thread.CurrentThread.CurrentUICulture.Name == AppConstant.PersianCulture ?  LayoutDirection.Rtl : LayoutDirection.Ltr;
        }

        public CultureInfo GetCurrentCultureInfo()
        {
            return Thread.CurrentThread.CurrentUICulture;
        }
    }
}