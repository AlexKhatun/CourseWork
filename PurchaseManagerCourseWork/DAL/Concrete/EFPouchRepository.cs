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
    public class EFPouchRepository : IPouchRepository
    {
        private PurchaseManagerEntities db;

        public EFPouchRepository()
        {
            db = new PurchaseManagerEntities();
        }

        public IEnumerable<Pouch> GetAll()
        {
            return db.Pouch.ToList();
        }

        public Pouch GetById(int id)
        {
            return db.Pouch.Find(id);
        }

        public void Insert(Pouch pouch)
        {
            db.Pouch.Add(pouch);
            this.Save();
        }

        public void Delete(int id)
        {
            Pouch pouch = db.Pouch.Find(id);
            db.Pouch.Remove(pouch);
            this.Save();
        }

        public void Update(Pouch pouch)
        {
            db.Entry(pouch).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
