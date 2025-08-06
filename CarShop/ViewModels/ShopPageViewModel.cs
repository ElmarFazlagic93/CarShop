using CarShop.Services;

namespace CarShop.ViewModels
{
    public class ShopPageViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public ShopPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}