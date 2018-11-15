using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("Shipper")]
    public class ShipperController : Controller
    {
        protected ApplicationDbContext mContext;

        public ShipperController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Shipper";

            ViewBag.Items = mContext.mtShipper.Include(x => x.coaIdr).Include(x => x.coaUsd).Include(x => x.employee).ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Shipper";

            ICollection<mtEmployee> employee = mContext.mtEmployee.Where(x => x.isActive == true).ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;
            ViewBag.employee = employee;

            ViewBag.Error = false;
            return View("Create", new mtShipper());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]mtShipper value)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                List<mtShipperDetails> details = new List<mtShipperDetails>();
                foreach (mtShipperDetails items in value.shipperDetails)
                {
                    items.isActive = true;
                    items.createdBy = user;
                    items.createdOn = txDate;
                    items.updatedBy = user;
                    items.updatedOn = txDate;
                }

                value.coaIdIdr = (value.coaIdIdr == 0 ? null : value.coaIdIdr);
                value.coaIdUsd = (value.coaIdUsd == 0 ? null : value.coaIdUsd);
                value.employeeId = (value.employeeId == 0 ? null : value.employeeId);

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

                mContext.mtShipper.Add(value);
                mContext.SaveChanges();

                return Ok(new { status = 200, message = "" });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtShipper.Find(id));
            mContext.RemoveRange(mContext.mtShipperDetails.Where(x => x.shipperId == id).ToList());
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Shipper";

            ICollection<mtEmployee> Employee = mContext.mtEmployee.Where(x => x.isActive == true).ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;
            ViewBag.Employee = Employee;

            ICollection<mtShipperDetails> Details =
                mContext.mtShipperDetails.Where(x => x.isActive == true && x.shipperId == id).ToList();
            ViewBag.Details = Details;

            ViewBag.Error = false;
            return View("Edit", mContext.mtShipper.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit([FromBody]mtShipper value)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                value.coaIdIdr = (value.coaIdIdr == 0 ? null : value.coaIdIdr);
                value.coaIdUsd = (value.coaIdUsd == 0 ? null : value.coaIdUsd);
                value.employeeId = (value.employeeId == 0 ? null : value.employeeId);

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
            mtShipper item = mContext.mtShipper.Find(id);
            item.isActive = !item.isActive;

            string user = "Admin";
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
            try
            {
                mtShipper item = mContext.mtShipper.Find(id);
                ICollection<mtShipperDetails> items = mContext.mtShipperDetails.Where(x => x.isActive == true && x.shipperId == item.id).ToList();

                mContext.Entry(item).Reload();

                foreach (mtShipperDetails value in items)
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
                mContext.Remove(mContext.mtShipperDetails.Find(id));
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
        public IActionResult addDetail([FromBody]mtShipperDetails value)
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

                mContext.mtShipperDetails.Add(value);
                mContext.SaveChanges();

                int id = value.id;
                return Ok(new { status = 200, message = id.ToString() });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
        }
    }
}
