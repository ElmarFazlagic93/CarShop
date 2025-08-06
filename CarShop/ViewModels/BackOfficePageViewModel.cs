using CarShop.Models;
using CarShop.Pages;
using CarShop.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CarShop.ViewModels
{
    public partial class BackOfficePageViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IItemService _itemService;

        private ObservableCollection<ItemViewModel> _items = [];

        public BackOfficePageViewModel(INavigationService navigationService, IItemService itemService)
        {
            _navigationService = navigationService;
            _itemService = itemService;

            AddItemCommand = new Command(OnAddItem);

            _ = LoadItemsAsync();
        }

        public ICommand AddItemCommand { get; }

        public ObservableCollection<ItemViewModel> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public override async Task OnAppearingAsync()
        {
            await RefreshAsync();
        }

        public async Task RefreshAsync()
        {
            await LoadItemsAsync();
        }

        private async Task LoadItemsAsync()
        {
            var items = await _itemService.GetAllAsync();
            var itemViewModels = items
                .Select(item => new ItemViewModel(item, OnEditItem))
                .ToList();

            Items = new ObservableCollection<ItemViewModel>(itemViewModels);
        }

        private async void OnAddItem()
        {
            await _navigationService.PushAsync(new ItemEditorPage());
        }

        private async void OnEditItem(Item? item)
        {
            if (item is null)
                return;

            await _navigationService.PushAsync(new ItemEditorPage(item));
        }
    }
}