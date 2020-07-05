using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARTheamF.Helpers;
using AlKhalidModels;
using System.Web.Mvc;
using System.Web.Routing;

namespace ARTheamF.Helpers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class SessionExpiryFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session == null || filterContext.HttpContext.Session[SessionConstants.UserSession] == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new
                        {
                            action = "Index",
                            controller = "Account"
                        }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}
