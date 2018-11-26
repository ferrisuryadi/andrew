using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class sysUser
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "Username maksimal 50 karakter")]
        [Required(ErrorMessage = "Username harus di isi")]
        [Display(Name = "Username")]
        public string username { get; set; }

        [MaxLength(50, ErrorMessage = "Password maksimal 50 karakter")]
        [Required(ErrorMessage = "Password harus di isi")]
        [Display(Name = "Password")]
        public string password { get; set; }

        [MaxLength(50, ErrorMessage = "Name maksimal 50 karakter")]
        [Required(ErrorMessage = "Name harus di isi")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [MaxLength(50, ErrorMessage = "Email maksimal 50 karakter")]
        [Required(ErrorMessage = "Email harus di isi")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Role")]
        public int roleId { get; set; }

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

        [ForeignKey("roleId")]
        public sysUserRole role { get; set; }
    }

    public class login
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
