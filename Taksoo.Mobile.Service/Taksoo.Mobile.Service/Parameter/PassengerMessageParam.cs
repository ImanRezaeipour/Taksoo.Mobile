using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.Mobile.Service.Parameter
{
   public class PassengerMessageParam : EntityParamBase
    {
        public string Content { get; set; }
        public Guid? ParentId { get; set; }



        public TripParam Trip { get; set; }
    }
}
