using DahaimMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DahaimMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageData messageDataBase;

        public HomeController(IMessageData messageDataBase)
        {
            this.messageDataBase = messageDataBase;
        }
        public ActionResult Index()
        {
            if (Session != null)
            {
                Session.Clear();
            }
            return View();
        }
        [HttpPost]
        public ActionResult Index(Message message)
        {
            messageDataBase.Add(message);

            ViewBag.SuccesMessageSend = "Wiadomość została wysłana";

            ModelState.Clear();

            return View(new Message());
        }
    }
}