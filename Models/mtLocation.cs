using System;
using System.ComponentModel.DataAnnotations;

namespace fms.Models
{
    public class mtLocation
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(500, ErrorMessage = "Location maksimal 500 karakter")]
        [Required(ErrorMessage = "Location harus di isi")]
        [Display(Name = "Location")]
        public string location { get; set; }

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
