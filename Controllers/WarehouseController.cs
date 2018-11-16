using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("Warehouse")]
    public class WarehouseController : Controller
    {
        protected ApplicationDbContext mContext;

        public WarehouseController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Warehouse";

            ViewBag.Items = mContext.mtWarehouse.Include(x => x.coaIdr).Include(x => x.coaUsd).ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Warehouse";

            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;

            ViewBag.Error = false;
            return View("Create", new mtWarehouse());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]mtWarehouse value)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                List<mtWarehouseDetails> details = new List<mtWarehouseDetails>();
                foreach (mtWarehouseDetails items in value.warehouseDetails)
                {
                    items.isActive = true;
                    items.createdBy = user;
                    items.createdOn = txDate;
                    items.updatedBy = user;
                    items.updatedOn = txDate;
                }

                value.createdBy = user;
                value.createdOn = txDate;
                value.updatedBy = user;
                value.updatedOn = txDate;

                value.coaIdIdr = (value.coaIdIdr == 0 ? null : value.coaIdIdr);
                value.coaIdUsd = (value.coaIdUsd == 0 ? null : value.coaIdUsd);

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

                mContext.mtWarehouse.Add(value);
                mContext.SaveChanges();

                return Ok(new { status = 200, message = "" });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtWarehouse.Find(id));
            mContext.RemoveRange(mContext.mtWarehouseDetails.Where(x => x.warehouseId == id).ToList());
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Warehouse";

            ICollection<mtWarehouseDetails> Details =
                mContext.mtWarehouseDetails.Where(x => x.isActive == true && x.warehouseId == id).ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                 mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;
            ViewBag.Details = Details;

            ViewBag.Error = false;
            return View("Edit", mContext.mtWarehouse.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit([FromBody]mtWarehouse value)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                value.coaIdIdr = (value.coaIdIdr == 0 ? null : value.coaIdIdr);
                value.coaIdUsd = (value.coaIdUsd == 0 ? null : value.coaIdUsd);

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
            mtWarehouse item = mContext.mtWarehouse.Find(id);
            item.isActive = !item.isActive;

            string user = "Admin";
            DateTime txDate = DateTime.Now;

            item.updatedBy = user;
            item.updatedOn = txDate;

            mContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            mContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("cancel/{id}")]
        public IActionResult cancel(int id)
        {
            try
            {
                mtWarehouse item = mContext.mtWarehouse.Find(id);
                ICollection<mtWarehouseDetails> items = mContext.mtWarehouseDetails.Where(x => x.isActive == true && x.warehouseId == item.id).ToList();

                mContext.Entry(item).Reload();

                foreach (mtWarehouseDetails value in items)
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
            try
            {
                mContext.Remove(mContext.mtWarehouseDetails.Find(id));
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
        public IActionResult addDetail([FromBody]mtWarehouseDetails value)
        {
            string user = "Admin";
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

                mContext.mtWarehouseDetails.Add(value);
                mContext.SaveChanges();

                int id = value.id;
                return Ok(new { status = 200, message = id.ToString() });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
        }
    }
}
