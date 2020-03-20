using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class InstructorController : Controller
    {
        // GET: Instructor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InstructorProfile()
        {
            if (Session["instructorID"] != null)
            {

                return View();
            }
            else { return RedirectToAction("Login", "Home"); }
        }
    }
}