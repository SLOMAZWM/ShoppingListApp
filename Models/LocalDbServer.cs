using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AppMVVM.Models
{
    public class LocalDbServer
    {
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbServer(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            InitializeDatabase().ConfigureAwait(false);
        }

        private async Task InitializeDatabase()
        {
            await _connection.CreateTableAsync<Category>();
            await _connection.CreateTableAsync<Item>();
            await _connection.CreateTableAsync<ShoppingList>();

            var seeder = new DatabaseSeeder(_connection);
            await seeder.SeedAsync().ConfigureAwait(false);
        }

        
    }
}
