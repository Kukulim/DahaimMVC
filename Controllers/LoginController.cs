using DahaimMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DahaimMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserData database;       
        public LoginController(IUserData database)
        {
            this.database = database;
        }
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Authorize(User userModel)
        {
            var UserDetails = database.GetLogin(userModel);           
            if (UserDetails == null)
            {
                ModelState.Clear();

                ViewBag.WrongPassword = "Błędny login lub hasło";

                return View("Index",new User());
            }
            else
            {
                Session["UserId"] = UserDetails.UserId;
                Session["UserName"] = UserDetails.UserName;
                Session["UserLvl"] = UserDetails.LanguageLvl;
                return RedirectToAction("Index", "UserDetails");
            }
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User userModel)
        {
            var UserDetails = database.GetUserByName(userModel);
            if (UserDetails == null)
            {
                database.Add(userModel);
                ViewBag.SuccesMessage = "Konto zostało utworzone";

                ModelState.Clear();

                return View("Register", new User());
            }

            ViewBag.LoginInUse = "Taki użytkownik jest już zarejstrowany";

            return View("Register");
        }
    }
}