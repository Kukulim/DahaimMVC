using DahaimMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DahaimMVC.Controllers
{
    public class ControlPanelController : Controller
    {
        private readonly IUserData database;
        public ControlPanelController(IUserData database)
        {
            this.database = database;
        }
        public ActionResult Index()
        {
            var model = database.GetAll();
            return View(model);
        }
    }
}