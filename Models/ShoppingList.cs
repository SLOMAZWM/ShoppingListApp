using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Collections.ObjectModel;

namespace AppMVVM.Models
{
    public class ShoppingList
    {
        [PrimaryKey, AutoIncrement]
        public int ShoppingId { get; set; }

        public string? ShoppingName { get; set; }

        public DateTime CreationTime { get; set; }

        public string Status { get; set; } = "Nowa Lista";

        [Ignore]
        public ObservableCollection<Item>? Items { get; set; }

        public int ShoppingListId { get; set; }
    }
}
