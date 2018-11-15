using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtAgentProfitShared
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Agent")]
        public int? agentId { get; set; }

        [Display(Name = "Container")]
        public int? containerId { get; set; }

        [Display(Name = "Agent Dari")]
        public int? shipperId { get; set; }

        [Display(Name = "Periode Start")]
        public DateTime periodStart { get; set; }

        [Display(Name = "Periode Berakhir")]
        public DateTime periodEnd { get; set; }

        [Display(Name = "Profit Shared")]
        public int profitShared { get; set; }

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

        [ForeignKey("agentId")]
        public mtAgent agent { get; set; }

        [ForeignKey("containerId")]
        public mtContainer container { get; set; }

        [ForeignKey("shipperId")]
        public mtShipper shipper { get; set; }
    }
}
