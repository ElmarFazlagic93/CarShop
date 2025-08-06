using CarShop.Services;

namespace CarShop.ViewModels
{
    public class BackOfficePageViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public BackOfficePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}