//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FPT_Final.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trainer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainer()
        {
            this.Links = new HashSet<Link>();
        }
    
        public long TrainerID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TrainerCode { get; set; }
        public string Name { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
        public string Education { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Link> Links { get; set; }
    }
}