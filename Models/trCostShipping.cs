using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class trCostShipping
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Ref No maksimal 50 karakter")]
        [Required(ErrorMessage = "Ref No harus di isi")]
        [Display(Name = "Ref No")]
        public string referenceNo { get; set; }

        [Display(Name = "Shipping Date")]
        [Required(ErrorMessage = "Shipping Date harus di isi")]
        public DateTime shippingDate { get; set; }

        [Display(Name = "Valid Date")]
        [Required(ErrorMessage = "Valid Date harus di isi")]
        public DateTime validDate { get; set; }

        [Display(Name = "Port Of Loading")]
        public int? portOfLoadingId { get; set; }

        [Display(Name = "Sales")]
        public int? userIdSales { get; set; }

        [MaxLength(50, ErrorMessage = "Ship Line Ref No maksimal 50 karakter")]
        [Required(ErrorMessage = "Ship Line Ref No harus di isi")]
        [Display(Name = "shipLineRefNo")]
        public string shipLineRefNo { get; set; }

        [MaxLength(50, ErrorMessage = "Shipping Info Kode maksimal 50 karakter")]
        [Required(ErrorMessage = "Shipping Info Kode harus di isi")]
        [Display(Name = "Shipping Info Kode")]
        public string shippingInfoKode { get; set; }

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

        [ForeignKey("portOfLoadingId")]
        public mtPortOfLoading portOfLoading { get; set; }

        [ForeignKey("userIdSales")]
        public mtUser user { get; set; }

        public ICollection<trCostShippingDetails> costShippingDetails { get; set; }
        public ICollection<trCostShippingShipper> costShippingShippers { get; set; }
    }
}
