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
    [Authorize]
    public class AddPouchController : BaseUserController
    {
        //
        // GET: /Users/AddPouch/

        public ActionResult Index()
        {
            return View("AddPouch");
        }

        [HttpPost]
        public ActionResult CreateNewPouch(Pouch pouch)
        {
            User user = objBs.UserBs.GetAll().FirstOrDefault(x => x.Email == System.Web.HttpContext.Current.User.Identity.Name);
            pouch.UserId = user.UserId;
            try
            {
                objBs.PouchBs.Insert(pouch);
                ViewBag.Message = "Success!";
            }
            catch (Exception)
            {
                ViewBag.Message = "Failed!";
            }
            return View("AddPouch");
        }
    }
}
