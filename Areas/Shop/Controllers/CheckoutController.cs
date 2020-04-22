using DahaimMVC.Areas.Shop.Models;
using DahaimMVC.Areas.Shop.Models.OrdersModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace DahaimMVC.Areas.Shop.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly StoreDbContext storeDB = new StoreDbContext();
        private const string PromoCode = "FREE";

        public ActionResult AddressAndPayment()
        {
            if (ShoppingCart.GetCart(this.HttpContext).GetTotal() == 0)
            {
                TempData["EmptyCart"] = "Koszyk niemoże być pusty";
                return RedirectToAction("Index", "ShoppingCart");
            }
            return View();
        }

        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection values)
        {
            var order = new Order();
            TryUpdateModel(order);

            try
            {
                if (Session["UserName"] != null)
                {
                    order.Username = Session["UserName"].ToString();
                }
                else
                {
                    order.Username = "Unregistered user";
                }
                order.OrderDate = DateTime.Now;

                var sum = ShoppingCart.GetCart(this.HttpContext).GetTotal();
                order.Total = sum;
                if (string.Equals(values["PromoCode"], PromoCode,
                    StringComparison.OrdinalIgnoreCase) == true)
                {
                    sum = (sum * (decimal)0.9);
                }
                order.Total = sum;

                storeDB.Orders.Add(order);
                storeDB.SaveChanges();

                var cart = ShoppingCart.GetCart(this.HttpContext);
                cart.CreateOrder(order);

                return RedirectToAction("Complete", new { id = order.OrderId });
            }
            catch
            {
                return View(order);
            }
        }

        public ActionResult Complete(int id)
        {
            bool isValid = storeDB.Orders.Any(
                o => o.OrderId == id);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }
}