using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DataConnection
{
    public class BaseBs
    {
        public PurchaseBs PurchaseBs { get; set; }

        public UserBs UserBs { get; set; }

        public PouchBs PouchBs { get; set; }

        public BaseBs()
        {
            PurchaseBs = new PurchaseBs();
            UserBs = new UserBs();
            PouchBs = new PouchBs();
        }
    }
}
