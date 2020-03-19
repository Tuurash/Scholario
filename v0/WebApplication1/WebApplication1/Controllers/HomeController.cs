using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scholar.Models;
using WebApplication1.Repository;

namespace Scholar.Controllers
{
    public class HomeController : Controller
    {
        IRepository<courseTB> courseRepo = new CourseRepository();
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Intro()
        {
            return View(courseRepo.GetAll());
        }

        public ActionResult Registration()
        {
            return RedirectToAction("Register","User");
        }

    }
}