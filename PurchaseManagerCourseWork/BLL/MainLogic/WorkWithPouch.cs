using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using BOL;

namespace BLL.MainLogic
{
    public class WorkWithPouch : BaseMainLogic
    {
        public bool CheckForUniquePouch(Pouch pouch)
        {
            var pouches = objBs.PouchBs.GetAll();
            foreach (var i in pouches)
            {
                if (i.Name == pouch.Name && i.User.UserId == pouch.UserId)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
