using CarShop.ViewModels;

namespace CarShop.Pages;

public partial class HomePage : BasePage
{
	public HomePage()
	{
		InitializeComponent();

        BindingContext = App.Services.GetRequiredService<HomePageViewModel>();
    }
}