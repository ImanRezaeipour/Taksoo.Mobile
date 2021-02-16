using System;
using System.Collections.Generic;
using Taksoo.Mobile.Service.Enum;
using Taksoo.Mobile.Service.Parameter;

namespace Taksoo.Mobile.Service.Service.Interface
{
    public interface ITripService
    {
        List<TripParam> GetTripByMobile(string mobile);
        TripParam GetTripDetailsByTripId(Guid id);
        void Insert(TripParam tripParam);

        TripParam GetById(Guid id);
        void DriverAccept(Guid tripId, Guid driverId);
        void AddTripDetailState(Guid tripId, TripDetailStatusType tripDetailStatusType);
        void AddTripState(Guid tripId, TripStatusType tripStatusType);
        void InsertTripDriverScore(Guid tripId, double driverScore);
        void InsertTripPassengerScore(Guid tripId, double passengerScore);
        List<TripParam> GetNewRequest();
    }
}
