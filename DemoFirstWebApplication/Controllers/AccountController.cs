using DemoFirstWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoFirstWebApplication.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        //By default all action methods are get method or get request methods only\
        [HttpGet]
        public ActionResult SignIn()
        {
            //var user = new UserDetails{ Username = "sa", Password = "password@123" };
            var user = new UserDetails();

            return View(user);
        }
        [HttpPost]
        public ActionResult SignIn(UserDetails usr)
        {
            if (usr.Username == "sa" && usr.Password == "pass@123")
            {
                //store data into the session variables
                Session["user"] = usr.Username;
                return RedirectToAction("AdminHomePage");
            }
            else
                return Content("Invalid User Credentials, Please login again");
        }

        public ActionResult AdminHomePage()
        {
            return View();
        }
    }
}