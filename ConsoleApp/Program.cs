using ClassLibrary.Shared.Interface;
using ClassLibrary.Shared.Services;
using ConsoleApp.Services;
using Microsoft.Extensions.Hosting;

//  var builder = Host.CreateDefaultBuilder().ConfigureServices.(Services =>   DETTA ÄR DEPENDENCY INJECTION.
//  {
//      services.Addsingleton<IContactService, ContactServices>();
//      services.AddSingleton<IFileService, (new FileService(@"C:\Projects\Contact-list\content.json"));   <--- inject json file here instead of in contactservice

//  }).Build();

var contactMenu  = new ContactMenu();

contactMenu.ShowMainMenu();
