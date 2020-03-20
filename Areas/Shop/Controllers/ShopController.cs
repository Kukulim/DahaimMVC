using DahaimMVC.Areas.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Type = DahaimMVC.Areas.Shop.Models.Type;

namespace DahaimMVC.Areas.Shop.Controllers
{

    public class ShopController : Controller
    {
        private readonly ITypeData typeData;
        private readonly IProductData productData;

        public ShopController(ITypeData typeData, IProductData productData)
        {
            this.typeData = typeData;
            this.productData = productData;
        }
        public ActionResult Index()
        {
            var types = typeData.GetAll();
            return View(types);
        }
        public ActionResult Browse(string type)
        {
            var typeModel = new Type { Name = type };
            return View(typeModel);
        }

        public ActionResult Details(int id)
        {
            var product = new Product { Title = "Produkt nazwa " + id };
            return View(product);
        }
    }
}