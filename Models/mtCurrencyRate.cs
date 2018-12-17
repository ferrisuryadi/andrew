using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtCurrencyRate
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Currency From")]
        public int? currencyIdFrom { get; set; }

        [Display(Name = "Currency To")]
        public int? currencyIdTo { get; set; }

        [Display(Name = "Category")]
        public int category { get; set; } //1: BI, 2: Pelayaran

        [Display(Name = "Rate")]
        [Required(ErrorMessage = "Rate harus di isi")]
        public double rate { get; set; }

        [Display(Name = "Date From")]
        [Required(ErrorMessage = "Date From harus di isi")]
        public DateTime validFrom { get; set; }

        [Display(Name = "Date To")]
        [Required(ErrorMessage = "Date To harus di isi")]
        public DateTime validTo { get; set; }

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

        [ForeignKey("currencyIdFrom")]
        public mtCurrency currencyFrom { get; set; }

        [ForeignKey("currencyIdTo")]
        public mtCurrency currencyTo { get; set; }
    }

    public class mtCurrencyRatePreview
    {
        public int id { get; set; }
        public string currencyIdFrom { get; set; }
        public string currencyIdTo { get; set; }
        public string category { get; set; }
        public string rate { get; set; }
        public string validFrom { get; set; }
        public string validTo { get; set; }
        public bool isActive { get; set; }
        public string createdBy { get; set; }
        public string createdOn { get; set; }
        public string updatedBy { get; set; }
        public string updatedOn { get; set; }
    }
}
