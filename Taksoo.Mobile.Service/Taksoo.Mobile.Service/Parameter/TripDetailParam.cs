using System;
using System.Collections.Generic;
using System.Reflection;
using Taksoo.Mobile.Service.Enum;

namespace Taksoo.Mobile.Service.Parameter
{
    public class TripDetailParam : EntityParamBase
    {
        public int Cost { get; set; }
        public int? Distance { get; set; }
        public int Order { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public string SourceAddress { get; set; }
        public double SourceLatitude { get; set; }
        public double SourceLongitude { get; set; }

        public string DestinationAddress { get; set; }
        public double DestinationLatitude { get; set; }
        public double DestinationLongitude { get; set; }

        public DriverParam DriverParam { get; set; }
        public TripParam TripParam { get; set; }
        public List<TripDetailActionParam> TripDetailActionParams { get; set; }

        public TripDetailParam()
        {
            DriverParam = new DriverParam();
            TripParam = new TripParam();
            TripDetailActionParams = new List<TripDetailActionParam>();
        }


    }
}
