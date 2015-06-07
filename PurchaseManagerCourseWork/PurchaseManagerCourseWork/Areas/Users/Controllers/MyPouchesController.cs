using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BLL.MainLogic;
using BOL;

namespace PurchaseManagerCourseWork.Areas.Users.Controllers
{
    public class MyPouchesController : BaseUserController
    {
        //
        // GET: /Users/MyPouches/
        private List<Pouch> pouches;
        //
        // GET: /Users/MyPurchases/

        public MyPouchesController()
        {
            pouches = objBs.PouchBs.GetAll().Where(x => x.User.Email == System.Web.HttpContext.Current.User.Identity.Name).ToList();
        }
        public ActionResult Index(string message = "")
        {
            ViewBag.Message = message;
            return View("MyPouches", pouches);
        }

        public ActionResult DeletePouch(int id)
        {
            objBs.PouchBs.Delete(id);
            string messageDeleted = "Deleted Successfuly";
            return RedirectToAction("Index", new {message = messageDeleted});
        }

    }
}
