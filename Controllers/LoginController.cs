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
        UserDbContext database = new UserDbContext();
        public LoginController()
        {
            //UserDbContext database = new UserDbContext();
        }
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Authorize(User userModel)
        {
            var UserDetails = database.User.Where(x => x.UserName == userModel.UserName && x.UserPassword == userModel.UserPassword).FirstOrDefault();
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
    }
}