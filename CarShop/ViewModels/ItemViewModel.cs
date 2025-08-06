using CarShop.Models;
using System.Windows.Input;

namespace CarShop.ViewModels
{
    public partial class ItemViewModel
    {
        public Item Model { get; }
        public ICommand EditCommand { get; }

        public string Name => Model.Name;
        public string? Description => Model.Description;
        public decimal Price => Model.Price;

        public ItemViewModel(Item model, Action<Item> onEdit)
        {
            Model = model;
            EditCommand = new Command(() => onEdit(Model));
        }
    }
}