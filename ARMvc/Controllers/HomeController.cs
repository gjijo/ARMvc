using AlKhalidRentalsClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARMvc.Controllers
{
    [SessionExpiryFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}