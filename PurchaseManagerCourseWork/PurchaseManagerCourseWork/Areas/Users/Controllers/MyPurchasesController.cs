using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.DataConnection;
using BLL.MainLogic;
using BOL;

namespace PurchaseManagerCourseWork.Areas.Users.Controllers
{
    public class MyPurchasesController : BaseUserController
    {
        private List<Purchase> purchases;
        //
        // GET: /Users/MyPurchases/

        public MyPurchasesController()
        {
            purchases = objBs.PurchaseBs.GetAll().Where(x => x.User.Email == System.Web.HttpContext.Current.User.Identity.Name).ToList();
        }

        public ActionResult Index(string message = "")
        {
            ViewBag.Message = message;
            return View("MyPurchases", purchases);
        }

        public ActionResult DeletePurchase(int id)
          {
            objBs.PurchaseBs.Delete(id);
            string messageDeleted = "Успешно удалено!";
            return RedirectToAction("Index", new {message = messageDeleted});
        }

    }
}
