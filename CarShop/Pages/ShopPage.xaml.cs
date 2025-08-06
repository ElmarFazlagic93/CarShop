using CarShop.ViewModels;

namespace CarShop.Pages;

public partial class ShopPage : ContentPage
{
	public ShopPage()
	{
		InitializeComponent();

        BindingContext = App.Services.GetRequiredService<ShopPageViewModel>();
    }
}