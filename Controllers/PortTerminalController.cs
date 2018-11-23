using System;
using System.Collections.Generic;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("PortTerminal")]
    public class PortTerminalController : Controller
    {
        protected ApplicationDbContext mContext;

        public PortTerminalController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "PortTerminal";

            IList<mtPortTerminal> PortTerminals = mContext.mtPortTerminal.Include(x => x.portOfLoading).ToList();
            ViewBag.Items = PortTerminals;
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "PortTerminal";

            ViewBag.PortOfLoading = mContext.mtPortOfLoading.Where(x => x.isActive == true).ToList();
            ViewBag.Error = false;
            return View("Create", new mtPortTerminal());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtPortTerminal item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.mtPortTerminal.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "PortTerminal";
            ViewBag.PortOfLoading = mContext.mtPortOfLoading.Where(x => x.isActive == true).ToList();
            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtPortTerminal.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "PortTerminal";

            ViewBag.PortOfLoading = mContext.mtPortOfLoading.Where(x => x.isActive == true).ToList();
            ViewBag.Error = false;
            return View("Edit", mContext.mtPortTerminal.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtPortTerminal item)
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
            ViewData["SubMenuLvl1"] = "PortTerminal";
            ViewBag.PortOfLoading = mContext.mtPortOfLoading.Where(x => x.isActive == true).ToList();
            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtPortTerminal item = mContext.mtPortTerminal.Find(id);
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
