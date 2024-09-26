using Microsoft.Extensions.Logging;

namespace ProyectoMauiVJ
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
                    fonts.AddFont("Douglast PERSONAL USE ONLY!.ttf", "FontDouglast");
                });

#if DEBUG
            builder.Services.AddSingleton<LocalDbService>();
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<InicioSesion>();
            builder.Services.AddTransient<Registro>();
            builder.Services.AddTransient<Registrarse>();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
