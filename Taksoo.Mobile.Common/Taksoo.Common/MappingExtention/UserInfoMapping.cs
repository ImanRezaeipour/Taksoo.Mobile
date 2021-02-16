using ServiceHelper.Model;
using System;
using Taksoo.Mobile.Common.Model;

namespace Taksoo.Mobile.Common.MappingExtention
{
    public static class UserInfoMapping
    {

        public static void ClearUserInfo()
        {
            var userInfo = UserInfo.Instance;

            userInfo.Id = Guid.Empty;
            userInfo.FirstName = string.Empty;
            userInfo.LastName = string.Empty;
            userInfo.Mobile = string.Empty;
            userInfo.Email = string.Empty;
            userInfo.Password = string.Empty;
            userInfo.IsAuthenticated = false;
        }

        public static IUserInfo MapToUserInfo()
        {
            var userInfo = UserInfo.Instance;
            return userInfo;
        }
    }
}

