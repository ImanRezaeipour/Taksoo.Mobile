using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.Mobile.Data.Model
{
    public class PassengerMessage:EntityBase
    {
        public string Content { get; set; }
        public Guid? ParentId { get; set; }
    }
}
