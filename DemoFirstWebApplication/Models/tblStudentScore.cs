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
    
    public partial class tblStudentScore
    {
        public int slno { get; set; }
        public Nullable<int> stid { get; set; }
        public Nullable<int> subject1 { get; set; }
        public Nullable<int> subject2 { get; set; }
        public Nullable<int> subject3 { get; set; }
        public Nullable<int> subj1Attempts { get; set; }
        public Nullable<int> subj2Attempts { get; set; }
        public Nullable<int> subj3Attempts { get; set; }
    
        public virtual tblStudent tblStudent { get; set; }
    }
}
