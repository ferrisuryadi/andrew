using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class sysModule
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Code maksimal 50 karakter")]
        [Required(ErrorMessage = "Code harus di isi")]
        [Display(Name = "Code")]
        public string code { get; set; }

        [MaxLength(100, ErrorMessage = "Name maksimal 50 karakter")]
        [Required(ErrorMessage = "Name harus di isi")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Parent ID")]
        public int? parentId { get; set; }

        [MaxLength(50, ErrorMessage = "controller maksimal 50 karakter")]
        [Required(ErrorMessage = "controller harus di isi")]
        [Display(Name = "controller")]
        public string controller { get; set; }

        [MaxLength(50, ErrorMessage = "view maksimal 50 karakter")]
        [Required(ErrorMessage = "view harus di isi")]
        [Display(Name = "view")]
        public string view { get; set; }

        [Display(Name = "Level")]
        public int level { get; set; }

        [Display(Name = "Order Module")]
        public int orderModule { get; set; }

        [Required]
        [Display(Name = "hasChild")]
        public bool hasChild { get; set; }

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

        [ForeignKey("parentId")]
        public sysModule module { get; set; }

        public ICollection<sysModuleRole> moduleRoles { get; set; }
    }
}
