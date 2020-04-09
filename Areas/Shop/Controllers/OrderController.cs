using DahaimMVC.Areas.Shop.Models;
using DahaimMVC.Areas.Shop.Models.OrdersModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DahaimMVC.Areas.Shop.Controllers
{
    public class OrderController : Controller
    {
        readonly StoreDbContext storeDB = new StoreDbContext();

        // GET: Shop/Order
        public ActionResult Index()
        {
            var model = storeDB.ShipmentAndPayments.Where(x => x.IsComplete == false).ToList();
            return View(model);
        }
        public ActionResult Archive()
        {
            var model = storeDB.ShipmentAndPayments.Where(x => x.IsComplete == true).ToList();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var model = storeDB.Orders.Where( x => x.OrderId == id ).SingleOrDefault();
            return View(model);
        }
    }
}