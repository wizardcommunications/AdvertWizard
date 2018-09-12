using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertWizard.Model
{
    [Table("Module")]
    public class Module
    {

        [Key]
        [Display(Name = "ModuleId")]
        public int ModuleId { get; set; }

        [Required]
        [Display(Name = "Name"), MaxLength(500)]
        public string Name { get; set; }

        [Display(Name = "Description"), MaxLength(500)]
        public string Description { get; set; }

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
