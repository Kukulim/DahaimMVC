using System.Web.Mvc;

namespace DahaimMVC.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private readonly Administrator admin;

        public AdminController()
        {
            admin = new Administrator();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Administrator adminModel)
        {
            if ((adminModel.AdminName == admin.AdminName) && (adminModel.AdminPassword == admin.AdminPassword))
            {
                Session["UserName"] = adminModel.AdminName;
                return RedirectToAction("Index", "ControlPanel");
            }
            return View();
        }

        public ActionResult LogOut()
        {
            if (Session != null)
            {
                Session.Clear();
            }

            return RedirectToAction("Index", "Admin");
        }
    }
}