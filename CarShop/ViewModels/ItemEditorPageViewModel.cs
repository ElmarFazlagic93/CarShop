using CarShop.Models;
using CarShop.Services;
using System.Windows.Input;

namespace CarShop.ViewModels
{
    public partial class ItemEditorPageViewModel : BaseViewModel
    {
        private readonly IItemService _itemService;
        private readonly INavigationService _navigationService;

        private Item _item = null!;

        public ItemEditorPageViewModel(IItemService itemService, INavigationService navigationService)
        {
            _itemService = itemService;
            _navigationService = navigationService;

            SaveCommand = new Command(OnSave);
            CancelCommand = new Command(OnCancel);
        }

        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }

        public string Title => _item.Id == 0 ? "Add Item" : "Edit Item";

        public string Name
        {
            get => _item.Name;
            set { _item.Name = value; OnPropertyChanged(); }
        }

        public string? Description
        {
            get => _item.Description;
            set { _item.Description = value; OnPropertyChanged(); }
        }

        public string PriceString
        {
            get => _item.Price.ToString("0.##");
            set
            {
                if (decimal.TryParse(value, out var result))
                    _item.Price = result;

                OnPropertyChanged();
            }
        }

        public void SetItem(Item? item)
        {
            _item = item ?? new Item();
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Description));
            OnPropertyChanged(nameof(PriceString));
            OnPropertyChanged(nameof(Title));
        }

        private async void OnSave()
        {
            if (_item.Id == 0)
                await _itemService.AddAsync(_item);
            else
                await _itemService.UpdateAsync(_item);

            await _navigationService.PopAsync();
        }

        private async void OnCancel()
        {
            await _navigationService.PopAsync();
        }
    }
}
