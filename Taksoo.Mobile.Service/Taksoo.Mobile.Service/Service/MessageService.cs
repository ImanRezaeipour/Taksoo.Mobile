using ServiceHelper.ServiceHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksoo.Mobile.Common.Constant;
using Taksoo.Mobile.Common.MappingExtention;
using Taksoo.Mobile.Service.Parameter;
using Taksoo.Mobile.Service.Service.Interface;


namespace Taksoo.Mobile.Service.Service
{
   public class MessageService:IMessageService
    {
        public void Insert(PassengerMessageParam message)
        {
            try
            {
            //new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(HttpUrlHelper.Post(AppConstant.RestUrl,"Message","Create"),message);
                new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(
                    HttpUrlHelper.Post(AppConstant.RestUrl, "Message", "Create"), message);
            }
            catch (Exception ex)
            {

               throw new Exception(ex.Message);
            }


        }

        public List<PassengerMessageParam> GetList()
        {
            var result = new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<List<PassengerMessageParam>>(HttpUrlHelper.Get(AppConstant.RestUrl, "Driver", "GetNearByDrivers"), null);
            return result;
        }


    }
}
