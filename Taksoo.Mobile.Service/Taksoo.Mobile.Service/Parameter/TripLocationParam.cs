

using Taksoo.Mobile.Service.Enum;

namespace Taksoo.Mobile.Service.Parameter
{
    public class TripLocationParam : EntityParamBase
    {
        public TripType TripType { get; set; }
        public double SourceLatitude { get; set; }
        public double SourceLongitude { get; set; }
        public string SourceAddress { get; set; }

        public double DestinationLatitude { get; set; }
        public double DestinationLongitude { get; set; }
        public string DestinationAddress { get; set; }
    }
}
