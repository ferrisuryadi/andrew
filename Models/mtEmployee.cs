using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtEmployee
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Code maksimal 50 karakter")]
        [Required(ErrorMessage = "Code harus di isi")]
        [Display(Name = "Company")]
        public string code { get; set; }

        [MaxLength(250, ErrorMessage = "Name maksimal 250 karakter")]
        [Required(ErrorMessage = "Name harus di isi")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [MaxLength(50, ErrorMessage = "Initial maksimal 50 karakter")]
        [Required(ErrorMessage = "Initial harus di isi")]
        [Display(Name = "Initial")]
        public string initial { get; set; }

        [MaxLength(500, ErrorMessage = "Address maksimal 500 karakter")]
        [Required(ErrorMessage = "Address harus di isi")]
        [Display(Name = "Address")]
        public string address { get; set; }

        [Display(Name = "Join Date")]
        [Required(ErrorMessage = "Join Date harus di isi")]
        public DateTime joinDate { get; set; }

        [MaxLength(50, ErrorMessage = "Email maksimal 50 karakter")]
        [Required(ErrorMessage = "Email harus di isi")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [MaxLength(50, ErrorMessage = "HP maksimal 50 karakter")]
        [Required(ErrorMessage = "HP harus di isi")]
        [Display(Name = "HP")]
        public string handphone { get; set; }

        [MaxLength(50, ErrorMessage = "Phone maksimal 50 karakter")]
        [Required(ErrorMessage = "Phone harus di isi")]
        [Display(Name = "Phone")]
        public string phone { get; set; }

        [MaxLength(50, ErrorMessage = "KTP maksimal 50 karakter")]
        [Required(ErrorMessage = "KTP harus di isi")]
        [Display(Name = "KTP")]
        public string idCard { get; set; }

        [Required(ErrorMessage = "Picture harus di isi")]
        [Display(Name = "Picture")]
        public string pictureUrl { get; set; }

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
