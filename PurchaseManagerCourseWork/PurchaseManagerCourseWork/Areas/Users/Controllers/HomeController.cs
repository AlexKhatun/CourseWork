using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;

namespace PurchaseManagerCourseWork.Areas.Users.Controllers
{
    [AllowAnonymous]
    public class HomeController : BaseUserController
    {
        //
        // GET: /User/Home/

        public ActionResult AppStart(string message = "")
        {
            ViewBag.Mess = message;
            //var user = new User { UserId = 1, Email = "khatun3000@yandex.ru", Password = "khatunec" };
            //objBs.UserBs.Insert(user);
            if (System.Web.HttpContext.Current.User.Identity.Name != null)
            {
                ViewBag.Message = System.Web.HttpContext.Current.User.Identity.Name;
            }
            return View("Home");
        }

    }
}
