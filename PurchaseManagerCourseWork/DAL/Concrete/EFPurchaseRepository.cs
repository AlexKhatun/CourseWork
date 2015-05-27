using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using BOL;
using System.Data.Entity;

namespace DAL.Concrete
{
    public class EFPurchaseRepository : IPurchaseRepository
    {
        private PurchaseManagerEntities db;

        public EFPurchaseRepository()
        {
            db = new PurchaseManagerEntities();
        }

        public IEnumerable<Purchase> GetAll()
        {
            return db.Purchase.ToList();
        }

        public Purchase GetById(int id)
        {
            return db.Purchase.Find(id);
        }

        public void Insert(Purchase purchase)
        {
            db.Purchase.Add(purchase);
            this.Save();
        }

        public void Delete(int id)
        {
            Purchase purchase = db.Purchase.Find(id);
            db.Purchase.Remove(purchase);
            this.Save();
        }

        public void Update(Purchase purchase)
        {
            db.Entry(purchase).State = EntityState.Modified;
            this.Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
