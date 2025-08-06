using CarShop.ViewModels;

namespace CarShop.Pages;

public partial class ShopPage : BasePage
{
	public ShopPage()
	{
		InitializeComponent();

        BindingContext = App.Services.GetRequiredService<ShopPageViewModel>();
    }
}