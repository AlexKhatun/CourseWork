using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PurchaseManagerCourseWork.Areas.Users.Controllers
{
    public class PouchDetailsController : BaseUserController
    {
        //
        // GET: /Users/Pouch/

        public ActionResult Index(int id)
        {
            var pouch = objBs.PouchBs.GetById(id);
            return View("PouchDetails", pouch);
        }

    }
}
