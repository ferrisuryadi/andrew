using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtQuotation
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Code maksimal 50 karakter")]
        [Required(ErrorMessage = "Code harus di isi")]
        [Display(Name = "Code")]
        public string code { get; set; }

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
    }
}
