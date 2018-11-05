using System;
using System.Collections.Generic;
using System.Linq;
using fms.Models;
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
            ViewBag.Items = mContext.mtVendor.Include(x => x.coaIdr).Include(x => x.coaUsd).Include(x => x.type).ToList();
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
            string user = "Admin";
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

                mContext.mtVendor.Add(value);
                mContext.SaveChanges();

                return Json("success");
            }

            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();
            ICollection<mtType> Type = mContext.mtType.Where(x => x.isActive == true && x.category == 2).ToList();

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
            mContext.Remove(mContext.mtVendor.Find(id));
            mContext.RemoveRange(mContext.mtVendorDetails.Where(x => x.vendorId == id).ToList());
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
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
        public IActionResult Edit(mtVendor item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.coaIdIdr = (item.coaIdIdr == 0 ? null : item.coaIdIdr);
                item.coaIdUsd = (item.coaIdUsd == 0 ? null : item.coaIdUsd);
                item.typeId = (item.typeId == 0 ? null : item.typeId);

                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ICollection<mtVendorDetails> Details =
                mContext.mtVendorDetails.Where(x => x.isActive == true && x.vendorId == item.id).ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();
            ICollection<mtType> Type = mContext.mtType.Where(x => x.isActive == true && x.category == 2).ToList();

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
            mtVendor item = mContext.mtVendor.Find(id);
            item.isActive = !item.isActive;

            string user = "Admin";
            DateTime txDate = DateTime.Now;

            item.updatedBy = user;
            item.updatedOn = txDate;

            mContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            mContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
