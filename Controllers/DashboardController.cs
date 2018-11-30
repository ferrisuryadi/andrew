using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Web;
using fms.Models;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("Dashboard")]
    public class DashboardController : Controller
    {
        protected ApplicationDbContext mContext;

        public DashboardController(ApplicationDbContext context)
        {
            mContext = context;
        }

        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            ICollection<sysModule> moduleLvl1 =
                mContext.sysModuleRole.Include(x => x.module)
                        .Where(x => x.userRoleId == HttpContext.Session.GetInt32("roleId") && x.isActive == true && x.module.level == 1)
                        .Select(x => x.module).ToList();

            ICollection<sysModule> moduleLvl2 =
                mContext.sysModuleRole.Include(x => x.module)
                        .Where(x => x.userRoleId == HttpContext.Session.GetInt32("roleId") && x.isActive == true && x.module.level == 2)
                        .Select(x => x.module).ToList();

            ViewBag.moduleLvl1 = moduleLvl1.OrderBy(x => x.orderModule);
            ViewBag.moduleLvl2 = moduleLvl2.OrderBy(x => x.orderModule);
            ViewBag.user = HttpContext.Session.GetString("fullname");

            try
            {
                sysModule menu = moduleLvl1.Where(x => x.code == "Dashboard").SingleOrDefault();

                ViewData["Menu"] = menu.name;
                ViewData["SubMenuLvl1"] = "";
                ViewData["Title"] = menu.name;
            }
            catch{
                return RedirectToAction("index", "login");
            }


            return View();
        }
    }
}
