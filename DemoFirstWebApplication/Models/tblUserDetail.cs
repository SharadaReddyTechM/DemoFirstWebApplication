//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoFirstWebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblUserDetail
    {
        public int regno { get; set; }

        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="Please enter your full name")]
        public string fullname { get; set; }


        [Display(Name ="Email Id")]
        [Required(ErrorMessage ="Please enter email id")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage ="Please enter valid Email address")]
        public string email { get; set; }


        [Display(Name ="Mobile Number")]
        [Required(ErrorMessage ="Please enter mobile number")]
        [RegularExpression(@"[6-9]{1}\d{9}",ErrorMessage ="Please enter 10-digit mobile number")]
        public string mobile { get; set; }

        [Required(ErrorMessage ="Please enter username")]
        public string username { get; set; }

        [Display(Name ="Password")]
        [Required(ErrorMessage ="Please enter password")]
        [StringLength(15,MinimumLength =3,ErrorMessage ="Password must be between 3 character to 15 character long")]
        public string password { get; set; }

        [Required(ErrorMessage ="Please select the Usertype")]
        public Nullable<int> usertype { get; set; }
    
        public virtual tblUserType tblUserType { get; set; }
    }
}