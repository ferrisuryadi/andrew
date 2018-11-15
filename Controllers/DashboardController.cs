using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace fms.Controllers
{
    [Route("Dashboard")]
    public class DashboardController : Controller
    {
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewData["Menu"] = "Dashboard";
            ViewData["SubMenuLvl1"] = "";
            return View();
        }
    }
}
