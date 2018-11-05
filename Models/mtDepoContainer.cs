using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtDepoContainer
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Code maksimal 50 karakter")]
        [Required(ErrorMessage = "Code harus di isi")]
        [Display(Name = "Code")]
        public string code { get; set; }

        [MaxLength(50, ErrorMessage = "Name maksimal 50 karakter")]
        [Required(ErrorMessage = "Name harus di isi")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [MaxLength(500, ErrorMessage = "Address maksimal 500 karakter")]
        [Required(ErrorMessage = "Address harus di isi")]
        [Display(Name = "Address")]
        public string address { get; set; }

        [MaxLength(50, ErrorMessage = "Email maksimal 50 karakter")]
        [Required(ErrorMessage = "Email harus di isi")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [MaxLength(50, ErrorMessage = "Website maksimal 50 karakter")]
        [Required(ErrorMessage = "Website harus di isi")]
        [Display(Name = "Website")]
        public string website { get; set; }

        [MaxLength(50, ErrorMessage = "Telepon maksimal 50 karakter")]
        [Required(ErrorMessage = "Telepon harus di isi")]
        [Display(Name = "Telepon")]
        public string telepon { get; set; }

        [MaxLength(50, ErrorMessage = "Fax maksimal 50 karakter")]
        [Required(ErrorMessage = "Fax harus di isi")]
        [Display(Name = "Fax")]
        public string fax { get; set; }

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

        public ICollection<mtDepoContainerDetails> depoContainerDetails { get; set; }
    }
}
