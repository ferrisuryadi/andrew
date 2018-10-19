using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtProfitSharedDetails
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Profit Shared")]
        public int profitSharedId { get; set; }

        [Display(Name = "Container")]
        public int containerId { get; set; }

        [MaxLength(50, ErrorMessage = "RefNo maksimal 50 karakter")]
        [Required(ErrorMessage = "RefNo harus di isi")]
        [Display(Name = "RefNo")]
        public string refNo { get; set; }

        [Display(Name = "PS For Agent")]
        public double psForAgent { get; set; }

        [Display(Name = "PS For TSK")]
        public double psForTsk { get; set; }

        [Display(Name = "PS Due For Agent")]
        public double psDueForAgent { get; set; }

        [Display(Name = "PS Due For TSK")]
        public double psDueForTsk { get; set; }

        [Required]
        [Display(Name = "Is Active")]
        public bool isActive { get; set; }

        [MaxLength(100)]
        [Display(Name = "Created By")]
        public string createdBy { get; set; }

        [Display(Name = "Created On")]
        public DateTime createdOn { get; set; }

        [MaxLength(100)]
        [Display(Name = "Updated By")]
        public string updatedBy { get; set; }

        [Display(Name = "Updated On")]
        public DateTime updatedOn { get; set; }

        [ForeignKey("profitSharedId")]
        public mtProfitShared profitShared { get; set; }

        [ForeignKey("containerId")]
        public mtContainer container { get; set; }
    }
}
