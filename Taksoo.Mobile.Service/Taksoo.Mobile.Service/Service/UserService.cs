using System;
using System.Collections.Generic;
using System.Linq;
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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(SQLiteConnection sqLiteConnection)
        {
            _userRepository = new UserRepository(sqLiteConnection);
        }


        public string GetUserLanguage()
        {
            var userViewModels = _userRepository.GetAll();
            var userViewModel = userViewModels.FirstOrDefault();
            return userViewModel?.Language ?? AppConstant.DefaultCulture;
        }



        public void InitUserData()
        {

            var userViewModels = _userRepository.GetAll();
            var userViewModel = userViewModels.FirstOrDefault(c => c.IsAuthenticated);
            if (userViewModel != null && userViewModel.IsAuthenticated)
            {
                LogIn(new UserParam
                {
                    Id = userViewModel.Id,
                    Password = userViewModel.Password,
                    IsAuthenticated = userViewModel.IsAuthenticated,
                    Language = userViewModel.Language,
                    Mobile = userViewModel.Mobile,

                });
            }
            else
            {
                UserInfoMapping.ClearUserInfo();
            }
        }

        public void LogIn(UserParam userParam)
        {
            try
            {


                var userInfo = UserInfo.Instance;
                userInfo.Mobile = userParam.Mobile;
                userInfo.Password = userParam.Password;
                userInfo.IsAuthenticated = true;
                var passengerParam = new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<PassengerParam>(HttpUrlHelper.Get(AppConstant.RestUrl, "Passenger", "GetByMobile", userParam.Mobile));

                userParam.Language = string.IsNullOrEmpty(userParam.Language) ? userInfo.Language : userParam.Language;

                passengerParam.UserParam.IsAuthenticated = true;
                passengerParam.UserParam.Language = userParam.Language;
                passengerParam.UserParam.Password = userParam.Password;
                userParam.Id = passengerParam.UserParam.Id;
                userParam.IsAuthenticated = true;


                var users = _userRepository.GetAll();
                foreach (var user in users)
                {
                    user.IsAuthenticated = false;
                    _userRepository.Update(user);
                }


                var currentUser = users.FirstOrDefault(c => c.Mobile == userParam.Mobile);
                if (currentUser == null)
                {

                    var userInsert = new User()
                    {
                        Id = userParam.Id,
                        IsAuthenticated = true,
                        Password = userParam.Password,
                        Language = userParam.Language,
                        Mobile = userParam.Mobile
                    };
                    _userRepository.Insert(userInsert);
                }
                else
                {
                    currentUser.IsAuthenticated = true;
                    _userRepository.Update(currentUser);
                }





                MapToUserInfo(passengerParam);
            }
            catch (Exception e)
            {
                UserInfo.Instance.IsAuthenticated = false;
                throw new Exception(e.Message);
            }
        }


        private void MapToUserInfo(PassengerParam passengerParam)
        {

            var userInfo = UserInfo.Instance;

            userInfo.TotalTurnover = passengerParam.UserParam.TurnoverTotalParam.TotalTurnover;

            userInfo.Id = passengerParam.UserParam.Id;
            userInfo.LastName = passengerParam.LastName;
            userInfo.FirstName = passengerParam.FirstName;
            userInfo.Password = passengerParam.UserParam.Password;
            userInfo.Mobile = passengerParam.UserParam.Mobile;
            userInfo.Email = passengerParam.Email;
            userInfo.IsAuthenticated = passengerParam.UserParam.IsAuthenticated;
            userInfo.Language = !string.IsNullOrEmpty(passengerParam.UserParam.Language) ? passengerParam.UserParam.Language : userInfo.Language;
        }
        public void LogOut()
        {
            //var userViewModels = _userRepository.GetAll();
            //foreach (var userViewModel in userViewModels)
            //{
            //    userViewModel.IsAuthenticated = false;
            //    _userRepository.Update(userViewModel);
            //}

            var users = _userRepository.GetAll();

            foreach (var user in users)
            {
                user.IsAuthenticated = false;
                _userRepository.Update(user);
            }

        }

        public void SendUserCode(UserParam userParam)
        {
            new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(HttpUrlHelper.Post(AppConstant.RestUrl, "Account", "SendUserCode"), userParam);
        }

        public  void UpdateUserCode(UserParam userParam)
        {
            new  HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(HttpUrlHelper.Post(AppConstant.RestUrl, "Account", "UpdateUserCode"), userParam);
        }

        public UserParam GetUserCode(string mobile)
        {
            if (mobile == null) mobile = UserInfo.Instance.Mobile;
            var userParam = new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<UserParam>(HttpUrlHelper.Get(AppConstant.RestUrl, "Account", "GetByMobile", mobile));
            return userParam;

        }

       
    }
}
