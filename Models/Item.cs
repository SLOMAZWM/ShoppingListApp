using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AppMVVM.Models
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ItemId { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }
        [MaxLength(250)]
        public string? Description { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        [Ignore]
        public Category? CategoryOfItem { get; set; }
    }
}
