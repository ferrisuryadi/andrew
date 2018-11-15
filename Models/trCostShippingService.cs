using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class trCostShippingService
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Cost Shipping Header")]
        public int costShippingId { get; set; }

        [Required(ErrorMessage = "Item Of Service harus di isi")]
        [Display(Name = "Item Of Service")]
        public int serviceId { get; set; }

        [Required(ErrorMessage = "Port Of Destination harus di isi")]
        [Display(Name = "Port Of Destination")]
        public int portOfDestinationId { get; set; }

        [Required(ErrorMessage = "O/F / EMKL harus di isi")]
        [Display(Name = "O/F / EMKL")]
        public int ofEmkl { get; set; }

        [Required(ErrorMessage = "P/C/Pay harus di isi")]
        [Display(Name = "P/C/Pay")]
        public int pcPay { get; set; }

        [Required(ErrorMessage = "Container harus di isi")]
        [Display(Name = "Container")]
        public int containerId { get; set; }

        [Required(ErrorMessage = "% tax 23 harus di isi")]
        [Display(Name = "% tax 23")]
        public int taxId23 { get; set; }

        [Required(ErrorMessage = "% vat harus di isi")]
        [Display(Name = "% vat")]
        public int taxIdvat { get; set; }

        [MaxLength(500, ErrorMessage = "Remark maksimal 500 karakter")]
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

        [ForeignKey("taxId23")]
        public mtTax tax23 { get; set; }

        [ForeignKey("taxIdvat")]
        public mtTax vat { get; set; }
    }
}
