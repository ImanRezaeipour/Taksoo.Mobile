using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksoo.Mobile.Service.Enum;

namespace Taksoo.ViewModel
{
    public class TripDetailViewModel : EntityViewModelBase
    {

        public string Cost { get; set; }
        public int? Distance { get; set; }
        public int Order { get; set; }
        public string StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string DriverName { get; set; }
        public string Score { get; set; }
        public string TripCode { get; set; }
        public string SurceAddress { get; set; }
        public double SourceLatitude { get; set; }
        public double SourceLongitude { get; set; }
        public string DestinationAddress { get; set; }
        public double DestinationLatitude { get; set; }
        public double DestinationLongitude { get; set; }
        public List<TripDetailActionViewModel> TripDetailActionViewModels{ get; set; }

    }

   
}
