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

        public ActionResult Intro()
        {
            return View(courseRepo.GetAll());
        }

        public ActionResult Registration()
        {
            return RedirectToAction("Register", "User");
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewmodel model)
        {
            scholarDBContext DB = new scholarDBContext();

            var user = DB.userTBs.FirstOrDefault(x => x.userMail == model.userMail  && x.Password == model.Password);
            if (user != null)
            {
                Session["userName"] = user.userName;
                Session["userID"] = user.userID;
                return RedirectToAction("UserProfile", "User", new { user.userID });
            }
            else
            {
                var instructor = DB.instructorTBs.FirstOrDefault(x => x.instructorMail == model.userMail && x.password == model.Password);
                if (instructor != null)
                {
                    Session["instructorName"] = instructor.instructorName;
                    Session["instructorID"] = instructor.instructorID;
                    return RedirectToAction("InstructorProfile", "Instructor", new { instructor.instructorID });
                }
                else 
                {
                    var admin = DB.adminTBs.FirstOrDefault(x => x.adminMail == model.userMail && x.adminPass == model.Password);
                    if (admin != null)
                    {
                        Session["adminName"] = admin.adminMail;
                        Session["adminID"] = admin.adminID;
                        return RedirectToAction("AdminProfile", "Admin", new { admin.adminID });
                    }
                    else
                    return RedirectToAction("Login");
                }
            }
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