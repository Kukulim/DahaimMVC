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
        public ActionResult UserDetails(int id)
        {
            var model = database.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        public ActionResult UserEdit(int id)
        {
            var model = database.Get(id);
            if (model == null)
            {
                return View("Notfound");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult UserEdit(User model)
        {
            database.Edit(model);
            TempData["Message"] = "Zapisano w bazie danych";
            return RedirectToAction("Index");
        }
        public ActionResult UserDelete(int id)
        {
            var model = database.Get(id);
            if (model == null)
            {
                return View("Notfound");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult UserDelete(User model)
        {
            database.Delete(model);
            TempData["Message"] = "Student usuniety z bazy danych";
            return RedirectToAction("Index");

        }
    }
}