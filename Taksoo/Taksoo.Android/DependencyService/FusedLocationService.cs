using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Common;
using Android.Gms.Common.Apis;
using Android.Gms.Location;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Taksoo.Droid.DependencyService;
using Taksoo.IDependencyService;
using Java.Lang;
using ILocationListener = Android.Gms.Location.ILocationListener;

[assembly: Xamarin.Forms.Dependency(typeof(FusedLocationService))]
namespace Taksoo.Droid.DependencyService
{
    public class LocationEventArgs : EventArgs, ILocationEventArgs
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
    public class FusedLocationService : Java.Lang.Object, ILocationListener, IJavaObject, IDisposable, ILocationManager, GoogleApiClient.IConnectionCallbacks, GoogleApiClient.IOnConnectionFailedListener
    {

        private static long INTERVAL = 1000 * 30; //30sec
        private static long FASTEST_INTERVAL = 1000 * 5; // 5sec

        //private bool _isInitLocation = false;
        private readonly LocationRequest _locationRequest;
        private readonly GoogleApiClient _googleApiClient;
        //private Location _location;
        private readonly IFusedLocationProviderApi _fusedLocationProviderApi;

        public FusedLocationService()
        {
            _fusedLocationProviderApi = LocationServices.FusedLocationApi;
            _locationRequest = new LocationRequest();
            _locationRequest.SetPriority(LocationRequest.PriorityHighAccuracy);
            _locationRequest.SetInterval(INTERVAL);
            _locationRequest.SetFastestInterval(FASTEST_INTERVAL);
            _googleApiClient = new GoogleApiClient.Builder(Application.Context)
                .AddApi(LocationServices.API)
                .AddConnectionCallbacks(this)
                .AddOnConnectionFailedListener(this)
                .Build();

            _googleApiClient?.Connect();
        }


        //public Location GetLocation()
        //{
        //    return _location;
        //}



        public void OnConnected(Bundle connectionHint)
        {
            //_location = _fusedLocationProviderApi.GetLastLocation(_googleApiClient);
            _fusedLocationProviderApi.RequestLocationUpdates(_googleApiClient, _locationRequest, this);

           

         
            //if (_location!=null && Initlocation!=null)
            //{
            //    _isInitLocation = true;

            //    ILocationEventArgs args = new LocationEventArgs()
            //    {
            //        Latitude = _location.Latitude,
            //        Longitude = _location.Longitude
            //    };

            //    Initlocation.Invoke(this, args);
               
            //}
           
        }

        public void OnConnectionSuspended(int cause)
        {
        }

        public void OnConnectionFailed(ConnectionResult result)
        {

        }


        public event EventHandler<ILocationEventArgs> LocationObtained;
        event EventHandler<ILocationEventArgs> ILocationManager.OnLocationChanged
        {
            add => LocationObtained += value;
            remove => LocationObtained -= value;
        }
        public void OnLocationChanged(Location location)
        {
            ILocationEventArgs args = new LocationEventArgs()
            {
                Latitude = location.Latitude,
                Longitude = location.Longitude
            };

            //if (!_isInitLocation && Initlocation != null)
            //{
            //    _isInitLocation = true;
            //    Initlocation?.Invoke(this, args);

            //}

            LocationObtained?.Invoke(this, args);
               
        }


        //public event EventHandler<ILocationEventArgs> Initlocation;
        //event EventHandler<ILocationEventArgs> ILocationManager.OnInitLocation
        //{
        //    add => Initlocation += value;
        //    remove => Initlocation -= value;
        //}
        //public void OnInitLocation(Location location)
        //{
        //}
    }
}