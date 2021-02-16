using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksoo.Mobile.Service.Service;
using Taksoo.Mobile.Service.Service.Interface;
using SQLite;

namespace Taksoo.Helper.UserHelper
{
   public  class UserHelper
    {
        private readonly IUserService _userService ;
        public UserHelper(SQLiteConnection sqLiteConnection)
        {
            _userService = new UserService(sqLiteConnection);
        }
       
        public string GetUserLanguage()
        {
            return  _userService.GetUserLanguage();
        }
      
        public void LogOut()
        {
             _userService.LogOut();
        }
    }
}
