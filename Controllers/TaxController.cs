using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using fms.Common;
using System.Globalization;

namespace fms.Controllers
{
    [Route("Tax")]
    public class TaxController : Controller
    {
        protected ApplicationDbContext mContext;

        public TaxController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Tax";

            ICollection<mtTaxPreview> mtTax =
                mContext.mtTax.Select(x => new mtTaxPreview { 
                    id = x.id,
                    code = x.code, 
                    amount = x.amount.ToString(SystemFormat.decimalFormat),
                    isActive = x.isActive,
                    createdBy = x.createdBy,
                    createdOn = x.createdOn.ToString(SystemFormat.datetimeFormat),
                    updatedBy = x.updatedBy,
                    updatedOn = x.updatedOn.ToString(SystemFormat.datetimeFormat)
                }).ToList();

            ViewBag.Items = mtTax;
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Tax";

            ViewBag.Error = false;
            return View("Create", new mtTax());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtTax item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.mtTax.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtTax.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Tax";

            ViewBag.Error = false;
            return View("Edit", mContext.mtTax.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtTax item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.Entry(item).State = EntityState.Modified;
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtTax item = mContext.mtTax.Find(id);
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
