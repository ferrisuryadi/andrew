using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using fms.Models;
using Microsoft.AspNetCore.Mvc;

namespace fms.Controllers
{
    [Route("Groups")]
    public class GroupsController : Controller
    {
        protected ApplicationDbContext mContext;

        public GroupsController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Groups";

            ViewBag.Items = mContext.mtGroups.ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Groups";

            ViewBag.Error = false;
            return View("Create", new mtGroups());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtGroups item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.mtGroups.Add(item);
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
            mContext.Remove(mContext.mtGroups.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Groups";

            ViewBag.Error = false;
            return View("Edit", mContext.mtGroups.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtGroups item)
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

            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtGroups item = mContext.mtGroups.Find(id);
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
