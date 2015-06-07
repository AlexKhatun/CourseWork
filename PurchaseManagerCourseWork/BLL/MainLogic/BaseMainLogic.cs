using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DataConnection;

namespace BLL.MainLogic
{
    public class BaseMainLogic
    {
        protected BaseBs objBs;

        public BaseMainLogic()
        {
            objBs = new BaseBs();
        }
    }
}
