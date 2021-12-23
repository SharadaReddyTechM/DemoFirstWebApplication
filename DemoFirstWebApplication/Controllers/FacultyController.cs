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
        // GET: Faculty
        public ActionResult Index()
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
            if (Session["username"].ToString() != string.Empty && Session["userType"].ToString() != null)
            {
                if ((int)Session["userType"] == 1)
                {
                    //return Content("Welcome " + Session["username"] + " to Faculty Management Portal" + "<br/>You have logged in as Admin");
                    dbContextObj = new vizagdbEntities();
                    var emps = dbContextObj.tblemployees.ToList();
                    return View(emps);
                }
                else if (Session["username"].ToString() != string.Empty && Session["userType"].ToString() != null && (int)Session["userType"] == 2)
                {
                    return Content("Welcome " + Session["username"] + " to Faculty Management Portal" + "<br/>You have logged in as Faculty");
                }
                else
                {
                    return RedirectToAction("InvalidLogin", "Account");
                }
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }

        }

        // GET: Faculty/Details/5
        public ActionResult Details(string id)
        {
            return View();
        }

        // GET: Faculty/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Faculty/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: Faculty/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
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
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: Faculty/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
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
