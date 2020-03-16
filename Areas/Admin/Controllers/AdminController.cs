using DahaimMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DahaimMVC.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private Administrator admin;

        public AdminController()
        {
            admin =  new Administrator();
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
            Session.Abandon();
            return RedirectToAction("Index", "Admin");
        }
    }
}