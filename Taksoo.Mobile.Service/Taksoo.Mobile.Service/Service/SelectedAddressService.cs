using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksoo.Mobile.Common.Constant;
using Taksoo.Mobile.Common.MappingExtention;
using Taksoo.Mobile.Common.Model;
using Taksoo.Mobile.Service.Parameter;
using Taksoo.Mobile.Service.Service.Interface;

using SQLite;
using ServiceHelper.ServiceHelper;

namespace Taksoo.Mobile.Service.Service
{
   public class SelectedAddressService: ISelectedAddressService
   {
       private readonly IPassengerService _userService;

       public SelectedAddressService(SQLiteConnection slqConnection)
       {
           _userService = new PassengerService(slqConnection);
       }
        public void Insert(SelectedAddressParam model)
        {
            try
            {
                var user = _userService.GetPassengerByMobile(UserInfo.Instance.Mobile);
                model.User = user.UserParam;
                new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(
                    HttpUrlHelper.Post(AppConstant.RestUrl, "SelectedAddress", "Insert"), model);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(SelectedAddressParam model)
        {
            throw new NotImplementedException();
        }

        public List<SelectedAddressParam> GetByMobile(string mobile)
        {
            try
            {
                return new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<List<SelectedAddressParam>>(HttpUrlHelper.Get(AppConstant.RestUrl, "SelectedAddress", "GetByMobile", mobile));

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public SelectedAddressParam GetbyId(Guid id)
        {
            try
            {
                return new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<SelectedAddressParam>(HttpUrlHelper.Get(AppConstant.RestUrl, "SelectedAddress", "GetbyId", id.ToString()));

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
       

    public void Delete(Guid id)
       {
           try
           {
                new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<SelectedAddressParam>(HttpUrlHelper.Get(AppConstant.RestUrl, "SelectedAddress", "Delete", id.ToString()));

           }
           catch (Exception e)
           {
               throw new Exception(e.Message);
           }
       }
}
}
