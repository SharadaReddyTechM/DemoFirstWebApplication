using DemoFirstWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoFirstWebApplication.Controllers
{
    public class ProductController : Controller
    {
        List<Product> prdList = new List<Product>
        {
            new Product{ProductId=101,ProductName="Laptop",ProductPrice=55000},
            new Product{ProductId=102,ProductName="Projector",ProductPrice=89000},
            new Product{ProductId=103,ProductName="Scanner",ProductPrice=67000},
            new Product{ProductId=104,ProductName="Printer",ProductPrice=7500}
        };
        // GET: Product
        //public string Index()
        //{
        //    return "Hello from Index Action method in Product Controller class<br/>Hello all";
        //}

        public ActionResult Index()
        {
            Product prd = new Product { ProductId = 101, ProductName = "Laptop", ProductPrice = 89000 };
            //return prd;//with this, the fully qualified name gets printed
            //return prd;//after the ToString() method being overriden, the content i.e., the details of the object are getting printed
            //ViewBag.ProductId = prd.ProductId;

            //ViewBag.ProductName = prd.ProductName;

            //ViewData["ProductPrice"] = prd.ProductPrice;

            //ViewBag.ProductObj = prd;
            ViewBag.PrdList = prdList;
            return View();
        }

        public ActionResult ViewProduct1()
        {
            Product prd = new Product { ProductId = 101, ProductName = "Laptop", ProductPrice = 89000 };           
            return View(prd);//strongly typed view           

        }
        public ActionResult ViewProduct()
        {
            Product prd = new Product { ProductId = 101, ProductName = "Laptop", ProductPrice = 89000 };
            return View(prd);//strongly typed view           

        }
        public int ProductCount()
        {
            return 100;
        }
    }
}