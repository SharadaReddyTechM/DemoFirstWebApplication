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
    
    public partial class tblStudent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblStudent()
        {
            this.tblStudentScores = new HashSet<tblStudentScore>();
        }
    
        public int studId { get; set; }
        public string studName { get; set; }
        public string studMobile { get; set; }
        public Nullable<int> studAge { get; set; }
        public string studGender { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStudentScore> tblStudentScores { get; set; }
    }
}
