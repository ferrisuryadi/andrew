using System;
using System.Collections.Generic;
using System.Linq;
using fms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("CostShipping")]
    public class CostShippingController : Controller
    {
        protected ApplicationDbContext mContext;

        public CostShippingController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewBag.Items = mContext.trCostShipping.Include(
                x => x.portOfLoading).Include(x => x.user).ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ICollection<mtPortOfLoading> PortOfLoadings = mContext.mtPortOfLoading.Where(x => x.isActive == true).ToList();
            ICollection<mtShipper> Shippers = mContext.mtShipper.Where(x => x.isActive == true).ToList();
            ICollection<mtUser> Users = mContext.mtUser.Where(x => x.isActive == true).ToList();
            ICollection<mtServices> Services = mContext.mtServices.Where(x => x.isActive == true).ToList();
            ICollection<mtPortOfDestination> PortOfDestinations = mContext.mtPortOfDestination.Where(x => x.isActive == true).ToList();
            ICollection<mtContainer> Containers = mContext.mtContainer.Where(x => x.isActive == true).ToList();
            ICollection<mtCurrency> Currencies = mContext.mtCurrency.Where(x => x.isActive == true).ToList();
            ICollection<mtTax> Taxes = mContext.mtTax.Where(x => x.isActive == true).ToList();

            ViewBag.PortOfLoadings = PortOfLoadings;
            ViewBag.Shippers = Shippers;
            ViewBag.Users = Users;
            ViewBag.Services = Services;

            ViewBag.PortOfDestinations = PortOfDestinations;
            ViewBag.Containers = Containers;
            ViewBag.Currencies = Currencies;
            ViewBag.Taxes = Taxes;

            ViewBag.Error = false;
            return View("Create", new trCostShipping());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]trCostShipping value)
        {
            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (value != null)
            {
                List<trCostShippingDetails> details = new List<trCostShippingDetails>();
                foreach (trCostShippingDetails items in value.costShippingDetails)
                {
                    items.isActive = true;
                    items.createdBy = user;
                    items.createdOn = txDate;
                    items.updatedBy = user;
                    items.updatedOn = txDate;
                }

                List<trCostShippingShipper> shippers = new List<trCostShippingShipper>();
                foreach (trCostShippingShipper items in value.costShippingShippers)
                {
                    items.isActive = true;
                    items.createdBy = user;
                    items.createdOn = txDate;
                    items.updatedBy = user;
                    items.updatedOn = txDate;
                }

                value.portOfLoadingId = (value.portOfLoadingId == 0 ? null : value.portOfLoadingId);
                value.userIdSales = (value.userIdSales == 0 ? null : value.userIdSales);
                value.isActive = true;
                value.createdBy = user;
                value.createdOn = txDate;
                value.updatedBy = user;
                value.updatedOn = txDate;

                mContext.trCostShipping.Add(value);
                mContext.SaveChanges();

                return Json("success");
            }

            ICollection<mtPortOfLoading> PortOfLoadings = mContext.mtPortOfLoading.Where(x => x.isActive == true).ToList();
            ICollection<mtShipper> Shippers = mContext.mtShipper.Where(x => x.isActive == true).ToList();
            ICollection<mtUser> Users = mContext.mtUser.Where(x => x.isActive == true).ToList();
            ICollection<mtServices> Services = mContext.mtServices.Where(x => x.isActive == true).ToList();
            ICollection<mtPortOfDestination> PortOfDestinations = mContext.mtPortOfDestination.Where(x => x.isActive == true).ToList();
            ICollection<mtContainer> Containers = mContext.mtContainer.Where(x => x.isActive == true).ToList();
            ICollection<mtCurrency> Currencies = mContext.mtCurrency.Where(x => x.isActive == true).ToList();
            ICollection<mtTax> Taxes = mContext.mtTax.Where(x => x.isActive == true).ToList();

            ViewBag.PortOfLoadings = PortOfLoadings;
            ViewBag.PortOfDestinations = PortOfDestinations;
            ViewBag.Shippers = Shippers;
            ViewBag.Users = Users;
            ViewBag.Containers = Containers;
            ViewBag.Services = Services;
            ViewBag.Currencies = Currencies;
            ViewBag.Taxes = Taxes;

            ViewBag.Error = true;
            return Json("Error");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.trCostShipping.Find(id));
            mContext.RemoveRange(mContext.trCostShippingDetails.Where(x => x.costShippingId == id).ToList());
            mContext.RemoveRange(mContext.trCostShippingShipper.Where(x => x.costShippingId == id).ToList());
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ICollection<mtPortOfLoading> PortOfLoadings = mContext.mtPortOfLoading.Where(x => x.isActive == true).ToList();
            ICollection<mtShipper> Shippers = mContext.mtShipper.Where(x => x.isActive == true).ToList();
            ICollection<mtUser> Users = mContext.mtUser.Where(x => x.isActive == true).ToList();
            ICollection<mtServices> Services = mContext.mtServices.Where(x => x.isActive == true).ToList();
            ICollection<mtPortOfDestination> PortOfDestinations = mContext.mtPortOfDestination.Where(x => x.isActive == true).ToList();
            ICollection<mtContainer> Containers = mContext.mtContainer.Where(x => x.isActive == true).ToList();
            ICollection<mtCurrency> Currencies = mContext.mtCurrency.Where(x => x.isActive == true).ToList();
            ICollection<mtTax> Taxes = mContext.mtTax.Where(x => x.isActive == true).ToList();

            ICollection<trCostShippingDetails> Details = mContext.trCostShippingDetails.Where(x => x.isActive == true && x.costShippingId == id).ToList();
            //ICollection<trCostShippingShipper> Shipper = mContext.trCostShippingShipper.Where(x => x.isActive == true && x.costShippingId == id && x.costShippingDetailId == Details.First().id).ToList();

            ViewBag.Details = Details;
            //ViewBag.Shipper = Shipper;

            ViewBag.PortOfLoadings = PortOfLoadings;
            ViewBag.PortOfDestinations = PortOfDestinations;
            ViewBag.Shippers = Shippers;
            ViewBag.Users = Users;
            ViewBag.Containers = Containers;
            ViewBag.Services = Services;
            ViewBag.Currencies = Currencies;
            ViewBag.Taxes = Taxes;

            ViewBag.Error = false;
            return View("Edit", mContext.trCostShipping.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(trCostShipping item)
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

            ICollection<mtPortOfLoading> PortOfLoadings = mContext.mtPortOfLoading.Where(x => x.isActive == true).ToList();
            ICollection<mtShipper> Shippers = mContext.mtShipper.Where(x => x.isActive == true).ToList();
            ICollection<mtUser> Users = mContext.mtUser.Where(x => x.isActive == true).ToList();
            ICollection<mtServices> Services = mContext.mtServices.Where(x => x.isActive == true).ToList();
            ICollection<mtPortOfDestination> PortOfDestinations = mContext.mtPortOfDestination.Where(x => x.isActive == true).ToList();
            ICollection<mtContainer> Containers = mContext.mtContainer.Where(x => x.isActive == true).ToList();
            ICollection<mtCurrency> Currencies = mContext.mtCurrency.Where(x => x.isActive == true).ToList();
            ICollection<mtTax> Taxes = mContext.mtTax.Where(x => x.isActive == true).ToList();

            ICollection<trCostShippingDetails> Details = mContext.trCostShippingDetails.Where(x => x.isActive == true && x.costShippingId == item.id).ToList();
            //ICollection<trCostShippingShipper> Shipper = mContext.trCostShippingShipper.Where(x => x.isActive == true && x.costShippingId == item.id && x.costShippingDetailId == Details.First().id).ToList();

            ViewBag.Details = Details;
            //ViewBag.Shipper = Shipper;

            ViewBag.PortOfLoadings = PortOfLoadings;
            ViewBag.PortOfDestinations = PortOfDestinations;
            ViewBag.Shippers = Shippers;
            ViewBag.Users = Users;
            ViewBag.Containers = Containers;
            ViewBag.Services = Services;
            ViewBag.Currencies = Currencies;
            ViewBag.Taxes = Taxes;

            ViewBag.Error = true;
            return View("edit");
        }
    }
}
