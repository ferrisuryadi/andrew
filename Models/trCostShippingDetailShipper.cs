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

        [Required(ErrorMessage = "Container harus di isi")]
        [Display(Name = "Container")]
        public int containerId { get; set; }

        [Required(ErrorMessage = "Currency harus di isi")]
        [Display(Name = "Currency")]
        public int currencyId { get; set; }

        [Required(ErrorMessage = "Port Of Destination harus di isi")]
        [Display(Name = "Port Of Destination")]
        public int portOfDestinationId { get; set; }

        [Required(ErrorMessage = "Operation Monitoring harus di isi")]
        [Display(Name = "Operation Monitoring")]
        public decimal operationMonitoring { get; set; }

        [Required(ErrorMessage = "Operation Monitoring Type harus di isi")]
        [Display(Name = "Operation Monitoring Type")]
        public int operationMonitoringType { get; set; } //1: Percentage; 2: Amount;

        [Display(Name = "Payable")]
        public string payable { get; set; }

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

        [ForeignKey("portOfDestinationId")]
        public mtPortOfDestination portOfDestination { get; set; }

        [ForeignKey("containerId")]
        public mtContainer container { get; set; }

        [ForeignKey("currencyId")]
        public mtCurrency currency { get; set; }
    }

    public class trCostShippingDetailShipperLoad
    {
        public int costShippingId { get; set; }
        public int costShippingDetailId { get; set; }
    }

    public class trCostShippingDetailShipperModel
    {
        public int id { get; set; }
        public int costShippingId { get; set; }
        public int costShippingDetailId { get; set; }
        public string container { get; set; }
        public string currency { get; set; }
        public string portOfDestination { get; set; }
        public decimal operationMonitoring { get; set; }
        public string operationMonitoringType { get; set; } //1: Percentage; 2: Amount;
        public string payable { get; set; }
        public string shipperCode { get; set; }
        public string shipperName { get; set; }
    }
}