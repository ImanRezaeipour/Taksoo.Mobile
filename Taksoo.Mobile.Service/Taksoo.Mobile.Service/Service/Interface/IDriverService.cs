using System.Collections.Generic;
using Taksoo.Mobile.Service.Parameter;

namespace Taksoo.Mobile.Service.Service.Interface
{
    public interface IDriverService
    {
        List<DriverParam> GetNearByDrivers(DriverLocationFilter driverLocationFilter);

    }
}
