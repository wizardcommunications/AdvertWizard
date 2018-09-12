using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertWizard.Model
{
    [Table("OperatingUnitUserMapping")]
    public class OperatingUnitUserMapping
    {

        [Key]
        [Display(Name = "OperatingUnitUserMappingId")]
        public int OperatingUnitUserMappingId { get; set; }

        [Display(Name = "OperatingUnitId"), MaxLength(8)]
        public string OperatingUnitId { get; set; }

        [Display(Name = "UserId"), MaxLength(8)]
        public string UserId { get; set; }

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
