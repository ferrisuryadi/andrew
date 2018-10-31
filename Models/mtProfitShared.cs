using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtProfitShared
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Agent")]
        public int? agentId { get; set; }

        [Display(Name = "Country")]
        public int? countryId { get; set; }

        [MaxLength(50, ErrorMessage = "RefNo maksimal 50 karakter")]
        [Required(ErrorMessage = "RefNo harus di isi")]
        [Display(Name = "RefNo")]
        public string refNo { get; set; }

        [Display(Name = "Tanggal")]
        public DateTime txDate { get; set; }

        [Display(Name = "Valid Date")]
        public DateTime txValidDate { get; set; }

        [Display(Name = "PS Condition")]
        public int psCondition { get; set; }

        [Display(Name = "PS For Agent")]
        public double psForAgent { get; set; }

        [Display(Name = "PS Condition")]
        public double rebateForTsk { get; set; }

        [MaxLength(50, ErrorMessage = "Input By maksimal 50 karakter")]
        [Required(ErrorMessage = "Input By harus di isi")]
        [Display(Name = "Input By")]
        public string inputBy { get; set; }

        [MaxLength(500, ErrorMessage = "Remark maksimal 500 karakter")]
        [Required(ErrorMessage = "Remark harus di isi")]
        [Display(Name = "Remark")]
        public string remark { get; set; }

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

        [ForeignKey("agentId")]
        public mtAgent agents { get; set; }

        [ForeignKey("countryId")]
        public mtCountry country { get; set; }

        public ICollection<mtProfitSharedDetails> profitSharedDetails { get; set; }
    }
}
