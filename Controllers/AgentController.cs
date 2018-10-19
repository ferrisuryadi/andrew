using System;
using System.Collections.Generic;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("Agent")]
    public class AgentController : Controller
    {
        protected ApplicationDbContext mContext;

        public AgentController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewBag.Items = mContext.mtAgent.Include(x => x.portOfDestination).Include(x => x.shipper).Include(x => x.type).ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ICollection<mtPortOfDestination> PortOfDestination = mContext.mtPortOfDestination.Where(x => x.isActive == true).ToList();
            ICollection<mtShipper> Shipper = mContext.mtShipper.Where(x => x.isActive == true).ToList();
            ICollection<mtType> Type = mContext.mtType.Where(x => x.isActive == true && x.category == 3).ToList();

            ViewBag.PortOfDestination = PortOfDestination;
            ViewBag.Shipper = Shipper;
            ViewBag.Type = Type;

            ViewBag.Error = false;
            return View("Create", new mtAgent());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtAgent item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.mtAgent.Add(item);
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
            mContext.Remove(mContext.mtAgent.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewBag.Error = false;
            return View("Edit", mContext.mtAgent.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtAgent item)
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

            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtAgent item = mContext.mtAgent.Find(id);
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
