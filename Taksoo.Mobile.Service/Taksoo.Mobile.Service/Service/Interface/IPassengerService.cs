using Taksoo.Mobile.Service.Parameter;

namespace Taksoo.Mobile.Service.Service.Interface
{
    public interface IPassengerService 
    {
        void Insert(PassengerParam passengerParam);
        void Edit(PassengerParam passengerParam);
        PassengerParam GetPassengerByMobile(string mobile);
    }
}
