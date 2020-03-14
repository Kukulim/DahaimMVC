using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DahaimMVC.Controllers
{
    public class UserDetailsController : Controller
    {
        // GET: UserDetails
        public ActionResult Index()
        {
            if (Convert.ToInt32(Session["UserLvl"]) == 0)
            {
                return RedirectToAction("NoAuthorization", "UserDetails");
            }
            return View();
        }
        public ActionResult NoAuthorization()
        {
            return View();
        }
        public ActionResult A0()
        {
            return View();
        }
        public ActionResult A1()
        {
            return View();
        }
        public ActionResult A2()
        {
            return View();
        }
        public ActionResult B1()
        {
            return View();
        }
        public ActionResult B2()
        {
            return View();
        }
        public ActionResult C1()
        {
            return View();
        }
        public ActionResult C2()
        {
            return View();
        }
    }
}