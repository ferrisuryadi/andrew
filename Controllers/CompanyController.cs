using System;
using System.Collections.Generic;
using System.Linq;
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
            ViewBag.Items = mContext.mtCompany.Include(x => x.coaIdr).Include(x => x.coaUsd).Include(x => x.type).ToList();
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
        public IActionResult Add([FromBody]mtCompany company)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (company != null)
            {
                List<mtCompanyDetails> details = new List<mtCompanyDetails>();
                foreach (mtCompanyDetails items in company.companyDetails)
                {
                    items.isActive = true;
                    items.createdBy = user;
                    items.createdOn = txDate;
                    items.updatedBy = user;
                    items.updatedOn = txDate;
                }

                company.coaIdIdr = (company.coaIdIdr == 0 ? null : company.coaIdIdr);
                company.coaIdUsd = (company.coaIdUsd == 0 ? null : company.coaIdUsd);
                company.typeId = (company.typeId == 0 ? null : company.typeId);

                company.createdBy = user;
                company.createdOn = txDate;
                company.updatedBy = user;
                company.updatedOn = txDate;

                mContext.mtCompany.Add(company);
                mContext.SaveChanges();

                return Json("success");
            }

            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();
            ICollection<mtType> Type = mContext.mtType.Where(x => x.isActive == true && x.category == 1).ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;
            ViewBag.Type = Type;

            ViewBag.Error = true;
            return Json("Error");
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
        public IActionResult Edit(mtCompany item)
        {
            if (ModelState.IsValid)
            {
                item.coaIdIdr = (item.coaIdIdr == 0 ? null : item.coaIdIdr);
                item.coaIdUsd = (item.coaIdUsd == 0 ? null : item.coaIdUsd);
                item.typeId = (item.typeId == 0 ? null : item.typeId);

                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.Entry(item).State = EntityState.Modified;
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();
            ICollection<mtType> Type = mContext.mtType.Where(x => x.isActive == true && x.category == 1).ToList();
            ICollection<mtCompanyDetails> Details = mContext.mtCompanyDetails.Where(x => x.isActive == true && x.companyId == item.id).ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;
            ViewBag.Type = Type;
            ViewBag.Details = Details;

            ViewBag.Error = true;
            return View("edit");
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
    }
}
