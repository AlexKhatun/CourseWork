using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using System.Data.Entity;
using DAL.Abstract;

namespace DAL.Concrete
{
    public class EFUserRepository : IUserRepository
    {
        private PurchaseManagerEntities db;

        public EFUserRepository()
        {
            db = new PurchaseManagerEntities();
        }

        public IEnumerable<User> GetAll()
        {
            return db.User.ToList();
        }

        public User GetById(int id)
        {
            return db.User.Find(id);
        }

        public void Insert(User user)
        {
            db.User.Add(user);
            this.Save();
        }

        public void Delete(int id)
        {
            User user = db.User.Find(id);
            db.User.Remove(user);
            this.Save();
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            this.Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
