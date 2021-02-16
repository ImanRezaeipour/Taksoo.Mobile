using System;
using System.Collections.Generic;

namespace Taksoo.Mobile.Service.Parameter
{
    public class DriverParam : EntityParamBase
    {
        public double Score { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public UserParam UserParam { set; get; }
        public LocationParam LocationParam { set; get; }
        public List<TripParam> TripParams { set; get; }
        public List<LocationHistoryParam> LocationHistoryParams { set; get; }
        public List<RoleParam> RoleParams { set; get; } 
    }
}
