using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IPouchRepository
    {
        IEnumerable<Pouch> GetAll();

        Pouch GetById(int id);

        void Insert(Pouch pouch);

        void Delete(int id);

        void Update(Pouch pouch);

        void Save();
    }
}
