using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AppMVVM.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AppMVVM.ViewModels
{
    public class AddShoppingListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private LocalDbServer dbServer;

        public AddShoppingListViewModel(LocalDbServer localDbServer)
        {
            dbServer = localDbServer;
            AddShoppingListCommand = new Command(AddShoppingList);
            AddItemCommand = new Command(AddItem);
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand AddShoppingListCommand { get; private set; }
        public ICommand AddItemCommand { get; private set; }

        private async void AddShoppingList()
        {
            var shoppingList = new ShoppingList
            {
                ShoppingName = ShoppingListName,
                CreationTime = DateTime.Now,
                Items = items
            };
            await dbServer.AddShoppingList(shoppingList);
        }

        private async void AddItem()
        {
            string itemName = await Application.Current.MainPage.DisplayPromptAsync("Nowy produkt", "Podaj nazwę produktu:", "OK", "Anuluj");

            if (string.IsNullOrWhiteSpace(itemName))
            {
                await Application.Current.MainPage.DisplayAlert("Anulowano", "Nie dodano produktu.", "OK");
                return; 
            }

            string quantityString = await Application.Current.MainPage.DisplayPromptAsync("Ilość produktu", "Podaj ilość produktu:", "OK", "Anuluj", keyboard: Keyboard.Numeric);

            if (string.IsNullOrWhiteSpace(quantityString))
            {
                await Application.Current.MainPage.DisplayAlert("Anulowano", "Nie określono ilości.", "OK");
                return; 
            }

            if (int.TryParse(quantityString, out int quantity) && quantity > 0)
            {
                Item newItem = new Item
                {
                    Name = itemName,
                    Quantity = quantity
                };
                Items.Add(newItem);
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Błąd", "Wprowadzona ilość jest nieprawidłowa.", "OK");
            }
        }

        private ObservableCollection<Item> items = new ObservableCollection<Item>();

        public ObservableCollection<Item> Items
        {
            get => items;
            set
            {
                if (items != value)
                {
                    items = value;
                    OnPropertyChanged();
                }
            }
        }

        private string shoppingListName;

        public string ShoppingListName
        {
            get => shoppingListName;
            set
            {
                if(shoppingListName != value)
                {
                    shoppingListName = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
