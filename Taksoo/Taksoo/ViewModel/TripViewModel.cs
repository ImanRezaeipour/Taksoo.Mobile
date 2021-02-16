using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.ViewModel
{
    public class TripViewModel : EntityViewModelBase
    {

        public double? DriverScore { get; set; }
        public double? PassengerScore { get; set; }
        public string TotalCost { get; set; }
        public int? TotalDistance { get; set; }
        public int? TotalTime { get; set; }
        public int? PredictTotalDistance { get; set; }
        public int? RealTotalDistance { get; set; }
        public int? PredictTotalTime { get; set; }
        public int? RealTotalTime { get; set; }
        public string CreateDate { get; set; }
        public string TripCode { get; set; }
        public string ShortTime { get; set; }
        public long TripCount { get; set; }
        public DriverViewModel DriverViewModel { set; get; }
        public List<PassengerViewModel> PassengerViewModels { set; get; }
        public List<TripDetailViewModel> TripDetailViewModels { set; get; } 
        public List<TripActionViewModel> TripActionViewModels { set; get; }

    }
}
