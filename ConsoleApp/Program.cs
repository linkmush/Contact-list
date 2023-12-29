using ClassLibrary.Shared.Interfaces;
using ClassLibrary.Shared.Services;
using ConsoleApp.Interfaces;
using ConsoleApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
  {

    services.AddSingleton<IContactService, ContactServices>();
    services.AddSingleton<IFileService>(new FileService(@"C:\Projects\Contact-list\content.json"));
    services.AddSingleton<IContactMenu, ContactMenu>();

  }).Build();

var contactMenu = builder.Services.GetRequiredService<IContactMenu>();
contactMenu.ShowMainMenu();
