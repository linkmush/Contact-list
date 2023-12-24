using CommunityToolkit.Mvvm.ComponentModel;
using Interfaces = ClassLibrary.Shared.Interfaces;
using Models = ClassLibrary.Shared.Models;
using CommunityToolkit.Mvvm.Input;

namespace ContactMaui.ViewModels
{
    public partial class ContactAddViewModel : ObservableObject
    {
        private readonly Interfaces.IContactService _contactServices;

        public ContactAddViewModel(Interfaces.IContactService contactServices)
        {
            _contactServices = contactServices;
        }

        [ObservableProperty]
        private Interfaces.IContacts _addContactForm = new Models.Contacts();

        [RelayCommand]
        private async Task AddContactToList() 
        {
            _contactServices.AddContactToList(AddContactForm);
            AddContactForm = new Models.Contacts();
            await Shell.Current.GoToAsync("..");  // Kan skriva sidan du ska gå till i "mainpage" TYP. Kan skriva //ochdensidaduskatill
        }
    }
}
