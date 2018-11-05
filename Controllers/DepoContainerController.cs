using System;
using System.Collections.Generic;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("DepoContainer")]
    public class DepoContainerController : Controller
    {
        protected ApplicationDbContext mContext;

        public DepoContainerController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewBag.Items = mContext.mtDepoContainer.ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewBag.Error = false;
            return View("Create", new mtDepoContainer());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]mtDepoContainer value)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                List<mtDepoContainerDetails> details = new List<mtDepoContainerDetails>();
                foreach (mtDepoContainerDetails items in value.depoContainerDetails)
                {
                    items.isActive = true;
                    items.createdBy = user;
                    items.createdOn = txDate;
                    items.updatedBy = user;
                    items.updatedOn = txDate;
                }

                value.createdBy = user;
                value.createdOn = txDate;
                value.updatedBy = user;
                value.updatedOn = txDate;

                mContext.mtDepoContainer.Add(value);
                mContext.SaveChanges();

                return Json("success");
            }

            ViewBag.Error = true;
            return Json("Error");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtDepoContainer.Find(id));
            mContext.RemoveRange(mContext.mtDepoContainerDetails.Where(x => x.depoContainerId == id).ToList());
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ICollection<mtDepoContainerDetails> Details = 
                mContext.mtDepoContainerDetails.Where(x => x.isActive == true && x.depoContainerId == id).ToList();
            ViewBag.Details = Details;

            ViewBag.Error = false;
            return View("Edit", mContext.mtDepoContainer.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtDepoContainer item)
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

            ICollection<mtDepoContainerDetails> Details = 
                mContext.mtDepoContainerDetails.Where(x => x.isActive == true && x.depoContainerId == item.id).ToList();
            ViewBag.Details = Details;

            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtDepoContainer item = mContext.mtDepoContainer.Find(id);
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
