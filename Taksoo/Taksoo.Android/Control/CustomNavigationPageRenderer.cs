using System;
using System.ComponentModel;
using Android.App;
using Android.Graphics;
using Android.Widget;
using Taksoo.Droid.Control;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;
using Support = Android.Support.V7.Widget;


[assembly: ExportRenderer(typeof(NavigationPage), typeof(ToolbarPageRenderer))]
namespace Taksoo.Droid.Control
{
    public class ToolbarPageRenderer : NavigationPageRenderer
    {
        private Support.Toolbar _toolbar;

        public override void OnViewAdded(Android.Views.View child)
        {

            base.OnViewAdded(child);

            try
            {
            if (child.GetType() == typeof(Support.Toolbar))
                _toolbar = (Support.Toolbar)child;

            }
            catch (Exception e)
            {
                new Exception(e.Message);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            var page = this.Element as NavigationPage;

            if (page != null && _toolbar != null)
            {
                Typeface tf = Typeface.CreateFromAsset(Android.App.Application.Context.Assets, "IRANSansWeb.ttf");

                TextView title = (TextView)_toolbar.FindViewById(Resource.Id.toolbar_title);
                title.SetText(title.Text, TextView.BufferType.Normal);
                title.SetTypeface(tf, TypefaceStyle.Normal);
            }

        }

    }
}