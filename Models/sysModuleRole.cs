﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class sysModuleRole
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "userRoleId")]
        public int userRoleId { get; set; }

        [Display(Name = "moduleId")]
        public int moduleId { get; set; }

        [Display(Name = "moduleId")]
        public bool isDefault { get; set; } = false;

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

        [ForeignKey("userRoleId")]
        public sysUserRole userRole { get; set; }

        [ForeignKey("moduleId")]
        public sysModule module { get; set; }
    }
}
