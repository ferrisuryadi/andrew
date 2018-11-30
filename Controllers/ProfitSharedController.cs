using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using fms.Common;
using fms.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("ProfitShared")]
    public class ProfitSharedController : Controller
    {
        protected ApplicationDbContext mContext;

        public ProfitSharedController(ApplicationDbContext context)
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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "ProfitShared").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ViewBag.Items = mContext.mtProfitShared.Include(x => x.country).Include(x => x.agents).ToList();
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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "ProfitShared").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ICollection<mtCountry> Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ICollection<mtAgent> Agents = mContext.mtAgent.Where(x => x.isActive == true).ToList();
            ICollection<mtContainer> Container = mContext.mtContainer.Where(x => x.isActive == true).ToList();

            ViewBag.Container = Container;
            ViewBag.Countries = Countries;
            ViewBag.Agents = Agents;

            ViewBag.Error = false;
            return View("Create", new mtProfitShared());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]mtProfitShared value)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");
                       
            string user = HttpContext.Session.GetString("fullname");
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                List<mtProfitSharedDetails> details = new List<mtProfitSharedDetails>();
                foreach (mtProfitSharedDetails items in value.profitSharedDetails)
                {
                    items.containerId = (items.containerId == 0 ? null : items.containerId);
                    items.isActive = true;
                    items.createdBy = user;
                    items.createdOn = txDate;
                    items.updatedBy = user;
                    items.updatedOn = txDate;
                }

                value.agentId = (value.agentId == 0 ? null : value.agentId);
                value.countryId = (value.countryId == 0 ? null : value.countryId);

                value.createdBy = user;
                value.createdOn = txDate;
                value.updatedBy = user;
                value.updatedOn = txDate;

                var context = new ValidationContext(value, serviceProvider: null, items: null);
                var results = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(value, context, results, true);

                List<string> errorMessage = new List<string>();

                if (!isValid)
                {
                    foreach (ValidationResult validationResult in results)
                        errorMessage.Add(validationResult.ErrorMessage);

                    return Ok(new { status = 400, message = errorMessage });
                }

                mContext.mtProfitShared.Add(value);
                mContext.SaveChanges();

                return Ok(new { status = 200, message = "" });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");
                       
            mContext.Remove(mContext.mtProfitShared.Find(id));
            mContext.RemoveRange(mContext.mtProfitSharedDetails.Where(x => x.profitSharedId == id).ToList());
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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "ProfitShared").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ICollection<mtProfitSharedDetails> Details =
                mContext.mtProfitSharedDetails.Include(x => x.container).Where(x => x.isActive == true && x.profitSharedId == id).ToList();
            ICollection<mtCountry> Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ICollection<mtAgent> Agents = mContext.mtAgent.Where(x => x.isActive == true).ToList();
            ICollection<mtContainer> Container = mContext.mtContainer.Where(x => x.isActive == true).ToList();

            ViewBag.Container = Container;
            ViewBag.Countries = Countries;
            ViewBag.Agents = Agents;
            ViewBag.Details = Details;

            ViewBag.Error = false;
            return View("Edit", mContext.mtProfitShared.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit([FromBody]mtProfitShared value)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");
                       
            string user = HttpContext.Session.GetString("fullname");
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                value.agentId = (value.agentId == 0 ? null : value.agentId);
                value.countryId = (value.countryId == 0 ? null : value.countryId);

                value.updatedBy = user;
                value.updatedOn = txDate;

                var context = new ValidationContext(value, serviceProvider: null, items: null);
                var results = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(value, context, results, true);

                List<string> errorMessage = new List<string>();

                if (!isValid)
                {
                    foreach (ValidationResult validationResult in results)
                        errorMessage.Add(validationResult.ErrorMessage);

                    return Ok(new { status = 400, message = errorMessage });
                }
                mContext.Entry(value).State = EntityState.Modified;
                mContext.SaveChanges();

                return Ok(new { status = 200, message = "" });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");
                       
            mtProfitShared item = mContext.mtProfitShared.Find(id);
            item.isActive = !item.isActive;

            string user = HttpContext.Session.GetString("fullname");
            DateTime txDate = DateTime.Now;

            item.updatedBy = user;
            item.updatedOn = txDate;

            mContext.Entry(item).State = EntityState.Modified;
            mContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("cancel/{id}")]
        public IActionResult cancel(int id)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");
                       
            try
            {
                mtProfitShared item = mContext.mtProfitShared.Find(id);
                ICollection<mtProfitSharedDetails> items = mContext.mtProfitSharedDetails.Where(x => x.isActive == true && x.profitSharedId == item.id).ToList();

                mContext.Entry(item).Reload();

                foreach (mtProfitSharedDetails value in items)
                {
                    mContext.Entry(value).Reload();
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = 409, message = e.Message });
            }

            return Ok(new { status = 200, message = "" });
        }

        [HttpPost]
        [Route("deleteDetail/{id}")]
        public IActionResult deleteDetail(int id)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");
                       
            try
            {
                mContext.Remove(mContext.mtProfitSharedDetails.Find(id));
                mContext.SaveChanges();
            }
            catch(Exception e)
            {
                return Ok(new { status = 409, message = e.Message });
            }

            return Ok(new { status = 200, message = "" });
        }

        [HttpPost]
        [Route("addDetail")]
        public IActionResult addDetail([FromBody]mtProfitSharedDetails value)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");
                       
            string user = HttpContext.Session.GetString("fullname");
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                value.containerId = (value.containerId == 0 ? null : value.containerId);
                value.isActive = true;
                value.createdBy = user;
                value.createdOn = txDate;
                value.updatedBy = user;
                value.updatedOn = txDate;

                var context = new ValidationContext(value, serviceProvider: null, items: null);
                var results = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(value, context, results, true);

                List<string> errorMessage = new List<string>();

                if (!isValid)
                {
                    foreach (ValidationResult validationResult in results)
                        errorMessage.Add(validationResult.ErrorMessage);

                    return Ok(new { status = 400, message = errorMessage });
                }

                mContext.mtProfitSharedDetails.Add(value);
                mContext.SaveChanges();

                int id = value.id;
                return Ok(new { status = 200, message = id.ToString() });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
        }
    }
}
