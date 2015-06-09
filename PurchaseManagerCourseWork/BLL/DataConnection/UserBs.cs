using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using Ninject;
using BLL.Infrastructure;
using BOL;

namespace BLL.DataConnection
{
    public class UserBs
    {
        private IUserRepository objDb;
        public UserBs()
        {
            IKernel kernel = new StandardKernel(new Binding());
            objDb = kernel.Get<IUserRepository>();
        }

        public IEnumerable<User> GetAll()
        {
            return objDb.GetAll();
        }

        public User GetById(int id)
        {
            return objDb.GetById(id);
        }

        public void Insert(User user)
        {
            int id = objDb.GetAll().Max(i => i.UserId);
            user.UserId = id + 1;
            objDb.Insert(user);
        }

        public void Delete(int id)
        {

            objDb.Delete(id);
        }

        public void Update(User user)
        {
            objDb.Update(user);
        }
    }
}
