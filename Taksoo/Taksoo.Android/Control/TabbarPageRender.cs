using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Taksoo.Droid.Control;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;
using Support = Android.Support.Design.Widget;


[assembly: ExportRenderer(typeof(StyledTabbedPage), typeof(StyledTabbedPageRenderer))]

namespace Taksoo.Droid.Control
{
    public class StyledTabbedPageRenderer : TabbedPageRenderer
    {
        //private void CustomTabRenderer_ElementChanged(object sender, VisualElementChangedEventArgs e)
        //{
        //Support.TabItem.title
        //}

    }
}