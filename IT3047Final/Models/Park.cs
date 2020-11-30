using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IT3047Final.Models
{
    public class Park
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Park Name")]
        public string parkName { get; set; }

        [Required]
        [Display(Name = "Park Address")]
        public string parkAddress { get; set; }

        [Required]
        [Display(Name = "Park Rating")]
        public int parkRating { get; set; }
    }
}
