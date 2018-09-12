using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertWizard.Model
{
        [Table("Campaign")]
        public class Campaign
        {

            [Key]
            [Display(Name = "CampaignId"), MaxLength(8)]
            public string CampaignId { get; set; }

            [Required]
            [Display(Name = "CampaignName"), MaxLength(400)]
            public string CampaignName { get; set; }

            [Required]
            [Display(Name = "OrganisationId"), MaxLength(8)]
            public string OrganisationId { get; set; }

            [Required]
            [Display(Name = "OperatingUnitId"), MaxLength(8)]
            public string OperatingUnitId { get; set; }

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

