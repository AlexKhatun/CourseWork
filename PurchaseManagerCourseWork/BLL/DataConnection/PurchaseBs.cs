using BLL.Infrastructure;
using BOL;
using DAL.Abstract;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DataConnection
{
    public class PurchaseBs
    {
        private IPurchaseRepository objDb;

        public PurchaseBs()
        {
            IKernel kernel = new StandardKernel(new Binding());
            objDb = kernel.Get<IPurchaseRepository>();
        }

        public IEnumerable<Purchase> GetAll()
        {
            return objDb.GetAll();
        }

        public Purchase GetById(int id)
        {
            return objDb.GetById(id);
        }

        public void Insert(Purchase purchase)
        {
            int id = objDb.GetAll().Max(i => i.PurchaseId);
            purchase.PurchaseId = id + 1;
            objDb.Insert(purchase);
        }

        public void Delete(int id)
        {
            objDb.Delete(id);
        }

        public void Update(Purchase purchase)
        {
            objDb.Update(purchase);
        }
    }
}
