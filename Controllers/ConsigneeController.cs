using System;
using System.Collections.Generic;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("Consignee")]
    public class ConsigneeController : Controller
    {
        protected ApplicationDbContext mContext;

        public ConsigneeController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            IList<mtConsignee> consignee = mContext.mtConsignee.Include(x => x.country).ToList();
            ViewBag.Items = consignee;
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewBag.Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ViewBag.Error = false;
            return View("Create", new mtConsignee());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtConsignee item)
        {
            if (ModelState.IsValid)
            {
                item.countryId = (item.countryId == 0 ? null : item.countryId);

                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.mtConsignee.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtConsignee.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewBag.Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ViewBag.Error = false;
            return View("Edit", mContext.mtConsignee.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtConsignee item)
        {
            if (ModelState.IsValid)
            {
                item.countryId = (item.countryId == 0 ? null : item.countryId);

                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.Entry(item).State = EntityState.Modified;
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtConsignee item = mContext.mtConsignee.Find(id);
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
