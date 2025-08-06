using CarShop.ViewModels;

namespace CarShop.Pages;

public partial class BackOfficePage : ContentPage
{
	public BackOfficePage()
	{
		InitializeComponent();

        BindingContext = App.Services.GetRequiredService<BackOfficePageViewModel>();
    }
}