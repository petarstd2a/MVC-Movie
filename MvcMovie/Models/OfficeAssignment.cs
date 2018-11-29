using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        [Display(Name = "Location")]
        public string Location { get; set; }

        public Movie Instructor { get; set; }
    }
}
