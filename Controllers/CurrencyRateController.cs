using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fms.Common;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("CurrencyRate")]
    public class CurrencyRateController : Controller
    {
        protected ApplicationDbContext mContext;

        public CurrencyRateController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ICollection<mtCurrencyRatePreview> mtCurrencyRate =
                mContext.mtCurrencyRate.Include(x => x.currencyFrom).Include(x => x.currencyTo)
                        .Select(x => new mtCurrencyRatePreview
                        {
                            id = x.id,
                            currencyIdFrom = (x.currencyFrom == null ? "" : x.currencyFrom.code + " - " + x.currencyFrom.description),
                            currencyIdTo = (x.currencyTo == null ? "" : x.currencyTo.code + " - " + x.currencyTo.description),
                            rate = x.rate.ToString(SystemFormat.decimalFormat),
                            validFrom = x.validFrom.ToString(SystemFormat.dateFormat),
                            validTo = x.validTo.ToString(SystemFormat.dateFormat),
                            isActive = x.isActive,
                            createdBy = x.createdBy,
                            createdOn = x.createdOn.ToString(SystemFormat.datetimeFormat),
                            updatedBy = x.updatedBy,
                            updatedOn = x.updatedOn.ToString(SystemFormat.datetimeFormat)
                        }).ToList();

            ViewBag.Items = mtCurrencyRate;
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewBag.Currency = mContext.mtCurrency.Where(x => x.isActive == true).ToList();
            ViewBag.Error = false;
            return View("Create", new mtCurrencyRate());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtCurrencyRate item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.mtCurrencyRate.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Currency = mContext.mtCurrency.Where(x => x.isActive == true).ToList();
            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtCurrencyRate.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewBag.Currency = mContext.mtCurrency.Where(x => x.isActive == true).ToList();
            ViewBag.Error = false;
            return View("Edit", mContext.mtCurrencyRate.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtCurrencyRate item)
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

            ViewBag.Currency = mContext.mtCurrency.Where(x => x.isActive == true).ToList();
            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtCurrencyRate item = mContext.mtCurrencyRate.Find(id);
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
