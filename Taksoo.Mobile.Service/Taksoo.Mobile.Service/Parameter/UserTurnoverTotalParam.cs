using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.Mobile.Service.Parameter
{
   public class UserTurnoverTotalParam:EntityParamBase
    {
        public decimal TotalTurnover { get; set; }
        public ICollection<UserTurnoverParam> UserTurnovers { get; set; }
        public UserParam User { get; set; }

      
    }
}
