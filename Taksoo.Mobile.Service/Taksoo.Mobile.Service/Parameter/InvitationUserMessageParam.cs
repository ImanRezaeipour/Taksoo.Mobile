using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.Mobile.Service.Parameter
{
  public  class InvitationUserMessageParam
    {
        public string UserId { get; set; }
        public string ReciverMoblile { get; set; }
        public string UserMobile { get; set; }
        public string UserCode { get; set; }

        public UserParam UserParam { get; set; }
    }
}
