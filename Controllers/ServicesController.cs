using System;
using System.Collections.Generic;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("Services")]
    public class ServicesController : Controller
    {
        protected ApplicationDbContext mContext;
        public ServicesController(ApplicationDbContext context)
        {
            mContext = context;
        }

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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "Service").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ICollection<mtServices> services = 
                mContext.mtServices
                        .Include(x => x.coaIdr)
                        .Include(x => x.coaUsd)
                        .Include(x => x.groups).ToList();
            ViewBag.Items = services;
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "Service").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ICollection<mtChartOfAccount> CoaIdr = 
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "IDR").ToList();

            ICollection<mtChartOfAccount> CoaUsd =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ICollection<mtGroups> Groups =
                mContext.mtGroups
                    .Where(x => x.isActive == true).ToList();

            ViewBag.CoaIdr = CoaIdr;
            ViewBag.coausd = CoaUsd;
            ViewBag.Groups = Groups;

            ViewBag.Error = false;
            return View("Create", new mtServices());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtServices item)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            if (ModelState.IsValid)
            {
                string user = HttpContext.Session.GetString("fullname");
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                item.coaIdIdr = (item.coaIdIdr == 0 ? null : item.coaIdIdr);
                item.coaIdUsd = (item.coaIdUsd == 0 ? null : item.coaIdUsd);
                item.groupId = (item.groupId == 0 ? null : item.groupId);

                mContext.mtServices.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }
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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "Service").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ICollection<mtChartOfAccount> CoaIdr =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "IDR").ToList();

            ICollection<mtChartOfAccount> CoaUsd =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ICollection<mtGroups> Groups =
                mContext.mtGroups
                    .Where(x => x.isActive == true).ToList();

            ViewBag.CoaIdr = CoaIdr;
            ViewBag.coausd = CoaUsd;
            ViewBag.Groups = Groups;

            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            mContext.Remove(mContext.mtServices.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "Service").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ICollection<mtChartOfAccount> CoaIdr =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "IDR").ToList();

            ICollection<mtChartOfAccount> CoaUsd =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ICollection<mtGroups> Groups =
                mContext.mtGroups
                    .Where(x => x.isActive == true).ToList();

            ViewBag.CoaIdr = CoaIdr;
            ViewBag.CoaUsd = CoaUsd;
            ViewBag.Groups = Groups;

            ViewBag.Error = false;
            return View("Edit", mContext.mtServices.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtServices item)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            if (ModelState.IsValid)
            {
                string user = HttpContext.Session.GetString("fullname");
                DateTime txDate = DateTime.Now;

                item.updatedBy = user;
                item.updatedOn = txDate;

                item.coaIdIdr = (item.coaIdIdr == 0 ? null : item.coaIdIdr);
                item.coaIdUsd = (item.coaIdUsd == 0 ? null : item.coaIdUsd);
                item.groupId = (item.groupId == 0 ? null : item.groupId);

                mContext.Entry(item).State = EntityState.Modified;
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "Service").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ICollection<mtChartOfAccount> CoaIdr =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "IDR").ToList();

            ICollection<mtChartOfAccount> CoaUsd =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ICollection<mtGroups> Groups =
                mContext.mtGroups
                    .Where(x => x.isActive == true).ToList();

            ViewBag.CoaIdr = CoaIdr;
            ViewBag.coausd = CoaUsd;
            ViewBag.Groups = Groups;

            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            mtServices item = mContext.mtServices.Find(id);
            item.isActive = !item.isActive;

            string user = HttpContext.Session.GetString("fullname");
            DateTime txDate = DateTime.Now;

            item.updatedBy = user;
            item.updatedOn = txDate;

            mContext.Entry(item).State = EntityState.Modified;
            mContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
