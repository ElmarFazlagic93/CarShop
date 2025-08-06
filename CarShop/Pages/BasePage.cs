using CarShop.Services;

namespace CarShop.Pages
{
    public partial class BasePage : ContentPage
    {
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (BindingContext is IViewModelOnAppearing appearing)
                await appearing.OnAppearingAsync();
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();

            if (BindingContext is IViewModelOnDisappearing disappearing)
                await disappearing.OnDisappearingAsync();
        }
    }
}