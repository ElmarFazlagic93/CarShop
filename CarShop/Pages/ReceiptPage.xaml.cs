using CarShop.ViewModels;

namespace CarShop.Pages;

public partial class ReceiptPage : BasePage
{
	public ReceiptPage()
	{
		InitializeComponent();

        BindingContext = App.Services.GetRequiredService<ReceiptPageViewModel>();
    }
}