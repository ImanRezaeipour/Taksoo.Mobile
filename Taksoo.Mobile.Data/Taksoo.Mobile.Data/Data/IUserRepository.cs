using System;
using System.Collections.Generic;
using Taksoo.Mobile.Data.Model;

namespace Taksoo.Mobile.Data.Data
{
    public interface IUserRepository
    {
        User GetById(Guid id);
        List<User> GetAll();
        void Insert(User user);
        void Update(User user);
        void Delete(Guid id);

    }
}
