using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using fms.Common;
using fms.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("SellingShipper")]
    public class SellingShipperController : Controller
    {
        protected ApplicationDbContext mContext;

        public SellingShipperController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            ICollection<sysModule> moduleLvl1 =
                mContext.sysModuleRole.Include(x => x.module)
                        .Where(x => x.userRoleId == HttpContext.Session.GetInt32("roleId") && x.isActive == true && x.module.level == 1)
                        .Select(x => x.module).ToList();

            ICollection<sysModule> moduleLvl2 =
                mContext.sysModuleRole.Include(x => x.module)
                        .Where(x => x.userRoleId == HttpContext.Session.GetInt32("roleId") && x.isActive == true && x.module.level == 2)
                        .Select(x => x.module).ToList();

            ViewBag.moduleLvl1 = moduleLvl1.OrderBy(x => x.orderModule);
            ViewBag.moduleLvl2 = moduleLvl2.OrderBy(x => x.orderModule);
            ViewBag.user = HttpContext.Session.GetString("fullname");

            try
            {
                sysModule menu2 = moduleLvl2.Where(x => x.code == "SellingShipper").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ViewBag.Items = mContext.trSellingShipper.ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            ICollection<sysModule> moduleLvl1 =
                mContext.sysModuleRole.Include(x => x.module)
                        .Where(x => x.userRoleId == HttpContext.Session.GetInt32("roleId") && x.isActive == true && x.module.level == 1)
                        .Select(x => x.module).ToList();

            ICollection<sysModule> moduleLvl2 =
                mContext.sysModuleRole.Include(x => x.module)
                        .Where(x => x.userRoleId == HttpContext.Session.GetInt32("roleId") && x.isActive == true && x.module.level == 2)
                        .Select(x => x.module).ToList();

            ViewBag.moduleLvl1 = moduleLvl1.OrderBy(x => x.orderModule);
            ViewBag.moduleLvl2 = moduleLvl2.OrderBy(x => x.orderModule);
            ViewBag.user = HttpContext.Session.GetString("fullname");

            try
            {
                sysModule menu2 = moduleLvl2.Where(x => x.code == "SellingShipper").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            return View("Create", new trSellingShipper());
        }

        [HttpGet]
        [Route("getShipper")]
        public IActionResult getShipper()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtShipper.Where(x => x.isActive == true)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.code + " - " + x.name)
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getShipper/{id}")]
        public IActionResult getShipper(int id)
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtShipper.Where(x => x.isActive == true && x.id == id)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = x.attention
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getEmployee")]
        public IActionResult getEmployee()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtEmployee.Where(x => x.isActive == true)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.code + " - " + x.name)
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getPortOfLoading")]
        public IActionResult getPortOfLoading()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtPortOfLoading.Where(x => x.isActive == true)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.port)
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getService")]
        public IActionResult getService()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtServices.Where(x => x.isActive == true)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.code + " - " + x.description)
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getPortOfDestination")]
        public IActionResult getPortOfDestination()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtPortOfDestination.Where(x => x.isActive == true)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.location)
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getContainer")]
        public IActionResult getContainer()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtContainer.Where(x => x.isActive == true)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.typeofContainer)
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getTax")]
        public IActionResult getTax()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtTax.Where(x => x.isActive == true)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.code + " - " + x.amount.ToString(SystemFormat.decimalFormat))
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getLocation")]
        public IActionResult getLocation()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtLocation.Where(x => x.isActive == true)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.location)
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getCurrency")]
        public IActionResult getCurrency()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtCurrency.Where(x => x.isActive == true)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.code + " - " + x.description)
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getConsignee")]
        public IActionResult getConsignee()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtConsignee.Where(x => x.isActive == true)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.code  + " - " + x.name)
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getOrder")]
        public IActionResult getOrder()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtOrders.Where(x => x.isActive == true)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.name)
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getCoLoader")]
        public IActionResult getCoLoader()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtVendor.Where(x => x.isActive == true && x.typeId == 5)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.code + " - " + x.name)
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getVendor")]
        public IActionResult getVendor()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtVendor.Where(x => x.isActive == true)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.code + " - " + x.name)
                        }).ToList();

            return Ok(new { status = 200, message = dropDowns });
        }

        [HttpGet]
        [Route("getVendor/{id}")]
        public IActionResult getVendor(int id)
        {
            mtVendor value = mContext.mtVendor.Where(x => x.isActive == true && x.id == id).FirstOrDefault();
            return Ok(new { status = 200, message = new { code = value.code, name = value.name } });
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]trSellingShipper value)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            string user = HttpContext.Session.GetString("fullname");
            DateTime txDate = DateTime.Now;
            SystemDocumentNo sysDocNo = new SystemDocumentNo(mContext);

            try{
                value.referenceNo = (value.id == 0 ? sysDocNo.getDocNo("SellingShipper", "RefNo", false) : "");
                value.isActive = true;
                value.createdBy = (value.id == 0 ? user : value.createdBy);
                value.createdOn = (value.id == 0 ? txDate : value.createdOn);
                value.updatedBy = user;
                value.updatedOn = txDate;

                var context = new ValidationContext(value, serviceProvider: null, items: null);
                var results = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(value, context, results, true);

                List<string> errorMessage = new List<string>();
                if (value.shipperId == 0) errorMessage.Add("To harus di isi");
                if (value.employeeId == 0) errorMessage.Add("From harus di isi");
                if (value.portOfLoadingId == 0) errorMessage.Add("Port Of Loading harus di isi");

                if ((!isValid) || (errorMessage.Count > 0))
                {
                    foreach (ValidationResult validationResult in results)
                        errorMessage.Add(validationResult.ErrorMessage);

                    return Ok(new { status = 400, message = errorMessage });
                }

                if (value.id == 0)
                {
                    value.referenceNo = (value.id == 0 ? sysDocNo.getDocNo("SellingShipper", "RefNo", true) : "");
                    mContext.trSellingShipper.Add(value);
                }
                else
                    mContext.Entry(value).State = EntityState.Modified;

                mContext.SaveChanges();

                return Ok(new { status = 200, message = new { id = value.id, referenceNo = value.referenceNo } });

            }
            catch (Exception ex){
                return Ok(new { status = 409, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("serviceAdd")]
        public IActionResult serviceAdd([FromBody]trSellingShipperService value)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            string user = HttpContext.Session.GetString("fullname");
            DateTime txDate = DateTime.Now;

            try
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
                if (value.serviceId == 0) errorMessage.Add("Item Of Service harus di isi");
                if (value.portOfDestinationId == 0) errorMessage.Add("Port Of Destination harus di isi");
                if (value.containerId == 0) errorMessage.Add("Container harus di isi");
                if (value.taxId23 == 0) errorMessage.Add("% tax 23 harus di isi");
                if (value.taxIdvat == 0) errorMessage.Add("% vat harus di isi");

                if ((!isValid) || (errorMessage.Count > 0))
                {
                    foreach (ValidationResult validationResult in results)
                        errorMessage.Add(validationResult.ErrorMessage);

                    return Ok(new { status = 400, message = errorMessage });
                }

                mContext.trSellingShipperService.Add(value);
                mContext.SaveChanges();

                return Ok(new { status = 200, message = value.id });

            }
            catch (Exception ex)
            {
                return Ok(new { status = 409, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("serviceDelete/{id}")]
        public IActionResult serviceDelete(int id)
        {
            try
            {
                mContext.Remove(mContext.trSellingShipperService.Find(id));
                mContext.SaveChanges();
            }
            catch (Exception e)
            {
                return Ok(new { status = 409, message = e.Message });
            }

            return Ok(new { status = 200, message = "" });
        }

        [HttpPost]
        [Route("detailAdd")]
        public IActionResult detailAdd([FromBody]trSellingShipperDetail value)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            string user = HttpContext.Session.GetString("fullname");
            DateTime txDate = DateTime.Now;

            try
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
                if (value.serviceId == 0) errorMessage.Add("Item Of Service harus di isi");
                if (value.portOfDestinationId == 0) errorMessage.Add("Port Of Destination harus di isi");
                if (value.locationId == 0) errorMessage.Add("Location harus di isi");
                if (value.consigneeId == 0) errorMessage.Add("Consignee harus di isi");
                if (value.containerId == 0) errorMessage.Add("Container harus di isi");
                if (value.currencyId == 0) errorMessage.Add("Currency harus di isi");
                if (value.taxId23 == 0) errorMessage.Add("% tax 23 harus di isi");
                if (value.taxIdvat == 0) errorMessage.Add("% vat harus di isi");
                if (value.orderId == 0) errorMessage.Add("Invoice Group harus di isi");
                if (value.vendorId == 0) errorMessage.Add("CoLoader harus di isi");

                if ((!isValid) || (errorMessage.Count > 0))
                {
                    foreach (ValidationResult validationResult in results)
                        errorMessage.Add(validationResult.ErrorMessage);

                    return Ok(new { status = 400, message = errorMessage });
                }

                mContext.trSellingShipperDetail.Add(value);
                mContext.SaveChanges();

                return Ok(new { status = 200, message = value.id });

            }
            catch (Exception ex)
            {
                return Ok(new { status = 409, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("detailDelete/{id}")]
        public IActionResult detailDelete(int id)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            try
            {
                mContext.Remove(mContext.trSellingShipperDetail.Find(id));
                mContext.SaveChanges();
            }
            catch (Exception e)
            {
                return Ok(new { status = 409, message = e.Message });
            }

            return Ok(new { status = 200, message = "" });
        }

        [HttpPost]
        [Route("vendorAdd")]
        public IActionResult vendorAdd([FromBody]trSellingShipperDetailVendor value)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            string user = HttpContext.Session.GetString("fullname");
            DateTime txDate = DateTime.Now;

            try
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
                if (value.sellingShipperDetailId == 0) errorMessage.Add("Mohon memilih salah satu detail");
                if (value.vendorId == 0) errorMessage.Add("Vendor harus di isi");

                if ((!isValid) || (errorMessage.Count > 0))
                {
                    foreach (ValidationResult validationResult in results)
                        errorMessage.Add(validationResult.ErrorMessage);

                    return Ok(new { status = 400, message = errorMessage });
                }

                mContext.trSellingShipperDetailVendor.Add(value);
                mContext.SaveChanges();

                return Ok(new { status = 200, message = value.id });

            }
            catch (Exception ex)
            {
                return Ok(new { status = 409, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("vendorDelete/{id}")]
        public IActionResult vendorDelete(int id)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            try
            {
                mContext.Remove(mContext.trSellingShipperDetailVendor.Find(id));
                mContext.SaveChanges();
            }
            catch (Exception e)
            {
                return Ok(new { status = 409, message = e.Message });
            }

            return Ok(new { status = 200, message = "" });
        }

        [HttpPost]
        [Route("loadVendor")]
        public IActionResult loadVendor([FromBody]trSellingShipperDetailVendorLoad value)
        {
            ICollection<trSellingShipperDetailVendor> mtVendor = 
                mContext.trSellingShipperDetailVendor
                        .Where(x => x.isActive == true && 
                               x.sellingShipperId == value.sellingShipperId && 
                               x.sellingShipperDetailId == value.sellingShipperDetailId).ToList();

            return Ok(new { status = 200, message = mtVendor });
        }
    }
}
