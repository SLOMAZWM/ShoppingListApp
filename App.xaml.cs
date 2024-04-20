using AppMVVM.Views;
using AppMVVM.Models;

namespace AppMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationView();
        }

    }
}
