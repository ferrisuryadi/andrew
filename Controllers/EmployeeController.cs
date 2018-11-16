using System;
using System.IO;
using System.Linq;
using fms.Common;
using fms.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fms.Controllers
{
    [Route("Employee")]
    public class EmployeeController : Controller
    {
        protected ApplicationDbContext mContext;

        public EmployeeController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Employee";

            ViewBag.Items = mContext.mtEmployee.ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Create()
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Employee";

            ViewBag.Error = false;
            return View("Create", new mtEmployee());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Create(mtEmployee item, IFormFile pictureUrl)
        {
            SystemDocumentNo sysDocNo = new SystemDocumentNo(mContext);

            if (pictureUrl == null || pictureUrl.Length == 0)
            {
                item.pictureUrl = "";
            }
            else{
                string fileName = sysDocNo.getDocNo("Employee", "Image", false) + Path.GetExtension(pictureUrl.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/employeeImages", fileName);
                pictureUrl.CopyTo(new FileStream(path, FileMode.Create));
                item.pictureUrl = fileName;
            }

            string user = "Admin";
            DateTime txDate = DateTime.Now;

            if (ModelState.IsValid)
            {

                item.createdBy = user;
                item.createdOn = txDate;
                item.updatedBy = user;
                item.updatedOn = txDate;

                sysDocNo.getDocNo("Employee", "Image", true);
                mContext.mtEmployee.Add(item);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Error = true;
            return View("Create");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            mContext.Remove(mContext.mtEmployee.Find(id));
            mContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewData["Menu"] = "Master";
            ViewData["SubMenuLvl1"] = "Employee";

            ViewBag.Error = false;
            mtEmployee employee = mContext.mtEmployee.Find(id);
            return View("Edit", employee);
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(mtEmployee item, IFormFile pictureUrl)
        {
            SystemDocumentNo sysDocNo = new SystemDocumentNo(mContext);

            if (pictureUrl == null || pictureUrl.Length == 0)
            {
                mtEmployee old = mContext.mtEmployee.Find(item.id);
                item.pictureUrl = old.pictureUrl;
            }
            else
            {
                string fileName = sysDocNo.getDocNo("Employee", "Image", true) + Path.GetExtension(pictureUrl.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/employeeImages", fileName);
                pictureUrl.CopyTo(new FileStream(path, FileMode.Create));
                item.pictureUrl = fileName;
            }

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

            ViewBag.Error = true;
            return View("edit");
        }

        [HttpGet]
        [Route("isActive/{id}")]
        public IActionResult IsActive(int id)
        {
            mtEmployee item = mContext.mtEmployee.Find(id);
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
