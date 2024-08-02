using MAUIusingXAMPP.ViewModel;
using Microsoft.Extensions.Logging;

namespace MAUIusingXAMPP
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
            
            //registers IConnectivity
            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

            // registers with the dependency service
            //singleton is a global that creates one copy and uses it through out
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            //transient will create and destroy the page each time
            builder.Services.AddSingleton<DetailPage>();
            builder.Services.AddSingleton<DetailViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
