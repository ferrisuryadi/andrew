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

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Date harus di isi")]
        public DateTime txDate { get; set; }

        [Display(Name = "Valid Date")]
        [Required(ErrorMessage = "Valid Date harus di isi")]
        public DateTime txValidDate { get; set; }

        [Display(Name = "Port Of Loading")]
        public int portOfLoadingId { get; set; }

        [Display(Name = "Sales")]
        [Required(ErrorMessage = "Sales harus di isi")]
        [MaxLength(200, ErrorMessage = "Sales maksimal 200 karakter")]
        public string sales { get; set; }

        [MaxLength(50, ErrorMessage = "Shipping Reference No maksimal 50 karakter")]
        [Required(ErrorMessage = "Shipping Reference No harus di isi")]
        [Display(Name = "Shipping Reference No")]
        public string shippingReferenceNo { get; set; }

        [Display(Name = "Kode")]
        public int vendorId { get; set; }

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

        [ForeignKey("vendorId")]
        public mtVendor vendor { get; set; }

        public ICollection<trCostShippingDetail> costShippingDetails { get; set; }
        public ICollection<trCostShippingService> costShippingServices { get; set; }
    }

    public class trCostShippingVendorLoad
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }

    public class trCostShippingView
    {
        public int id { get; set; }
        public string referenceNo { get; set; }
        public string txDate { get; set; }
        public string txValidDate { get; set; }
        public string updatedBy { get; set; }
        public string updatedOn { get; set; }
    }

    public class trCostShippingSave
    {
        public int id { get; set; }
        public string referenceNo { get; set; }
        public DateTime txDate { get; set; }
        public DateTime txValidDate { get; set; }
        public int portOfLoadingId { get; set; }
        public string sales { get; set; }
        public string shippingReferenceNo { get; set; }
        public int vendorId { get; set; }
        public string remark { get; set; }
        public bool isActive { get; set; }
        public string createdBy { get; set; }
        public DateTime createdOn { get; set; }
    }
}
