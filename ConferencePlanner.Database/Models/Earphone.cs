using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePlanner.Database.Models
{
    public class Earphone
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Brand { get; set; }

        public double Decebells { get; set; }
    }
}
