using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;

namespace PurchaseManagerCourseWork.Areas.Security.Controllers
{
    public class RegistrationController : BaseSecurityController
    {
        //
        // GET: /Security/Registration/

        public ActionResult Index()
        {
            return View("Registration");
        }

        public ActionResult CreateUser(User user)
        {
            user.Date = DateTime.Now;
            objBs.UserBs.Insert(user);
            return RedirectToAction("AppStart", "Home", new {area = "Users"});
        }
    }
}
