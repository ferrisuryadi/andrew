using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtAgent
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

        [MaxLength(50, ErrorMessage = "Postal Code maksimal 50 karakter")]
        [Required(ErrorMessage = "Postal Code harus di isi")]
        [Display(Name = "Postal Code")]
        public string postalCode { get; set; }

        [Display(Name = "Location")]
        public int? portOfDestinationId { get; set; }

        [Display(Name = "Type")]
        public int? typeId { get; set; }

        [Display(Name = "Agent Dari")]
        public int? shipperId { get; set; }

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

        [ForeignKey("portOfDestinationId")]
        public mtPortOfDestination portOfDestination { get; set; }

        [ForeignKey("typeId")]
        public mtType type { get; set; }

        [ForeignKey("shipperId")]
        public mtShipper shipper { get; set; }

        public ICollection<mtAgentDetails> agentDetails { get; set; }
        public ICollection<mtAgentProfitShared> agentProfitShareds { get; set; }
        public ICollection<mtProfitShared> profitShareds { get; set; }
    }
}
