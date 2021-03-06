using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CustomerApp.Models
{
    public class Customer
    {
        public int id { get; set; }

        [Required]
        public string customerName { get; set; }

        [Required]
        public string address { get; set; }
    }
}
