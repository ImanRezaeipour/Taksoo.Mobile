using System;
using Taksoo.Mobile.Service.Service;
using Taksoo.IDependencyService;
using Taksoo.Page;
using Xamarin.Forms;

namespace Taksoo
{
    public partial class App : Application
    {
        public App()
        {
            Initialize();

            InitializeComponent();

            MainPage = new MainPage(new FirstPage());
        }


        protected override void OnStart()
        {


        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void Initialize()
        {
            try
            {
                var sqLite = DependencyService.Get<ISQLite>();
                new UserService(sqLite.GetConnection()).InitUserData();
            }
            catch (Exception e)
            {
              
            }
           
        }


    }
}
