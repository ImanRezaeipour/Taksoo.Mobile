using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksoo.Mobile.Data.Model;

namespace Taksoo.Mobile.Data.Data.MessageRepository
{
   public class MessageRepository:IMessageRepository
   {

       private TaksooContext _context;

       public MessageRepository(TaksooContext context)
       {
           _context = context;
       }


       public PassengerMessage GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<PassengerMessage> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(PassengerMessage user)
        {
            throw new NotImplementedException();
        }

        public void Update(PassengerMessage user)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
