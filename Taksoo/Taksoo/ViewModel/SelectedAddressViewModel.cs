using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.ViewModel
{
    public class SelectedAddressViewModel:EntityViewModelBase
    {
        public string _address { get; set; }
        public string _name { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (value != null)
                {
                    _address = value;
                    OnPropertyChanged("Address");
                }
            }
        }

        public UserViewModel User { get; set; }
        public double DestLat { get; set; }
        public double DestLong { get; set; }

     
    }
}
