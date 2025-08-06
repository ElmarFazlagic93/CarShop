using CarShop.Services;
using CarShop.ViewModels;
using Microsoft.Extensions.Logging;

namespace CarShop
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            // Register services
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<IDatabaseService, DatabaseService>();
            builder.Services.AddSingleton<IItemService, ItemService>();

            // Register ViewModels
            builder.Services.AddTransient<HomePageViewModel>();
            builder.Services.AddTransient<ShopPageViewModel>();
            builder.Services.AddTransient<BackOfficePageViewModel>();
            builder.Services.AddTransient<ItemEditorPageViewModel>();

            return builder.Build();
        }
    }
}