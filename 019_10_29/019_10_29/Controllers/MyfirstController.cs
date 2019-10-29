using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _019_10_29.Controllers
{
    public class MyfirstController : Controller
    {
        // GET: Myfirst
        public ActionResult Index()
        {
      

            return View();
            //return Content("XXXXX")
        }

        public ActionResult Index2()
        {
            Models.Class1 class1 = new Models.Class1
            {
                UserName = "我很猛"
            };


            return View(class1);
            //return Content("XXXXX")
        }


    }

}
