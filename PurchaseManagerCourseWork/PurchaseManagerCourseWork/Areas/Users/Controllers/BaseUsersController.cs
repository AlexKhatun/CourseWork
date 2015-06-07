using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.DataConnection;

namespace PurchaseManagerCourseWork.Areas.Users.Controllers
{
    public class BaseUserController : Controller
    {
        protected BaseBs objBs;

        public BaseUserController()
        {
            objBs = new BaseBs();
        }
    }
}
