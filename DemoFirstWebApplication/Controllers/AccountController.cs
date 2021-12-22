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
        vizagdbEntities dbContextObj = null;
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

        [HttpGet]
        public ActionResult Register()
        {
            dbContextObj = new vizagdbEntities();
            tblUserDetail usr = new tblUserDetail();
            if (usr != null)
                return View(usr);
            else
                return Content("OOPS....<br/>There are some network issues...please connect after sometime");
        }
        [HttpPost]
        public ActionResult Register(tblUserDetail userdetails)
        {
            dbContextObj = new vizagdbEntities();
            if (ModelState.IsValid)
            {
                if (dbContextObj != null)
                {
                    dbContextObj.tblUserDetails.Add(userdetails);
                    dbContextObj.SaveChanges();
                    return Content("Registration Successful..Please Login");
                }
                else
                    return Content("Registration is not successful...Please try again...");
            }
            else
                return View(userdetails);
        }
        public ActionResult Login()
        {

            return Content("You have clicked Login option");
        }

        public ActionResult AdminHomePage()
        {
            return View();
        }
    }
}