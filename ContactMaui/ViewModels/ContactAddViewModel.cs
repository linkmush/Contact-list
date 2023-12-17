using CommunityToolkit.Mvvm.ComponentModel;
using ClassLibrary.Shared.Interfaces;
using System.Collections.ObjectModel;
using Contact = ClassLibrary.Shared.Models.Contacts;
using ClassLibrary.Shared.Enums;

namespace ContactMaui.ViewModels
{
    public partial class ContactAddViewModel : ObservableObject
    {
        private readonly IContactService _contactServices;

        public ContactAddViewModel(IContactService contactServices)
        {
            _contactServices = contactServices;
        }

        [ObservableProperty]
        private Contact _addContactForm = new();

        [ObservableProperty]
        private ObservableCollection<Contact> _contactList = [];

        public void AddContact(Contact newContact)
        {
            var result = _contactServices.AddContactToList(newContact);

            if (result.Status == ServiceStatus.SUCCESSED)
            {
                ContactList.Add(newContact); // Uppdatera den lokala listan med den nya kontakten
            }
            else if (result.Status == ServiceStatus.ALREADY_EXIST) 
            {
                 // Visa meddelande till användaren att kontakten redan finns
            }
        }
    }
}
