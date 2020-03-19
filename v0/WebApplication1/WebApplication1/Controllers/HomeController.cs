using System;
using System.Collections.Generic;
using System.IO;
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
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(courseTB crs)
        {
            string filename = Path.GetFileNameWithoutExtension(crs.ImageFile.FileName);
            string extension = Path.GetExtension(crs.ImageFile.FileName);
            filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            crs.courseImage = "~/Image/" + filename;
            filename = Path.Combine(Server.MapPath("~/Image/"), filename);
            crs.ImageFile.SaveAs(filename);

            using (scholarDBContext dbmodel = new scholarDBContext())
            {
                dbmodel.courseTBs.Add(crs);
                dbmodel.SaveChanges();
            }ModelState.Clear();

            return RedirectToAction("Intro");
        }

    }
}