using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mymagicwilltearyouapart.Models;

namespace Mymagicwilltearyouapart.Controllers
{
    public class HomeController : Controller
    {
        //private ModelDBContext _db = new ModelDBContext();

        //public ActionResult loginb()
        //{
        //    using (ModelDBContext DB = new ModelDBContext())
        //    {            }
        // return View();
        //}



        public ActionResult LoginPage()
        {                         
            return View();
        }

        [HttpPost]
        public ActionResult LoginPage(string email,string password)
        {
            using (HappyDBContext DB = new HappyDBContext())
            {

                Table table1 = DB.Table.Find(email);
               

                Table table2 = DB.Table.Find(password);
               
                if (table1 == null || table2 == null)
                {
                    return View();
                }
              
                return Login();
            }
        }
        public ActionResult Login()
        {
            Session["auth"] = true;
            return RedirectToAction("LoginPage");
        }
        public ActionResult Logout()
        {
            Session["auth"] = false;
            return RedirectToAction("LoginPage");
        }

        [AuthorizePlus]
        public ActionResult Secret()
        {
            return View();
        }

        




        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModels model)
        {
            return View();
        }
      
      

    }
}