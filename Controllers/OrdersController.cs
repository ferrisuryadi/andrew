using System;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Mvc;

namespace fms.Controllers
{
    [Route("Orders")]
    public class OrdersController : Controller
    {
        protected ApplicationDbContext mContext;

        public OrdersController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Orders";

            ViewBag.Items = mContext.mtOrders.ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Orders";

            ViewBag.Error = false;
            return View("Create", new mtOrders());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtOrders item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.mtOrders.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Orders";
            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtOrders.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Orders";

            ViewBag.Error = false;
            return View("Edit", mContext.mtOrders.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtOrders item)
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
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Orders";
            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtOrders item = mContext.mtOrders.Find(id);
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
