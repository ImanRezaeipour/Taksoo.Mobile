using System;
using System.Collections.Generic;
using System.Linq;
using Taksoo.Mobile.Data.Model;
using SQLite;

namespace Taksoo.Mobile.Data.Data
{
    public class UserRepository :IUserRepository
    {
        private readonly TaksooContext _TaksooContext;
        public UserRepository(SQLiteConnection sqLiteConnection)
        {
            _TaksooContext = _TaksooContext ?? (_TaksooContext = new TaksooContext(sqLiteConnection));
        }

        public User GetById(Guid id)
        {
            return _TaksooContext.Database.Table<User>().FirstOrDefault(c => c.Id == id);
        }

        public List<User> GetAll()
        {
            return _TaksooContext.Database.Table<User>().ToList();
        }

        public void Insert(User user)
        {
            _TaksooContext.Database.Insert(user);
        }

        public void Update(User user)
        {
            _TaksooContext.Database.Update(user);
        }

        public void Delete(Guid id)
        {
            _TaksooContext.Database.Delete(GetById(id));
        }  

    }
}
