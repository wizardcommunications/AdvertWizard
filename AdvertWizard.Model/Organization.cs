using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertWizard.Model
{
    [Table("Organization")]
    public class Organization
    {
        [Key]
        [Display(Name = "OrganizationId"), MaxLength(8)]
        public string OrganizationId { get; set; }

        [Display(Name = "Name"), MaxLength(500)]
        public string Name { get; set; }

        [Display(Name = "OwnerName"), MaxLength(500)]
        public string OwnerName { get; set; }

        [Display(Name = "Address1"), MaxLength(500)]
        public string Address1 { get; set; }

        [Display(Name = "Address2"), MaxLength(500)]
        public string Address2 { get; set; }

        [Display(Name = "City"), MaxLength(40)]
        public string City { get; set; }

        [Display(Name = "State"), MaxLength(40)]
        public string State { get; set; }

        [Display(Name = "Country"), MaxLength(40)]
        public string Country { get; set; }

        [Display(Name = "Zip"), MaxLength(40)]
        public string Zip { get; set; }

        [Display(Name = "Email"), MaxLength(40)]
        public string Email { get; set; }

        [Display(Name = "MobileNumber"), MaxLength(40)]
        public string MobileNumber { get; set; }

        [Display(Name = "AlternateNumber"), MaxLength(40)]
        public string AlternateNumber { get; set; }

        [Display(Name = "Logo"), MaxLength(1000)]
        public string Logo { get; set; }

        [Required]
        [Display(Name = "ConnectionString"), MaxLength(200)]
        public string ConnectionString { get; set; }

        [Required]
        [Display(Name = "StoragePath"), MaxLength(400)]
        public string StoragePath { get; set; }

        [Required]
        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }

        [Display(Name = "CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "UpdatedBy")]
        public int UpdatedBy { get; set; }

        [Display(Name = "UpdatedAt")]
        public DateTime UpdatedAt { get; set; }

    }

}

