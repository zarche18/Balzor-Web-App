using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.API.Core.Entities
{
    public class Product
    {
        public int ID { get; set; } 
        public string Name { get; set; }   
        public decimal Price { get; set; } 
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
