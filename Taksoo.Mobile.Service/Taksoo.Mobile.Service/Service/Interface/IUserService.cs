using System;
using Taksoo.Mobile.Service.Parameter;

namespace Taksoo.Mobile.Service.Service.Interface
{
    public interface IUserService 
    {
        string GetUserLanguage();
        void InitUserData();
        void LogIn(UserParam userParam);
        void LogOut();
        void SendUserCode(UserParam userParam);
        void  UpdateUserCode(UserParam userParam);

        UserParam GetUserCode(string mobile);

    }
}
