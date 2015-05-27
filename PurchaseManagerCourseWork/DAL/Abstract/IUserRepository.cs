using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();

        User GetById(int id);

        void Insert(User user);

        void Delete(int id);

        void Update(User user);

        void Save();
    }
}
