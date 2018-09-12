using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertWizard.Model
{
    [Table("MenuRoleMapping")]
    public class MenuRoleMapping
    {

        [Key]
        [Display(Name = "MenuRoleMappingId")]
        public int MenuRoleMappingId { get; set; }

        [Required]
        [Display(Name = "MenuId")]
        public int MenuId { get; set; }

        [Required]
        [Display(Name = "RoleId")]
        public int RoleId { get; set; }

        [Required]
        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "CreatedBy")]
        public int CreatedBy { get; set; }

        [Required]
        [Display(Name = "CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "UpdatedBy")]
        public int UpdatedBy { get; set; }

        [Display(Name = "UpdatedAt")]
        public DateTime UpdatedAt { get; set; }

    }

}
