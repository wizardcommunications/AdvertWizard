using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertWizard.Model
{
    [Table("User")]
    public class User
    {

        [Key]
        [Display(Name = "UserId"), MaxLength(8)]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "OrganizationId"), MaxLength(8)]
        public string OrganizationId { get; set; }

        [Required]
        [Display(Name = "FirstName"), MaxLength(500)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "LastName"), MaxLength(500)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "ContactNumber"), MaxLength(40)]
        public string ContactNumber { get; set; }

        [Display(Name = "Email"), MaxLength(40)]
        public string Email { get; set; }

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

        [Required]
        [Display(Name = "UserName"), MaxLength(500)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password"), MaxLength(500)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "IsAdminUser")]
        public bool IsAdminUser { get; set; }

        [Required]
        [Display(Name = "IsSuperUser")]
        public bool IsSuperUser { get; set; }

        [Required]
        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "CreatedBy")]
        public int CreatedBy { get; set; }

        [Display(Name = "UpdatedAt")]
        public DateTime UpdatedAt { get; set; }

        [Display(Name = "UpdatedBy")]
        public int UpdatedBy { get; set; }

    }
}

