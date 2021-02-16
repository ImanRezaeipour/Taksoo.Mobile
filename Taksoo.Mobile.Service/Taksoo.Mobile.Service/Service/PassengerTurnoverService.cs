using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksoo.Mobile.Common.Constant;
using Taksoo.Mobile.Common.MappingExtention;
using Taksoo.Mobile.Common.Model;
using Taksoo.Mobile.Data.Data;
using Taksoo.Mobile.Service.Parameter;
using Taksoo.Mobile.Service.Service.Interface;

using SQLite;
using ServiceHelper.ServiceHelper;

namespace Taksoo.Mobile.Service.Service
{
  public  class PassengerTurnoverService: IPassengerTurnoverService

    {
        private readonly IUserRepository _userRepository;


        public PassengerTurnoverService(SQLiteConnection sqLiteConnection)
        {
            _userRepository = new UserRepository(sqLiteConnection);
        }
        public UserTurnoverParam GetById(Guid id)
        {
       
            throw new NotImplementedException();


        }

        public List<UserTurnoverParam> GetByIds(List<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public List<UserTurnoverParam> ListPassengerTurnover(Guid id)
        {

            try
            {

                //if (id.ToString() == null) id = UserInfo.InstanceId;
                //var result = new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<PassengerTurnoverParam>
                //    (HttpUrlHelper.Get(AppConstant.RestUrl, "PassengerTurnover", "Test"), UserInfo.InstanceId);

                //return new List<PassengerTurnoverParam>();
                //var user = _userRepository.GetById(UserInfo.Instance.Id);
                var result = new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<List<UserTurnoverParam>>
                (HttpUrlHelper.Get(AppConstant.RestUrl, "UserTurnover", "GetUserturnover",
                    UserInfo.Instance.Mobile));


                return result;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
          

        }

        public UserTurnoverTotalParam UserTurnOvertotal(string mobile)
        {
            try
            {

                var result = new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<UserTurnoverTotalParam>
                (HttpUrlHelper.Get(AppConstant.RestUrl, "UserTurnover", "GetUserTurnOverTotal",
                    mobile));


                return result;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddOrUpdate(UserTurnoverParam turnoverParam)
        {
            try
            {
                new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Post(
                    HttpUrlHelper.Post(AppConstant.RestUrl, "PassengerTurnover", "AddOrUpdate"), turnoverParam);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
