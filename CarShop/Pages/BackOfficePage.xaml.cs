using CarShop.ViewModels;

namespace CarShop.Pages;

public partial class BackOfficePage : BasePage
{
	public BackOfficePage()
	{
		InitializeComponent();

        BindingContext = App.Services.GetRequiredService<BackOfficePageViewModel>();
    }
}