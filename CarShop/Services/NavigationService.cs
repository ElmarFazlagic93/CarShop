namespace CarShop.Services
{
    public class NavigationService : INavigationService
    {
        private INavigation? Navigation =>
            (Application.Current!.Windows.FirstOrDefault()?.Page as NavigationPage)?.Navigation;

        public async Task PushAsync(Page page)
        {
            if (Navigation != null)
                await Navigation.PushAsync(page);
        }

        public async Task PopAsync()
        {
            if (Navigation != null)
                await Navigation.PopAsync();
        }
    }
}