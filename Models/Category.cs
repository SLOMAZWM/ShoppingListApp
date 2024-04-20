using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AppMVVM.Models
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int CategoryId { get; set; }
        
        public string? Name { get; set; }
        
    }
}
