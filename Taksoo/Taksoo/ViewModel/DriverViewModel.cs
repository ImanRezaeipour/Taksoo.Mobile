using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.ViewModel
{
    public class DriverViewModel : EntityViewModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public double Score { get; set; }

        public string FullName => FirstName + " " + LastName;

        public UserViewModel UserViewModel { set; get; }
        public CarViewModel CarViewModel { set; get; }
        public LocationViewModel LocationViewModel { set; get; }
        public List<TripViewModel> TripViewModels { set; get; }
        public List<LocationHistoryViewModel> LocationHistoryViewModels { set; get; }
        public List<RoleViewModel> RoleViewModels { set; get; }

    }
}
