using Android.App;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Widget;
using Taksoo.Droid.DependencyService;
using Taksoo.Helper.UserHelper;
using Xamarin.Forms;

namespace Taksoo.Droid
{
    [Activity(Label = "تکسو", Icon = "@drawable/logo", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.Locale | ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        static readonly MainActivity Instance = null;

        // Return the current activity instance.
        public static MainActivity CurrentActivity
        {
            get
            {
                return Instance;
            }
        }

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            //int actionBarTitle = this.Resources.GetIdentifier("tabbar_title", "id", "android");
            //TextView title = (TextView)Window.FindViewById(Resource.Id.tabbar_title);
            //title.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, "IRANSansWeb.ttf");


            base.OnCreate(bundle);
            //Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "FontAwesome.ttf");
            //TextView button = (TextView)FindViewById(Resource.Id.toolbar_search);
            //button.SetTypeface(font,TypefaceStyle.Normal);

            //Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule())
            //    .With(new Plugin.Iconize.Fonts.MaterialModule())
            //    .With(new Plugin.Iconize.Fonts.MeteoconsModule())
            //    .With(new Plugin.Iconize.Fonts.TypiconsModule());

            global::Xamarin.Forms.Forms.Init(this, bundle);

            Initialize();

            Xamarin.FormsGoogleMaps.Init(this, bundle);
            LoadApplication(new App());




        }


        private void Initialize()
        {
            new Localize().SetLocale(new UserHelper(new AndroidSqLite().GetConnection()).GetUserLanguage());

        }




    }

}

