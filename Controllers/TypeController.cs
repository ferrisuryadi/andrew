using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using fms.Models;
using Microsoft.AspNetCore.Mvc;

namespace fms.Controllers
{
    [Route("Type")]
    public class TypeController : Controller
    {
        protected ApplicationDbContext mContext;

        public TypeController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Type";

            ViewBag.Items = mContext.mtType.ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Type";

            ViewBag.Error = false;
            return View("Create", new mtType());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtType item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.mtType.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Type";
            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtType.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Type";

            ViewBag.Error = false;
            return View("Edit", mContext.mtType.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtType item)
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
            ViewData["SubMenuLvl1"] = "Type";
            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtType item = mContext.mtType.Find(id);
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
