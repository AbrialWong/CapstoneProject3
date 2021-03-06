using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        // validation is in the model
        public string name { get; set; }
        public List<Product> products { get; set; }
    }
}
