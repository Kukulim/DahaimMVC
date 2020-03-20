using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DahaimMVC.Areas.Shop.Models;

namespace DahaimMVC.Areas.Shop.Controllers
{
    public class ShopManagerController : Controller
    {
        private readonly IProductData productData;

        public ShopManagerController(IProductData productData)
        {
            this.productData = productData;
        }

        public ActionResult Index()
        {
            var model = productData.GetAll();
            return View();
        }

    }
}