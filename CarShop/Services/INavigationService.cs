namespace CarShop.Services
{
    public interface INavigationService
    {
        Task PushAsync(Page page);
        Task PopAsync();
    }
}