using System;
using System.ComponentModel.DataAnnotations;

namespace fms.Models
{
    public class mtTax
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(10, ErrorMessage = "Code maksimal 10 karakter")]
        [Required(ErrorMessage = "Code harus di isi")]
        [Display(Name = "Code")]
        public string code { get; set; }

        [Required(ErrorMessage = "Amount harus di isi")]
        [Display(Name = "Amount")]
        [Range(0, 9999999999999999.99)]
        public decimal amount { get; set; }

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

    public class mtTaxPreview
    {
        public int id { get; set; }
        public string code { get; set; }
        public string amount { get; set; }
        public bool isActive { get; set; }
        public string createdBy { get; set; }
        public string createdOn { get; set; }
        public string updatedBy { get; set; }
        public string updatedOn { get; set; }
    }
}
