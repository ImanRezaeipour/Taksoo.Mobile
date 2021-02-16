using System;
using System.Collections.Generic;

namespace Taksoo.Mobile.Service.Parameter
{
    public class TripParam : EntityParamBase
    {

       public double? DriverScore { get; set; }
        public double? PassengerScore { get; set; }
        public int TotalCost { get; set; }
        public int? PredictTotalDistance { get; set; }
        public int? RealTotalDistance { get; set; }
        public int? PredictTotalTime { get; set; }
        public int? RealTotalTime { get; set; }
        public string TripCode { get; set; }

        public DateTime CreateDate { get; set; }
        public DriverParam DriverParam { set; get; }
        public List<PassengerParam> PassengerParams { set; get; }
        public List<TripDetailParam> TripDetailParams { set; get; }
        public List<TripActionParam> TripActionParams { set; get; }
        public List<MessageParam> MessageParams { get; set; }

        

    }
}
