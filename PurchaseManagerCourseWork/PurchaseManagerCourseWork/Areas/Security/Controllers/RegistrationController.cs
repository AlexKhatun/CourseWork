using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Services.Description;
using BLL.MainLogic;
using BOL;

namespace PurchaseManagerCourseWork.Areas.Security.Controllers
{
    [AllowAnonymous]
    public class RegistrationController : BaseSecurityController
    {
        //
        // GET: /Security/Registration/

        public ActionResult Index(string message = "")
        {
            ViewBag.Message = message;
            return View("Registration");
        }

        public ActionResult CreateUser(User user)
        {
            user.Date = DateTime.Now;
            WorkWithUser workWithUser = new WorkWithUser();
            if (workWithUser.CheckForUniqueUser(user.Email))
            {
                user.Password = WorkWithUser.GetPasswordHash(user.Password);
                objBs.UserBs.Insert(user);
                FormsAuthentication.SetAuthCookie(user.Email, true);
                return RedirectToAction("AppStart", "Home", new {area = "Users", message = "Регистрация успешна!"});
            }
            else
            {
                return RedirectToAction("Index", new {message = "Такой пользователь уже существует!"});
            }
        }
    }
}
