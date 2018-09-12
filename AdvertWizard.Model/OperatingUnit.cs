using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertWizard.Model
{
    [Table("OperatingUnit")]
    public class OperatingUnit
    {

        [Key]
        [Display(Name = "OperatingUnitId"), MaxLength(8)]
        public string OperatingUnitId { get; set; }

        [Required]
        [Display(Name = "OrganizationId"), MaxLength(8)]
        public string OrganizationId { get; set; }

        [Display(Name = "Name"), MaxLength(500)]
        public string Name { get; set; }

        [Display(Name = "Description"), MaxLength(500)]
        public string Description { get; set; }

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

        [Required]
        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Display(Name = "CreatedBy")]
        public int CreatedBy { get; set; }

        [Display(Name = "UpdatedBy")]
        public int UpdatedBy { get; set; }

        [Display(Name = "UpdatedAt")]
        public DateTime UpdatedAt { get; set; }

    }
}
