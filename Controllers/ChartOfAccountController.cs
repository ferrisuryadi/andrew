using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("ChartOfAccount")]
    public class ChartOfAccountController : Controller
    {
        protected ApplicationDbContext mContext;

        public ChartOfAccountController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            IList<mtChartOfAccount> chartOfAccounts = 
                mContext.mtChartOfAccount.Include(x => x.currency).Include(x => x.chartOfAccount).ToList();
            ViewBag.Items = chartOfAccounts;
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewBag.Currency = mContext.mtCurrency.Where(x => x.isActive == true).ToList();
            ViewBag.ChartOfAccount = mContext.mtChartOfAccount.Where(x => x.isActive == true).ToList();
            ViewBag.Error = false;
            return View("Create", new mtChartOfAccount());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtChartOfAccount item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                item.parentId = (item.parentId == 0 ? null : item.parentId);

                mContext.mtChartOfAccount.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Currency = mContext.mtCurrency.Where(x => x.isActive == true).ToList();
            ViewBag.ChartOfAccount = mContext.mtChartOfAccount.Where(x => x.isActive == true).ToList();
            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtChartOfAccount.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewBag.Currency = mContext.mtCurrency.Where(x => x.isActive == true).ToList();
            ViewBag.ChartOfAccount = mContext.mtChartOfAccount.Where(x => x.isActive == true).ToList();

            ViewBag.Error = false;
            return View("Edit", mContext.mtChartOfAccount.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtChartOfAccount item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.updatedBy = user;
                item.updatedOn = txDate;

                item.parentId = (item.parentId == 0 ? null : item.parentId);

                mContext.Entry(item).State = EntityState.Modified;
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Currency = mContext.mtCurrency.Where(x => x.isActive == true).ToList();
            ViewBag.ChartOfAccount = mContext.mtChartOfAccount.Where(x => x.isActive == true).ToList();
            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtChartOfAccount item = mContext.mtChartOfAccount.Find(id);
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
