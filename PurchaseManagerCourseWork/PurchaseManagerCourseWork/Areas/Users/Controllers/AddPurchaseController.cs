using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BLL.MainLogic;
using BOL;

namespace PurchaseManagerCourseWork.Areas.Users.Controllers
{
    public class AddPurchaseController : BaseUserController
    {
        //
        // GET: /Users/AppPurchase/

        public ActionResult Index()
        {
            return View("AddPurchase");
        }

        [HttpPost]
        public ActionResult CreateNewPurchase(Purchase purchase)
        {
            User user = objBs.UserBs.GetAll().FirstOrDefault(x => x.Email == System.Web.HttpContext.Current.User.Identity.Name);
            purchase.UserId = user.UserId;
            try
            {
                objBs.PurchaseBs.Insert(purchase);
                ViewBag.Message = "Success!";
            }
            catch (Exception)
            {
                ViewBag.Message = "Failed!";
            }
            return View("AddPurchase");

        }

    }
}
