﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtCompany
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Company maksimal 50 karakter")]
        [Required(ErrorMessage = "Company harus di isi")]
        [Display(Name = "Company")]
        public string company { get; set; }

        [MaxLength(50, ErrorMessage = "Name maksimal 50 karakter")]
        [Required(ErrorMessage = "Name harus di isi")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [MaxLength(500, ErrorMessage = "Address maksimal 500 karakter")]
        [Required(ErrorMessage = "Address harus di isi")]
        [Display(Name = "Address")]
        public string address { get; set; }

        [MaxLength(250, ErrorMessage = "Email maksimal 250 karakter")]
        [Required(ErrorMessage = "Email harus di isi")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [MaxLength(50, ErrorMessage = "Website maksimal 50 karakter")]
        [Required(ErrorMessage = "Website harus di isi")]
        [Display(Name = "Website")]
        public string website { get; set; }

        [MaxLength(50, ErrorMessage = "Telepon maksimal 50 karakter")]
        [Required(ErrorMessage = "Telepon harus di isi")]
        [Display(Name = "Telepon")]
        public string telepon { get; set; }

        [MaxLength(50, ErrorMessage = "Fax maksimal 50 karakter")]
        [Required(ErrorMessage = "Fax harus di isi")]
        [Display(Name = "Fax")]
        public string fax { get; set; }

        [MaxLength(50, ErrorMessage = "NPWP maksimal 50 karakter")]
        [Required(ErrorMessage = "NPWP harus di isi")]
        [Display(Name = "NPWP")]
        public string taxNo { get; set; }

        [Display(Name = "Company Type")]
        public int? typeId { get; set; }

        [Display(Name = "COA USD")]
        public int? coaIdUsd { get; set; }

        [Display(Name = "COA IDR")]
        public int? coaIdIdr { get; set; }

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

        [ForeignKey("typeId")]
        public mtType type { get; set; }

        [ForeignKey("coaIdUsd")]
        public mtChartOfAccount coaUsd { get; set; }

        [ForeignKey("coaIdIdr")]
        public mtChartOfAccount coaIdr { get; set; }

        public ICollection<mtCompanyDetails> companyDetails { get; set; }
    }

    public class mtCompanyPreview
    {
        public int id { get; set; }
        public string company { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string telepon { get; set; }
        public string fax { get; set; }
        public string taxNo { get; set; }
        public string typeId { get; set; }
        public string coaIdUsd { get; set; }
        public string coaIdIdr { get; set; }
        public string remark { get; set; }
        public bool isActive { get; set; }
        public string createdBy { get; set; }
        public string createdOn { get; set; }
        public string updatedBy { get; set; }
        public string updatedOn { get; set; }
    }
}
