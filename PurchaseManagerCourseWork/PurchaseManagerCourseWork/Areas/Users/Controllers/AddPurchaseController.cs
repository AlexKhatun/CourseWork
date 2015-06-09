using System;
using System.Collections;
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
        private List<int> myList = new List<int>();
        //
        // GET: /Users/AppPurchase/
        public ActionResult Index(string message = "")
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            ViewBag.Message = message;
            var db = new PurchaseManagerEntities();
            ViewBag.Priority = new SelectList(myList);
            ViewBag.PouchId = new SelectList(db.Pouch.Where(x=>x.User.Email == System.Web.HttpContext.Current.User.Identity.Name), "PouchId", "Name");
            return View("AddPurchase");
        }

        [HttpPost]
        public ActionResult CreateNewPurchase(Purchase purchase)
        {
            User user = objBs.UserBs.GetAll().FirstOrDefault(x => x.Email == System.Web.HttpContext.Current.User.Identity.Name);
            purchase.UserId = user.UserId;
            purchase.Status = 0;
            if (purchase.Period < DateTime.Now)
            {
                return RedirectToAction("Index", new {message = "Введите дату больше текущей!"});
            }
            try
            {
                objBs.PurchaseBs.Insert(purchase);
                ViewBag.Message = "Успешно!";
            }
            catch (Exception)
            {
                ViewBag.Message = "Ошибка!";
            }
            return RedirectToAction("Index", new { message = ViewBag.Message });

        }

    }
}
