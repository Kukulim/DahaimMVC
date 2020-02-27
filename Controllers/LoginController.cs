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
                return View("Index");
            }
            else
            {
                Session["UserId"] = UserDetails.UserId;
                Session["UserName"] = UserDetails.UserName;
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
        public ActionResult Register(User user)
        {
            database.Add(user);
            ViewBag.SuccesMessage = "Konto zostało utworzone";
            return View("Register", new User());
        }
    }
}