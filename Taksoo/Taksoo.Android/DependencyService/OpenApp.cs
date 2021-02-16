using System;
using Android.App;
using Android.Content;
using Android.Provider;
using Taksoo.Mobile.Common.Constant;
using Taksoo.Droid.DependencyService;
using Taksoo.IDependencyService;
using Xamarin.Forms;
using Android.Telephony;
using Android.Widget;
using Xamarin.Forms.PlatformConfiguration;


[assembly: Xamarin.Forms.Dependency(typeof(OpenApp))]

namespace Taksoo.Droid.DependencyService
{
    class OpenApp : Java.Lang.Object, IIntent
    {

        public void SendSms(string code)
        {
            var ctx = Forms.Context;





            var smsUri = Android.Net.Uri.Parse("smsto:");
            var smsIntent = new Intent(Intent.ActionSendto, smsUri); 

            ctx.StartActivity(smsIntent);

            //else
            //{
            //    try
            //    {
            //        ctx.StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("")));
            //    }
            //    catch (Exception ex)
            //    {
            //        ctx.StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://play.google.com/store/apps/details?id=" + "org.telegram.messenger")));
            //    }
            //}
        }

        public void SendEmail(string code)
        {
            try
            {
                var ctx = Forms.Context;
                var email = new Intent(Android.Content.Intent.ActionSend);

                email.PutExtra(Android.Content.Intent.ExtraEmail,
                    new string[] { "person1@xamarin.com", "person2@xamrin.com" });

                email.PutExtra(Android.Content.Intent.ExtraCc,
                    new string[] { "person3@xamarin.com" });

                email.PutExtra(Android.Content.Intent.ExtraSubject, "Hello Email");

                email.PutExtra(Android.Content.Intent.ExtraText,
                    "Hello from Xamarin.Android");


                ctx.StartActivity(email);
            }
            catch (ActivityNotFoundException ex)
            {
                Toast.MakeText(Forms.Context, ex.Message,ToastLength.Long).Show();
            }

        }

        public void SendTelegram(string code)
        {
            Intent intent = Forms.Context.PackageManager.GetLaunchIntentForPackage("org.telegram.messenger");

            if (intent != null)
            {
                intent.AddFlags(ActivityFlags.NewTask);
                Intent myIntent = new Intent(Intent.ActionSend);
                myIntent.SetType("text/plain");
                myIntent.SetPackage("org.telegram.messenger");
                myIntent.PutExtra(Intent.ExtraText, "ssss");//
                Forms.Context.StartActivity(Intent.CreateChooser(myIntent, "Kevin"));

            }
            else
            {
                intent = new Intent(Intent.ActionView);
                intent.AddFlags(ActivityFlags.NewTask);
                intent.SetData(Android.Net.Uri.Parse("https://play.google.com/store/apps/details?id=" + "org.telegram.messenger"));
                Forms.Context.StartActivity(intent);
            }
        }


    }
}