using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.ViewModel
{
    public class PassengerViewModel : EntityViewModelBase
    {
        private string firstName, lastName, reagentCode, email;
        private bool _isBussy;
//C:\Project\Taksoo\Taksoo.Mobile\Taksoo\Taksoo\actualroute.png
        public string Html { get; set; } =
            @"<html><head><link type='text/css' rel='stylesheet' href='style.css' media='all' /></head><body><div class='loader' style='top:40%;left:40%;position:absolute;'></div>
        </body></html>";
        public bool IsBussy
        {
            get => _isBussy;
            set
            {
                _isBussy = value;
                OnPropertyChanged("IsBussy");
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    OnPropertyChanged("FristName");
                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public string ReagentCode
        {
            get
            {
                return reagentCode;
            }
            set
            {
                if (reagentCode != value)
                {
                    reagentCode = value;
                    OnPropertyChanged("ReagentCode");
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        public string Address { get; set; }
        public string Mobile { get; set; }

        public DateTime? BirthDate { get; set; }

        public string FullName => FirstName + " " + LastName;

        public UserViewModel UserViewModel { set; get; }
        public List<TripViewModel> TripViewModels { set; get; }
        public List<RoleViewModel> RoleViewModels { set; get; }
        public string Inventory { get; set; }
    }
}
