using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class trSellingShipper
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Ref No maksimal 50 karakter")]
        [Required(ErrorMessage = "Ref No harus di isi")]
        [Display(Name = "Ref No")]
        public string referenceNo { get; set; }

        [Display(Name = "Selling Shipper Date")]
        [Required(ErrorMessage = "Selling Shipper Date harus di isi")]
        public DateTime txDate { get; set; }

        [Display(Name = "Valid Date")]
        [Required(ErrorMessage = "Valid Date harus di isi")]
        public DateTime txValidDate { get; set; }

        [Required(ErrorMessage = "To harus di isi")]
        [Display(Name = "To")]
        public int shipperId { get; set; }

        [MaxLength(50, ErrorMessage = "Attn maksimal 50 karakter")]
        [Display(Name = "Attn")]
        [Required(ErrorMessage = "Attn harus di isi")]
        public string shipperAttention { get; set; }

        [MaxLength(50, ErrorMessage = "CC maksimal 50 karakter")]
        [Display(Name = "CC")]
        [Required(ErrorMessage = "CC harus di isi")]
        public string shipperCc { get; set; }

        [Required(ErrorMessage = "From harus di isi")]
        [Display(Name = "From")]
        public int employeeId { get; set; }

        [MaxLength(50, ErrorMessage = "CC From maksimal 50 karakter")]
        [Display(Name = "CC From")]
        [Required(ErrorMessage = "CC From harus di isi")]
        public string employeeCc { get; set; }

        [Display(Name = "Term Of Payment")]
        [Required(ErrorMessage = "Term Of Payment harus di isi")]
        public int termOfPayment { get; set; }

        [Display(Name = "Port Of Loading")]
        [Required(ErrorMessage = "Port Of Loading harus di isi")]
        public int portOfLoadingId { get; set; }

        [MaxLength(500, ErrorMessage = "Remark O/F Quotation maksimal 500 karakter")]
        [Display(Name = "Remark O/F Quotation")]
        public string remarkQuo { get; set; }

        [MaxLength(500, ErrorMessage = "Remark Of EMKL maksimal 500 karakter")]
        [Display(Name = "Remark Of EMKL")]
        public string remarkEmkl { get; set; }

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

        [ForeignKey("shipperId")]
        public mtShipper shipper { get; set; }

        [ForeignKey("employeeId")]
        public mtEmployee employee { get; set; }

        [ForeignKey("portOfLoadingId")]
        public mtPortOfLoading portOfLoading { get; set; }

        public ICollection<trSellingShipperService> sellingShipperServices { get; set; }
        public ICollection<trSellingShipperDetail> sellingShipperDetails { get; set; }
    }
}
