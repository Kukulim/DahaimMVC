using DahaimMVC.Areas.Shop.Models;
using PagedList;
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

        public ActionResult Browse(string type, int? page)
        {
            Type typeModel = typeData.GetType(type);

            int pageSize = 6;
            int pageNumber = (page ?? 1);

            ViewBag.Type = type;

            return View(typeModel.Products.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Details(int id)
        {
            var typeModel = productData.Get(id);
            return View(typeModel);
        }

        [ChildActionOnly]
        public ActionResult TypeMenu()
        {
            var genres = typeData.GetAll();
            return PartialView(genres);
        }
    }
}