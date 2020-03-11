using DahaimMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DahaimMVC.Controllers
{
    public class AdminController : Controller
    {
        private Admin admin;

        public AdminController()
        {
            admin =  new Admin();
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin adminModel)
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
            Session.Abandon();
            return RedirectToAction("Index", "Admin");
        }
    }
}