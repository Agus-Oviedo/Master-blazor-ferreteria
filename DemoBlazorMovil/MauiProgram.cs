using DemoBlazorMovil.Services;
using Microsoft.Extensions.Logging;

namespace DemoBlazorMovil
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

            builder.Services.AddMauiBlazorWebView();

            // ✅ Registro de servicios
            builder.Services.AddSingleton<UsuarioService>();        // Singleton para mantener sesión
            builder.Services.AddSingleton<SesionUsuario>();         // Nuevo servicio para manejar usuario activo
            builder.Services.AddScoped<ProductoService>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
