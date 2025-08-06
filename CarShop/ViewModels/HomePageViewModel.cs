using CarShop.Pages;
using CarShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarShop.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public HomePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            OpenShopCommand = new Command(OnOpenShop);
            OpenBackOfficeCommand = new Command(OnOpenBackOffice);
        }

        public ICommand OpenShopCommand { get; }
        public ICommand OpenBackOfficeCommand { get; }

        private async void OnOpenShop()
        {
            await _navigationService.PushAsync(new ShopPage());
        }

        private async void OnOpenBackOffice()
        {
            await _navigationService.PushAsync(new BackOfficePage());
        }
    }
}