using ServiceHelper.Model;
using System;
using Taksoo.Mobile.Common.Constant;

namespace Taksoo.Mobile.Common.Model
{
    public class UserInfo : IUserInfo
    {
        private static UserInfo instance ;
        public static UserInfo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserInfo();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private UserInfo()
        {

        }
        public Guid PassengerId { get; set; } = Guid.Empty;
        public Guid Id { get; set; } = Guid.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsActive { get; set; } = false;
        public bool IsAuthenticated { get; set; } = false;
        public string Language { get; set; } = AppConstant.DefaultCulture;

        public decimal TotalTurnover { get; set; } = 0;





    }
}
