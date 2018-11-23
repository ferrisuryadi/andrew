using System;
using System.Collections.Generic;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("PortOfDestination")]
    public class PortOfDestinationController : Controller
    {
        protected ApplicationDbContext mContext;

        public PortOfDestinationController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "PortOfDestination";

            IList<mtPortOfDestination> portOfDestinations = mContext.mtPortOfDestination.Include(x => x.country).Include(x => x.countryTransit).ToList();
            ViewBag.Items = portOfDestinations;
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "PortOfDestination";

            ViewBag.Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ViewBag.Error = false;
            return View("Create", new mtPortOfDestination());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtPortOfDestination item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.mtPortOfDestination.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "PortOfDestination";
            ViewBag.Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtPortOfDestination.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "PortOfDestination";

            ViewBag.Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ViewBag.Error = false;
            return View("Edit", mContext.mtPortOfDestination.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtPortOfDestination item)
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
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "PortOfDestination";
            ViewBag.Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtPortOfDestination item = mContext.mtPortOfDestination.Find(id);
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
