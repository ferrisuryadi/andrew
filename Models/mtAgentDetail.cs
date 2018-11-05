using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtAgentDetails
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Agent")]
        public int agentId { get; set; }

        [MaxLength(50, ErrorMessage = "Contact Person maksimal 50 karakter")]
        [Required(ErrorMessage = "Contact Person harus di isi")]
        [Display(Name = "Contact Person")]
        public string contactPerson { get; set; }

        [MaxLength(50, ErrorMessage = "Telepon maksimal 50 karakter")]
        [Required(ErrorMessage = "Telepon harus di isi")]
        [Display(Name = "Telepon")]
        public string telepon { get; set; }

        [MaxLength(50, ErrorMessage = "Position maksimal 50 karakter")]
        [Required(ErrorMessage = "Position harus di isi")]
        [Display(Name = "Position")]
        public string position { get; set; }

        [MaxLength(500, ErrorMessage = "Address maksimal 500 karakter")]
        [Required(ErrorMessage = "Address harus di isi")]
        [Display(Name = "Address")]
        public string address { get; set; }

        [MaxLength(50, ErrorMessage = "Handphone maksimal 50 karakter")]
        [Required(ErrorMessage = "Handphone harus di isi")]
        [Display(Name = "Handphone")]
        public string handphone { get; set; }

        [MaxLength(50, ErrorMessage = "Email maksimal 50 karakter")]
        [Required(ErrorMessage = "Email harus di isi")]
        [Display(Name = "Email")]
        public string email { get; set; }

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
        public mtAgent agent { get; set; }
    }
}
