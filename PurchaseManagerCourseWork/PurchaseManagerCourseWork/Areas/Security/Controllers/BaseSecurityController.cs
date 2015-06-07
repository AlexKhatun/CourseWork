using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.DataConnection;

namespace PurchaseManagerCourseWork.Areas.Security.Controllers
{
    public class BaseSecurityController : Controller
    {
        protected BaseBs objBs;

        public BaseSecurityController()
        {
            objBs = new BaseBs();
        }
    }
}