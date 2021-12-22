using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoFirstWebApplication.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }

        public override string ToString()
        {
            return "Product Id: " + this.ProductId
                + "\nProduct Name: " + this.ProductName
                + "\nProduct Price: " + this.ProductPrice;
                
        }
    }
}