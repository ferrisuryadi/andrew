using System;
using System.Linq;
using fms.Common;
using fms.Models;
using Microsoft.AspNetCore.Mvc;

namespace fms.Controllers
{
    [Route("Bank")]
    public class BankController : Controller
    {
        protected ApplicationDbContext mContext;

        public BankController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Bank";

            ViewBag.Items = mContext.mtBank.ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Bank";

            ViewBag.Error = false;
            return View("Create", new mtBank());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtBank item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.mtBank.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Bank";
            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtBank.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Bank";

            ViewBag.Error = false;
            return View("Edit", mContext.mtBank.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtBank item)
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
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Bank";
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtBank item = mContext.mtBank.Find(id);
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
