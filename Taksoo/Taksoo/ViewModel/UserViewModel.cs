using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.ViewModel
{
    public class UserViewModel : EntityViewModelBase
    {

        private string _userCode;
        private bool _isBusy;

        public string Mobile { get; set; }
        public string Password { get; set; }
        public string GetCode { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Language { get; set; }

        public bool IsBussy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged("IsBussy");
            }
        }

        public string UserCode
        {
            get { return _userCode; }
            set
            {
                if (value != null)
                {
                    _userCode = value;
                    OnPropertyChanged("UserCode");
                }
            }

        }
    }
}
