using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoFirstWebApplication.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter username")]
        [Display(Name ="Username")]
        public string username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter password")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Password must be between 3 character to 15 character long")]
        public string password { get; set; }

        [Required(ErrorMessage = "Please select the Usertype")]
        [Display(Name ="Usertype")]
        public Nullable<int> usertype { get; set; }
    }
}