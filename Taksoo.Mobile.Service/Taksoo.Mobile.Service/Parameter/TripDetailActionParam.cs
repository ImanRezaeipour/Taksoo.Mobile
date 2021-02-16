using System;
using System.Reflection;
using Taksoo.Mobile.Service.Enum;

namespace Taksoo.Mobile.Service.Parameter
{
    public class TripDetailActionParam : EntityParamBase
    {
        public TripDetailStatusType Status { get; set; }
    }
}
