using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.MainLogic;

namespace PurchaseManagerCourseWork.Areas.Users.Controllers
{
    public class PurchaseDetailsController : BaseUserController
    {
        //
        // GET: /Users/PurchaseDetails/

        public ActionResult Index(int id)
        {
            var purchase = objBs.PurchaseBs.GetById(id);
            PurchaseCounter purchCounter = new PurchaseCounter(purchase);
            try
            {
                ViewBag.MonthPayment = purchCounter.CountMonthPayment();
            }
            catch (Exception ex)
            {
                ViewBag.MonthPayment = ex.Message;
            }
            return View("PurchaseDetails", purchase);
        }

    }
}
