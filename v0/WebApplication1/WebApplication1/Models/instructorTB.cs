//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scholar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class instructorTB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public instructorTB()
        {
            this.courseTBs = new HashSet<courseTB>();
        }
    
        public int instructorID { get; set; }
        public string instructorName { get; set; }
        public string instructorMail { get; set; }
        public string password { get; set; }
        public string instructorImage { get; set; }
        public string instructorDocumet { get; set; }
        public string instructorStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courseTB> courseTBs { get; set; }
    }
}
