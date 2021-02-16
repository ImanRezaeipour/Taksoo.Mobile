using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksoo.Mobile.Service.Parameter;

namespace Taksoo.Mobile.Service.Service.Interface
{
    public interface  IUserSendGiftCode
    {
        void Insert(InvitationUserMessageParam messageParam);

    }
}
