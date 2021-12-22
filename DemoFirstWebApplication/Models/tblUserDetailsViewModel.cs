using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoFirstWebApplication.Models
{
    partial class tblUserDetail
    {
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Please enter confirm password")]
        [Compare("password",ErrorMessage ="Password and Confirm Password mismatches")]
        public string confirmpassword { get; set; }
    }
}