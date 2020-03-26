using DahaimMVC.Areas.Shop.Models;
using DahaimMVC.Filters;
using System.Web.Mvc;

namespace DahaimMVC.Areas.Shop.Controllers
{
    [AdminAccessFilter]
    public class ShopManagerController : Controller
    {
        private readonly ITypeData typeData;
        private readonly IProductData productData;
        private readonly IAuthorData authorData;

        public ShopManagerController(ITypeData typeData, IProductData productData, IAuthorData authorData)
        {
            this.typeData = typeData;
            this.productData = productData;
            this.authorData = authorData;
        }
        public ActionResult Index()
        {
            var model = productData.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            ViewBag.TypeId = new SelectList(typeData.GetAll(), "TypeId", "Name");
            ViewBag.AuthorId = new SelectList(authorData.GetAll(), "AuthorId", "AuthorName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                productData.Add(product);
                return RedirectToAction("Index");
            }
            ViewBag.TypeId = new SelectList(typeData.GetAll(), "TypeId", "Name", product.TypeId);
            ViewBag.AuthorId = new SelectList(authorData.GetAll(), "AuthorId", "AuthorName", product.AuthorId);

            return View(product);
        }
        public ActionResult Edit(int id)
        {
            Product product = productData.Get(id);
            ViewBag.TypeId = new SelectList(typeData.GetAll(), "TypeId", "Name", product.TypeId);
            ViewBag.AuthorId = new SelectList(authorData.GetAll(), "AuthorId", "AuthorName", product.AuthorId);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                productData.Edit(product);
                return RedirectToAction("Index");
            }
            ViewBag.TypeId = new SelectList(typeData.GetAll(), "TypeId", "Name", product.TypeId);
            ViewBag.AuthorId = new SelectList(authorData.GetAll(), "AuthorId", "AuthorName", product.AuthorId);
            return View(product);
        }
        public ViewResult Details(int id)
        {
            Product product = productData.Get(id);
            return View(product);
        }
        public ActionResult Delete(int id)
        {
            Product product = productData.Get(id);
            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = productData.Get(id);
            productData.Delete(product);
            return RedirectToAction("Index");
        }
    }
}