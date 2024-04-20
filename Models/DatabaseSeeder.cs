using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AppMVVM.Models
{
    public class DatabaseSeeder
    {
        private readonly SQLiteAsyncConnection _connection;

        public DatabaseSeeder(SQLiteAsyncConnection connection)
        {
            _connection = connection;
        }

        public async Task SeedAsync()
        {
            if (await _connection.Table<Category>().CountAsync() == 0)
            {
                var categories = new List<Category>
                {
                    new Category { Name = "Warzywa" },
                    new Category { Name = "Owoce" },
                    new Category { Name = "Nabiał" },
                    new Category { Name = "Mięso" },
                    new Category { Name = "Pieczywo" },
                    new Category { Name = "Przyprawy" },
                    new Category { Name = "Napoje gazowane" },
                    new Category { Name = "Napoje niegazowane" },
                    new Category { Name = "Słodycze" },
                    new Category { Name = "Przekąski" },
                    new Category { Name = "Produkty mrożone" },
                    new Category { Name = "Produkty suche" },
                    new Category { Name = "Konserwy" },
                    new Category { Name = "Artykuły śniadaniowe" },
                    new Category { Name = "Alkohole" },
                    new Category { Name = "Produkty bezglutenowe" },
                    new Category { Name = "Produkty wegańskie" },
                    new Category { Name = "Produkty wegetariańskie" },
                    new Category { Name = "Produkty bio" },
                    new Category { Name = "Ryby i owoce morza" },
                    new Category { Name = "Dania gotowe" },
                    new Category { Name = "Artykuły higieniczne" },
                    new Category { Name = "Środki czystości" },
                    new Category { Name = "Artykuły dla zwierząt" },
                    new Category { Name = "Artykuły dla dzieci" },
                };
            }

            if (await _connection.Table<Item>().CountAsync() == 0)
            {

            }
        }
    }
}
