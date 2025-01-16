using System.ComponentModel;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;

namespace MeroBudget
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
                });
            builder.Services.AddSingleton<UserService>(); // Register UserService for DI
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;  // or LicenseContext.NonCommercial if you're using it for non-commercial purposes
            return builder.Build();
        }
    }
}
