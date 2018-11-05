using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class trCostShippingDetails
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Cost Shipping Header")]
        public int costShippingId { get; set; }

        [Display(Name = "Service")]
        public int? serviceId { get; set; }

        [Display(Name = "Port Transipment")]
        public int? portTransipmentId { get; set; }

        [Display(Name = "Port Destination")]
        public int? portOfDestinationId { get; set; }

        [Display(Name = "Container")]
        public int? containerId { get; set; }

        [Display(Name = "P/C")]
        public int? pc { get; set; }

        [Display(Name = "Currency")]
        public int? currencyId { get; set; }

        [Required]
        [Display(Name = "Harga")]
        public double price { get; set; }

        [Display(Name = "Tax")]
        public int? taxId { get; set; }

        [Display(Name = "Vat")]
        public int? vatId { get; set; }

        [Required]
        [Display(Name = "All In")]
        public bool allIn { get; set; }

        [Required]
        [Display(Name = "Refund")]
        public double refund { get; set; }

        [MaxLength(500, ErrorMessage = "payable To maksimal 500 karakter")]
        [Required(ErrorMessage = "payable To harus di isi")]
        [Display(Name = "Payable To")]
        public string payableTo { get; set; }

        [Display(Name = "Destination")]
        public int? destinationId { get; set; }

        [Display(Name = "Shipper")]
        public int? shipperId { get; set; }

        [Display(Name = "OF / EMKL")]
        public int? ofEmkl { get; set; }

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

        [ForeignKey("costShippingId")]
        public trCostShipping costShipping { get; set; }

        [ForeignKey("serviceId")]
        public mtServices services { get; set; }

        [ForeignKey("portOfDestinationId")]
        public mtPortOfDestination portOfDestination { get; set; }

        [ForeignKey("containerId")]
        public mtContainer container { get; set; }

        [ForeignKey("currencyId")]
        public mtCurrency currency { get; set; }

        [ForeignKey("taxId")]
        public mtTax tax { get; set; }

        [ForeignKey("vatId")]
        public mtTax vat { get; set; }

        [ForeignKey("shipperId")]
        public mtShipper shipper { get; set; }
    }
}
