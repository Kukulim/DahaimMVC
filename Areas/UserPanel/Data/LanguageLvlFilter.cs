using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace DahaimMVC.Areas.UserPanel.Data
{
    public class LanguageLvlFilter : FilterAttribute, IActionFilter
    {
        public int RequiredLvl { get; set; }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            int UserLvl = Convert.ToInt32(filterContext.HttpContext.Session["UserLvl"]);
            if (UserLvl < RequiredLvl)
            {
                filterContext.Result = (new RedirectToRouteResult(new RouteValueDictionary(new { action = "Index", controller = "UserDetails" })));
            }
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }
    }
}