using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtPortTerminal
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "ort Of Loading harus di isi")]
        [Display(Name = "Port Of Loading")]
        public int portOfLoadingId { get; set; }

        [MaxLength(50, ErrorMessage = "Terminal Port maksimal 50 karakter")]
        [Required(ErrorMessage = "Terminal Port harus di isi")]
        [Display(Name = "Terminal Port")]
        public string terminalPort { get; set; }

        [MaxLength(500, ErrorMessage = "Address maksimal 500 karakter")]
        [Required(ErrorMessage = "Address harus di isi")]
        [Display(Name = "Address")]
        public string address { get; set; }

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

        [ForeignKey("portOfLoadingId")]
        public mtPortOfLoading portOfLoading { get; set; }
    }
}
