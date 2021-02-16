using System;
using System.Collections.Generic;

namespace Taksoo.Mobile.Service.Parameter
{
    public class PassengerParam : EntityParamBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ReagentCode { get; set; }
        public DateTime? BirthDate { get; set; }
        public UserParam UserParam { set; get; } 
        public List<TripParam> TripParams { set; get; }
        public List<RoleParam> RoleParams { set; get; }
    }
}
