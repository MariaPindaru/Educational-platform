//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolPlatform.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prof_Subj_Class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prof_Subj_Class()
        {
            this.Documents = new HashSet<Document>();
        }
    
        public int ProfSubjClassID { get; set; }
        public int ProfSubjID { get; set; }
        public int YearSpecID { get; set; }
        public int Hours_per_week { get; set; }
        public bool FinalTestRequired { get; set; }
    
        public virtual Professor_Subject Professor_Subject { get; set; }
        public virtual Year_Specializaion Year_Specializaion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents { get; set; }
    }
}