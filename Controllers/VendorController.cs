using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("Vendor")]
    public class VendorController : Controller
    {
        protected ApplicationDbContext mContext;

        public VendorController(ApplicationDbContext context)
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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "Vendor").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ViewBag.Items = mContext.mtVendor.Include(x => x.coaIdr).Include(x => x.coaUsd).Include(x => x.type).ToList();
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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "Vendor").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();
            ICollection<mtType> Type = mContext.mtType.Where(x => x.isActive == true && x.category == 2).ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;
            ViewBag.Type = Type;

            ViewBag.Error = false;
            return View("Create", new mtVendor());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]mtVendor value)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            string user = HttpContext.Session.GetString("fullname");
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                List<mtVendorDetails> details = new List<mtVendorDetails>();
                foreach (mtVendorDetails items in value.vendorDetails)
                {
                    items.isActive = true;
                    items.createdBy = user;
                    items.createdOn = txDate;
                    items.updatedBy = user;
                    items.updatedOn = txDate;
                }

                value.coaIdIdr = (value.coaIdIdr == 0 ? null : value.coaIdIdr);
                value.coaIdUsd = (value.coaIdUsd == 0 ? null : value.coaIdUsd);
                value.typeId = (value.typeId == 0 ? null : value.typeId);

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

                mContext.mtVendor.Add(value);
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

            mContext.Remove(mContext.mtVendor.Find(id));
            mContext.RemoveRange(mContext.mtVendorDetails.Where(x => x.vendorId == id).ToList());
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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "Vendor").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }


            ICollection<mtVendorDetails> Details =
                mContext.mtVendorDetails.Where(x => x.isActive == true && x.vendorId == id).ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();
            ICollection<mtType> Type = mContext.mtType.Where(x => x.isActive == true && x.category == 2).ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;
            ViewBag.Type = Type;
            ViewBag.Details = Details;

            ViewBag.Error = false;
            return View("Edit", mContext.mtVendor.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit([FromBody]mtVendor value)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            string user = HttpContext.Session.GetString("fullname");
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                value.coaIdIdr = (value.coaIdIdr == 0 ? null : value.coaIdIdr);
                value.coaIdUsd = (value.coaIdUsd == 0 ? null : value.coaIdUsd);
                value.typeId = (value.typeId == 0 ? null : value.typeId);

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

            mtVendor item = mContext.mtVendor.Find(id);
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
                mtVendor item = mContext.mtVendor.Find(id);
                ICollection<mtVendorDetails> items = mContext.mtVendorDetails.Where(x => x.isActive == true && x.vendorId == item.id).ToList();

                mContext.Entry(item).Reload();

                foreach (mtVendorDetails value in items)
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
                mContext.Remove(mContext.mtVendorDetails.Find(id));
                mContext.SaveChanges();
            }
            catch (Exception e)
            {
                return Ok(new { status = 409, message = e.Message });
            }

            return Ok(new { status = 200, message = "" });
        }

        [HttpPost]
        [Route("addDetail")]
        public IActionResult addDetail([FromBody]mtVendorDetails value)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            string user = HttpContext.Session.GetString("fullname");
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
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

                mContext.mtVendorDetails.Add(value);
                mContext.SaveChanges();

                int id = value.id;
                return Ok(new { status = 200, message = id.ToString() });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
        }
    }
}
