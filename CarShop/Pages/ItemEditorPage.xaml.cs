using CarShop.Models;
using CarShop.ViewModels;

namespace CarShop.Pages;

public partial class ItemEditorPage : BasePage
{
    private readonly ItemEditorPageViewModel _vm;

    public ItemEditorPage(Item? item = null)
    {
        InitializeComponent();

        _vm = App.Services.GetRequiredService<ItemEditorPageViewModel>();
        _vm.SetItem(item);

        BindingContext = _vm;
    }
}