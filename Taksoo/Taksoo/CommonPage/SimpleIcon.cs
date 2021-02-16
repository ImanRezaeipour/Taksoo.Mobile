using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Taksoo.CommonPage
{
    public class SimpleIcon : Label
    {
        public static readonly string Typeface = "simpleLineIcons";

        //Parameterless constructor for XAML
        public SimpleIcon()
        {
            FontFamily = Typeface;
        }

        public SimpleIcon(string fontAwesomeLabel = null)
        {
            FontFamily = Typeface;
            Text = fontAwesomeLabel;
        }
    }

    // https://github.com/neilkennedy/FontAwesome.Xamarin/blob/master/FontAwesome.Xamarin/FontAwesome.cs
    // For a huge list of icon codes
  public static class Icons
    {
        public static string FAGlass = "\xe057";
    }
}
