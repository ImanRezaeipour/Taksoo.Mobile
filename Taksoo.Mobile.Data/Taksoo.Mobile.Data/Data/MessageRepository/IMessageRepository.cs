using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksoo.Mobile.Data.Model;

namespace Taksoo.Mobile.Data.Data.MessageRepository
{
    public  interface IMessageRepository
    {
        PassengerMessage GetById(Guid id);
        List<PassengerMessage> GetAll();
        void Insert(PassengerMessage user);
        void Update(PassengerMessage user);
        void Delete(Guid id);
    }
}
