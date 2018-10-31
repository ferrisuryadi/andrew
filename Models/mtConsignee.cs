using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtConsignee
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Code maksimal 50 karakter")]
        [Required(ErrorMessage = "Code harus di isi")]
        [Display(Name = "Code")]
        public string code { get; set; }

        [MaxLength(50, ErrorMessage = "RefNo maksimal 50 karakter")]
        [Required(ErrorMessage = "RefNo harus di isi")]
        [Display(Name = "RefNo")]
        public string referenceNo { get; set; }

        [MaxLength(50, ErrorMessage = "Name maksimal 50 karakter")]
        [Required(ErrorMessage = "Name harus di isi")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [MaxLength(500, ErrorMessage = "Address maksimal 50 karakter")]
        [Required(ErrorMessage = "Address harus di isi")]
        [Display(Name = "Address")]
        public string address { get; set; }

        [MaxLength(50, ErrorMessage = "Dog maksimal 50 karakter")]
        [Required(ErrorMessage = "Dog harus di isi")]
        [Display(Name = "Dog")]
        public string dog { get; set; }

        [Display(Name = "Country")]
        public int? countryId { get; set; }

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

        [ForeignKey("countryId")]
        public mtCountry country { get; set; }
    }
}
