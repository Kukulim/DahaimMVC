using DahaimMVC.Areas.Shop.Models;
using DahaimMVC.Areas.Shop.Models.OrdersModels;
using DahaimMVC.Areas.Shop.ViewModels;
using DahaimMVC.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DahaimMVC.Areas.Shop.Controllers
{
    [AdminAccessFilter]
    public class OrderController : Controller
    {
        private readonly StoreDbContext storeDB = new StoreDbContext();

        // GET: Shop/Order
        public ActionResult Index()
        {
            var model = storeDB.ShipmentAndPayments.Where(x => x.IsComplete == false).ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(IList<ShipmentAndPayment> modeledit)
        {
            var model = storeDB.ShipmentAndPayments.Where(x => x.IsComplete == false).ToList();
            for (int i = 0; i < modeledit.Count(); i++)
            {
                if (model[i].IsPayed == false && modeledit[i].IsPayed == true)
                {
                    model[i].PayedTime = DateTime.Now;
                }
                model[i].IsPayed = modeledit[i].IsPayed;

                if (model[i].IsSent == false && modeledit[i].IsSent == true)
                {
                    model[i].SentTime = DateTime.Now;
                }
                model[i].IsSent = modeledit[i].IsSent;

                model[i].IsComplete = modeledit[i].IsComplete;
            }
            storeDB.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Archive()
        {
            var model = storeDB.ShipmentAndPayments.Where(x => x.IsComplete == true).ToList();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = new OrderDetailsViewModel
            {
                Order = storeDB.Orders.Where(x => x.OrderId == id).SingleOrDefault(),
                OrderDetail = storeDB.OrderDetails.Where(x => x.OrderId == id).ToList()
            };
            return View(model);
        }
    }
}