using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtServices
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Code maksimal 50 karakter")]
        [Required(ErrorMessage = "Code harus di isi")]
        [Display(Name = "Code")]
        public string code { get; set; }

        [MaxLength(50, ErrorMessage = "Description maksimal 50 karakter")]
        [Required(ErrorMessage = "Description harus di isi")]
        [Display(Name = "Description")]
        public string description { get; set; }

        [Display(Name = "COA USD")]
        public int? coaIdUsd { get; set; }

        [Display(Name = "COA IDR")]
        public int? coaIdIdr { get; set; }

        [Display(Name = "Group")]
        public int? groupId { get; set; }

        [Display(Name = "Harga Per Con")]
        public int hargaPerCon { get; set; }

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

        [ForeignKey("groupId")]
        public mtGroups groups { get; set; }

        [ForeignKey("coaIdUsd")]
        public mtChartOfAccount coaUsd { get; set; }

        [ForeignKey("coaIdIdr")]
        public mtChartOfAccount coaIdr { get; set; }
    }
}
