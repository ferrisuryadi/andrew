using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("AgentShared")]
    public class AgentProfitSharedController : Controller
    {
        protected ApplicationDbContext mContext;

        public AgentProfitSharedController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewBag.Items = mContext.mtAgentProfitShared.Include(x => x.shipper).Include(x => x.agent).Include(x => x.container).ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewBag.Container = mContext.mtContainer.Where(x => x.isActive == true).ToList();
            ViewBag.Agent = mContext.mtAgent.Where(x => x.isActive == true).ToList();
            ViewBag.Shipper = mContext.mtShipper.Where(x => x.isActive == true).ToList();
            ViewBag.Error = false;
            return View("Create", new mtAgentProfitShared());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtAgentProfitShared item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.mtAgentProfitShared.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Container = mContext.mtContainer.Where(x => x.isActive == true).ToList();
            ViewBag.Agent = mContext.mtAgent.Where(x => x.isActive == true).ToList();
            ViewBag.Shipper = mContext.mtShipper.Where(x => x.isActive == true).ToList();

            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtAgentProfitShared.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewBag.Container = mContext.mtContainer.Where(x => x.isActive == true).ToList();
            ViewBag.Agent = mContext.mtAgent.Where(x => x.isActive == true).ToList();
            ViewBag.Shipper = mContext.mtShipper.Where(x => x.isActive == true).ToList();

            ViewBag.Error = false;
            return View("Edit", mContext.mtAgentProfitShared.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtAgentProfitShared item)
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

            ViewBag.Container = mContext.mtContainer.Where(x => x.isActive == true).ToList();
            ViewBag.Agent = mContext.mtAgent.Where(x => x.isActive == true).ToList();
            ViewBag.Shipper = mContext.mtShipper.Where(x => x.isActive == true).ToList();

            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtAgentProfitShared item = mContext.mtAgentProfitShared.Find(id);
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
