using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.Maui.Controls;
using System.Windows.Input;
using AppMVVM.Views;
using System.Runtime.CompilerServices;

namespace AppMVVM.ViewModels
{
    public class ShoppingListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand OpenAddShoppingListViewCommand { get; private set; }

        public ShoppingListViewModel()
        {
            OpenAddShoppingListViewCommand = new Command(OpenAddShoppingListView);
        }

        private async void OpenAddShoppingListView()
        {
            var mainPage = Application.Current.MainPage as TabbedPage;
            var navigationPage = mainPage.CurrentPage as NavigationPage;

            await navigationPage.Navigation.PushAsync(new AddShoppingListView());

        }
    }
}
