using System;
using Taksoo.TestData;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Taksoo.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetails : ContentPage
    {
        public ProductDetails()
        {
            InitializeComponent();
            Product pr = new Product();

        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            PopUp.IsVisible = !PopUp.IsVisible;
            PopUp.Padding = new Thickness();
           
         
        }
    }
}