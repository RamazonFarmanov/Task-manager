using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Plugin.LocalNotification;
using TextAppMaui.Models;
using TextAppMaui.ViewModels;
using TextAppMaui.Views;

namespace TextAppMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseLocalNotification()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<DBController>();
            builder.Services.AddTransient<TestPage>();
/*#if DEBUG
    		builder.Logging.AddDebug();
#endif*/

            return builder.Build();
        }
    }
}
