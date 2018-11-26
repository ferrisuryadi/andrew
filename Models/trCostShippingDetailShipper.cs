using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class trCostShippingDetailShipper
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Cost Shipping")]
        public int costShippingId { get; set; }

        [Display(Name = "Cost Detail Shipping")]
        public int costShippingDetailId { get; set; }

        [Display(Name = "Shipper")]
        public int shipperId { get; set; }

        [MaxLength(50, ErrorMessage = "Shipper Code maksimal 50 karakter")]
        [Required(ErrorMessage = "Shipper Code harus di isi")]
        [Display(Name = "Shipper Code")]
        public string shipperCode { get; set; }

        [MaxLength(50, ErrorMessage = "Shipper Name maksimal 50 karakter")]
        [Required(ErrorMessage = "Shipper Name harus di isi")]
        [Display(Name = "Shipper Name")]
        public string shipperName { get; set; }

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

        [ForeignKey("costShippingId")]
        public trCostShipping costShipping { get; set; }

        [ForeignKey("costShippingDetailId")]
        public trCostShippingDetail costShippingDetail { get; set; }

        [ForeignKey("shipperId")]
        public mtShipper shipper { get; set; }
    }

    public class trCostShippingDetailShipperLoad
    {
        public int costShippingId { get; set; }
        public int costShippingDetailId { get; set; }
    }
}
