using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fms.Models
{
    public class mtPortOfDestination
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [MaxLength(150, ErrorMessage = "Location maksimal 150 karakter")]
        [Required(ErrorMessage = "Location harus di isi")]
        [Display(Name = "Location")]
        public string location { get; set; }

        [Required(ErrorMessage = "Country harus di isi")]
        [Display(Name = "Country")]
        public int? countryId { get; set; }

        [Required(ErrorMessage = "Pindah harus di isi")]
        [Display(Name = "Pindah")]
        public int? countryIdTransit { get; set; }

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

        [ForeignKey("countryId")]
        public mtCountry country { get; set; }

        [ForeignKey("countryIdTransit")]
        public mtCountry countryTransit { get; set; }

        public ICollection<mtAgent> agents { get; set; }
    }
}
