using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtChartOfAccount
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Code maksimal 50 karakter")]
        [Required(ErrorMessage = "Code harus di isi")]
        [Display(Name = "Code")]
        public string code { get; set; }

        [MaxLength(50, ErrorMessage = "Description maksimal 500 karakter")]
        [Required(ErrorMessage = "Description harus di isi")]
        [Display(Name = "Description")]
        public string description { get; set; }

        [Display(Name = "Parent Account")]
        public int? parentId { get; set; }

        [Display(Name = "Currency")]
        [Required(ErrorMessage = "Currency harus di isi")]
        public int? currencyId { get; set; }

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

        [ForeignKey("currencyId")]
        public mtCurrency currency { get; set; }

        [ForeignKey("parentId")]
        public mtChartOfAccount chartOfAccount { get; set; }

        public ICollection<mtChartOfAccount> chartOfAccounts { get; set; }
        //public ICollection<mtServices> services { get; set; }
        //public ICollection<mtCompany> company { get; set; }
        //public ICollection<mtShipper> shippers { get; set; }
        //public ICollection<mtVendor> vendors { get; set; }
        //public ICollection<mtWarehouse> warehouses { get; set; }
    }
}
