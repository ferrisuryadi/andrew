using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Agent";

            ViewBag.Items = mContext.mtAgent.Include(x => x.portOfDestination).Include(x => x.shipper).Include(x => x.type).ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Agent";

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

                var context = new ValidationContext(value, serviceProvider: null, items: null);
                var results = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(value, context, results, true);

                List<string> errorMessage = new List<string>();

                if (!isValid)
                {
                    foreach (ValidationResult validationResult in results)
                        errorMessage.Add(validationResult.ErrorMessage);

                    return Ok(new { status = 400, message = errorMessage });
                }

                mContext.mtAgent.Add(value);
                mContext.SaveChanges();

                return Ok(new { status = 200, message = "" });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
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
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Agent";

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
        public IActionResult Edit([FromBody]mtAgent value)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                value.portOfDestinationId = (value.portOfDestinationId == 0 ? null : value.portOfDestinationId);
                value.shipperId = (value.shipperId == 0 ? null : value.shipperId);
                value.typeId = (value.typeId == 0 ? null : value.typeId);

                value.updatedBy = user;
                value.updatedOn = txDate;

                var context = new ValidationContext(value, serviceProvider: null, items: null);
                var results = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(value, context, results, true);

                List<string> errorMessage = new List<string>();

                if (!isValid)
                {
                    foreach (ValidationResult validationResult in results)
                        errorMessage.Add(validationResult.ErrorMessage);

                    return Ok(new { status = 400, message = errorMessage });
                }
                mContext.Entry(value).State = EntityState.Modified;
                mContext.SaveChanges();

                return Ok(new { status = 200, message = "" });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
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

            mContext.Entry(item).State = EntityState.Modified;
            mContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("cancel/{id}")]
        public IActionResult cancel(int id)
        {
            try
            {
                mtAgent item = mContext.mtAgent.Find(id);
                ICollection<mtAgentDetails> items = mContext.mtAgentDetails.Where(x => x.isActive == true && x.agentId == item.id).ToList();

                mContext.Entry(item).Reload();

                foreach (mtAgentDetails value in items)
                {
                    mContext.Entry(value).Reload();
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = 409, message = e.Message });
            }

            return Ok(new { status = 200, message = "" });
        }

        [HttpPost]
        [Route("deleteDetail/{id}")]
        public IActionResult deleteDetail(int id)
        {
            try
            {
                mContext.Remove(mContext.mtAgentDetails.Find(id));
                mContext.SaveChanges();
            }
            catch (Exception e)
            {
                return Ok(new { status = 409, message = e.Message });
            }

            return Ok(new { status = 200, message = "" });
        }

        [HttpPost]
        [Route("addDetail")]
        public IActionResult addDetail([FromBody]mtAgentDetails value)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                value.isActive = true;
                value.createdBy = user;
                value.createdOn = txDate;
                value.updatedBy = user;
                value.updatedOn = txDate;

                var context = new ValidationContext(value, serviceProvider: null, items: null);
                var results = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(value, context, results, true);

                List<string> errorMessage = new List<string>();

                if (!isValid)
                {
                    foreach (ValidationResult validationResult in results)
                        errorMessage.Add(validationResult.ErrorMessage);

                    return Ok(new { status = 400, message = errorMessage });
                }

                mContext.mtAgentDetails.Add(value);
                mContext.SaveChanges();

                int id = value.id;
                return Ok(new { status = 200, message = id.ToString() });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
        }
    }
}
