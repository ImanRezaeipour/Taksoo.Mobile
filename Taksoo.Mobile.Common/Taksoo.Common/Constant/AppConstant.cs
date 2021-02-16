namespace Taksoo.Mobile.Common.Constant
{
    public static class AppConstant
    {
        /// <summary>
        /// نام Application
        /// </summary> 
        public const string AppName = "Taksoo";

        /// <summary>
        /// آدرس وب سایت
        /// </summary> 
        //public static string SiteUrl = "http://192.168.42.73:26301";
        //public static string SiteUrl = "http://192.168.42.201:8088";
        //public static string SiteUrl = "http://188.121.113.230:8090"; 
        //public static string SiteUrl = "http://188.121.113.230:8088"; 
        //public static string SiteUrl = "http://192.168.42.193:8088";
        //public static string SiteUrl = "http://192.168.137.1:8088/";
        //public static string SiteUrl = "http://192.168.42.9:8088";
        //public static string SiteUrl = "http://192.168.2.167:8080";
        public static string SiteUrl = "http://192.168.8.100:8081";


        /// <summary>
        /// آدرس سرویس API
        /// </summary> 
        public static string RestUrl = SiteUrl + "/api/";

        /// <summary>
        /// فرمت شماره تلفن
        /// </summary>
        //public static string PhoneNoFormat = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
        public static string PersianPhoneNoFormat = @"(\+98|0)9\d{9}";
        //public static string PersianPhoneNoFormat = @"09\d{9}";
        public static string PersianPhoneNoPrefix = "+98";


        /// <summary>
        /// تعداد ارقام کد یوزر
        /// </summary>
        public static int UserCodeLength = 6;

        /// <summary>
        /// Culture فارسی
        /// </summary>
        public static string PersianCulture = "fa-IR";

        /// <summary>
        /// DefaultCulture 
        /// </summary>
        public static string DefaultCulture = PersianCulture;

        /// <summary>
        /// Culture انگلیسی
        /// </summary>
        public static string EnglishCulture = "en-US";

        /// <summary>
        /// کلید نقشه گوگل Android
        ///  https://developers.google.com/maps/documentation/android-api/signup
        /// </summary>
        public static string GOOGLE_MAPS_ANDROID_API_KEY = "AIzaSyCfQfdevUEzYWYldD604vBNkcosM7wohvs";

        /// <summary>
        /// کلید نقشه گوگل IOC
        /// https://developers.google.com/maps/documentation/ios-sdk/start#step_4_get_an_api_key
        /// </summary>
        public static string GOOGLE_MAPS_IOS_API_KEY = "AIzaSyCI4FeClcgaHsIcrKxKZiicPEi0gnBiWD8";

        /// <summary>
        /// کلید نقشه گوگل Windows
        /// https://msdn.microsoft.com/windows/uwp/maps-and-location/authentication-key
        /// </summary>
        public static string BING_MAPS_UWP_API_KEY = "your_bing_maps_apikey";

        /// <summary>
        /// AutoComplete برای Google
        /// </summary>
        public static string StrAutoCompleteGoogleApi = "https://maps.googleapis.com/maps/api/place/autocomplete/json?sensor=true&radius=1&components=country:ir&language=fa&key=" + AppConstant.GOOGLE_MAPS_ANDROID_API_KEY + "&input=";

        /// <summary>
        /// GeoCoding برای Google
        /// </summary>
        public static string StrGeoCodingUrl = "https://maps.googleapis.com/maps/api/geocode/json?language=fa&key=" + AppConstant.GOOGLE_MAPS_ANDROID_API_KEY + "&";
        /// <summary>
        /// Google Play Service Package Name
        /// </summary>
        public static string GooglePlayServicePackageName = "com.google.android.gms";

        /// <summary>
        /// Google Play Service Search By Id Url
        /// </summary>
        public static string GooglePlayServiceSearchByIdUrl = "market://details?id=";

        /// <summary>
        /// Google Play Service Search By Name
        /// </summary>
        public static string GooglePlayServiceSearchByNameUrl = "http://play.google.com/store/apps/details?id=";



        /// <summary>
        /// Initialize Google Map and Current Location if Null
        /// </summary>t
        public static double InitLatitude = 35.70163793;
        public static double InitLongitude = 51.37893676;

        /// <summary>
        /// TripHub Name
        /// </summary>
        public static string TripHubName = "TripHub";

        /// <summary>
        /// NewLine
        /// </summary>
        public static string NewLine = "\n";
    }
}
