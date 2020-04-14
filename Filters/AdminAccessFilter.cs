using DahaimMVC.Areas.Admin;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace DahaimMVC.Filters
{

    public class AdminAccessFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public static Administrator Administrator = new Administrator();
        string adminRole = Administrator.AdminName;

        public void OnAuthentication(AuthenticationContext context)
        {
            if (context.HttpContext.Session["UserName"] == null)
            {
                context.Result = new HttpUnauthorizedResult();
            }
            else if (context.HttpContext.Session["UserName"].ToString() == adminRole)
            {
            }
            else
            {
                context.Result = new HttpUnauthorizedResult();
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext context)
        {
            if (context.Result == null || context.Result is HttpUnauthorizedResult)
            {
                context.Result = new RedirectToRouteResult("Default",
                    new System.Web.Routing.RouteValueDictionary{
                        {"controller", "Home"},
                        {"action", "Index"},
                        {"returnUrl", context.HttpContext.Request.RawUrl}
                    });
            }
        }
    }
}
