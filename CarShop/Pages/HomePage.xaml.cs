using CarShop.ViewModels;

namespace CarShop.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

        BindingContext = App.Services.GetRequiredService<HomePageViewModel>();
    }
}