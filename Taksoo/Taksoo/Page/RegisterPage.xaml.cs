//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Android.Gms.Maps;
//using Taksoo.Mobile.Common.Constant;
//using Taksoo.Mobile.Common.Model;
//using Taksoo.Mobile.Common.RandomHelper;
//using Taksoo.Mobile.Common.TypeHelper;
//using Taksoo.Mobile.Service.Enum;
//using Taksoo.Mobile.Service.Parameter;
//using Taksoo.Mobile.Service.Service;
//using Taksoo.Mobile.Service.Service.Interface;
//using Taksoo.IDependencyService;
//using Taksoo.ViewModel;
//using Newtonsoft.Json.Schema;
//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

//namespace Taksoo.Page
//{
//    [XamlCompilation(XamlCompilationOptions.Compile)]
//    public partial class RegisterPage : ContentPage
//    {

//        private readonly IPassengerService _passengerService;
//        private readonly IUserService _userService;
//        private PassengerViewModel _passengerViewModel;

//        public RegisterPage()
//        {

//            InitializeComponent();

//            //if (Device.OS == TargetPlatform.iOS)
//            //{
//            //    Title = "دهکده";
//            //    NavigationPage.SetBackButtonTitle(this, string.Empty);
//            //    //NavigationPage.SetHasNavigationBar(this, true);
//            //    //NavigationPage.SetHasBackButton(this,true);
//            //}
//            try
//            {
//                var sqLite = DependencyService.Get<ISQLite>();


//            _passengerService = new PassengerService(sqLite.GetConnection());
//            _userService = new UserService(sqLite.GetConnection());


//            _passengerViewModel = new PassengerViewModel()
//            {
//                Id = Guid.NewGuid(),
//            };
                
//                Initialize();

//            }
//            catch (Exception e)
//            {
//                DisplayAlert("خطای سیستمی ", e.Message, "تایید");

//            }

//        }


//        private void Initialize()
//        {
//            _passengerViewModel.RoleViewModels =
//                new List<RoleViewModel>()
//                {
//                    new RoleViewModel()
//                    {
//                        Id = Guid.NewGuid(),
//                        RoleType = RoleType,
//                        IsBusy = false
//                    }
//                };
//            _passengerViewModel.UserViewModel = new UserViewModel()
//            {
//                Id = Guid.NewGuid(),
//                Password = RandomHelper.GetRandom(AppConstant.UserCodeLength),
//                Language = UserInfo.Instance.Language
//            };
//            BindingContext = _passengerViewModel;


//        }


//        private void TapGestureRecognizer_OnStkLytSubmitTapped(object sender, EventArgs e)
//        {
//            try
//            {
//                _passengerViewModel.UserViewModel.Mobile =
//                    _passengerViewModel.UserViewModel.Mobile.ToPersianPhoneNumber();

//                if (Validation(_passengerViewModel))
//                {
//                    try
//                    {
//                        Indicator.IsVisible = true;

//                        var r = Task.Factory.StartNew(async () =>
//                            {

//                                await Task.Delay(5);
//                                Device.BeginInvokeOnMainThread(() =>
//                                {
//                                    try
//                                    {

//                                        _passengerViewModel.UserViewModel.Mobile =
//                                            _passengerViewModel.UserViewModel.Mobile.ToPersianPhoneNumber();
//                                        _passengerService.Insert(MapToPassengerParam(_passengerViewModel));
//                                        _passengerViewModel.UserViewModel.Password = string.Empty;
//                                        Navigation.PushAsync(new LoginCodePage(_passengerViewModel.UserViewModel));
//                                        Indicator.IsVisible = false;
//                                    }
//                                    catch (Exception ex)
//                                    {

//                                        DisplayAlert(Resource.TaksooResource.Error, ex.Message,
//                                            Resource.TaksooResource.Confirm);
//                                        Indicator.IsVisible = false;

//                                    }
//                                });


//                            })
//                            .Result;

//                    }
//                    catch (Exception ex)
//                    {
//                        Device.BeginInvokeOnMainThread(() =>
//                        {
//                            DisplayAlert(string.Empty, ex.Message, "OK");

//                        });
//                    }
//                }

//            }
//            catch (Exception ex)
//            {
                
//            }
//        }


//        private bool Validation(PassengerViewModel passengerViewModel)
//        {

//            bool valid = !(passengerViewModel.FirstName == null || passengerViewModel.LastName == null || passengerViewModel.UserViewModel.Mobile == null);
//            if (valid == false)
//                DisplayAlert(Resource.TaksooResource.Confirm, Resource.TaksooResource.WrongInformation, Resource.TaksooResource.Confirm);

//            if (passengerViewModel.ReagentCode?.Length < 6)
//            {
//                DisplayAlert(Resource.TaksooResource.Error, Resource.TaksooResource.ReagentCodeMustBeSixCharecter, Resource.TaksooResource.Confirm);
//                valid = false;
//            }


//            return valid;
//        }

//        private PassengerParam MapToPassengerParam(PassengerViewModel passengerViewModel)
//        {
//            var passengerParam = new PassengerParam()
//            {
//                Id = passengerViewModel.Id,
//                UserParam = passengerViewModel.UserViewModel == null ? null : new UserParam()
//                {
//                    Id = passengerViewModel.UserViewModel.Id,
//                    Password = passengerViewModel.UserViewModel.Password,
//                    IsAuthenticated = true,
//                    Language = passengerViewModel.UserViewModel.Language,
//                    IsActive = true,
//                    Mobile = passengerViewModel.UserViewModel.Mobile

//                },
//                RoleParams = new List<RoleParam>()
//                    {
//                        new RoleParam()
//                        {
//                            Id = passengerViewModel.RoleViewModels.First().Id,
//                            RoleType = passengerViewModel.RoleViewModels.First().RoleType
//                        }
//                    },
//                Address = passengerViewModel.Address,
//                BirthDate = passengerViewModel.BirthDate,
//                Email = passengerViewModel.Email,
//                FirstName = passengerViewModel.FirstName,
//                LastName = passengerViewModel.LastName,
//                ReagentCode = passengerViewModel.ReagentCode


//            };
//            return passengerParam;
//        }
//        private void BtnLogOut_OnClicked(object sender, EventArgs e)
//        {

//            _userService.LogOut();
//            App.Current.MainPage = new NavigationPage(new RegisterPage());
//        }
//        private void TapGestureRecognizer_OnRegisterBeforeTapped(object sender, EventArgs e)
//        {
//            try
//            {
//                //WaitingBackGround.IsVisible = true;
//                Task.Factory.StartNew(() =>
//                { });
//                App.Current.MainPage = new NavigationPage(new LoginPage());
//                //WaitingBackGround.IsVisible = false;


//            }
//            catch (Exception exception)
//            {

//                DisplayAlert("خطا", exception.Message, "تایید");
//            }


//        }

//        protected override void OnAppearing()
//        {
//            base.OnAppearing();
//            //WaitingBackGround.IsVisible = false;
//        }


//    }
//}
