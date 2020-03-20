using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult UserProfile(int userID)
        {
            if (Session["UserID"] != null)
            {

                return View();
            }
            else { return RedirectToAction("Login","Home"); }
        }
    }
}