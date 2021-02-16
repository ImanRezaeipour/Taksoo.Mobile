using System;
using System.Threading.Tasks;
using Taksoo.Mobile.Common.Constant;
using Taksoo.Mobile.Common.MappingExtention;
using Taksoo.Mobile.Common.Model;
using Taksoo.Mobile.Data.Data;
using Taksoo.Mobile.Data.Model;
using Taksoo.Mobile.Service.Parameter;
using Taksoo.Mobile.Service.Service.Interface;

using SQLite;
using ServiceHelper.ServiceHelper;

namespace Taksoo.Mobile.Service.Service
{
    public class PassengerService :  IPassengerService
    {

        private readonly IUserRepository _userRepository;
  

        public PassengerService(SQLiteConnection sqLiteConnection) 
        {
            _userRepository =  new UserRepository(sqLiteConnection);
        }
        
       
        public  void Insert(PassengerParam passengerParam)
        {
            try
            {
                new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(
                    HttpUrlHelper.Post(AppConstant.RestUrl, "Passenger", "Insert"), passengerParam);

        
            
            MapToUserInfo(passengerParam);

            var user = new User()
            {
                Id = passengerParam.UserParam.Id,
                IsAuthenticated = true,
                Password = passengerParam.UserParam.Password,
                Language = passengerParam.UserParam.Language,
                Mobile = passengerParam.UserParam.Mobile
                
            };
            _userRepository.Insert(user);
    }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }
        }

        public void Edit(PassengerParam passengerParam)
        {
            new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(HttpUrlHelper.Post(AppConstant.RestUrl, "Passenger", "Update"), passengerParam);
           //var userInfo =  GetPassengerByMobile(passengerParam.UserParam.Mobile);
            MapToUserInfo(passengerParam);
        }

        public PassengerParam GetPassengerByMobile(string mobile)
        {
            return new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<PassengerParam>(HttpUrlHelper.Get(AppConstant.RestUrl, "Passenger", "GetByMobile", mobile));
        }


        private void MapToUserInfo(PassengerParam passengerParam)
        {

            var userInfo = UserInfo.Instance;

            userInfo.Id = passengerParam.UserParam.Id;
            userInfo.LastName = passengerParam.LastName;
            userInfo.FirstName = passengerParam.FirstName;
            userInfo.Password = passengerParam.UserParam.Password;
            userInfo.Mobile = passengerParam.UserParam.Mobile;
            userInfo.Email = passengerParam.Email;
            userInfo.IsAuthenticated = passengerParam.UserParam.IsAuthenticated;
            userInfo.Language = !string.IsNullOrEmpty(passengerParam.UserParam.Language) ? passengerParam.UserParam.Language : userInfo.Language;
        }

    }
}
