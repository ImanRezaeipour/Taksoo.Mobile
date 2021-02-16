using System.Collections.Generic;

namespace Taksoo.Mobile.Service.Parameter
{
    public class UserParam : EntityParamBase
    {
        public string Mobile { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Language { get; set; }
        public string UserCode { get; set; }

        public List<InvitationUserMessageParam> InvitationUserMessageParams { get; set; }
        public TurnoverTotalParam TurnoverTotalParam { get; set; }

    }
}
