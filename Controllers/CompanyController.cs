using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using fms.Common;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("Company")]
    public class CompanyController : Controller
    {
        protected ApplicationDbContext mContext;

        public CompanyController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ICollection<mtCompanyPreview> mtCompany =
                mContext.mtCompany.Include(x => x.coaIdr).Include(x => x.coaUsd).Include(x => x.type)
                        .Select(x => new mtCompanyPreview
                        {
                            id = x.id,
                            company = x.company,
                            name = x.name,
                            address = x.address,
                            email = x.email,
                            website = x.website,
                            telepon = x.telepon,
                            fax = x.fax,
                            taxNo = x.taxNo,
                            typeId = (x.type == null ? "" : x.type.code + " - " + x.type.description),
                            coaIdUsd = (x.coaUsd == null ? "" : x.coaUsd.code + " - " + x.coaUsd.description),
                            coaIdIdr = (x.coaIdr == null ? "" : x.coaIdr.code + " - " + x.coaIdr.description),
                            remark = x.remark,
                            isActive = x.isActive,
                            createdBy = x.createdBy,
                            createdOn = x.createdOn.ToString(SystemFormat.datetimeFormat),
                            updatedBy = x.updatedBy,
                            updatedOn = x.updatedOn.ToString(SystemFormat.datetimeFormat)
                        }).ToList();

            ViewBag.Items = mtCompany;
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ICollection<mtChartOfAccount> ChartOfAccountsIdr = 
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();
            ICollection<mtType> Type = mContext.mtType.Where(x => x.isActive == true && x.category == 1).ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;
            ViewBag.Type = Type;

            ViewBag.Error = false;
            return View("Create", new mtCompany());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]mtCompany value)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                List<mtCompanyDetails> details = new List<mtCompanyDetails>();
                foreach (mtCompanyDetails items in value.companyDetails)
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

                value.telepon = value.telepon.Replace("_", "");
                value.taxNo = value.taxNo.Replace("_", "");

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

                mContext.mtCompany.Add(value);
                mContext.SaveChanges();

                return Ok(new { status = 200, message = "" });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtCompany.Find(id));
            mContext.RemoveRange(mContext.mtCompanyDetails.Where(x => x.companyId == id).ToList());
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();
            ICollection<mtType> Type = mContext.mtType.Where(x => x.isActive == true && x.category == 1).ToList();
            ICollection<mtCompanyDetails> Details = mContext.mtCompanyDetails.Where(x => x.isActive == true && x.companyId == id).ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;
            ViewBag.Type = Type;
            ViewBag.Details = Details;

            ViewBag.Error = false;
            return View("Edit", mContext.mtCompany.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit([FromBody]mtCompany value)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                value.coaIdIdr = (value.coaIdIdr == 0 ? null : value.coaIdIdr);
                value.coaIdUsd = (value.coaIdUsd == 0 ? null : value.coaIdUsd);
                value.typeId = (value.typeId == 0 ? null : value.typeId);

                value.telepon = value.telepon.Replace("_", "");
                value.taxNo = value.taxNo.Replace("_", "");

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
            mtCompany item = mContext.mtCompany.Find(id);
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
                mtCompany item = mContext.mtCompany.Find(id);
                ICollection<mtCompanyDetails> items = mContext.mtCompanyDetails.Where(x => x.isActive == true && x.companyId == item.id).ToList();

                mContext.Entry(item).Reload();

                foreach (mtCompanyDetails value in items)
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
                mContext.Remove(mContext.mtCompanyDetails.Find(id));
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
        public IActionResult addDetail([FromBody]mtCompanyDetails value)
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

                mContext.mtCompanyDetails.Add(value);
                mContext.SaveChanges();

                int id = value.id;
                return Ok(new { status = 200, message = id.ToString() });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
        }
    }
}
