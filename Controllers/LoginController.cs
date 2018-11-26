using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fms.Models;
using fms.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace fms.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        protected ApplicationDbContext mContext;

        public LoginController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public IActionResult login([FromBody]login value)
        {
            if (string.IsNullOrEmpty(value.username))
                return Ok(new { status = 409, message = "Username/Email Required" });

            if (string.IsNullOrEmpty(value.password))
                return Ok(new { status = 409, message = "Password Required" });

            Authorize auth = new Authorize();
            sysUser user = mContext.sysUser.Where(x => x.username == value.username || x.email == value.username).SingleOrDefault();

            if (user == null)
                return Ok(new { status = 409, message = "Username/email is not found" });

            bool validate = auth.validateLoginPassword(value.password, user.password);
            if (!validate)
                return Ok(new { status = 409, message = "Wrong Password" });

            string defaultMenu = mContext.sysModuleRole.Include(x => x.module).Where(x => x.userRoleId == user.roleId && x.isActive == true && x.isDefault == true).Select(x => "/" + x.module.controller + "/" + x.module.view).SingleOrDefault();
           
            HttpContext.Session.SetString("fullname", user.name);
            HttpContext.Session.SetInt32("roleId", user.roleId);

            return Ok(new { status = 200, message = defaultMenu });
        }

        [HttpPost]
        [Route("logout")]
        public IActionResult logout()
        {
            HttpContext.Session.Remove("fullname");
            HttpContext.Session.Remove("roleId");

            return Ok(new { status = 200, message = "" });
        }
    }
}
