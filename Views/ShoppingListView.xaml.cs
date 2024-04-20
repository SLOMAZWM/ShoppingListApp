using AppMVVM.ViewModels;

namespace AppMVVM.Views;

public partial class ShoppingListView : ContentPage
{
	public ShoppingListView()
	{
		InitializeComponent();
        BindingContext = new ShoppingListViewModel();
    }
}