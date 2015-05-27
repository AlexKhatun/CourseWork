using BLL.Infrastructure;
using BOL;
using DAL.Abstract;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DataConnection
{
    public class PouchBs
    {
        private IPouchRepository objDb;

        public PouchBs()
        {
            IKernel kernel = new StandardKernel(new Binding());
            objDb = kernel.Get<IPouchRepository>();
        }

        public IEnumerable<Pouch> GetAll()
        {
            return objDb.GetAll();
        }

        public Pouch GetById(int id)
        {
            return objDb.GetById(id);
        }

        public void Insert(Pouch pouch)
        {
            int id = objDb.GetAll().Max(i => i.PouchId);
            pouch.PouchId = id + 1;
            objDb.Insert(pouch);
        }

        public void Delete(int id)
        {
            objDb.Delete(id);
        }

        public void Update(Pouch pouch)
        {
            objDb.Update(pouch);
        }
    }
}
