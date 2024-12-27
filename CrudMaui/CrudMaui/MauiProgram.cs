using Microsoft.Extensions.Logging;
using UraniumUI;
using UraniumUI.Icons.MaterialIcons;


namespace CrudMaui
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
                    fonts.AddFont("MaterialRegular.ttf", "MaterialRegular");
                    fonts.
                    AddMaterialIconFonts();
                   // FormHandler.RemoveBorders();
                }).UseUraniumUI().UseUraniumUIMaterial(); // Habilitar Material Design para controles
       // .UseUraniumUIIconsMaterial(); // Habilitar íconos de Material Design;

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
