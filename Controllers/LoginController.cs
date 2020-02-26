using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DahaimMVC.Models;
using DahaimMVC.Models.Context;

namespace DahaimMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly DahaimAppContext db = new DahaimAppContext();

        public ActionResult AddOrEdit()
        {
            return View();
        }

    }
}
