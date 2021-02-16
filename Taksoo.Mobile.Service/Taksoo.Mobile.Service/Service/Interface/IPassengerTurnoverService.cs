using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksoo.Mobile.Service.Parameter;

namespace Taksoo.Mobile.Service.Service.Interface
{
   public interface IPassengerTurnoverService
    {
        UserTurnoverParam GetById(Guid id);
        List<UserTurnoverParam> GetByIds(List<Guid> ids);
        List<UserTurnoverParam> ListPassengerTurnover(Guid id);
        UserTurnoverTotalParam UserTurnOvertotal(string mobile);


        void AddOrUpdate(UserTurnoverParam turnoverParam);
        void Remove(Guid id);
    }
}
