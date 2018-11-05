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
        public IActionResult Add([FromBody]mtAgent value)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (value != null){
                List<mtAgentDetails> details = new List<mtAgentDetails>();
                foreach(mtAgentDetails items in value.agentDetails)
                {
                    items.isActive = true;
                    items.createdBy = user;
                    items.createdOn = txDate;
                    items.updatedBy = user;
                    items.updatedOn = txDate;
                }

                value.portOfDestinationId = (value.portOfDestinationId == 0 ? null : value.portOfDestinationId);
                value.shipperId = (value.shipperId == 0 ? null : value.shipperId);
                value.typeId = (value.typeId == 0 ? null : value.typeId);

                value.createdBy = user;
                value.createdOn = txDate;
                value.updatedBy = user;
                value.updatedOn = txDate;

                mContext.mtAgent.Add(value);
                mContext.SaveChanges();

                return Json("success");
            }

            ICollection<mtPortOfDestination> PortOfDestination = mContext.mtPortOfDestination.Where(x => x.isActive == true).ToList();
            ICollection<mtShipper> Shipper = mContext.mtShipper.Where(x => x.isActive == true).ToList();
            ICollection<mtType> Type = mContext.mtType.Where(x => x.isActive == true && x.category == 3).ToList();

            ViewBag.PortOfDestination = PortOfDestination;
            ViewBag.Shipper = Shipper;
            ViewBag.Type = Type;

            ViewBag.Error = true;
            return Json("Error");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtAgent.Find(id));
            mContext.RemoveRange(mContext.mtAgentDetails.Where(x => x.agentId == id).ToList());
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ICollection<mtPortOfDestination> PortOfDestination = mContext.mtPortOfDestination.Where(x => x.isActive == true).ToList();
            ICollection<mtShipper> Shipper = mContext.mtShipper.Where(x => x.isActive == true).ToList();
            ICollection<mtType> Type = mContext.mtType.Where(x => x.isActive == true && x.category == 3).ToList();
            ICollection<mtAgentDetails> AgentDetails = mContext.mtAgentDetails.Where(x => x.isActive == true && x.agentId == id).ToList();

            ViewBag.PortOfDestination = PortOfDestination;
            ViewBag.Shipper = Shipper;
            ViewBag.Type = Type;
            ViewBag.AgentDetails = AgentDetails;

            ViewBag.Error = false;
            return View("Edit", mContext.mtAgent.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtAgent item)
        {
            if (ModelState.IsValid)
            {
                item.portOfDestinationId = (item.portOfDestinationId == 0 ? null : item.portOfDestinationId);
                item.shipperId = (item.shipperId == 0 ? null : item.shipperId);
                item.typeId = (item.typeId == 0 ? null : item.typeId);

                string user = "Admin";
                DateTime txDate = DateTime.Now;

                item.updatedBy = user;
                item.updatedOn = txDate;

                mContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ICollection<mtPortOfDestination> PortOfDestination = mContext.mtPortOfDestination.Where(x => x.isActive == true).ToList();
            ICollection<mtShipper> Shipper = mContext.mtShipper.Where(x => x.isActive == true).ToList();
            ICollection<mtType> Type = mContext.mtType.Where(x => x.isActive == true && x.category == 3).ToList();
            ICollection<mtAgentDetails> AgentDetails = mContext.mtAgentDetails.Where(x => x.isActive == true && x.agentId == item.id).ToList();

            ViewBag.PortOfDestination = PortOfDestination;
            ViewBag.Shipper = Shipper;
            ViewBag.Type = Type;
            ViewBag.AgentDetails = AgentDetails;

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
