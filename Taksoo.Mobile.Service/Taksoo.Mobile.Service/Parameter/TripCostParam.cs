
using Taksoo.Mobile.Service.Enum;

namespace Taksoo.Mobile.Service.Parameter
{
    public class TripCostParam : EntityParamBase
    {
        public int Cost { get; set; }
        public TripType TripType { get; set; }
        public RegionParam SourceRegionParam { get; set; }
        public RegionParam DestinationRegionParam { get; set; }
    }
}
