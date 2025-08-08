using CarShop.Models;
using CarShop.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CarShop.ViewModels
{
    public partial class ReceiptPageViewModel : BaseViewModel
    {
        // 1. Private service fields
        private readonly INavigationService _navigationService;

        // 2. Private backing fields
        private string _fullName = "";
        private string _vehicle = "";
        private string _year = "";
        private string _licensePlate = "";

        // 3. Constructor
        public ReceiptPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            Items = new ObservableCollection<ReceiptItem>();
            AddItemCommand = new Command(OnAddItem);
            ClearCommand = new Command(OnClear);
            PrintCommand = new Command(OnPrint);

            Items.CollectionChanged += (_, __) => OnPropertyChanged(nameof(DisplayItems));
        }

        // 4. Commands
        public ICommand AddItemCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand PrintCommand { get; }

        // 5. Public properties

        public ObservableCollection<ReceiptItem> Items { get; } = new();

        public IEnumerable<ReceiptItem> DisplayItems =>
        new[] { _header }.Concat(Items);

        private readonly ReceiptItem _header = new()
        {
            IsHeader = true,
            Name = "Naziv",
            Description = "Opis",
            Quantity = "Kolicina",
            Price = "Cijena",
        };

        public string FullName
        {
            get => _fullName;
            set => SetProperty(ref _fullName, value);
        }

        public string Vehicle
        {
            get => _vehicle;
            set => SetProperty(ref _vehicle, value);
        }

        public string Year
        {
            get => _year;
            set => SetProperty(ref _year, value);
        }

        public string LicensePlate
        {
            get => _licensePlate;
            set => SetProperty(ref _licensePlate, value);
        }

        public string TotalText => $"Ukupno: {Items.Sum(i => i.Total):0.00} KM";

        // 6. Public methods
        public void OnAppearing()
        {
            // nothing for now
        }

        // 7. Private methods
        private async void OnAddItem()
        {
            // Open dialog (placeholder)
            //var item = await _navigationService.ShowAddItemDialogAsync();
            //if (item != null)
            //{
            //    Items.Add(item);
            //    OnPropertyChanged(nameof(TotalText));
            //}


            // TODO: Replace with dialog later
            var demoItem = new ReceiptItem
            {
                Name = "Ulje",
                Description = "Zamjena ulja",
                Quantity = "1",
                Price = "50"
            };

            var demoItem1 = new ReceiptItem
            {
                Name = "Ulje sa duzim tekstom",
                Description = "Zamjena ulja",
                Quantity = "3",
                Price = "150"
            };

            Items.Add(demoItem);
            Items.Add(demoItem1);
            OnPropertyChanged(nameof(TotalText));
        }

        private async void OnClear()
        {
            //var confirmed = await _navigationService.ConfirmAsync("Potvrda", "Da li ste sigurni da želite obrisati sve podatke?");
            //if (confirmed)
            //{
            //    FullName = string.Empty;
            //    Vehicle = string.Empty;
            //    Year = string.Empty;
            //    LicensePlate = string.Empty;
            //    Items.Clear();
            //    OnPropertyChanged(nameof(TotalText));
            //}
        }

        private async void OnPrint()
        {
            //var confirmed = await _navigationService.ConfirmAsync("Potvrda", "Da li želite odštampati račun?");
            //if (!confirmed)
            //    return;

            // TODO: Add print logic
        }
    }
}