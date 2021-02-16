using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Taksoo.CommonPage;
using Taksoo.Droid.Control;
using FontIconApp.UserControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(SimpleIcon), typeof(SimpleFontIcon))]

namespace Taksoo.Droid.Control
{
  
        public class SimpleFontIcon : LabelRenderer
        {
            protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
            {
                base.OnElementChanged(e);
                if (e.OldElement == null)
                {
                    //The ttf in /Assets is CaseSensitive, so name it FontAwesome.ttf
                    Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, SimpleIcon.Typeface + ".eot");
                }
            }
        }
}