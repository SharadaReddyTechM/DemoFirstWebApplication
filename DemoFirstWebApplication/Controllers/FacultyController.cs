using DemoFirstWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoFirstWebApplication.Controllers
{
    public class FacultyController : Controller
    {
        vizagdbEntities dbContextObj = null;
        public ActionResult Home()
        {
            return View();
        }

        // GET: Faculty
        public ActionResult AllFaculties()
        {
            #region Complex code for user session activeness and as well user type who logged in
            //if (Session["username"].ToString() != string.Empty && Session["userType"].ToString() != null && (int)Session["userType"] == 1)
            //{
            //    return Content("Welcome " + Session["username"] + " to Faculty Management Portal" + "<br/>You have logged in as Admin");
            //}
            //else if (Session["username"].ToString() != string.Empty && Session["userType"].ToString() != null && (int)Session["userType"] == 1)
            //{
            //    return Content("Welcome " + Session["username"] + " to Faculty Management Portal" + "<br/>You have logged in as Faculty");
            //}
            //else
            //{
            //    return RedirectToAction("InvalidLogin", "Account");
            //}
            #endregion
            //if (Session["username"].ToString() != string.Empty && Session["userType"].ToString() != null)
            //{
            //    if ((int)Session["userType"] == 1)
            //    {
                    //return Content("Welcome " + Session["username"] + " to Faculty Management Portal" + "<br/>You have logged in as Admin");
                    dbContextObj = new vizagdbEntities();
                    var emps = dbContextObj.tblemployees.ToList();
                    return View(emps);
            //    }
            //    else if (Session["username"].ToString() != string.Empty && Session["userType"].ToString() != null && (int)Session["userType"] == 2)
            //    {
            //        return Content("Welcome " + Session["username"] + " to Faculty Management Portal" + "<br/>You have logged in as Faculty");
            //    }
            //    else
            //    {
            //        return RedirectToAction("InvalidLogin", "Account");
            //    }
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Account");
            //}

        }

        // GET: Faculty/Details/5
        public ActionResult ViewFaculty()
        {
            dbContextObj = new vizagdbEntities();

            return View(dbContextObj.tblemployees.ToList());
        }

        public ActionResult ShowFaculty(string id)
        {
            dbContextObj = new vizagdbEntities();
            var emp = dbContextObj.tblemployees.FirstOrDefault(e => e.empid == id);
            if (emp != null)
            {
                return View(emp);
            }

            else
                return Content("No such employee exists with given Employee Id");
        }

        // GET: Faculty/Create
        public ActionResult AddFaculty()
        {
            tblemployee emp = new tblemployee();
            return View(emp);
        }

        // POST: Faculty/Create
        [HttpPost]
        public ActionResult AddFaculty(tblemployee emp)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Faculty/Edit/5
        public ActionResult ModifyFaculty(string id)
        {
            tblemployee emp = new tblemployee();
            return View(emp);
        }

        // POST: Faculty/Edit/5
        [HttpPost]
        public ActionResult ModifyFaculty(string id, tblemployee emp)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Faculty/Delete/5
        public ActionResult DeleteFaculty(string id)
        {
            tblemployee emp = new tblemployee();
            return View(emp);
        }

        // POST: Faculty/Delete/5
        [HttpPost]
        public ActionResult DeleteFaculty(string id, tblemployee emp)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
