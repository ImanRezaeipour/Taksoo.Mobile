using Taksoo.Mobile.Service.Parameter;

namespace Taksoo.Mobile.Service.Service.Interface
{
    public interface ITripCostService 
    {
        TripCostParam GetTripCost(TripLocationParam tripLocationParam);

    }
}
