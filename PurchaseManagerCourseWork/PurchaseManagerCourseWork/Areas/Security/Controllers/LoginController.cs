using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BLL.MainLogic;
using BOL;

namespace PurchaseManagerCourseWork.Areas.Security.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        //
        // GET: /Security/Login/

        public ActionResult Index()
        {
            
            return View("Login");
        }

        public ActionResult SignIn(User user)
        {
            if (Membership.ValidateUser(user.Email, user.Password))
            {
                FormsAuthentication.SetAuthCookie(user.Email, true);
                return RedirectToAction("AppStart", "Home", new { area = "Users", });
            }
            return RedirectToAction("Index");
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("AppStart", "Home", new {area = "Users"});
        }
    }
}
