using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppMVVM.Models
{
    public class Item
    {
        
        public int ItemId { get; set; }

        
        public string? Name { get; set; }

        public string? Description { get; set; }

        
        public decimal Price { get; set; }

        public string? Image { get; set; }

        
        public Category? CategoryOfItem { get; set; }

        
    }
}
