using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.Mobile.Service.Parameter
{
   public class UserTurnoverParam
    {
        public string color;
        public DateTime CreatedDate { get; set; }
        public bool Type { get; set; }
        public long AmountAccount { get; set; }
        //public ChargeType ChargeType { get; set; }
        public Guid TurnoverTotalId { get; set; }
        //public TurnoverTotalParam TurnoverTotalParam { get; set; }
        public string Description { get; set; }


        public PassengerParam PassengerParam { get; set; }
        public TripParam TripParam { get; set; }
    }
}
