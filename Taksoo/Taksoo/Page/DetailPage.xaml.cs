//using System;
//using Taksoo.Mobile.Common.Model;
//using Taksoo.Mobile.Service.Service;
//using Taksoo.Mobile.Service.Service.Interface;
//using Taksoo.IDependencyService;
//using Taksoo.ViewModel;
//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

//namespace Taksoo.Page
//{
//    [XamlCompilation(XamlCompilationOptions.Compile)]
//    public partial class DetailPage : ContentPage
//    {
//        private readonly IPassengerTurnoverService _passengerTurnover;
//        private readonly IPassengerService _passengerService;

//        public DetailPage()
//        {
//            var sqLite = DependencyService.Get<ISQLite>();

//            _passengerService = new PassengerService(sqLite.GetConnection());
//            _passengerTurnover=new PassengerTurnoverService(sqLite.GetConnection());

//            InitializeComponent();
//            try
//            {
//                Initialize();
//            }
//            catch (Exception e)
//            {
//                DisplayAlert("خطای سیستمی ", e.Message, "تایید");
//            }
//        }

//        private void Initialize()
//        {

//            try
//            {
//                var result = _passengerService.GetPassengerByMobile(UserInfo.Instance.Mobile);
//                BindingContext = new PassengerViewModel()
//                {
//                    LastName = result.LastName,
//                    FirstName = result.FirstName,
//                    Mobile = result.UserParam.Mobile,
//                    Email = result.Email,
//                    Inventory = _passengerTurnover.UserTurnOvertotal(result.UserParam.Mobile).TotalTurnover.ToString("0.####")
//            };
//            }
//            catch (Exception e)
//            {
//                DisplayAlert("خطای سیستمی ", e.Message, "تایید");
//            }

//        }

//        private void TlbDetails_OnClicked(object sender, EventArgs e)
//        {
//            var passnegerPage = new PassengerEdit(_passengerService);

//            passnegerPage.EditPassenger += RefreshEdit;
//            Navigation.PushAsync(passnegerPage);
//        }

//        private void RefreshEdit(object sender, DriverSpecificationEvnetArgs e)
//        {
//            var binding = (PassengerViewModel)BindingContext;
//            BindingContext = new PassengerViewModel
//            {
//                LastName = e.LastName,
//                FirstName = e.FirstName,
//                Email = e.Email,
//                Mobile = binding.Mobile,
//                Inventory = binding.Inventory
//            };
//        }


//        private void UserTurnover(object sender, EventArgs e)
//        {
//            Navigation.PushAsync(new PassengerTurnover());
//        }

//        protected override bool OnBackButtonPressed()
//        {
//            Navigation.PopAsync(true);
//            return base.OnBackButtonPressed();
//        }
//    }
//}
