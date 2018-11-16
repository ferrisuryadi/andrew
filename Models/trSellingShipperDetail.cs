using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class trSellingShipperDetail
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Selling Shipper Header")]
        public int sellingShipperId { get; set; }

        [Required(ErrorMessage = "Item Of Service harus di isi")]
        [Display(Name = "Item Of Service")]
        public int serviceId { get; set; }

        [Required(ErrorMessage = "Port Of Destination harus di isi")]
        [Display(Name = "Port Of Destination")]
        public int portOfDestinationId { get; set; }

        [Required(ErrorMessage = "O/F / EMKL harus di isi")]
        [Display(Name = "O/F / EMKL")]
        public int ofEmkl { get; set; }

        [Required(ErrorMessage = "Location harus di isi")]
        [Display(Name = "Location")]
        public int locationId { get; set; }

        [Required(ErrorMessage = "Consignee harus di isi")]
        [Display(Name = "Consignee")]
        public int consigneeId { get; set; }

        [Required(ErrorMessage = "Container harus di isi")]
        [Display(Name = "Container")]
        public int containerId { get; set; }

        [Required(ErrorMessage = "Currency harus di isi")]
        [Display(Name = "Currency")]
        public int currencyId { get; set; }

        [Required(ErrorMessage = "Trucking Condition harus di isi")]
        [Display(Name = "Trucking Condition")]
        public int truckingCondition { get; set; } //1: Single; 2: Double;

        [Required(ErrorMessage = "% tax 23 harus di isi")]
        [Display(Name = "% tax 23")]
        public int taxId23 { get; set; }

        [Required(ErrorMessage = "% vat harus di isi")]
        [Display(Name = "% vat")]
        public int taxIdvat { get; set; }

        [Required(ErrorMessage = "Price harus di isi")]
        [Display(Name = "Price")]
        public decimal price { get; set; }

        [MaxLength(500, ErrorMessage = "Remark maksimal 500 karakter")]
        [Display(Name = "Remark")]
        public string remark { get; set; }

        [Required(ErrorMessage = "Invoice Group harus di isi")]
        [Display(Name = "Invoice Group")]
        public int orderId { get; set; }

        [Required]
        [Display(Name = "All In")]
        public bool allIn { get; set; }

        [Required(ErrorMessage = "Refund harus di isi")]
        [Display(Name = "Refund")]
        public decimal refund { get; set; }

        [Required(ErrorMessage = "Refund Type harus di isi")]
        [Display(Name = "Refund Type")]
        public int refundType { get; set; } //1: Percentage; 2: Amount;

        [Required(ErrorMessage = "Payable harus di isi")]
        [Display(Name = "Payable")]
        public string payable { get; set; }

        [Required(ErrorMessage = "Ship CoLoader harus di isi")]
        [Display(Name = "Ship CoLoader")]
        public int vendorId { get; set; }

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

        [ForeignKey("serviceId")]
        public mtServices services { get; set; }

        [ForeignKey("portOfDestinationId")]
        public mtPortOfDestination portOfDestination { get; set; }

        [ForeignKey("locationId")]
        public mtLocation location { get; set; }

        [ForeignKey("containerId")]
        public mtContainer container { get; set; }

        [ForeignKey("consigneeId")]
        public mtConsignee consignee { get; set; }

        [ForeignKey("currencyId")]
        public mtCurrency currency { get; set; }

        [ForeignKey("taxId23")]
        public mtTax tax23 { get; set; }

        [ForeignKey("taxIdvat")]
        public mtTax vat { get; set; }

        [ForeignKey("orderId")]
        public mtOrders orders { get; set; }

        [ForeignKey("vendorId")]
        public mtVendor vendor { get; set; }

        public ICollection<trSellingShipperDetailVendor> sellingShipperDetailVendors { get; set; }
    }
}
