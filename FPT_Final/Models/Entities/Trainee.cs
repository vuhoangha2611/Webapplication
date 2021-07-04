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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class Trainee
    {
        public Trainee()
        {
            Images = "~/Content/Images/add.png";
        }




        public int ID { get; set; }
        [Display(Name = "Image")]
        public string Images { get; set; }
        [Display(Name = "Name of trainee")]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Phone Number")]
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        [Display(Name = "Programming Language")]
        public string ProgrammingLanguage { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}