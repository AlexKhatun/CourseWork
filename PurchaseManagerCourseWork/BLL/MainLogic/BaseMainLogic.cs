using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DataConnection;

namespace BLL.MainLogic
{
    class BaseMainLogic
    {
        private BaseBs objBs;

        public BaseMainLogic()
        {
            objBs = new BaseBs();
        }
    }
}
