using AlKhalidRentalsClient.Helpers;
using ARMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ARMvc.Controllers
{
    [SessionExpiryFilter]
    public class MaintenanceController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> PreviousMainatenanceStatus()
        {
            return Json(new ResponseModel() { Status = false, Data = null, Errors = null });
        }
    }
}