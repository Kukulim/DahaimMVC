﻿using DahaimMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DahaimMVC.Controllers
{
    public class UserDetailsController : Controller
    {
        private readonly IUserData database;

        public UserDetailsController(IUserData database)
        {
            this.database = database;
        }
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
        public ActionResult UserDelete()
        {
            int identy = Convert.ToInt32(Session["UserId"]);
            var model = database.Get(identy);
            return View(model);
        }
        [HttpPost]
        public ActionResult UserDelete(User user)
        {
            int identy = Convert.ToInt32(Session["UserId"]);
            var model = database.Get(identy);

            if (model.UserPassword == user.UserPassword)
            {
                database.Delete(model);
                TempData["Usunieto"] = "Konto usunięte";
                Session.Clear();
                return RedirectToAction("Index", "Home");
            }
            TempData["BadPass"] = "Błędne hasło";
            return RedirectToAction("UserDelete");
        }

        public ActionResult UserEdit()
        {
            int id = Convert.ToInt32(Session["UserId"]);
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
            database.EditByUser(model);
            TempData["Message"] = "Zapisano w bazie danych";
            Session.Clear();
            return RedirectToAction("Index","Login");
        }
    }
}