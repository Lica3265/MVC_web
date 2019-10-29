using Mymagicwilltearyouapart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace Mymagicwilltearyouapart.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account account)
        {
            ViewBag.Accounttttt = Request.Form["account"];
            ViewBag.Passwordddd = Request.Form["password"];

            return View();
        }
    }
}