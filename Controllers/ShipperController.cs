using System;
using System.Collections.Generic;
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
            ViewBag.Items = mContext.mtShipper.Include(x => x.coaIdr).Include(x => x.coaUsd).Include(x => x.user).ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ICollection<mtUser> Users = mContext.mtUser.Where(x => x.isActive == true).ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;
            ViewBag.Users = Users;

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
                foreach (mtShipperDetails items in value.mtShipperDetails)
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

                mContext.mtShipper.Add(value);
                mContext.SaveChanges();

                return Json("success");
            }

            ICollection<mtUser> Users = mContext.mtUser.Where(x => x.isActive == true).ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;
            ViewBag.Users = Users;

            ViewBag.Error = true;
            return Json("Error");
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
            ICollection<mtUser> Users = mContext.mtUser.Where(x => x.isActive == true).ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;
            ViewBag.Users = Users;

            ICollection<mtShipperDetails> Details =
                mContext.mtShipperDetails.Where(x => x.isActive == true && x.shipperId == id).ToList();
            ViewBag.Details = Details;

            ViewBag.Error = false;
            return View("Edit", mContext.mtShipper.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtShipper item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ICollection<mtUser> Users = mContext.mtUser.Where(x => x.isActive == true).ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsIdr =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "IDR").ToList();
            ICollection<mtChartOfAccount> ChartOfAccountsUsd =
                mContext.mtChartOfAccount.Include(x => x.currency).Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ViewBag.ChartOfAccountsIdr = ChartOfAccountsIdr;
            ViewBag.ChartOfAccountsUsd = ChartOfAccountsUsd;
            ViewBag.Users = Users;

            ICollection<mtShipperDetails> Details =
                mContext.mtShipperDetails.Where(x => x.isActive == true && x.shipperId == item.id).ToList();
            ViewBag.Details = Details;

            ViewBag.Error = true;
            return View("edit");
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

            mContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            mContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
