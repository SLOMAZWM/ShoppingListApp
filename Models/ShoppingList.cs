using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMVVM.Models
{
    public class ShoppingList
    {
        
        public int ShoppingId { get; set; }

        
        public string? ShoppingName { get; set; }

        public DateTime CreationTime { get; set; }

        public string Status { get; set; } = "Nowa Lista";

        public List<Item>? Items { get; set; }

    }
}
