using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fms.Models
{
    public class mtContainer
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Type Of Container maksimal 50 karakter")]
        [Required(ErrorMessage = "Type Of Container harus di isi")]
        [Display(Name = "Type Of Container")]
        public string typeofContainer { get; set; }

        [MaxLength(50, ErrorMessage = "Interior Dimension maksimal 50 karakter")]
        [Required(ErrorMessage = "Interior Dimension harus di isi")]
        [Display(Name = "Interior Dimension")]
        public string interiorDimension { get; set; }

        [MaxLength(50, ErrorMessage = "Door Opening maksimal 50 karakter")]
        [Required(ErrorMessage = "Door Opening harus di isi")]
        [Display(Name = "Door Opening")]
        public string doorOpening { get; set; }

        [MaxLength(50, ErrorMessage = "Tare Weight maksimal 50 karakter")]
        [Required(ErrorMessage = "Tare Weight harus di isi")]
        [Display(Name = "Tare Weight")]
        public string tareWeight { get; set; }

        [MaxLength(50, ErrorMessage = "Cubic Capacity maksimal 50 karakter")]
        [Required(ErrorMessage = "Cubic Capacity harus di isi")]
        [Display(Name = "Cubic Capacity")]
        public string cubicCapacity { get; set; }

        [MaxLength(50, ErrorMessage = "Payload maksimal 50 karakter")]
        [Required(ErrorMessage = "Payload harus di isi")]
        [Display(Name = "Payload")]
        public string payload { get; set; }

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

        public ICollection<mtAgentProfitShared> agentProfitShareds { get; set; }
        public ICollection<mtProfitShared> profitShareds { get; set; }
    }
}
