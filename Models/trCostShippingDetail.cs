﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class trCostShippingDetail
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Selling Shipper Header")]
        public int costShippingId { get; set; }

        [Required(ErrorMessage = "Item Of Service harus di isi")]
        [Display(Name = "Item Of Service")]
        public int serviceId { get; set; }

        [Required(ErrorMessage = "Port Of Destination harus di isi")]
        [Display(Name = "Port Of Destination")]
        public int portOfDestinationId { get; set; }

        [Required(ErrorMessage = "Port Of Transhipment Type harus di isi")]
        [Display(Name = "Port Of Transhipment Type")]
        public int portTerminalType { get; set; } // 1: POL, 2: POD

        [Required(ErrorMessage = "Port Of Transhipment harus di isi")]
        [Display(Name = "Port Of Transhipment")]
        public int portTerminalId { get; set; }

        [Required(ErrorMessage = "P/C/Pay harus di isi")]
        [Display(Name = "P/C/Pay")]
        public int pcPay { get; set; }

        [Required(ErrorMessage = "Container harus di isi")]
        [Display(Name = "Container")]
        public int containerId { get; set; }

        [Required(ErrorMessage = "Currency harus di isi")]
        [Display(Name = "Currency")]
        public int currencyId { get; set; }

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

        [Required]
        [Display(Name = "All In")]
        public bool allIn { get; set; }

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

        [ForeignKey("taxId23")]
        public mtTax tax23 { get; set; }

        [ForeignKey("taxIdvat")]
        public mtTax vat { get; set; }

        public ICollection<trCostShippingDetailShipper> costShippingDetailShippers { get; set; }
    }

    public class trCostShippingDetailView
    {
        public int id { get; set; }
        public string serviceId { get; set; }
        public string portOfDestinationId { get; set; }
        public string portTerminalType { get; set; } // 1: POL, 2: POD
        public string portTerminalId { get; set; }
        public string pcPay { get; set; }
        public string containerId { get; set; }
        public string currencyId { get; set; }
        public string taxId23 { get; set; }
        public string taxIdvat { get; set; }
        public decimal price { get; set; }
        public string remark { get; set; }
        public string allIn { get; set; }
    }

    public class trCostShippingDetailModel
    {
        public int id { get; set; }
        public int costShippingId { get; set; }
        public int serviceId { get; set; }
        public int portOfDestinationId { get; set; }
        public int portTerminalType { get; set; } // 1: POD, 2: POD
        public int portTerminalId { get; set; }
        public int pcPay { get; set; }
        public int containerId { get; set; }
        public int currencyId { get; set; }
        public int taxId23 { get; set; }
        public int taxIdvat { get; set; }
        public decimal price { get; set; }
        public string remark { get; set; }
        public bool allIn { get; set; }
        public decimal operationMonitoring { get; set; }
        public int operationMonitoringType { get; set; } //1: Percentage; 2: Amount;
        public string payable { get; set; }
        public int vendorId { get; set; }
    }
}
