using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksoo.Mobile.Service.Enum;
using Taksoo.Resource;

namespace Taksoo.ViewModel
{
    public class TripCostViewModel : EntityViewModelBase
    {

        public int Cost { get; set; }
        public TripType TripType { get; set; }
        public string CostDescription
        {
            get => string.Format(TaksooResource.TripCostToman, Cost.ToString("N0"));
            
        }
        public RegionViewModel SourceRegionViewModel { get; set; }
        public RegionViewModel DestinationRegionViewModel { get; set; }
    }
}
