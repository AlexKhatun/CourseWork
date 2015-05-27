using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IPurchaseRepository
    {
        IEnumerable<Purchase> GetAll();

        Purchase GetById(int id);

        void Insert(Purchase purchase);

        void Delete(int id);

        void Update(Purchase purchase);

        void Save();
    }
}
