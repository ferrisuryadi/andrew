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
    }
}
