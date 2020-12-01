using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IT3047Final.Models
{
    public class Trail
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Trail Name")]
        public string trailName { get; set; }

        [Required]
        [Display(Name = "Park Name")]
        public string parkName { get; set; }

        [Required]
        [Display(Name = "Trail Rating")]
        public int trailRating { get; set; }
    }
}
