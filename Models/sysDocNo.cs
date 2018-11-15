using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class sysDocNo
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(100, ErrorMessage = "Module maksimal 100 karakter")]
        [Required(ErrorMessage = "Module harus di isi")]
        [Display(Name = "Module")]
        public string module { get; set; }

        [MaxLength(20, ErrorMessage = "Document Type maksimal 20 karakter")]
        [Required(ErrorMessage = "Document Type harus di isi")]
        [Display(Name = "Document Type")]
        public string documentType { get; set; }

        [MaxLength(50, ErrorMessage = "Number Format maksimal 50 karakter")]
        [Required(ErrorMessage = "Number Format harus di isi")]
        [Display(Name = "Number Format")]
        public string numberFormat { get; set; }

        [MaxLength(20, ErrorMessage = "Prefix maksimal 20 karakter")]
        [Required(ErrorMessage = "Prefix harus di isi")]
        [Display(Name = "Prefix")]
        public string prefix { get; set; }

        [Required(ErrorMessage = "Next Doc No harus di isi")]
        [Display(Name = "Next Doc No")]
        public int nextDocNo { get; set; }

        [MaxLength(20, ErrorMessage = "Suffix maksimal 20 karakter")]
        [Required(ErrorMessage = "Suffix harus di isi")]
        [Display(Name = "Suffix")]
        public string suffix { get; set; }

        [Required(ErrorMessage = "Last Year harus di isi")]
        [Display(Name = "Last Year")]
        public int lastYear { get; set; }

        [Required(ErrorMessage = "Last Month harus di isi")]
        [Display(Name = "Last Month")]
        public int lastMonth { get; set; }

        [Required(ErrorMessage = "Last Day harus di isi")]
        [Display(Name = "Last Day")]
        public int lastDay { get; set; }

        [Required(ErrorMessage = "Reset Level harus di isi")]
        [Display(Name = "Reset Level")]
        //1 = reset per day, 2 = reset per months, 3 = reset per years
        public int resetLevel { get; set; }

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
