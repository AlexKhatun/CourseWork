using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BOL;

namespace PurchaseManagerCourseWork.Areas.Users.Controllers
{
    public class ProfileController : BaseUserController
    {
        //
        // GET: /Users/Profile/
        public ActionResult Index()
        {
            User user =
                objBs.UserBs.GetAll().FirstOrDefault(x => x.Email == System.Web.HttpContext.Current.User.Identity.Name);
            return View("MyProfile", user);
        }

        public ActionResult DeleteProfile()
        {
            User user =
                objBs.UserBs
                    .GetAll()
                    .FirstOrDefault(x => x.Email == System.Web.HttpContext.Current.User.Identity.Name);
            if (objBs.PurchaseBs.GetAll().Count() != 0)
            {
                for (int i = 0; i <= objBs.PurchaseBs.GetAll().Max(x => x.PurchaseId); i++)
                {
                    try
                    {
                        if (objBs.PurchaseBs.GetById(i).UserId == user.UserId)
                        {
                            objBs.PurchaseBs.Delete(i);
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            if (objBs.PouchBs.GetAll().Count() != 0)
            {
                for (int i = 0; i <= objBs.PouchBs.GetAll().Max(x => x.PouchId); i++)
                {
                    try
                    {
                        if (objBs.PouchBs.GetById(i).UserId == user.UserId)
                        {
                            objBs.PouchBs.Delete(i);
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            objBs.UserBs.Delete(user.UserId);
            FormsAuthentication.SignOut();
            return RedirectToAction("AppStart", "Home");
        }
	}
}