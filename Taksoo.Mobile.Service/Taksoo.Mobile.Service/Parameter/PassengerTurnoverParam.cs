using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DehkadehTrip.Mobile.Service.Parameter
{
   public class PassengerTurnoverParam
    {
        public string color;
        public DateTime TourOverDateTime { get; set; }
        public bool Type { get; set; }
        public string Description { get; set; }
        public string AmountAccount { get; set; }
        public string CurrentAccount { get; set; }
        public Guid UserId { get; set; }

        public PassengerParam PassengerParam { get; set; }
        public TripParam TripParam { get; set; }
    }
}
