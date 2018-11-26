using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class sysUserRole
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Role name maksimal 50 karakter")]
        [Required(ErrorMessage = "Role name harus di isi")]
        [Display(Name = "Role Name")]
        public string name { get; set; }

        [MaxLength(50, ErrorMessage = "Description maksimal 50 karakter")]
        [Required(ErrorMessage = "Description harus di isi")]
        [Display(Name = "Description")]
        public string description { get; set; }

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

        public ICollection<sysModuleRole> moduleRoles { get; set; }
    }
}
