using ClassLibrary.Shared.Interfaces;
using ClassLibrary.Shared.Services;
using ContactMaui.ViewModels;
using ContactMaui.Views;
using Microsoft.Extensions.Logging;

namespace ContactMaui
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

            builder.Services.AddSingleton<ContactListViewModel>();
            builder.Services.AddSingleton<ContactListPage>();

            builder.Services.AddSingleton<ContactAddViewModel>();
            builder.Services.AddSingleton<ContactAddPage>();

            builder.Services.AddSingleton<ContactInfoViewModel>();
            builder.Services.AddSingleton<ContactInfoPage>();

            builder.Services.AddSingleton<ContactUpdateViewModel>();
            builder.Services.AddSingleton<ContactUpdatePage>();

            builder.Services.AddSingleton<IContactService, ContactServices>();
            builder.Services.AddSingleton<IFileService>(new FileService(@"C:\Projects\Contact-list\content.json"));


            builder.Logging.AddDebug();


            return builder.Build();
        }
    }
}
