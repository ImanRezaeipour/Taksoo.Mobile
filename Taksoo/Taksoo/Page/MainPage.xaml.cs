using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Taksoo.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage(Xamarin.Forms.Page detailPage)
        {
            InitializeComponent();
            


            Detail.Navigation.PushAsync(detailPage);
            try
            {
                Initialize();
            }
            catch (Exception e)
            {
                DisplayAlert("خطای سیستمی ", e.Message, "تایید");
            }
        }


        private void Initialize()
        {

        }


    }
}
