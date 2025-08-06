using CarShop.Services;

namespace CarShop.ViewModels
{
    public partial class ShopPageViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public ShopPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}