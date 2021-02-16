using ServiceHelper.ServiceHelper;
using System;
using Taksoo.Mobile.Common.Constant;
using Taksoo.Mobile.Common.MappingExtention;
using Taksoo.Mobile.Service.Parameter;
using Taksoo.Mobile.Service.Service.Interface;


namespace Taksoo.Mobile.Service.Service
{
    public class TripCostService : ITripCostService
    {
        
        public TripCostService()
        {
        }
        


        TripCostParam ITripCostService.GetTripCost(TripLocationParam tripLocationParam)
        {
            var result = new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<TripCostParam>(HttpUrlHelper.Get(AppConstant.RestUrl, "TripCost", "GetTripCost"), tripLocationParam);
            return result;
        }
    }
}
