using System;
using System.Collections.Generic;
using Taksoo.Mobile.Common.Constant;
using Taksoo.Mobile.Common.MappingExtention;
using Taksoo.Mobile.Service.Parameter;
using Taksoo.Mobile.Service.Service.Interface;


namespace Taksoo.Mobile.Service.Service
{
    public class DriverService :  IDriverService
    {
        

        public DriverService() 
        {

        }

        

        List<DriverParam> IDriverService.GetNearByDrivers(DriverLocationFilter driverLocationFilter)
        {
            //var result = new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<List<DriverParam>>(HttpUrlHelper.Get(AppConstant.RestUrl,"Driver", "GetNearByDrivers"), driverLocationFilter);
            return null;
        }



    }
}
