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
        [HttpGet]
        public ActionResult Login()
        {
            //tblUserDetail usr = new tblUserDetail();
            LoginViewModel usr = new LoginViewModel();
            return View(usr);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel usr)
        {
            dbContextObj = new vizagdbEntities();
            var usrFound = dbContextObj.tblUserDetails.FirstOrDefault(t => t.username == usr.username && t.password == usr.password && t.usertype == usr.usertype);
            if (usrFound != null)
            {
                Session["username"] = usr.username;
                Session["userType"] = usr.usertype;
                //Session["un"] = usr.username;
                //Session["ut"] = usr.usertype;
                //reading values from the session variables
                int usrtype = (int)Session["userType"];
                switch (usrtype)
                {
                    case 1://Usertype =1 means the user Admin
                        {
                            return RedirectToAction("Index","Admin");
                            //break;
                        }
                    case 2://Usertype =2 means the user Faculty
                        {
                            return RedirectToAction("Index","Faculty");
                            //break;
                        }
                    case 3://Usertype =3 means the user Student
                        {
                            return RedirectToAction("Index","Student");
                            //break;
                        }
                    default:
                        return RedirectToAction("InvalidLogin");
                        break;
                }
                
            }
            else
            {
                Session.Clear();
                Session.Abandon();
                //return Content("Invalid User Credentials, Please login again");
                return RedirectToAction("InvalidLogin");
            }
        }

        public ActionResult AdminHomePage()
        {
            return View();
        }
        public ActionResult InvalidLogin()
        {
            Session.Clear();
            Session.Abandon();
            ViewBag.ErrMsg = "Invalid User Credentials, Please login again";
            return View();
               
        }
    }
}