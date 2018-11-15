using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtVendor
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Code maksimal 50 karakter")]
        [Required(ErrorMessage = "Code harus di isi")]
        [Display(Name = "Code")]
        public string code { get; set; }

        [MaxLength(50, ErrorMessage = "Name maksimal 50 karakter")]
        [Required(ErrorMessage = "Name harus di isi")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [MaxLength(50, ErrorMessage = "Attention maksimal 50 karakter")]
        [Required(ErrorMessage = "Attention harus di isi")]
        [Display(Name = "Attention")]
        public string attention { get; set; }

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
        public string phone { get; set; }

        [MaxLength(50, ErrorMessage = "Fax maksimal 50 karakter")]
        [Required(ErrorMessage = "Fax harus di isi")]
        [Display(Name = "Fax")]
        public string fax { get; set; }

        [MaxLength(50, ErrorMessage = "Provinsi maksimal 50 karakter")]
        [Required(ErrorMessage = "Provinsi harus di isi")]
        [Display(Name = "Provinsi")]
        public string province { get; set; }

        [MaxLength(50, ErrorMessage = "Kabupaten maksimal 50 karakter")]
        [Required(ErrorMessage = "Kabupaten harus di isi")]
        [Display(Name = "Kabupaten")]
        public string city { get; set; }

        [MaxLength(50, ErrorMessage = "Kecamatan maksimal 50 karakter")]
        [Required(ErrorMessage = "Kecamatan harus di isi")]
        [Display(Name = "Kecamatan")]
        public string district { get; set; }

        [MaxLength(50, ErrorMessage = "Kelurahan maksimal 50 karakter")]
        [Required(ErrorMessage = "Kelurahan harus di isi")]
        [Display(Name = "Kelurahan")]
        public string subDistrict { get; set; }

        [MaxLength(50, ErrorMessage = "RW maksimal 50 karakter")]
        [Required(ErrorMessage = "RW harus di isi")]
        [Display(Name = "RW")]
        public string village { get; set; }

        [MaxLength(50, ErrorMessage = "RT maksimal 50 karakter")]
        [Required(ErrorMessage = "RT harus di isi")]
        [Display(Name = "RT")]
        public string subVillage { get; set; }

        [MaxLength(50, ErrorMessage = "Blok maksimal 50 karakter")]
        [Required(ErrorMessage = "Blok harus di isi")]
        [Display(Name = "Blok")]
        public string block { get; set; }

        [MaxLength(50, ErrorMessage = "Kode Pos maksimal 50 karakter")]
        [Required(ErrorMessage = "Kode Pos harus di isi")]
        [Display(Name = "Kode Pos")]
        public string postalCode { get; set; }

        [MaxLength(500, ErrorMessage = "Remark maksimal 500 karakter")]
        [Required(ErrorMessage = "Remark harus di isi")]
        [Display(Name = "Remark")]
        public string remark { get; set; }

        [Display(Name = "COA USD")]
        public int? coaIdUsd { get; set; }

        [Display(Name = "COA IDR")]
        public int? coaIdIdr { get; set; }

        [Display(Name = "Type")]
        public int? typeId { get; set; }

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

        public ICollection<mtVendorDetails> vendorDetails { get; set; }
    }
}
