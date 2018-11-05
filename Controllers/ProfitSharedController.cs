using System;
using System.Collections.Generic;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("ProfitShared")]
    public class ProfitSharedController : Controller
    {
        protected ApplicationDbContext mContext;

        public ProfitSharedController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewBag.Items = mContext.mtProfitShared.Include(x => x.country).Include(x => x.agents).ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ICollection<mtCountry> Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ICollection<mtAgent> Agents = mContext.mtAgent.Where(x => x.isActive == true).ToList();
            ViewBag.Countries = Countries;
            ViewBag.Agents = Agents;

            ViewBag.Error = false;
            return View("Create", new mtProfitShared());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]mtProfitShared value)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                List<mtProfitSharedDetails> details = new List<mtProfitSharedDetails>();
                foreach (mtProfitSharedDetails items in value.profitSharedDetails)
                {
                    items.containerId = null;
                    items.isActive = true;
                    items.createdBy = user;
                    items.createdOn = txDate;
                    items.updatedBy = user;
                    items.updatedOn = txDate;
                }

                value.agentId = (value.agentId == 0 ? null : value.agentId);
                value.countryId = (value.countryId == 0 ? null : value.countryId);

                value.createdBy = user;
                value.createdOn = txDate;
                value.updatedBy = user;
                value.updatedOn = txDate;

                mContext.mtProfitShared.Add(value);
                mContext.SaveChanges();

                return Json("success");
            }

            ICollection<mtCountry> Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ICollection<mtAgent> Agents = mContext.mtAgent.Where(x => x.isActive == true).ToList();
            ViewBag.Countries = Countries;
            ViewBag.Agents = Agents;

            ViewBag.Error = true;
            return Json("Error");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtProfitShared.Find(id));
            mContext.RemoveRange(mContext.mtProfitSharedDetails.Where(x => x.profitSharedId == id).ToList());
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ICollection<mtProfitSharedDetails> Details =
                mContext.mtProfitSharedDetails.Where(x => x.isActive == true && x.profitSharedId == id).ToList();
            ICollection<mtCountry> Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ICollection<mtAgent> Agents = mContext.mtAgent.Where(x => x.isActive == true).ToList();

            ViewBag.Countries = Countries;
            ViewBag.Agents = Agents;
            ViewBag.Details = Details;

            ViewBag.Error = false;
            return View("Edit", mContext.mtProfitShared.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtProfitShared item)
        {
            if (ModelState.IsValid)
            {
                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.agentId = (item.agentId == 0 ? null : item.agentId);
                item.countryId = (item.countryId == 0 ? null : item.countryId);

                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.Entry(item).State = EntityState.Modified;
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ICollection<mtProfitSharedDetails> Details =
                mContext.mtProfitSharedDetails.Where(x => x.isActive == true && x.profitSharedId == item.id).ToList();
            ICollection<mtCountry> Countries = mContext.mtCountry.Where(x => x.isActive == true).ToList();
            ICollection<mtAgent> Agents = mContext.mtAgent.Where(x => x.isActive == true).ToList();

            ViewBag.Countries = Countries;
            ViewBag.Agents = Agents;
            ViewBag.Details = Details;

            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtProfitShared item = mContext.mtProfitShared.Find(id);
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
