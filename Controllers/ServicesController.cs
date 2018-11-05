using System;
using System.Collections.Generic;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("Services")]
    public class ServicesController : Controller
    {
        protected ApplicationDbContext mContext;
        public ServicesController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ICollection<mtServices> services = 
                mContext.mtServices
                        .Include(x => x.coaIdr)
                        .Include(x => x.coaUsd)
                        .Include(x => x.groups).ToList();
            ViewBag.Items = services;
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ICollection<mtChartOfAccount> CoaIdr = 
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "IDR").ToList();

            ICollection<mtChartOfAccount> CoaUsd =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ICollection<mtGroups> Groups =
                mContext.mtGroups
                    .Where(x => x.isActive == true).ToList();

            ViewBag.CoaIdr = CoaIdr;
            ViewBag.coausd = CoaUsd;
            ViewBag.Groups = Groups;

            ViewBag.Error = false;
            return View("Create", new mtServices());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtServices item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                item.coaIdIdr = (item.coaIdIdr == 0 ? null : item.coaIdIdr);
                item.coaIdUsd = (item.coaIdUsd == 0 ? null : item.coaIdUsd);
                item.groupId = (item.groupId == 0 ? null : item.groupId);

                mContext.mtServices.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ICollection<mtChartOfAccount> CoaIdr =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "IDR").ToList();

            ICollection<mtChartOfAccount> CoaUsd =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ICollection<mtGroups> Groups =
                mContext.mtGroups
                    .Where(x => x.isActive == true).ToList();

            ViewBag.CoaIdr = CoaIdr;
            ViewBag.coausd = CoaUsd;
            ViewBag.Groups = Groups;

            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtServices.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ICollection<mtChartOfAccount> CoaIdr =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "IDR").ToList();

            ICollection<mtChartOfAccount> CoaUsd =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ICollection<mtGroups> Groups =
                mContext.mtGroups
                    .Where(x => x.isActive == true).ToList();

            ViewBag.CoaIdr = CoaIdr;
            ViewBag.CoaUsd = CoaUsd;
            ViewBag.Groups = Groups;

            ViewBag.Error = false;
            return View("Edit", mContext.mtServices.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtServices item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.updatedBy = user;
                item.updatedOn = txDate;

                item.coaIdIdr = (item.coaIdIdr == 0 ? null : item.coaIdIdr);
                item.coaIdUsd = (item.coaIdUsd == 0 ? null : item.coaIdUsd);
                item.groupId = (item.groupId == 0 ? null : item.groupId);

                mContext.Entry(item).State = EntityState.Modified;
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ICollection<mtChartOfAccount> CoaIdr =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "IDR").ToList();

            ICollection<mtChartOfAccount> CoaUsd =
                mContext.mtChartOfAccount
                    .Include(a => a.currency)
                    .Where(x => x.isActive == true && x.currency.code == "USD").ToList();

            ICollection<mtGroups> Groups =
                mContext.mtGroups
                    .Where(x => x.isActive == true).ToList();

            ViewBag.CoaIdr = CoaIdr;
            ViewBag.coausd = CoaUsd;
            ViewBag.Groups = Groups;

            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtServices item = mContext.mtServices.Find(id);
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
