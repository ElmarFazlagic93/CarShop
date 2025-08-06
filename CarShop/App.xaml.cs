using CarShop.Pages;
using CarShop.Services;

namespace CarShop
{
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; } = null!;

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            Services = serviceProvider;

            EnsureDatabaseInitialized();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new HomePage()));
        }

        private async void EnsureDatabaseInitialized()
        {
            var dbService = App.Services.GetRequiredService<IDatabaseService>();
            await dbService.InitializeAsync();
        }
    }
}