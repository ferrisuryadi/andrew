using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "DepoContainer";

            ViewBag.Items = mContext.mtDepoContainer.ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "DepoContainer";

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

                mContext.mtDepoContainer.Add(value);
                mContext.SaveChanges();

                return Ok(new { status = 200, message = "" });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
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
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "DepoContainer";

            ICollection<mtDepoContainerDetails> Details = 
                mContext.mtDepoContainerDetails.Where(x => x.isActive == true && x.depoContainerId == id).ToList();
            ViewBag.Details = Details;

            ViewBag.Error = false;
            return View("Edit", mContext.mtDepoContainer.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit([FromBody]mtDepoContainer value)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
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
            mtDepoContainer item = mContext.mtDepoContainer.Find(id);
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
                mtDepoContainer item = mContext.mtDepoContainer.Find(id);
                ICollection<mtDepoContainerDetails> items = mContext.mtDepoContainerDetails.Where(x => x.isActive == true && x.depoContainerId == item.id).ToList();

                mContext.Entry(item).Reload();

                foreach (mtDepoContainerDetails value in items)
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
                mContext.Remove(mContext.mtDepoContainerDetails.Find(id));
                mContext.SaveChanges();
            }
            catch(Exception e)
            {
                return Ok(new { status = 409, message = e.Message });
            }

            return Ok(new { status = 200, message = "" });
        }

        [HttpPost]
        [Route("addDetail")]
        public IActionResult addDetail([FromBody]mtDepoContainerDetails value)
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

                mContext.mtDepoContainerDetails.Add(value);
                mContext.SaveChanges();

                int id = value.id;
                return Ok(new { status = 200, message = id.ToString() });
            }

            return Ok(new { status = 409, message = "Json is null, please Check Controller" });
        }
    }
}
