using ServiceHelper.ServiceHelper;
using System;
using System.Collections.Generic;
using Taksoo.Mobile.Common.Constant;
using Taksoo.Mobile.Common.MappingExtention;
using Taksoo.Mobile.Service.Enum;
using Taksoo.Mobile.Service.Parameter;
using Taksoo.Mobile.Service.Service.Interface;


namespace Taksoo.Mobile.Service.Service
{
    public class TripService :  ITripService
    {
       
        public TripService() 
        {
        }

        public List<TripParam> GetTripByMobile(string mobile)
        {
            try
            {
            return new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<List<TripParam>>(HttpUrlHelper.Get(AppConstant.RestUrl, "Trip", "GetTripUserByMobile", mobile));

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public TripParam GetTripDetailsByTripId(Guid id)
        {
            try
            {
            return new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<TripParam>(HttpUrlHelper.Get(AppConstant.RestUrl, "Trip", "GetTripDetailsByTripId", id.ToString()));

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Insert(TripParam tripParam)
        {
            try
            {
                new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(HttpUrlHelper.Post(AppConstant.RestUrl, "Trip", "Insert"), tripParam);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        public TripParam GetById(Guid id)
        {
            var userParam = new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<TripParam>(HttpUrlHelper.Get(AppConstant.RestUrl, "Trip", "GetById", id.ToString()));
            return userParam;

        }

        public void DriverAccept(Guid tripId, Guid driverId)
        {
            var tripParam = new TripParam()
            {
                Id = tripId,
                DriverParam = new DriverParam()
                {
                    Id = driverId
                }
            };
            new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(HttpUrlHelper.Post(AppConstant.RestUrl, "Trip", "DriverAccept"), tripParam);
        }

        public void AddTripDetailState(Guid tripId, TripDetailStatusType tripDetailStatusType)
        {
            var tripParam = new TripParam()
            {
                Id = tripId,
                TripDetailParams = new List<TripDetailParam>()
                {
                    new TripDetailParam()
                    {
                        TripDetailActionParams = new List<TripDetailActionParam>()
                        {
                            new TripDetailActionParam()
                            {
                                Status = tripDetailStatusType
                            }
                        }
                    }
                }
            };
            new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(HttpUrlHelper.Post(AppConstant.RestUrl, "Trip", "AddTripDetailState"), tripParam);
        }

        public void AddTripState(Guid tripId, TripStatusType tripStatusType)
        {
            var tripParam = new TripParam()
            {
                Id = tripId,
                TripActionParams = new List<TripActionParam>()
                {
                    new TripActionParam()
                    {
                        Status = tripStatusType
                    }
                }
            };
            new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(HttpUrlHelper.Post(AppConstant.RestUrl, "Trip", "AddTripState"), tripParam);
        }

        public void InsertTripDriverScore(Guid tripId, double driverScore)
        {
            var tripParam = new TripParam()
            {
                Id = tripId,
                DriverScore = driverScore
            };
            new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(HttpUrlHelper.Post(AppConstant.RestUrl, "Trip", "InsertTripDriverScore"), tripParam);
        }

        public void InsertTripPassengerScore(Guid tripId, double passengerScore)
        {
            var tripParam = new TripParam()
            {
                Id = tripId,
                PassengerScore = passengerScore
            };
            new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(HttpUrlHelper.Post(AppConstant.RestUrl, "Trip", "InsertTripPassengerScore"), tripParam);
        }

        public List<TripParam> GetNewRequest()
        {
            var tripParam = new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<List<TripParam>>(HttpUrlHelper.Get(AppConstant.RestUrl, "Trip", "GetNewRequest"));
            return tripParam;

        }

    }
}
