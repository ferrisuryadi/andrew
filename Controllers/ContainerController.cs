using System;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Mvc;

namespace fms.Controllers
{
    [Route("Container")]
    public class ContainerController : Controller
    {
        protected ApplicationDbContext mContext;

        public ContainerController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Container";

            ViewBag.Items = mContext.mtContainer.ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Container";

            ViewBag.Error = false;
            return View("Create", new mtContainer());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtContainer item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.mtContainer.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Container";
            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtContainer.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Container";

            ViewBag.Error = false;
            return View("Edit", mContext.mtContainer.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtContainer item)
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
            mtContainer container = mContext.mtContainer.Find(id);
            container.isActive = !container.isActive;

            string user = "Admin";
            DateTime txDate = DateTime.Now;

            container.updatedBy = user;
            container.updatedOn = txDate;

            mContext.Entry(container).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            mContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
