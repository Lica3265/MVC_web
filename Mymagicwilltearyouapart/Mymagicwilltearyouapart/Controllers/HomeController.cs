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
        private ModelDBContext _db = new ModelDBContext();

        public ActionResult loginb()
        {
            using (ModelDBContext DB = new ModelDBContext())
            {

               
            }

                return View();
        }
        public ActionResult Index()
        {
            DateTime date = DateTime.Now;
            ViewBag.Date = date;

            Student data = new Student("1", "小明", 80);
            return View(data);
        }
        public ActionResult Transcripts(string id, string name, int score)
        {
            Student data = new Student(id, name, score);
            return View(data);
        }
        [HttpPost]
        public ActionResult Transcripts(Student model)
        {
            string id = model.id;
            string name = model.name;
            int score = model.score;
            Student data = new Student(id, name, score);
            return View(data);


        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModels model)
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