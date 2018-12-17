using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class trSellingShipperDetailVendor
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Selling Shipper Header")]
        public int sellingShipperId { get; set; }

        [Display(Name = "Selling Shipper Detail")]
        public int sellingShipperDetailId { get; set; }

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
        public decimal operationCost { get; set; }

        [Required(ErrorMessage = "Operation Monitoring Type harus di isi")]
        [Display(Name = "Operation Monitoring Type")]
        public int operationCostType { get; set; } //1: Percentage; 2: Amount;

        [Display(Name = "Payable")]
        public string payable { get; set; }

        [Display(Name = "Vendor Id")]
        public int vendorId { get; set; }

        [MaxLength(50, ErrorMessage = "Vendor Code maksimal 50 karakter")]
        [Required(ErrorMessage = "Vendor Code harus di isi")]
        [Display(Name = "Vendor Code")]
        public string vendorCode { get; set; }

        [MaxLength(50, ErrorMessage = "Vendor Name maksimal 50 karakter")]
        [Required(ErrorMessage = "Vendor Name harus di isi")]
        [Display(Name = "Vendor Name")]
        public string vendorName { get; set; }

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

        [ForeignKey("sellingShipperId")]
        public trSellingShipper sellingShipper { get; set; }

        [ForeignKey("sellingShipperDetailId")]
        public trSellingShipperDetail sellingShipperDetail { get; set; }

        [ForeignKey("vendorId")]
        public mtVendor vendor { get; set; }

        [ForeignKey("portOfDestinationId")]
        public mtPortOfDestination portOfDestination { get; set; }

        [ForeignKey("containerId")]
        public mtContainer container { get; set; }

        [ForeignKey("currencyId")]
        public mtCurrency currency { get; set; }
    }

    public class trSellingShipperDetailVendorLoad
    {
        public int sellingShipperId { get; set; }
        public int sellingShipperDetailId { get; set; }
    }

    public class trSellingShipperDetailVendorModel
    {
        public int id { get; set; }
        public int sellingShipperId { get; set; }
        public int sellingShipperDetailId { get; set; }
        public string container { get; set; }
        public string currency { get; set; }
        public string portOfDestination { get; set; }
        public decimal operationCost { get; set; }
        public string operationCostType { get; set; } //1: Percentage; 2: Amount;
        public string payable { get; set; }
        public string vendorCode { get; set; }
        public string vendorName { get; set; }
    }
}
