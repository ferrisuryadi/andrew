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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "CostShipping").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ViewBag.Items = mContext.trCostShipping.ToList();
            return View();
        }

        [HttpGet]
        [Route("add/{id}")]
        public IActionResult Create(int id)
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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "CostShipping").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ViewBag.user = HttpContext.Session.GetString("fullname");
            ViewBag.state = "add";
            ViewBag.vendorId = id;
            return View("Create", new trCostShipping());
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
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
                sysModule menu2 = moduleLvl2.Where(x => x.code == "CostShipping").SingleOrDefault();
                sysModule menu1 = moduleLvl1.Where(x => x.id == menu2.parentId).SingleOrDefault();

                ViewData["Menu"] = menu1.name;
                ViewData["SubMenuLvl1"] = menu2.name;
                ViewData["Title"] = menu2.name;
            }
            catch
            {
                return RedirectToAction("index", "login");
            }

            ViewBag.costShippingId = id;
            ViewBag.state = "edit";
            return View("Create", new trCostShipping());
        }

        [HttpGet]
        [Route("loadVendor")]
        public IActionResult loadVendor()
        {
            ICollection<trCostShippingVendorLoad> dataTable =
                mContext.mtVendor.Where(x => x.isActive == true && x.typeId == 4)
                        .Select(x => new trCostShippingVendorLoad
                        {
                            id = x.id,
                            code = x.code,
                            name = x.name
                        }).ToList();

            return Ok(new { status = 200, message = dataTable });
        }

        [HttpGet]
        [Route("loadTransaction/{id}")]
        public IActionResult loadTransaction(int id)
        {
            ICollection<trCostShippingView> dataTable =
                mContext.trCostShipping
                        .Where(x => x.isActive == true && x.vendorId == id)
                        .Select(x => new trCostShippingView
                        {
                            id = x.id,
                            referenceNo = x.referenceNo,
                            txDate = x.txDate.ToString(SystemFormat.dateFormat),
                            txValidDate = x.txValidDate.ToString(SystemFormat.dateFormat),
                            updatedBy = x.updatedBy,
                            updatedOn = x.updatedOn.ToString(SystemFormat.datetimeFormat)
                        }).ToList();

            return Ok(new { status = 200, message = dataTable });
        }

        [HttpGet]
        [Route("loadVendor/{id}")]
        public IActionResult loadVendor(int id)
        {
            sysDropDown dropDowns =
                mContext.mtVendor.Where(x => x.isActive == true && x.id == id)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.code + " - " + x.name)
                        }).SingleOrDefault();

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
        [Route("getTerminal")]
        public IActionResult getTerminal()
        {
            ICollection<sysDropDown> dropDowns =
                mContext.mtPortTerminal.Where(x => x.isActive == true)
                        .Select(x => new sysDropDown
                        {
                            id = x.id,
                            description = (x.terminalPort)
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
            mtShipper value = mContext.mtShipper.Where(x => x.isActive == true && x.id == id).FirstOrDefault();
            return Ok(new { status = 200, message = new { code = value.code, name = value.name } });
        }

        [HttpPost]
        [Route("save")]
        public IActionResult save([FromBody]trCostShipping value)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);

            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            string user = HttpContext.Session.GetString("fullname");
            DateTime txDate = DateTime.Now;
            SystemDocumentNo sysDocNo = new SystemDocumentNo(mContext);

            try
            {
                value.referenceNo = (value.id == 0 ? sysDocNo.getDocNo("CostShipping", "RefNo", false) : value.referenceNo);
                value.isActive = true;
                value.createdBy = (value.id == 0 ? user : value.createdBy);
                value.createdOn = (value.id == 0 ? txDate : value.createdOn);
                value.updatedBy = user;
                value.updatedOn = txDate;

                var context = new ValidationContext(value, serviceProvider: null, items: null);
                var results = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(value, context, results, true);

                List<string> errorMessage = new List<string>();
                if (value.vendorId == 0) errorMessage.Add("Vendor harus di isi");
                if (value.portOfLoadingId == 0) errorMessage.Add("Port Of Loading harus di isi");

                if ((!isValid) || (errorMessage.Count > 0))
                {
                    foreach (ValidationResult validationResult in results)
                        errorMessage.Add(validationResult.ErrorMessage);

                    return Ok(new { status = 400, message = errorMessage });
                }

                if (value.id == 0)
                {
                    value.referenceNo = (value.id == 0 ? sysDocNo.getDocNo("CostShipping", "RefNo", true) : "");
                    mContext.trCostShipping.Add(value);
                }
                else
                    mContext.Entry(value).State = EntityState.Modified;

                mContext.SaveChanges();

                return Ok(new { status = 200, message = new { id = value.id, referenceNo = value.referenceNo, createdBy = value.createdBy, createdOn = value.createdOn } });

            }
            catch (Exception ex)
            {
                return Ok(new { status = 409, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("serviceAdd")]
        public IActionResult serviceAdd([FromBody]trCostShippingService value)
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

                mContext.trCostShippingService.Add(value);
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
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);

            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            try
            {
                mContext.Remove(mContext.trCostShippingService.Find(id));
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
        public IActionResult detailAdd([FromBody]trCostShippingDetail value)
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
                if (value.portTerminalId == 0) errorMessage.Add("Port Of Transhipment harus di isi");
                if (value.containerId == 0) errorMessage.Add("Container harus di isi");
                if (value.currencyId == 0) errorMessage.Add("Currency harus di isi");
                if (value.taxId23 == 0) errorMessage.Add("% tax 23 harus di isi");
                if (value.taxIdvat == 0) errorMessage.Add("% vat harus di isi");
                if (value.vendorId == 0) errorMessage.Add("CoLoader harus di isi");

                if ((!isValid) || (errorMessage.Count > 0))
                {
                    foreach (ValidationResult validationResult in results)
                        errorMessage.Add(validationResult.ErrorMessage);

                    return Ok(new { status = 400, message = errorMessage });
                }

                mContext.trCostShippingDetail.Add(value);
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
                mContext.Remove(mContext.trCostShippingDetail.Find(id));
                mContext.SaveChanges();
            }
            catch (Exception e)
            {
                return Ok(new { status = 409, message = e.Message });
            }

            return Ok(new { status = 200, message = "" });
        }

        [HttpPost]
        [Route("shipperAdd")]
        public IActionResult shipperAdd([FromBody]trCostShippingDetailShipper value)
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
                if (value.costShippingDetailId == 0) errorMessage.Add("Mohon memilih salah satu detail");
                if (value.shipperId == 0) errorMessage.Add("Shipper harus di isi");

                if ((!isValid) || (errorMessage.Count > 0))
                {
                    foreach (ValidationResult validationResult in results)
                        errorMessage.Add(validationResult.ErrorMessage);

                    return Ok(new { status = 400, message = errorMessage });
                }

                mContext.trCostShippingDetailShipper.Add(value);
                mContext.SaveChanges();

                return Ok(new { status = 200, message = value.id });

            }
            catch (Exception ex)
            {
                return Ok(new { status = 409, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("shipperDelete/{id}")]
        public IActionResult shipperDelete(int id)
        {
            HttpContext.Session.SetString("fullname", "Administrator");
            HttpContext.Session.SetInt32("roleId", 1);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("fullname")))
                return RedirectToAction("index", "login");

            try
            {
                mContext.Remove(mContext.trCostShippingDetailShipper.Find(id));
                mContext.SaveChanges();
            }
            catch (Exception e)
            {
                return Ok(new { status = 409, message = e.Message });
            }

            return Ok(new { status = 200, message = "" });
        }

        [HttpPost]
        [Route("loadShipper")]
        public IActionResult loadShipper([FromBody]trCostShippingDetailShipperLoad value)
        {
            ICollection<trCostShippingDetailShipper> mtVendor =
                mContext.trCostShippingDetailShipper
                        .Where(x => x.isActive == true &&
                               x.costShippingId == value.costShippingId &&
                               x.costShippingDetailId == value.costShippingDetailId).ToList();

            return Ok(new { status = 200, message = mtVendor });
        }

        [HttpGet]
        [Route("loadHeader/{id}")]
        public IActionResult loadHeader(int id)
        {
            trCostShipping data =
                mContext.trCostShipping
                        .Where(x => x.isActive == true && x.id == id)
                        .SingleOrDefault();

            return Ok(new { status = 200, message = data });
        }

        [HttpGet]
        [Route("loadService/{id}")]
        public IActionResult loadService(int id)
        {
            ICollection<trCostShippingServiceView> data =
                mContext.trCostShippingService
                        .Include(x => x.services)
                        .Include(x => x.portOfDestination)
                        .Include(x => x.container)
                        .Include(x => x.tax23)
                        .Include(x => x.vat)
                        .Where(x => x.isActive == true && x.costShippingId == id)
                        .Select(x => new trCostShippingServiceView
                        {
                            id = x.id,
                            serviceId = (x.services.code + " - " + x.services.description),
                            portOfDestinationId = x.portOfDestination.location,
                            ofEmkl = (x.ofEmkl == 1 ? "O / F" : "EMKL"),
                            pcPay = (x.pcPay == 1 ? "PREPAID (P)" : (x.pcPay == 2 ? "COLLECT (C)" : "PAYABLE AT")),
                            containerId = (x.container.typeofContainer),
                            taxId23 = (x.tax23.code + " - " + x.tax23.amount.ToString(SystemFormat.decimalFormat)),
                            taxIdvat = (x.vat.code + " - " + x.vat.amount.ToString(SystemFormat.decimalFormat)),
                            remark = x.remark
                        }).ToList();

            return Ok(new { status = 200, message = data });
        }

        [HttpGet]
        [Route("loadDetail/{id}")]
        public IActionResult loadDetail(int id)
        {
            ICollection<trCostShippingDetailView> data =
                mContext.trCostShippingDetail
                        .Include(x => x.services)
                        .Include(x => x.portOfDestination)
                        .Include(x => x.portTerminal)
                        .Include(x => x.container)
                        .Include(x => x.currency)
                        .Include(x => x.tax23)
                        .Include(x => x.vat)
                        .Include(x => x.vendor)
                        .Where(x => x.isActive == true && x.costShippingId == id)
                        .Select(x => new trCostShippingDetailView
                        {
                            id = x.id,
                            serviceId = (x.services.code + " - " + x.services.description),
                            portOfDestinationId = x.portOfDestination.location,
                            portTerminalId = x.portTerminal.terminalPort,
                            pcPay = (x.pcPay == 1 ? "PREPAID (P)" : (x.pcPay == 2 ? "COLLECT (C)" : "PAYABLE AT")),
                            containerId = (x.container.typeofContainer),
                            currencyId = (x.currency.code + " - " + x.currency.description),
                            taxId23 = (x.tax23.code + " - " + x.tax23.amount.ToString(SystemFormat.decimalFormat)),
                            taxIdvat = (x.vat.code + " - " + x.vat.amount.ToString(SystemFormat.decimalFormat)),
                            price = x.price,
                            allIn = (x.allIn ? "True" : "False"),
                            refund = x.refund,
                            refundType = (x.refundType == 1 ? "Percentage" : "Amount"),
                            payable = x.payable,
                            vendorId = (x.vendor.code + " - " + x.vendor.name),
                            remark = x.remark
                        }).ToList();

            return Ok(new { status = 200, message = data });
        }
    }
}
