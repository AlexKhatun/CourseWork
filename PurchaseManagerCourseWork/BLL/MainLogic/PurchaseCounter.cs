﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL.MainLogic
{
    public class PurchaseCounter : BaseMainLogic
    {
        private Purchase purchase;

        public PurchaseCounter(Purchase purchase)
        {
            this.purchase = purchase;
        }
        public decimal CountMonthPayment()
        {
            if (CountFreeMoney() < 0)
            {
                throw new Exception("Простите, но по нашим данным, Вы не можете себе этого позволить:(");
            }
            int monthCount = Convert.ToInt32(Convert.ToDateTime(purchase.Period).Month - DateTime.Now.Month);
            if (monthCount == 0)
            {
                monthCount = 1;
            }
            if (monthCount < 0)
            {
                throw new Exception("Вы просрочили покупку на " + -monthCount + " месяцев");
            }
            decimal price = purchase.Price/monthCount;
            return price;
        }

        private decimal CountFreeMoney()
        {
            decimal money = GetUserMoney();
            decimal needs = GetUserNeeds();
            return money - needs;
        }
        private decimal GetUserNeeds()
        {
            var allUserPurchases = objBs.PurchaseBs.GetAll().Where(x => x.UserId == purchase.UserId && x.Priority >= purchase.Priority);
            return allUserPurchases.Sum(a => a.Price);
        }
        private decimal GetUserMoney()
        {
            var pouch = objBs.PouchBs.GetById(purchase.PouchId);
            return pouch.Money;
        }
    }
}
