using AppFakeStore2.Services;
using AppFakeStore2.ViewModels;
using AppFakeStore2.Views;
using Microsoft.Extensions.Logging;

namespace AppFakeStore2
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
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialDesignIcons");
                });

            //Inicializadores 'Singleton de cada clase'
            builder.Services.AddSingleton<ILoginService, LoginService>();
            builder.Services.AddSingleton<IProductoService, ProductoService>();
            builder.Services.AddSingleton<IUserService, UserService>();

            //Inicializamos todas las partes de cada sección
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<ProductoListaViewModel>();
            builder.Services.AddTransient<UserListaViewModel>();
            builder.Services.AddTransient<UserDetalleViewModel>();

            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<ProductoListaPage>();
            builder.Services.AddTransient<UserListaPage>();
            builder.Services.AddTransient<UserDetallePage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
