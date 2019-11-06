using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class UserDBController : Controller
    {

        private Models.MVC_UserDBContext _db = new Models.MVC_UserDBContext();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();

            }
            base.Dispose(disposing);
        }

        // GET: UserDB
        public ActionResult Index()
        {
          


            return View();
        }
    }
}