using DahaimMVC.Models;
using System;
using System.Web.Mvc;

namespace DahaimMVC.Areas.Admin.Controllers
{
    public class ControlPanelController : Controller
    {
        private readonly IUserData database;
        private readonly IMessageData messageData;

        public ControlPanelController(IUserData database, IMessageData messageData)
        {
            this.database = database;
            this.messageData = messageData;
        }
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.LvlSortParm = sortOrder == "lagnuageLvl" ? "lagnuageLvl_desc" : "lagnuageLvl";

            var model = database.GetAll(sortOrder, searchString);

            int unreaded = messageData.UnReaded();
            TempData["Unreaded"] = unreaded;

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
        public ActionResult UserDelete(int id, int? cos) //gdziesz widziałem jak to zrobić inaczej ROZWIAZANE W SHOPMANAGER KONTROLER ZOSTAWIAM JAKO PRZYKŁAD
        {
            var model = database.Get(id);
            database.Delete(model);
            TempData["Message"] = "Student usuniety z bazy danych";
            return RedirectToAction("Index");

        }
        public ActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUser(User userModel)
        {
            var UserDetails = database.GetUserByName(userModel);
            if (UserDetails == null)
            {
                database.Add(userModel);
                ViewBag.SuccesMessage = "Konto zostało utworzone";

                ModelState.Clear();

                return RedirectToAction("Index");
            }

            ViewBag.LoginInUse = "Taki użytkownik jest już zarejstrowany";

            return View();
        }
        public ActionResult MessageIndex()
        {
            var model = messageData.GetAll();
            TempData["Unreaded"] = messageData.UnReaded();
            return View(model);
        }
        public ActionResult MessageDetails(int id)
        {
          
            {
                var model = messageData.GetAndRead(id);
                if (model == null)
                {
                    return View("NotFound");
                }
                int unreaded = messageData.UnReaded();
                TempData["Unreaded"] = unreaded;
                return View(model);
            }
        }
        public ActionResult MessageDelete(int id)
        {
            var model = messageData.Get(id);
            if (model == null)
            {
                return View("Notfound");
            }
            int unreaded = messageData.UnReaded();
            TempData["Unreaded"] = unreaded;
            return View(model);
        }
        [HttpPost]
        public ActionResult MessageDelete(int id, int? cos) //gdziesz widziałem jak to zrobić inaczej ROZWIAZANE W SHOPMANAGER KONTROLER ZOSTAWIAM JAKO PRZYKŁAD
        {
            var model = messageData.Get(id);
            messageData.Delete(model);
            return RedirectToAction("MessageIndex");
        }
    }
}
